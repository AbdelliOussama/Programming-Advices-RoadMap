#include<iostream>
#include<iomanip>
#include<cstdlib>
#include<cstdio>
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
bool isscalar(int matrix[3][3], int nrows, int ncolomns)
{
	int firstdiagonal = matrix[0][0];
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			if (i == j && matrix[i][j] != firstdiagonal)
			{
				return false;
			}
			else if (i != j && matrix[i][j] != 0)
			{
				return false;
			}
		}

	}
	return true;
}

int main()
{
	srand((unsigned)time(NULL));
	int matrix1[3][3] =
	{   {9,0,0}
	   ,{0,9,0} 
	   ,{0,0,9}
	};
	int nrows = 3, ncolomns = 3;
	
	cout << "Matrix1\n";
	printmatrix(matrix1, nrows, ncolomns);
	if (isscalar(matrix1, nrows, ncolomns))
		cout << "Yes matrix is scalar\n";
	else
		cout << "No matrix is not scalar\n";


}