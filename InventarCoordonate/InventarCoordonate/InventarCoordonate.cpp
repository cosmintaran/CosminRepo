// InventarCoordonate.cpp : Defines the initialization routines for the DLL.
//

#include "stdafx.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

#include <tchar.h>
#include <aced.h>
#include <rxregsvc.h>
#include "Layer.h"
#include <dbents.h>
#include <adscodes.h>
#include <map>
#include <migrtion.h>
#include <dbapserv.h>
#include <dbobjptr.h>
#include <acdocman.h>
#include <acdbabb.h>
#include <fstream>
#include <iostream>
#include <iomanip>
#include <string>
#include <process.h>
#include "gepnt3d.h"
#include "dbtable.h"
#include "geassign.h"
#include "ExportClass.h"
#include "Utils.h"

#define NUM_COL 3
#define HEADERPERCENT 10
#define TITLEPERCENT 20
//declaring the function
void initApp(); //called from AutoCAD when application is loaded
void unloadApp();//called when application is unloaded
void GetCoordInventory();
void selectObject(AcDbObjectId&);
bool insertPoints(std::map<std::wstring,AcGePoint3d>&, Adesk::Int16, double,double);
void generateInventarTable(std::map<std::wstring, AcGePoint3d>&,double);
void extractVertexCoords(const AcDbObjectId& objID, std::map<std::wstring, AcGePoint3d>& m_3dPoints);


void initApp()
{
	acedRegCmds->addCommand(_T("EXTRACTCOORDONATES_COMMANDS"),
		_T("inventar"),
		_T("inventar"),
		ACRX_CMD_MODAL,
		GetCoordInventory);
}

void unloadApp()
{
	acedRegCmds->removeGroup(_T("EXTRACTCOORDONATES_COMMANDS"));
}

void GetCoordInventory()
{
	std::map<std::wstring, AcGePoint3d> m_3dPoints;
	u_int startIndex = 1;

	ads_real textHeightResult = 1;
	ads_real pointSizeResult = 0.25;	
	ACHAR stringResult[2];
	ACHAR prompt[100];
	AcDbObjectId pObj;	


	selectObject(pObj);
	if (pObj)
	{
		acedInitGet(RSG_NONULL | RSG_NOZERO | RSG_NONEG, NULL);
		acedGetReal(_T("\nIntroduceti inaltime text: "), &textHeightResult);
		acedGetReal(_T("\nIntroduceti dimensiunea punctului: "), &pointSizeResult);

		extractVertexCoords(pObj, m_3dPoints);
		if (m_3dPoints.size() > 0)
		{
			if (insertPoints(m_3dPoints, 32, pointSizeResult, textHeightResult))
			{
				acedInitGet(RSG_NONULL, _T("Y N"));
				acedGetKword(_T("\nInseram tabel de coordonate? [Yes No]:"), stringResult);
				if (wcscmp(stringResult, _T("N")))
				generateInventarTable(m_3dPoints,textHeightResult);

				//swprintf(prompt, _T("\nExportam fisier de coordonate? [Y/N]<stringResult=%s>: "), stringResult);
				acedInitGet(RSG_NONULL, _T("Y N"));
				acedGetKword(_T("\nExportam fisier de coordonate? [Yes No]: " ), stringResult);
				if (wcscmp(stringResult, _T("N")))
				{
				
				struct resbuf* result = NULL;
				if (acedGetFileNavDialog(_T("Save coordonates file"), NULL, _T("csv;txt"), _T("Save Dialog"), 1, &result) != RTERROR)
				{
					ExportClass* csvExport = new ExportClass(result->resval.rstring);
					csvExport->exportInventarCSV(m_3dPoints, startIndex);

					//*****Release memory area*****/
					acutRelRb(result);
					delete csvExport;
				}
				}
			}
		}
	}

	else
	{
		acutPrintf(_T("\nError nici un obiect selectat!"));
	}

}

void selectObject(AcDbObjectId& eID)
{
	ads_name en;
	ads_point pt;
	int nReturn;
	nReturn = acedEntSel(_T("\nSelecteaza polilinia de contur: "), en, pt);
	if (nReturn != RTNORM)
		return;
	if (acdbGetObjectId(eID, en) != Acad::eOk)
		return;
}

void extractVertexCoords(const AcDbObjectId& objID, std::map<std::wstring, AcGePoint3d>& m_3dPoints)
{
	AcDbEntity* pEnt = nullptr;
	acdbOpenObject(pEnt, objID, AcDb::kForRead);

	             /*****Pline****/
	if (pEnt->isA() == AcDbPolyline::desc())
	{
		AcDbPolyline* pLine = static_cast<AcDbPolyline*>(pEnt);
		pEnt->close();
		acdbOpenObject(pLine, objID, AcDb::kForRead);
		AcGePoint3d vertex;
		for (LONGLONG i = 0; i < pLine->numVerts(); i++)
		{
			pLine->getPointAt(i, vertex);
			std::wstring w_nrPunct = std::to_wstring(i + 1);
			m_3dPoints.insert(std::pair<std::wstring, AcGePoint3d>(w_nrPunct, vertex));
		}

		pLine->close();	
	}

	            /******P2dLine****/
	else if (pEnt->isA() == AcDb2dPolyline::desc())
	{
		AcGePoint3d point;
		AcDbObjectId vertexID;
		AcDb3dPolylineVertex* pVertex = nullptr;

		AcDb2dPolyline* p2dline = static_cast<AcDb2dPolyline*>(pEnt);
		pEnt->close();

		acdbOpenObject(p2dline, objID, AcDb::kForRead);
		AcDbObjectIterator* pIterator = p2dline->vertexIterator();
		for (pIterator->start(); !pIterator->done(); pIterator->step())
		{
			LONGLONG contor = 1;
			vertexID = pIterator->objectId();
			acdbOpenObject(pVertex, vertexID, AcDb::kForRead);
			point = pVertex->position();

			std::wstring w_nrPunct = std::to_wstring(contor);
			contor++;
			m_3dPoints.insert(std::pair<std::wstring, AcGePoint3d>(w_nrPunct, point));

			pVertex->close();
		}
		delete pIterator;
		p2dline->close();
	}

	         /***********P3dLine**************/
	else if (pEnt->isA() == AcDb3dPolyline::desc())
	{
		AcGePoint3d point;
		AcDbObjectId vertexID;
		AcDb3dPolylineVertex* pVertex = nullptr;

		AcDb3dPolyline* p3dline = static_cast<AcDb3dPolyline*>(pEnt);
		pEnt->close();

		acdbOpenObject(p3dline, objID, AcDb::kForRead);
		AcDbObjectIterator* pIterator = p3dline->vertexIterator();

		for (pIterator->start(); !pIterator->done(); pIterator->step())
		{
			LONGLONG contor = 1;
			vertexID = pIterator->objectId();
			acdbOpenObject(pVertex, vertexID, AcDb::kForRead);
			point = pVertex->position();

			std::wstring w_nrPunct = std::to_wstring(contor);

			m_3dPoints.insert(std::pair<std::wstring, AcGePoint3d>(w_nrPunct, point));
			pVertex->close();
		}
		delete pIterator;
		p3dline->close();
	}
	else
	{
		pEnt->close();
		acutPrintf(_T("\nObiectul selectat nu este o polilinie"));
	}

}

bool insertPoints(std::map<std::wstring,AcGePoint3d>& m_Points, Adesk::Int16 pointStyle, double pointSize, double textHeight)
{
	
	AcDbDatabase* pDb = acdbHostApplicationServices()->workingDatabase();
	AcCmColor pointColor;
	AcGePoint3d temp;
	AcDbPoint* tmp_point = nullptr;
	AcDbText* tmp_txt = nullptr;
	AcDbBlockTable* pBT = nullptr;
	AcDbBlockTableRecord* pBTR = nullptr;
	ACHAR* nrPct = nullptr;
	/*****************************************************************/
	pointColor.setColorIndex(7);
	Layer::Create(_T("pctContur"), pointColor, false, false, false);
	Layer::Create(_T("nrPct"), pointColor, false, false, false);
	Acad::ErrorStatus es = Acad::eOk;
	es = acdbHostApplicationServices()->workingDatabase()->setPdmode(pointStyle);
	es = acdbHostApplicationServices()->workingDatabase()->setPdsize(pointSize);

	/*****************************************************************/

	pDb->getSymbolTable(pBT, AcDb::kForRead);
	pBT->getAt(ACDB_MODEL_SPACE, pBTR, AcDb::kForWrite);
	pBT->close();

	std::map<std::wstring, AcGePoint3d>::iterator it;
	for (it = m_Points.begin(); it != m_Points.end();it++)
	{
		const wchar_t* key = it->first.c_str();
		tmp_point = new AcDbPoint;
		tmp_point->setPosition(it->second);
		tmp_point->setLayer(_T("pctContur"));
		
		tmp_txt = new AcDbText(it->second, key, AcDbObjectId::kNull, textHeight, 0);
		tmp_txt->setLayer(_T("nrPct"));
		

		pBTR->appendAcDbEntity(tmp_point);
		pBTR->appendAcDbEntity(tmp_txt);
		tmp_point->close();
		tmp_txt->close();
	}

	pBTR->close();

	return true;
}

void generateInventarTable(std::map<std::wstring, AcGePoint3d>& m_points, double textHeight)
{
	Acad::ErrorStatus es;
	AcGePoint3d insertionPoint;
	AcDbObjectId objectID;
	AcDbTable* pTable = nullptr;
	AcDbDictionary* pDic = nullptr;
	AcDbBlockTable* pBT = nullptr;
	AcDbBlockTableRecord* pBTR = nullptr;
	AcDbDatabase*pDb = nullptr;

	u_int nrRows = m_points.size() + 2;
	double headerHeight = textHeight + ((textHeight * HEADERPERCENT) / 100);
	double titleHeight = textHeight + ((textHeight * TITLEPERCENT) / 100);
	double nrpctWidth = 0.0;

	int ret = acedGetPoint(NULL, _T("\nSelecteaza punctul de insertie al tabelului "), asDblArray(insertionPoint));
	
	AcDbObjectId textID = Utils::NewTextStyle(_T("TableStyle"), titleHeight);
	pDb = acdbHostApplicationServices()->workingDatabase();
	pBTR = new AcDbBlockTableRecord;
	pDb->getSymbolTable(pBT, AcDb::kForRead);
	pBT->getAt(ACDB_MODEL_SPACE, pBTR, AcDb::kForWrite);
	pBT->close();

	es = pDb->getTableStyleDictionary(pDic, AcDb::kForWrite);
	es = pDic->getAt(_T("Standard"), objectID); 
	es = pDic->close();

	pTable = new AcDbTable;
	pTable->setTableStyle(objectID);
	
	pTable->setSize(nrRows, NUM_COL);
	pTable->setAlignment(AcDb::kMiddleCenter);
	pTable->setTextHeight( titleHeight,AcDb::kTitleRow);
	pTable->setTextHeight(headerHeight, AcDb::kHeaderRow);
	pTable->setTextHeight(textHeight, AcDb::kDataRow);
	//pTable->setTextStyle(objectID);
	
	pTable->setTextStyle(0, 0, textID);
	pTable->setTextString(0, 0, _T("Inventar de coordonate"));
	double tableWidth = Utils::GetTextWidth(_T("Inventar@de@coordonate"), _T("TableStyle"));
	pTable->setWidth(tableWidth + (tableWidth * 15) / 100);
	pTable->setTextString(1, 0, _T("Nr.\npct."));

	pTable->setTextStyle(1,0, textID);
	nrpctWidth = Utils::GetTextWidth(_T("NRPCT"), _T("TableStyle"));
	pTable->setColumnWidth(0,nrpctWidth);

	pTable->setTextStyle(1, 1, textID);
	pTable->setTextString(1, 1, _T("X[m]"));

	pTable->setTextStyle(1, 2, textID);
	pTable->setTextString(1, 2, _T("Y[m]"));


	std::map<std::wstring, AcGePoint3d>::iterator it = m_points.begin();
	for (u_int row = 0; row < nrRows; row++)
	{
		//double tempWidth = Utils::GetTextWidth(Utils::int_To_wstring(row + 1).c_str(),_T("TableStyle"));
		//if (tempWidth > nrpctWidth)
		//{
		//	nrpctWidth = tempWidth;
		//	pTable->setColumnWidth(0, nrpctWidth);
		//}
		pTable->setTextStyle(row + 2, 0, textID);
		pTable->setTextString(row + 2, 0, Utils::int_To_wstring(row+1).c_str());  //nr. curent
		
		pTable->setTextStyle(row + 2, 1, textID);
		pTable->setTextString(row + 2, 1, Utils::real_To_wstring(it->second.y).c_str());  // valoare X
		
		pTable->setTextStyle(row + 2, 2, textID);
		pTable->setTextString(row + 2, 2, Utils::real_To_wstring(it->second.x).c_str());  // valoare Y
		it++;
	}

	pTable->generateLayout();
	pTable->setPosition(insertionPoint);
	pBTR->appendAcDbEntity(pTable);
	pBTR->close();
	pTable->close();
	
}


extern "C" AcRx::AppRetCode
acrxEntryPoint(AcRx::AppMsgCode msg, void* pkt)
{
	switch (msg)
	{
	case AcRx::kInitAppMsg:
	{
	 acrxDynamicLinker->unlockApplication(pkt);
	 acrxRegisterAppMDIAware(pkt);
	 initApp();
	}
		break;
	case AcRx::kUnloadAppMsg:
	{
	 unloadApp();
	}
		break;

	default:
		break;
	}
	return AcRx::kRetOK;
}