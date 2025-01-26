#include<iostream>
#include<iomanip>
#include<cstdlib>
#include<cstdio>
#include<string>
#include<vector>
using namespace std;
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
int minofmatrix(int matrix[3][3], int nrows, int ncolomns)
{
	int min = matrix[0][0];
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			if (matrix[i][j] < min)
				min = matrix[i][j];
		}

	}return min;
}

int maxofmatrix(int matrix[3][3], int nrows, int ncolomns)
{
	int max = matrix[0][0];
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			if (matrix[i][j] > max)
				max = matrix[i][j];
		}

	}return max;
}
int main()
{
	srand((unsigned)time(NULL));
	int matrix1[3][3] =
	{ {9,77,0}
	   ,{12,9,99}
	   ,{0,12,9}
	};
	int nrows = 3, ncolomns = 3;
	cout << "Matrix1\n";
	printmatrix(matrix1, nrows, ncolomns);
	cout << "the min of the matrix is " << minofmatrix(matrix1, nrows, ncolomns)<<endl;
	cout << "the max of the matrix is " << maxofmatrix(matrix1, nrows, ncolomns) << endl;

}