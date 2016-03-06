#ifndef UTILS_H
#define UTILS_H
#include <iomanip>
#include <string>
#include <sstream>
#include "dbid.h"
class Utils
{
public:
	static void wchar_tToSTLstring(const wchar_t*, std::string&);
	static void int_To_wstring(int, std::wstring);
	static std::wstring int_To_wstring(int);
	static void real_To_wstring(double, std::wstring, int nr_decimals = 4);
	static std::wstring real_To_wstring(double, int nr_decimals = 4);
	static double GetTextWidth(const wchar_t*, const wchar_t*);
	static AcDbObjectId NewTextStyle(const wchar_t* textStyleName, double textHeight);

private:

};

#endif
