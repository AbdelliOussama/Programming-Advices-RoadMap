#include<iostream>
#include<string>
using namespace std;
int RandomNumber(int From, int To)
{ //Function to generate a random number
	int randNum = rand() % (To - From + 1) + From;
	return randNum;
}
int readpositivenumbers(string message)
{
	int number;
	do
	{
		cout << message << endl;
		cin >> number;
	} while (number < 0);
	return number;
}
void swap(int& A, int& B)
{
	int temp = 0;
	temp = A;
	A = B;
	B = temp;
}
void fillarraywithrandomnumbers(int arr[100], int arrlength)
{
	for (int i = 0; i <= arrlength - 1; i++)
	{
		arr[i] = RandomNumber(1,100);
	}
}

void copy_elemnts_of_array(int arr[100], int arr2[100], int arrlength)
{
	for (int i = 0; i <= arrlength; i++)
	{
		arr2[i] = arr[arrlength-1-i];
	}
}
void PrintArray(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << " ";  cout << "\n";
}

int main()
{ //Seeds the random number generator in C++, called only once   
	srand((unsigned)time(NULL));
	int arr[100], arr2[100];
	int arrLength = readpositivenumbers("please enter the lenght of the array");
	fillarraywithrandomnumbers(arr, arrLength);
	cout << "\nArray 1 elements:\n";
	PrintArray(arr, arrLength);
	copy_elemnts_of_array(arr, arr2, arrLength);
	cout << "array 2 element after copying array 1 in reversed order" << endl;
	PrintArray(arr2, arrLength);
	return 0;
}