#pragma once
#pragma once
#include <iostream>
#include<string>
using namespace std;

namespace Mymathlib
{
	float getfractionpart(float number)
	{
		return number - (int)number;
	}
	float myceilnumber(float number)
	{
		int intpart;
		intpart = (int)number;
		float fractionpart = getfractionpart(number);
		if (abs(fractionpart) > 0)
			if (number > 0)
				return ++intpart;
			else
				return intpart;
		else
			return number;

	}

}
