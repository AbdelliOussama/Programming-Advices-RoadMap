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
		arr[i] = random_number(0, 100);
	}
}
void print_array_of_random(int arr[100], int arrlength)
{
	for (int i = 0; i <= arrlength - 1; i++)
	{
		cout << arr[i] << " ";
	}
}
bool search_number(int arr[100], int arrlength, int research_number)
{
	for (int i = 0; i <= arrlength - 1; i++)
	{
		if (arr[i] == research_number)
			return 1;
	}
	return 0;
}




int main()
{
	srand((unsigned)time(NULL));
	int arr[100];
	int arrlength = read_a_positif_number("\nplease enter the array length\n");
	fillarrayelementswithrandomnumbers(arr, arrlength);
	cout << "Input:\n";
	cout << arrlength << endl;
	cout << "Output:\n";
	cout << "array 1 elements\n";
	print_array_of_random(arr, arrlength);
	int research_number = read_a_positif_number("\nplease enter the research_number\n");
	cout << "number you are looking for is?\n";
	cout << research_number << endl;
	if (search_number(arr, arrlength, research_number))
	{
		cout << "Yes ,the number is found :-)" << endl;
	}
	else
		cout << " No the number is not found:-( \n";

}
