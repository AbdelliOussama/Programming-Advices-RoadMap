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
 void FillArrayWithRandomNumbers(int arr[100], int arrLength) 
 {    
		for (int i = 0; i < arrLength; i++)
		{
			arr[i] = RandomNumber(1, 100);
		}
 } 
 
 void PrintArray(int arr[100], int arrLength) 
 { for (int i = 0; i < arrLength; i++)      
	cout << arr[i] << " ";  cout << "\n";
 }

 void sumofelementarr1arr2(int arr1[100], int arr2[100], int arr3[100], int arrlength)
 {
	 for (int i = 0; i < arrlength; i++)
	 {
		 arr3[i] = arr1[i] + arr2[i];
	 }
 }

 int main() 
 { //Seeds the random number generator in C++, called only once   
	 srand((unsigned)time(NULL));
	 int arr1[100], arr2[100],arr3[100];
	 int arrLength = readpositivenumbers("please enter the lenght of the array");
	 FillArrayWithRandomNumbers(arr1, arrLength); 
	 cout << "\nArray 1 elements:\n";
	 PrintArray(arr1, arrLength);
	 FillArrayWithRandomNumbers(arr2, arrLength);
	 cout << "\nArray 2 elements:\n";
	 PrintArray(arr2, arrLength);
	 sumofelementarr1arr2(arr1, arr2, arr3, arrLength);
	 cout << "sum of array1 and array2 elements :" << endl;
	 PrintArray(arr3, arrLength);
	 return 0;
 } 