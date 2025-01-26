#include<iostream>
#include<string>
#include<cstdlib>
#include<cmath>
using namespace std;
int readnumber(string message)
{
	float number;
	cout << message;
	cin >> number;
	return number;
}
float getfractionpart(float number)
{
	return number - (int)number;
}

float myroundnumber(float number)
{
	int intpart;
	intpart = (int)number;
	float fractionpart = getfractionpart(number);
	if (abs(fractionpart) > .5)
	{
		if (number > 0)
			return ++intpart;
		else
			return --intpart;
	}
	else
	{
		return intpart;
	}
}


int main()
{
	float number = readnumber("please enter a  number");
	cout << "Input:" << endl;
	cout << number << endl;
	cout << "Output:\n";
	cout << "my round result is: " << myroundnumber(number) << endl;
	cout << "C++ round number is: " << round(number) << endl;


}