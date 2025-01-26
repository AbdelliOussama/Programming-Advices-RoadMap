#include <iostream>
using namespace std;
enum enNumbertype{odd=1, even=2 };
int readnumber() {
	int number;
	cout << "enter a number";
	cin >> number;
	return number;
}

enNumbertype checknumbertype(int number) 
{
	int result = number % 2;
	if (result == 0)
		return enNumbertype::even;
	else
		return enNumbertype::odd;
}
void printnumbertype(enNumbertype numbertype) 
{
	if (numbertype == enNumbertype::odd)
		cout << "the number is odd" << endl;
	else 
		cout << "the number is even" << endl;
}
int main()
{
	printnumbertype(checknumbertype(readnumber()));
}

