#include<iostream>
#include<iomanip>
#include<cstdlib>
#include<cstdio>
#include<string>
using namespace std;

int readnumber(string message)
{
	int number;
	cout << message;
	cin >> number;
	return number;
}
void printmatrix(int matrix[3][3], int nrows, int ncolomns)
{
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			printf("%0*d\t", 2, matrix[i][j]);
		}
		cout << endl;
	}
}

int countnumber(int matrix[3][3], int nrows, int ncolomns,int number)
{
	int counter=0;
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			if (matrix[i][j] == number)
				counter++;
		}
		
	}
	return counter;
}
int main()
{
	srand((unsigned)time(NULL));
	int matrix1[3][3] =
	{ {9,0,0}
	   ,{0,9,0}
	   ,{0,0,9}
	};
	int nrows = 3, ncolomns = 3,number=0;

	cout << "Matrix1\n";
	printmatrix(matrix1, nrows, ncolomns);
	number = readnumber("enter the number you want to count? \n");
	cout<<"the number "<<number<<"count in matrix is "<< countnumber(matrix1, nrows, ncolomns,number);
	
}