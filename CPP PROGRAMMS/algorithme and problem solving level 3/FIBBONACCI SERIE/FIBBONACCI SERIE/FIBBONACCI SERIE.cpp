#include<iostream>
#include<string>
using namespace std;
void printfiboserieusingloop(int number)
{
	int prev1=1, prev2=0,fibo=0;
	cout << "1 ";
	for (int i = 2; i < number; i++)
	{
		fibo = prev2 + prev1;
		cout << fibo << " ";
		prev2 = prev1;
		prev1 = fibo;
	}
}
int main()
{
	printfiboserieusingloop(10);
	return 0;
}