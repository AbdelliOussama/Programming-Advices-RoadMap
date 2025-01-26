#include<iostream>
#include<iomanip>
using namespace std;
void fillmatrixwithorderednumber(int matrix[3][3], int nrows, int ncolomns)
{
	int counter = 0;
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			counter++;
			matrix[i][j] = counter;
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

void transposemtrix (int matrix[3][3],int transposedmatrix[3][3], int nrows, int ncolomns)
{
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			transposedmatrix[i][j]= matrix[j][i] ;
		}
		cout << endl;
	}
}
int main()
{
	int matrix[3][3],transposedmatrix[3][3], nrows = 3, ncolomns = 3;
	fillmatrixwithorderednumber(matrix, nrows, ncolomns);
	cout << "The following is a 3*3 ordered number \n";
	printmatrix(matrix, nrows, ncolomns);
	cout << "\ntransposed matrix \n";
	transposemtrix(matrix, transposedmatrix, nrows, ncolomns);
	printmatrix(transposedmatrix, nrows, ncolomns);
}