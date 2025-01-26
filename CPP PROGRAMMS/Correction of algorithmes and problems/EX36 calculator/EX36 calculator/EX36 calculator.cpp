#include<iostream>
#include<string>
using namespace std;
enum enooerationtype{add='+',minus='-',multi='*',division='/' };
int readnumber(string message)
{
	int number;
	cout << message << endl;
	cin >> number;
	return number;
}
enooerationtype readoptype()
{
	char ot = '+';
	cout << "\nplease enter operation type:" << endl;
	cin >> ot;
	return enooerationtype(ot);

}

float calculate(int number1, int number2, enooerationtype ot)
{
	switch (ot)
	{
	case  enooerationtype::add:
		return number1 + number2; break;
	case   enooerationtype::minus:
		return number1 - number2; break;
	case  enooerationtype::multi:
		return number1 * number2; break;
	case  enooerationtype::division:
		return number1 / number2; break;
	default :
		return number1 + number2;
	}
}

int main()
{
	int N1 = readnumber("please unter number1");
	int N2 = readnumber("please unter number2");
	enooerationtype ot = readoptype();
	cout<<"result=:"<< calculate(N1, N2, ot);
}