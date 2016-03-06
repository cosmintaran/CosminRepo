#include "stdafx.h"
#include <tchar.h>
#include <string>
#include <fstream>
#include <sstream>
#include <map>
#include <iomanip>
//===Autocad Headers==
#include "gepnt3d.h"
#include "acutads.h"

//======Defines======
#define MIN_PATH_LENGHT 4
//======================

#include "ExportClass.h"



ExportClass::ExportClass(){ this->m_wfilePath = L"c:\\Users\\Public\\Documents\\"; }

ExportClass::~ExportClass(){}

ExportClass::ExportClass(ACHAR* wfilePath)
{
	this->m_wfilePath = wfilePath;
}

ExportClass::ExportClass(const ExportClass& ex)
{
	if (this != &ex)
	{
		this->m_wfilePath = ex.m_wfilePath;
	}
}

ACHAR* ExportClass::GetFilePath()
{
	return m_wfilePath;
}

bool ExportClass::SetFilePath(ACHAR* wfilePath)
{
	m_wfilePath = wfilePath;
	return true;
}

bool ExportClass::exportInventarCSV(std::map<std::wstring, AcGePoint3d>& m3dPoints, u_int startIndex = 1)
{
	bool bSucces = false;
	std::fstream file;
	file.open(m_wfilePath, std::ios::out);
	if (file.is_open())
	{
		file << "Nr.crt." << "," << "X[m]" << "," << "Y[m]" << std::endl;

		std::map<std::wstring, AcGePoint3d>::iterator it;
		for (it = m3dPoints.begin(); it != m3dPoints.end(); it++)
		{
			file << std::fixed << std::setprecision(3) << startIndex << "," << it->second.y << "," << it->second.x << std::endl;
			startIndex++;
		}

		file.close();
	}
	else
	{
		acutPrintf(_T("\nEroare la deschiderea fisierului"));
	}


	return bSucces;
}