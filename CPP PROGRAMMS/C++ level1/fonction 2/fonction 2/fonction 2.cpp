#include <iostream>
#include<string>
using namespace std;
void my_sumfonction() {
	int number1, number2;
		cout << "please inter number 1"<<endl;
		cin >> number1;
		cout << "please inter number 2"<<endl;
		cin >> number2;
		cout << "the sum of number 1 &nd 2 is :" << number1 + number2<<endl;
}

int my_sumfonction2() {
	int number1, number2;
	cout << "please inter number 1" << endl;
	cin >> number1;
	cout << "please inter number 2" << endl;
	cin >> number2;
	return  number1+number2;
}
int main()
{
	int X = my_sumfonction2();
	cout << "x eequal" << X << endl;
	my_sumfonction();
	
}