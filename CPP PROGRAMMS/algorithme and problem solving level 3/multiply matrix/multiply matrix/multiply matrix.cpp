#include<iostream>
#include<iomanip>"
#include<cstdlib>
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
void calculate_result(int matrix1[3][3], int matrix2[3][3], int resultmatrix[3][3],int nrows, int ncolomns)
{
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			resultmatrix[i][j] = matrix1[i][j]* matrix2[i][j];
		}
	}
}
void printmatrix(int matrix[3][3], int nrows, int ncolomns)
{
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			cout << setw(3) << matrix[i][j] << " ";
		}
		cout << endl;
	}
}
int main()
{
	srand((unsigned)time(NULL));
	int matrix1[3][3], matrix2[3][3], resultmatrix[3][3], nrows = 3, ncolomns = 3;
	fillmatrixwithrandomnumber(matrix1, nrows, ncolomns);
	fillmatrixwithrandomnumber(matrix2, nrows, ncolomns);
	calculate_result(matrix1, matrix2, resultmatrix, nrows, ncolomns);
	cout << "matrix1:\n";
	printmatrix(matrix1, nrows, ncolomns);
	cout << "matrix2\n";
	printmatrix(matrix2, nrows, ncolomns);
	cout << "Result:\n";
	printmatrix(resultmatrix, nrows, ncolomns);






}