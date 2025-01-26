#include<iostream>
using namespace std;
void PrintNumbersFromMtoN(int N, int M)
{
	if (N <= M)
	{
		cout << M << endl;   
		PrintNumbersFromMtoN(N , M-1);
	}
}

void PrintNumbersFromMtoN(int N, int M)
{
	if (N <= M)
	{
		cout << M << endl;
		PrintNumbersFromMtoN(N, M - 1);
	}
}
int main()
{
	PrintNumbersFromMtoN(1, 10);
	return 0;
}