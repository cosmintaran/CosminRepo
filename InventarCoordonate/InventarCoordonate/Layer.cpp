#include "stdafx.h"
#include <tchar.h>
#include <dbsymtb.h>
#include <dbapserv.h>
#include <string>
#include "Layer.h"

#define COLOR_WHITE 7;

bool  Layer::Create(ACHAR* m_layerName, AcCmColor m_Color, bool m_isFrozen = false, bool m_isOff = false, bool m_isLoked = false)
{
	bool isSucceded = false;
	AcDbLayerTable* pLayerTb = nullptr;
	AcDbDatabase* pDb = acdbHostApplicationServices()->workingDatabase();
	pDb->getSymbolTable(pLayerTb, AcDb::kForWrite);
	if (!pLayerTb->has(m_layerName))
	{

		AcDbLayerTableRecord* pLayerTblRec = new AcDbLayerTableRecord;
		pLayerTblRec->setName(m_layerName);
		pLayerTblRec->setIsFrozen(m_isFrozen);
		pLayerTblRec->setIsOff(m_isOff);
		pLayerTblRec->setIsLocked(m_isLoked);
		pLayerTblRec->setColor(m_Color);
		pLayerTb->add(pLayerTblRec);
		pLayerTblRec->close();
		pLayerTb->close();
		isSucceded = true;
	}
	else
	{
		pLayerTb->close();
		isSucceded = true;
	}
	return isSucceded;
}