// NativeDll.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <stdio.h>
#include <cstdlib>
#include <vector>


extern "C"
{
	typedef struct _Point {
		int X;
		int Y;
	}Point;

	__declspec(dllexport) void DisplayHelloFromDLL()
	{
		printf("Hello from DLL !\n");
	}

	__declspec(dllexport) int* AllocateArrayOfInt(int size)
	{
		int* a = new int[size];
		for (int i = 0; i < size; i++) {
			a[i] = i;      // Initialize all elements to zero.
		}
		return a;
	}

	__declspec(dllexport) void DeallocateArrayOfInt(int* ptr)
	{
		delete[] ptr;
	}

	__declspec(dllexport) Point* AllocateArrayOfPoint(int size)
	{
		Point* a = new Point[size];    // Pointer to int, initialize to nothing.

		for (int i = 0; i < size; i++) {
			a[i].X = i;      // Initialize all elements to zero.
			a[i].Y = i + 1;
		}
		return a;
	}

	__declspec(dllexport) void DeallocateArrayOfPoint(Point* ptr)
	{
		delete[] ptr;
	}

	__declspec(dllexport) void AllocReallocAndFree()
	{
		// Set the number of elements for the array
		int n = 50;

		//Alloc memory
		int* ptr = static_cast<int*>(malloc(n * sizeof(int)));

		// Check if the memory has been successfully allocated by malloc or not
		if (ptr == nullptr)
		{
			return;
		}

		// Set the new size for the array
		n = 100;

		// Dynamically re-allocate memory using realloc()
		ptr = static_cast<int*>(realloc(ptr, n * sizeof(int)));

		// Free the memory
		free(ptr);
	}

	__declspec(dllexport) void AllocReallocAndFreeUsingVector()
	{
		// Set the number of elements for the array
		int n = 50;

		//Alloc memory
		//int* ptr = static_cast<int*>(malloc(n * sizeof(int)));
		std::vector<int> vector(n, 0);

		// Set the new size for the array
		n = 100;

		// Dynamically re-allocate memory using realloc()
		vector.resize(n);

		// Free the memory
		vector.clear();
	}
}
