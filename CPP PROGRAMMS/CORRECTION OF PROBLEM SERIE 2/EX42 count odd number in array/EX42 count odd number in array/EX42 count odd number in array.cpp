#include<iostream>
#include<string>
#include<cstdlib>
using namespace std;
enum enodoreven{odd=1,even=2};
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
enodoreven checkodd(int number)
{
	if(number % 2==0)
		return enodoreven::even;
	else
		return enodoreven::odd;
}

void fillarraywithrandom(int arr[100], int& arrlength)
{
	arrlength = readnumber("please enter the lenght of array\n");
	for (int i = 0; i <= arrlength - 1; i++)
	{
		arr[i] = generaterandom_number(1, 100);
	}
}
int countoddelemntinarray(int arr[100], int arrlength)
{
	int counter = 0;
	for (int i = 0; i <= arrlength - 1; i++)
	{
		if(checkodd(arr[i])==enodoreven::odd)
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
	printarray(arr, arrlength) ;
	cout << endl;
	cout << "odd number count is :" << countoddelemntinarray(arr, arrlength);



}