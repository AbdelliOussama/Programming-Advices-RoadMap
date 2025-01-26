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
			printf( "%0*d\t",2,  matrix[i][j]);
		}
		cout << endl;
	}
}
void printmiddlerow(int matrix[3][3], int nrows, int ncolomns)
{
	int middlerows = nrows / 2;
	for (int j = 0; j < ncolomns; j++)
	{
		printf("%0*d\t", 2, matrix[middlerows][j]);
	}cout << endl;
}
void printmiddlecolomn(int matrix[3][3], int nrows, int ncolomns)
{
	int middlecolomns = ncolomns / 2;
	for (int j = 0; j < nrows; j++)
	{
		printf("%0*d\t", 2, matrix[j][middlecolomns] );
	}cout << endl;
}

int main()
{
	srand((unsigned)time(NULL));
	int matrix[3][3], nrows = 3, ncolomns = 3;
	fillmatrixwithrandomnumber(matrix, nrows, ncolomns);
	cout << "the following is a 3*3 matrix \n";
	printmatrix(matrix, nrows, ncolomns);
	cout << "middle row of matrix is:\n";
	printmiddlerow(matrix, nrows, ncolomns);
	cout << "middle colomn of matrix is:\n";
	printmiddlecolomn(matrix, nrows, ncolomns);

}