#include<iostream>
#include<string>
#include<cstdlib>
using namespace std;
int readnumber(string message)
{
	int number;
	cout << message;
	cin >> number;
	return number;
}
int generaterandom_number(int from, int to)
{
	int random = rand() % (to - from + 1) + 1;
	return random;
}

void fillarraywithrandom(int arr[100], int& arrlength)
{
	arrlength = readnumber("please enter the lenght of array\n");
	for (int i = 0; i <= arrlength - 1; i++)
	{
		arr[i] = generaterandom_number(-100, 100);
	}
}
int countnegativeelemntinarray(int arr[100], int arrlength)
{
	int counter = 0;
	for (int i = 0; i <= arrlength - 1; i++)
	{
		if (arr[i] < 0)
			counter++;
	}
	return counter;
}
void printarray(int arr[100], int arrlength)
{
	for (int i = 0; i <= arrlength - 1; i++)
		cout << arr[i] << " ";
}

int main()
{
	srand((unsigned)time(NULL));
	int arr[100], arrlength = 0;
	fillarraywithrandom(arr, arrlength);
	cout << "\nInput:\n";
	cout << arrlength << endl;
	cout << "Output:\n";
	cout << "array element: ";
	printarray(arr, arrlength);
	cout << endl;
	cout << "negative number count is :" << countnegativeelemntinarray(arr, arrlength);



}