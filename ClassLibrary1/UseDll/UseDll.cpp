// UseDll.cpp : �������̨Ӧ�ó������ڵ㡣
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

