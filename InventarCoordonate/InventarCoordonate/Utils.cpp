#include "stdafx.h"
#include "Utils.h"
#include "acadstrc.h"
#include "dbmain.h"
#include "dbapserv.h"
#include "acgi.h"
#include "dbsymtb.h"
#include "acgiutil.h"


void Utils::wchar_tToSTLstring(const wchar_t* source, std::string& destination)
{
	std::wstring ws(source);
	std::string temp(ws.begin(), ws.end());
	destination = temp;
}

void Utils::int_To_wstring(int i_value, std::wstring result)
{
	result = std::to_wstring((LONGLONG)i_value);

}

std::wstring Utils::int_To_wstring(int i_value)
{
	std::wstring result = std::to_wstring((LONGLONG)i_value);
	return result;
}


void Utils::real_To_wstring(double r_value, std::wstring result, int nr_decimals )
{
	std::stringstream ss;	
	//ss.fixed;
	ss <<std::ios_base::fixed<<std::setprecision(nr_decimals)<< r_value;
	std::string s_string = ss.str();
	std::wstring ws(s_string.begin(), s_string.end());
	result = ws;
}

std::wstring Utils::real_To_wstring(double r_value, int nr_decimals)
{
	std::stringstream ss;
	//ss.fixed;
	ss << std::setprecision(nr_decimals) << r_value;
	std::string s_string = ss.str();
	std::wstring result(s_string.begin(), s_string.end());
	return result;
}

double Utils::GetTextWidth(const wchar_t* text, const wchar_t* textStyle)
{
	Acad::ErrorStatus es;
	AcDbDatabase* pDb = nullptr;
	
	AcGiTextStyle iStyle;
	AcDbTextStyleTable* pTextStyleBlock = nullptr;
	AcDbTextStyleTableRecord* pTextStyleRecord = new AcDbTextStyleTableRecord();
	pDb = acdbHostApplicationServices()->workingDatabase();
	try
	{
		pDb->getTextStyleTable(pTextStyleBlock, AcDb::kForRead);
		es = pTextStyleBlock->getAt(textStyle, pTextStyleRecord, AcDb::kForRead);
		es = fromAcDbTextStyle(iStyle, pTextStyleRecord->objectId());
		pTextStyleRecord->close();
		pTextStyleBlock->close();
	}
	catch (const Acad::ErrorStatus es)
	{
		acutPrintf(_T("\nEroare: %s", acadErrorStatusText(es)));
		pTextStyleRecord->close();
		pTextStyleBlock->close();
	}
	AcGePoint2d pct = iStyle.extents(text, Adesk::kFalse, _tcslen(text), Adesk::kTrue);
	return pct.x;
}

AcDbObjectId Utils::NewTextStyle(const wchar_t* textStyleName, double textHeight)
{
	Acad::ErrorStatus es;
	AcDbDatabase* pDb = acdbHostApplicationServices()->workingDatabase();
	AcGiTextStyle tableStyle;
	AcDbTextStyleTable* pTextStyleTable = nullptr;
	AcDbTextStyleTableRecord* pTextStyleTableRecord = nullptr;
	AcDbObjectId tempObj;
	try
	{
		pDb->getTextStyleTable(pTextStyleTable, AcDb::kForRead);

		if (!pTextStyleTable->has(textStyleName))
		{
			pTextStyleTableRecord = new AcDbTextStyleTableRecord();
			//es = pTextStyleTableRecord->setFileName(_T("ISO.shx"));
			pTextStyleTable->upgradeOpen();
			es = pTextStyleTableRecord->setName(textStyleName);
			es = pTextStyleTableRecord->setTextSize(textHeight);
			es = pTextStyleTableRecord->setFont(_T("Arial"), Adesk::kFalse, Adesk::kFalse, 0, 32);
			pTextStyleTable->add(pTextStyleTableRecord);
			pTextStyleTableRecord->close();
			pTextStyleTable->getAt(textStyleName, tempObj);
			pTextStyleTable->close();
		}
		else
		{
			pTextStyleTable->getAt(textStyleName, tempObj);
			pTextStyleTable->close();
			
			//es = pTextStyleTableRecord->setTextSize(textHeight);
		}
	}
	catch (Acad::ErrorStatus es)
	{
		acutPrintf(_T("Eroare: %s", acadErrorStatusText(es)));
		
		pTextStyleTable->close();
	}

	return tempObj;
}