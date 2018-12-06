// UseDll.cpp : 定义控制台应用程序的入口点。
//
#include "stdafx.h"
#using "ClassLibrary1.dll"
using namespace ClassLibrary1;

int _tmain(int argc, _TCHAR* argv[])
{	

	Class1 ^a = gcnew Class1();
	a->addEncryption();
	return 0;
}

