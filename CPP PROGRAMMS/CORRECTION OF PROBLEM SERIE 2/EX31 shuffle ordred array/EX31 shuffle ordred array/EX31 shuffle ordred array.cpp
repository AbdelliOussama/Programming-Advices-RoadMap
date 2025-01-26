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
	int temp=0;
	temp = A;
	A = B;
	B = temp;
}
void fillarraywithorderednumbers(int arr[100], int arrlength)
{
	for(int i=0;i<=arrlength-1;i++)
	{
		arr[i] = i+1;
	}
}

void shuffle_array(int arr[100], int arrlength)
{
	for (int i = 0; i < arrlength; i++)
	{
		swap(arr[RandomNumber(1, arrlength) - 1], arr[RandomNumber(1, arrlength) - 1]);
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
	int arr[100], shuffled_arr[100];
	int arrLength = readpositivenumbers("please enter the lenght of the array");
	fillarraywithorderednumbers(arr, arrLength);
	cout << "\nArray elements before shuffle:\n";
	PrintArray(arr, arrLength);
	shuffle_array(arr, arrLength);
	cout << "array element after suffle" << endl;
	PrintArray(arr, arrLength);
	return 0;
}