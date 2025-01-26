#pragma once
#include <iostream>
#include<string>
using namespace std;

namespace my_first_lib
{
	float read_number(string message)
	{
		float number;
		cout << message<<endl;
		cin >> number;
		return number;
	}
}