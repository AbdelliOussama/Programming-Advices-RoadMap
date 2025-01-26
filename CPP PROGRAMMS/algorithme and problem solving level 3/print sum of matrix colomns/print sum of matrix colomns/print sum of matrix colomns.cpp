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
int colomnssum(int matrix[3][3], int nrows, int ncolomns)
{
	int sum = 0;
	for (int i = 0; i < nrows; i++)
	{
		sum += matrix[i][ncolomns];

	}return sum;
}
void fillarraywithrowsum(int arr[3], int narrcolomns, int matrix[3][3], int nrows)
{
	for (int i = 0; i < narrcolomns; i++)
	{
		arr[i] = colomnssum(matrix, nrows, i);
	}
}
void printarray_elemnts(int arr[3], int narrcolomns)
{
	cout << "the followng is the sum of row elements\n";
	for (int i = 0; i < narrcolomns; i++)
	{
		cout << "colomn " << i << " sum= " << arr[i] << endl;
	}
}

int main()
{
	int arr[3], narrcolomns = 3;
	int matrix[3][3], nrows = 3, ncolomns = 3;
	srand((unsigned)time(NULL));
	fillmatrix(matrix, nrows, ncolomns);
	print_matrix(matrix, nrows, ncolomns);
	fillarraywithrowsum(arr, narrcolomns, matrix, ncolomns);
	printarray_elemnts(arr, narrcolomns);
}