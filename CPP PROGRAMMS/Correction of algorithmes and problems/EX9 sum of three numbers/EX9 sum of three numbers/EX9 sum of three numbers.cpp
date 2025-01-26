#include <iostream>
#include<string>
using namespace std;
enum enpassfail { pass = 1, fail = 2 };
void readnumbers(int& number1, int& number2, int& number3)
{
	
	cout << "\nenter number1"<<endl;
	cin >> number1;
	cout << "\nenter number2"<<endl;
	cin >> number2;
	cout << "\nenter number3"<<endl;
	cin >> number3;
}
int  sumofnumbers(int number1,int number2, int number3)
{
		return number1+number2+number3;	
}
float calculateaverage(int number1, int number2, int  number3)
{
	return (float)sumofnumbers(number1, number2, number3) / 3;
}
void printresult(int total)
{
	cout << "\nthe sum of the numbers is :" << total << endl;
	cout << "\nthe average of the three numbers is :" << (float)total/3;
}

int main()
{
	int number1, number2, number3;
	readnumbers(number1, number2, number3);
	printresult(sumofnumbers(number1, number2, number3));
}
