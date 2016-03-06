// stdafx.cpp : source file that includes just the standard includes
// InventarCoordonate.pch will be the pre-compiled header
// stdafx.obj will contain the pre-compiled type information

#if defined(_DEBUG) && !defined(_FULLDEBUG_)
#define _DEBUG_WAS_DEFINED
#undef _DEBUG
#endif

#include "stdafx.h"

#ifdef _DEBUG_WAS_DEFINED
#define _DEBUG
#undef _DEBUG_WAS_DEFINED
#endif

// ObjectARX Includes
#include "rxregsvc.h"
#include "acutads.h"
