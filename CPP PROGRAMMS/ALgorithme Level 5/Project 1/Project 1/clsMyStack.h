#pragma once
#include<iostream>
#include"clsMyQueue.h"
using namespace std;
template<class T>
class clsMyStack : public clsMyQueue<T>
{
public:
	T Top()
	{
		return clsMyQueue<T>::front();
	}
	T Bottom()
	{
		return clsMyQueue<T>::back();
	}
	void Push(T item)
	{
		clsMyQueue<T>::_MyList.InsertAtBeginning(item);
	}
};

