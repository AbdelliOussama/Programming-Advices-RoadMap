#include <iostream>
#include<string>
using namespace std;
int readnumber()
{
	int number;
	cout << "enter a number\n";
	cin >> number;
	return number;
}
float halfnumber(int number)
{
	float halfnumber= number / 2;
	return halfnumber;
}
void printhalfnumber(float halfnumber)
{
	cout << "the half of the number is :\n" << halfnumber;
}

int main()
{
	printhalfnumber(halfnumber(readnumber()));
}
