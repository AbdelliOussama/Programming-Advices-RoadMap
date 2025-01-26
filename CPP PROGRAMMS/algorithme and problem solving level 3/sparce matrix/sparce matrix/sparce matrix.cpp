#include<iostream>
#include<iomanip>
#include<cstdlib>
#include<cstdio>
#include<string>
using namespace std;
//sparce matrix is a matrix where the number of 0> other number
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

int countZeros(int matrix[3][3], int nrows, int ncolomns)
{
	int counter = 0;
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			if (matrix[i][j] == 0)
				counter++;
		}

	}
	return counter;
}
bool issparcematrix(int matrix[3][3], int nrows, int ncolomns)
{
	int matrixsize = nrows * ncolomns;
	if (countZeros(matrix, nrows, ncolomns) >= matrixsize/2)
		return true;
	else
		return false;
}
int main()
{
	srand((unsigned)time(NULL));
	int matrix1[3][3] =
	{ {9,0,0}
	   ,{0,9,0}
	   ,{0,0,9}
	};
	int nrows = 3, ncolomns = 3, number = 0;

	cout << "Matrix1\n";
	printmatrix(matrix1, nrows, ncolomns);
	if (issparcematrix(matrix1, nrows, ncolomns))
	{
		cout << "Yes ,it's sparce\n";
	}
	else
		cout << "No it's not sparce\n";


	
}