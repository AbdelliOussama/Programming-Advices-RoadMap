#include<iostream>
#include<iomanip>
#include<cstdlib>
#include<cstdio>
#include<string>
#include<vector>
using namespace std;
int readnumber(string message)
{
	int number;
	cout << message;
	cin >> number;
	return number;
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

bool checknumberexistance(int matrix[3][3], int nrows, int ncolomns, int number)
{
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			if (matrix[i][j] == number)
				return true;

		}

	} return false;

}
void intersectnumber(int matrix2[3][3],int matrix1[3][3], int nrows, int ncolomns, int number, vector<int>& vintersectnumber)
{
	for (int i = 0; i < nrows; i++)
	{
		for (int j = 0; j < ncolomns; j++)
		{
			if (checknumberexistance(matrix2, nrows, ncolomns, matrix1[i][j]))
				vintersectnumber.push_back(matrix1[i][j]);

		}

	} 
}
void printintersectednumber(vector<int>& vintersectnumber)
{
	for (int number : vintersectnumber)
	{
		cout << number << " ";
	}
}

int main()
{
	srand((unsigned)time(NULL));
	int matrix1[3][3] =
	{ {9,77,0}
	   ,{12,9,99}
	   ,{0,12,9}
	},
	matrix2[3][3] =
	{ {9,0,3}
	   ,{12,9,66}
	   ,{0,77,9}
	};
	int nrows = 3, ncolomns = 3, number=0;
	vector<int>vintersectnumber;
	cout << "Matrix1\n";
	printmatrix(matrix1, nrows, ncolomns);
	cout << "Matrix2\n";
	printmatrix(matrix2, nrows, ncolomns);
	intersectnumber(matrix1, matrix2, nrows, ncolomns, number, vintersectnumber);
	cout << "intersected number are\n";
	printintersectednumber(vintersectnumber);
}