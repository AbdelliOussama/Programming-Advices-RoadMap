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
float myfloornumber(float number)
{
	int intpart;
	intpart = (int)number;
		if (number > 0)
			return intpart;
		else
			return --intpart;
	
}


int main()
{
	float number = readnumber("please enter a  number");
	cout << "Input:" << endl;
	cout << number << endl;
	cout << "Output:\n";
	cout << "my round result is: " << myfloornumber(number) << endl;
	cout << "C++ floor number is: " << floor(number) << endl;


}