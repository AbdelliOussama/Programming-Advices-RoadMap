#include <iostream>
#include<string>
using namespace std;
int readnumber(string message)
{
	int N;
	do
	{
		cout << message << endl;
		cin >> N;
	} while (N<0);
	return N;
}

int factorial(int N)
{
	int f = 1;
	for (int i=1; i <= N; i++)
	{
		f *= i;
	}
	return f;
}

int main()
{
	cout  <<factorial(readnumber("please enter a positif number")) << endl;
	
}

