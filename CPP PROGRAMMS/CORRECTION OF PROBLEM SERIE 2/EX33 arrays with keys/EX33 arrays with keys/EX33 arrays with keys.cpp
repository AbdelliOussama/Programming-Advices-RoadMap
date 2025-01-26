#include<iostream>
#include<string>
#include<cstdlib>
using namespace std;
enum enchartype{digit=0,smallletter=1,capitalletter=2, special_caractere =3};
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
char generaterandomchar(enchartype chartype)
{
	switch (chartype)
	{
	case enchartype::capitalletter:
	{return char(random_number(65, 90)); break; }
	case enchartype::smallletter:
	{return char(random_number(97, 122)); break; }
	case enchartype::digit:
	{return char(random_number(48, 57)); break; }
	case enchartype::special_caractere:
	{return char (random_number(33, 47)); break; }
	}
	
}
string generateword(enchartype chartype, short length)
{
	string word =" ";
	for (int i=1; i <= length; i++)
	{
		word += (char)generaterandomchar(chartype);
	}
	return word;
}
string generatekeys()
{
	string key = generateword(enchartype::capitalletter,4) + "-" + generateword(enchartype::capitalletter, 4) + "-" + generateword(enchartype::capitalletter, 4) + " - " + generateword(enchartype::capitalletter, 4) ;
	return key;
}
void fillarrayelementswithkeys(string arr[100], int arrlength)
{
	for(int i=0;i<=arrlength-1;i++)
	{
		arr[i] = generatekeys();
	}
}
void print_array_of_keys(string arr[100], int arrlength)
{
	for (int i = 0; i <= arrlength - 1; i++)
	{
		cout << "array[" << i << "]:" << arr[i]<<endl;
	}
}


int main()
{
	srand((unsigned)time(NULL));
	string arr[100];
	int arrlength = read_a_positif_number("\nplease enter the array length\n");
	fillarrayelementswithkeys(arr, arrlength);
	cout << "Input:\n";
	cout << arrlength<<endl;
	cout << "Output:\n";
	cout << "array elements\n";
	print_array_of_keys(arr, arrlength);
}