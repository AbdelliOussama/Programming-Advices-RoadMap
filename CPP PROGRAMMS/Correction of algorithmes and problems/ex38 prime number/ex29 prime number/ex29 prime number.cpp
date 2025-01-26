#include<iostream>
#include<string>
using namespace std;
enum enprimenotprime{prime=1,notprime=2};
int readnumber(string message)
{
	int number;
	cout << message << endl;
	cin >> number;
	return number;
}
enprimenotprime checkprimes(int number)
{
	for (int i = 1; i < number / 2; i++)
	{
		if (number % i == 0)
			return enprimenotprime::notprime;
	}
	return enprimenotprime::prime;
}
void printnumbertype(int number)
{
	if (checkprimes(number) == enprimenotprime::notprime)
		cout << "\nthe number:" << number << " \tis not prime" << endl;
	else
		cout << "\nthe number:" << number << "\tis  prime" << endl;
}

int main()
{
	printnumbertype(readnumber("please enter a number"));
}