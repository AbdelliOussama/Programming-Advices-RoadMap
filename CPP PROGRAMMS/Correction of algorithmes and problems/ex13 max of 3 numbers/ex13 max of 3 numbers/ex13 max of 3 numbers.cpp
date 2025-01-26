#include <iostream>
using namespace std;
void readnumbers(int& num1, int& num2,int& num3)
{
	cout << "\nenter number1" << endl;
	cin >> num1;
	cout << "\nenter number2" << endl;
	cin >> num2;
	cout << "\nenter number3" << endl;
	cin >> num3;
}

int maxofnumbers(int num1, int num2,int num3)
{
	if (num1 > num2)
		if (num1 > num3)
			return num1;
		else
			return num3;

	else
		if (num2 > num3)
			return num2;
		else
			return num3;
}
void printmax(int max)
{

	cout << "\n the max of numbers is\t" << max;
}
int main()
{
	int num1, num2,num3;
	readnumbers(num1, num2,num3);
	printmax(maxofnumbers(num1, num2,num3));
}

