#include <iostream>
using namespace std;
void readnumbers(int& num1, int& num2)
{
	cout << "\nenter number1" << endl;
	cin >> num1;
	cout << "\nenter number2" << endl;
	cin >> num2;
	
}

void  swapnumbers(int& num1, int& num2)
{
	int temp;
	temp = num1;
	num1 = num2;
	num2 = temp;
	
}
void printnumber(int num1, int num2)
{
	cout << "\number1 is:\t" << num1;
	cout << "\number2 is:\t" << num2;

}
int main()
{
	int num1, num2;
	readnumbers(num1, num2);
	printnumber(num1, num2);
	swapnumbers(num1, num2);
	printnumber(num1, num2);
}

