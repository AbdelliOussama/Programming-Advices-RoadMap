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


int main()
{
	float number = readnumber("please enter a  number");
	cout << "Input:" << endl;
	cout << number << endl;
	cout << "Output:\n";
	cout << "my round result is: " << myceilnumber(number) << endl;
	cout << "C++ ceil number is: " << ceil(number) << endl;


}