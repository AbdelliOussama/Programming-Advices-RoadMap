#include <iostream>
#include<string>
using namespace std;

int my_sumfonction2(int number1, int number2) {
	return  number1 + number2;
}
// algorithme 31 
int my_powerfonction2(int number1) {
	return  number1 * number1;}
// algorithme 31 
int my_convertfonction3(int numof_day,int num_ofhours,int num_ofminute,int num_ofsecond) {
	int c;
	c = ((numof_day * 24 * 3600) + (num_ofhours * 3600) + (num_ofminute * 60) + num_ofsecond);
		return c;
}
//31,32,42,43

int main()
{
	int X = my_sumfonction2(4,7);
	cout << "x eequal\t" << X << endl;

	int P = my_powerfonction2(7);
	cout << "P eequal\t" << P << endl;

	int C = my_convertfonction3(2,5,45,35);
	cout << "C eequal\t" << C << endl;
}