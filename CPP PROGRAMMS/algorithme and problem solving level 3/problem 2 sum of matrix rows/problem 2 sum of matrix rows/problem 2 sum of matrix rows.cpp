#include<iostream>
#include<cstdlib>
#include<iomanip>
using namespace std;
int random_number(int from, int to)
{
	int random = rand() % (to - from + 1) + from;
	return random;
}
void fillmatrix(int matrix[3][3], int nrows, int ncolomns)
{
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			matrix[i][j] = random_number(1, 100);
		}
	}
}
void print_matrix(int matrix[3][3], int nrows, int ncolomns)
{
	cout << "the folowing is a 3*3 matrix\n";
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			cout << setw(3) << matrix[i][j] << " ";
		}
		cout << endl;
	}
}
int rowsum(int matrix[3][3], int nrows, int ncolomns)
{
	int sum = 0;
	for (int j = 0; j < ncolomns; j++)
	{
		sum += matrix[nrows][j];

	}return sum;
}
void sumofmatrixrows(int matrix[3][3], int nrows, int ncolomns)
{
	cout << "the followng is the sum of row elements\n";
	for (int i = 0; i < nrows; i++)
	{
		cout << "row " << i << " sum= " << rowsum(matrix,i,ncolomns) << endl;
	}
}
int main()
{
	int matrix[3][3], nrows = 3, ncolomns = 3;
	srand((unsigned)time(NULL));
	fillmatrix(matrix, nrows, ncolomns);
	print_matrix(matrix, nrows, ncolomns);
	sumofmatrixrows(matrix, nrows, ncolomns);

}