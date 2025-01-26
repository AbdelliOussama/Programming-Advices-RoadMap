#include<iostream>
#include<iomanip>
#include<cstdlib>
#include<cstdio>
using namespace std;
int randumnumber(int from, int to)
{
	int random = rand() % (to - from + 1) + from;
	return random;
}
void fillmatrixwithrandomnumber(int matrix[3][3], int nrows, int ncolomns)
{
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			matrix[i][j] = randumnumber(1, 10);
		}
	}
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

bool aretypical(int matrix1[3][3], int matrix2[3][3], int nrows, int ncolomns)
{
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			if(matrix1[i][j] != matrix2[i][j]);
			return false;
		}
		
	}
	return true;
}
int main()
{
	srand((unsigned)time(NULL));
	int matrix1[3][3], matrix2[3][3], nrows = 3, ncolomns = 3;
	fillmatrixwithrandomnumber(matrix1, nrows, ncolomns);
	cout << "Matrix1\n";
	printmatrix(matrix1, nrows, ncolomns);
	fillmatrixwithrandomnumber(matrix2, nrows, ncolomns);
	cout << "Matrix2 \n";
	printmatrix(matrix2, nrows, ncolomns);
	if (aretypical(matrix1, matrix2, nrows, ncolomns))
	{
		cout << "Yes matrix are equal\n";
	}
	else
		cout << "No matrix are not equal\n";
}