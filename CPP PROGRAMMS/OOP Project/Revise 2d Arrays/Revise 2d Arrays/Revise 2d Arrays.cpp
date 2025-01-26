#include<iostream>
#include<cstdio>
using namespace std;
void FillArray(int Arr[10][10])
{
	for(int i=0;i<10;i++)
	{
		for (int j = 0; j < 10; j++)
		{
			Arr[i][j] = (i + 1) * (j + 1);
		}
	}


}
void PrintArray(int Arr[10][10])
{
	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 10; j++)
		{
			printf("%0*d",2,Arr[i][j]);
			cout << "\t";

		}
		cout << endl;
	}
}
int main()
{
	int Arr[10][10];
	FillArray(Arr);
	PrintArray(Arr);
	system("pause>0");
	return 0;
}