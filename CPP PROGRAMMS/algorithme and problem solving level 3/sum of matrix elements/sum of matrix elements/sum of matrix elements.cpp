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
int sumofelemnts(int matrix[3][3], int nrows, int ncolomns)
{
	int sum = 0;
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			sum += matrix[i][j];
		}
	}return sum;
}

int main()
{
	srand((unsigned)time(NULL));
	int matrix[3][3], nrows = 3, ncolomns = 3;
	fillmatrixwithrandomnumber(matrix, nrows, ncolomns);
	cout << "the following is a 3*3 matrix \n";
	printmatrix(matrix, nrows, ncolomns);
	cout<<"the sum of matrix elements is:  "<< sumofelemnts(matrix, nrows, ncolomns);
	
}