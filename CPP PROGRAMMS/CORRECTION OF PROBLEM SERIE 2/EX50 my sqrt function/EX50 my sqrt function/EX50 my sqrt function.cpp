#include<iostream>
#include<string>
#include<cstdlib>
#include<cmath>
using namespace std;
float readnumber(string message)
{
	float number;
	cout << message;
	cin >> number;
	return number;
}

float mysqrtnumber(float number)
{
	return pow(number, 0.5);
}


int main()
{
	float number = readnumber("please enter a  number");
	cout << "Input:" << endl;
	cout << number << endl;
	cout << "Output:\n";
	cout << "my round result is: " << mysqrtnumber(number) << endl;
	cout << "C++ sqrt number is: " << sqrt(number) << endl;


}