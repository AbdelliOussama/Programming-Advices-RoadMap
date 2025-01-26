#include<iostream>
#include<string>
using namespace std;
int readnumber(string message)
{
	int number;
	cout << message;
	cin >> number;
	return number;
}
void FillArray(int arr[100], int& arrLength)
{
	int arrlength = 6;
	arr[0] = 10;
	arr[1] = 20;
	arr[2] = 30;
	arr[3] = 30;
	arr[4] = 20;
	arr[5] = 10;


}
void PrintArray(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << " ";
	cout << "\n";
}

bool palindrome_array(int arr[100], int length)
{
	for (int i = 0; i < length; i++)
	{
		if (arr[i] != arr[length - 1 - i])
		{
			return false;
		}
	}
	return true;

}

int main()
{
	int arr[100],arrlength=6;
	FillArray(arr, arrlength);
	cout << "\nArray  elements:\n";
	PrintArray(arr, arrlength);
	if (palindrome_array(arr, arrlength))
		cout << "yes the array is palindrome" << endl;
	else
		cout << "No the array is Not palindrome" << endl;
	return 0;
}