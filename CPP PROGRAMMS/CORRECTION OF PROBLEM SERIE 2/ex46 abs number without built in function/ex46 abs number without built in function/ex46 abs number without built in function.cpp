#include<iostream>
#include<string>
#include<cstdlib>
#include<cmath>
using namespace std;
int readnumber(string message)
{
	int number;
	cout << message;
	cin >> number;
	return number;
}

int absnumber(int number)
{
	if (number > 0)
		return number;
	else
		return number * -1;

}


int main()
{
	int number = readnumber("please enter a negative number");
	cout << "Input:"<<endl;
	cout << number << endl;
	cout << "Output:\n";
	cout << "my abs result is: " << absnumber(number) << endl;
	cout << "C++ abs number is: " << abs(number) << endl;


}