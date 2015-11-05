
#include "stdafx.h"
#include "tchar.h"
#include <aced.h>
#include <rxregsvc.h>
#include <dbents.h>
#include <arxHeaders.h>
void initApp();
void unloadApp();
void helloWorld();

void initApp()
{
	acedRegCmds->addCommand(_T("HelloWorld_Command"), _T("Hello"), _T("Bonjour"), ACRX_CMD_TRANSPARENT, helloWorld);
}

void unloadApp()
{
	acedRegCmds->removeGroup(_T("HelloWorld_Command"));
}

void helloWorld()
{
	AcGePoint3d startPoint(1.0, 1.0, 0.0);
	AcGePoint3d endPoint(10.0, 10.0, 0.0);
	AcDbLine *pLine = new AcDbLine(startPoint, endPoint);
	AcDbBlockTable *pBlockTable = nullptr;
	AcDbDatabase *pDB = acdbHostApplicationServices()->workingDatabase();
	pDB->getSymbolTable(pBlockTable, AcDb::kForRead);
	AcDbBlockTableRecord *pBlockTableRecord = nullptr;
	pBlockTable->getAt(ACDB_MODEL_SPACE, pBlockTableRecord, AcDb::kForRead);
	pBlockTable->close();
	AcDbObjectId lineID = AcDbObjectId::kNull;
	pBlockTableRecord->appendAcDbEntity(lineID, pLine);
	pBlockTableRecord->close();
	pLine->close();
}

extern "C"
AcRx::AppRetCode acrxEntryPoint(AcRx::AppMsgCode msg, void* appID)
{
	switch (msg)
	{

	case AcRx::kInitAppMsg:
	{
							  acrxDynamicLinker->unlockApplication(appID);
							  acrxDynamicLinker->registerAppMDIAware(appID);
							  initApp();
	}
		break;
	case AcRx::kOleUnloadAppMsg:
	{
								   unloadApp();
	}
		break;
	}

	return AcRx::kRetOK;
}
