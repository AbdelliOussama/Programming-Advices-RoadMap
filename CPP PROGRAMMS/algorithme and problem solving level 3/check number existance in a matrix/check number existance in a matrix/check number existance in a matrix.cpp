#include<iostream>
#include<iomanip>
#include<cstdlib>
#include<cstdio>
#include<string>
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

bool checknumberexistance(int matrix[3][3], int nrows, int ncolomns,int number)
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
int main()
{
	srand((unsigned)time(NULL));
	int matrix1[3][3] =
	{ {9,0,0}
	   ,{0,9,0}
	   ,{0,0,9}
	};
	int nrows = 3, ncolomns = 3, number ;

	cout << "Matrix1\n";
	printmatrix(matrix1, nrows, ncolomns);
	 number = readnumber("enter the number you look for in matrix ?"  );
	if (checknumberexistance(matrix1, nrows, ncolomns,number))
	{
		cout << "Yes ,it's there\n";
	}
	else
		cout << "No it's not there\n";



}