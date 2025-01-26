#include<iostream>
#include<string>
#include<cstdlib>
using namespace std;
enum enoddoreven{odd=0,even=1 };
int read_number(string message)
{
	int arrlength;
	cout << message;
	cin >> arrlength;
	return arrlength;
}
int random_number(int from, int to)
{
	int random = rand() % (to - from + 1) + from;
	return random;
}
enoddoreven checkodeven(int numbers)
{
	if (numbers % 2 == 0)
		return enoddoreven::even;
	else
		return enoddoreven::odd;
}
void fillarraywithrandomnumber(int arr1[100], int arrlength)
{
	for (int i = 0; i <= arrlength - 1; i++)
	{
		arr1[i] = random_number(1, 100);
	}
}
void AddArrayElement(int Number, int arr2[100], int& arr2Length)
{ //its a new element so we need to add the length by 1
	arr2Length++;
	arr2[arr2Length - 1] = Number;
}
void copyoddNumbersInArray(int arr[100], int arr2[100], int arrlength, int& arr2Length)
{
	for (int i = 0; i <= arrlength - 1; i++)
	{
		if(checkodeven(arr[i])== enoddoreven::odd)
		AddArrayElement(arr[i], arr2, arr2Length);
	}
}
void PrintArray(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << " ";     cout << "\n";
}

int main()
{
	srand((unsigned)time(NULL));
	int arr[100], arr2[100], arr2Length = 0;
	int arrlength = read_number("please enter array 1 length \n");
	fillarraywithrandomnumber(arr, arrlength);
	cout << "Input:\n";
	cout << arrlength << endl;
	cout << "array 1 elements :\n";
	PrintArray(arr, arrlength);
	copyoddNumbersInArray(arr, arr2, arrlength, arr2Length);
	cout << "array 2 elements :\n";
	PrintArray(arr2, arr2Length);



}