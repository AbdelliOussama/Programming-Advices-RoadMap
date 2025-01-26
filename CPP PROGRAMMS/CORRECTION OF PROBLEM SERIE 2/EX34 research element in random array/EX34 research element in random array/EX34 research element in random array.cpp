#include<iostream>
#include<string>
#include<cstdlib>
using namespace std;
int read_a_positif_number(string message)
{
	int number;
	do
	{
		cout << message;
		cin >> number;
	} while (number < 0);
	return number;
}

int random_number(int from, int to)
{
	int random = rand() % (to - from + 1) + from;
	return random;
}
void fillarrayelementswithrandomnumbers(int arr[100], int arrlength)
{
	for (int i = 0; i <= arrlength - 1; i++)
	{
		arr[i] = random_number(0,100);
	}
}
void print_array_of_random(int arr[100], int arrlength)
{
	for (int i = 0; i <= arrlength - 1; i++)
	{
		cout << arr[i] <<" ";
	}
}
int search_numberindex(int arr[100], int arrlength,int research_number)
{
	for (int i = 0; i <= arrlength - 1; i++)
	{
		if (arr[i] == research_number)
			return i;
	}
	return -1;
}




int main()
{
	srand((unsigned)time(NULL));
	int arr[100],index;
	int arrlength = read_a_positif_number("\nplease enter the array length\n");
	fillarrayelementswithrandomnumbers(arr, arrlength);
	cout << "Input:\n";
	cout << arrlength << endl;
	cout << "Output:\n";
	cout << "array 1 elements\n";
	print_array_of_random(arr, arrlength);
	int research_number= read_a_positif_number("\nplease enter the research_number\n");
	cout << "number you are looking for is?\n";
	cout << research_number<<endl;
	index = search_numberindex(arr, arrlength, research_number);
	if (index != -1)
	{
		cout << "the number found at position" << index << endl;
		cout << "the number found its order:" << index + 1 << endl;
	}
	else
		cout << "the number is not found:-(\n";
	
}
