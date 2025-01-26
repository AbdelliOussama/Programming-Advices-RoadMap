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
		for (int j = 0; j < ncolomns/2; j++)
		{
			printf("%0*d\t", 2, matrix[i][j]);
		}
		cout << endl;
	}
}
bool ispalindrome(int matrix[3][3], int nrows, int ncolomns)
{
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			if (matrix[i][j] == matrix[i][ncolomns - j])
				return true;
		}

	}return false;
}

int main()
{
	srand((unsigned)time(NULL));
	int matrix1[3][3] =
	{ {1,2,1}
	   ,{5,5,5}
	   ,{7,3,7}
	};
	int nrows = 3, ncolomns = 3;
	cout << "Matrix1\n";
	printmatrix(matrix1, nrows, ncolomns);
	if (ispalindrome(matrix1, nrows, ncolomns))
		cout << "Yes: matrix is palindrome\n";
	else
		cout<< "No: matrix is not palindrome\n";
	

}