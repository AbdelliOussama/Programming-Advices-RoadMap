#include <iostream>
using namespace std;
void readnumbers(int& num1, int& num2)
{
	cout << "\nenter number1" << endl;
	cin >> num1;
	cout << "\nenter number2" << endl;
	cin >> num2;
}

int maxofnumbers(int num1, int num2)
{
	if (num1 > num2)

		return num1;
	else
		return num2;
}
void printmax(int max)
{

	cout << "\n the max of numbers is\t" << max;
}
int main()
{
	int num1, num2;
	readnumbers(num1, num2);
	printmax(maxofnumbers(num1,num2));
}

