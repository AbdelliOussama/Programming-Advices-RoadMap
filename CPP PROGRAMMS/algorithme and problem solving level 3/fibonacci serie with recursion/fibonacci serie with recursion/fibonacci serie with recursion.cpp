#include<iostream>
#include<string>
using namespace std;
void printfiboseriewithrecursion(int number, int prev2, int prev1 )
{
	int fibo = 0;

	if ( number>0)
	{
		
		fibo = prev2 + prev1;
		prev2 = prev1;
		prev1 = fibo;
		cout << fibo << " ";
		printfiboseriewithrecursion(number-1,prev1,prev2);
	}
}
int main()
{
	printfiboseriewithrecursion(10,0,1);
	return 0;
}