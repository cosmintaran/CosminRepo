#ifndef EXPORTCLASS_H
#define EXPORTCLASS_H
//=======================

class ExportClass
{
public:
	ExportClass();
	ExportClass(ACHAR* wfilePath);
	ExportClass(const ExportClass& ex);
	ExportClass& operator=(const ExportClass& ex)
	{
		this->m_wfilePath = ex.m_wfilePath;
	}
	~ExportClass();

	bool exportInventarCSV(std::map<std::wstring, AcGePoint3d>&, u_int startIndex);

	ACHAR* GetFilePath();
	bool SetFilePath(ACHAR* filePath);


private:
	ACHAR* m_wfilePath;
};
#endif