#include<iostream>
#include<iomanip>
#include<cstdlib>
#include<cstdio>
using namespace std;

void fillmatrixwithnumber(int matrix[3][3], int nrows, int ncolomns)
{
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			cin>>matrix[i][j] ;
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
bool isidentity(int matrix[3][3], int nrows, int ncolomns)
{
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			if (matrix[j][j] == 1 && matrix[i][j] == 0)
				return true;
		}
		
	}
	return false;
}

int main()
{
	srand((unsigned)time(NULL));
	int matrix1[3][3], nrows = 3, ncolomns = 3;
	fillmatrixwithnumber(matrix1, nrows, ncolomns);
	cout << "Matrix1\n";
	printmatrix(matrix1, nrows, ncolomns);
	if (isidentity(matrix1, nrows, ncolomns))
		cout << "Yes matrix is identity\n";
	else
		cout << "No matrix is not identity\n";

	
}