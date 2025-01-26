#include<iostream>
#include<string>
using namespace std;
enum primenotprime { prime = 1, notprime = 2 };
int readnumber(string message)
{
	int number;
	cout << message;
	cin >> number;
	return number;
}
primenotprime checkprime(int number)
{

	for (int i = 2; i <= number / 2; i++)
	{
		if (number % i == 0)
			return  primenotprime::notprime;
		
	}	return  primenotprime::prime;
}
void printprimenumbers(int number)
{
	cout << "\n";
	cout << "prime number from " << 1 << " to " << number<<endl<<endl;
	for (int i = 1; i <= number; i++)
	{
		if (checkprime(i) == primenotprime::prime)
		{
			cout << i << "is a prime number" << endl;
		}

	}
}
int main()
{
	printprimenumbers(readnumber("please enter a number"));
}