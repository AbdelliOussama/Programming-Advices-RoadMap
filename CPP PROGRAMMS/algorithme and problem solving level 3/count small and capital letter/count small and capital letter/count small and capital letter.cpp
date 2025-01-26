#include<iostream>
#include<string>
#include<cctype>
using namespace std;
string readstring()
{
	string mystring;
	cout << "please enter your string\n";
	getline(cin, mystring);
	return mystring;

}

int countsmallletter(string mystring)
{
	int counter=0;
	for (int i = 0; i < mystring.length(); i++)
	{
		if (islower(mystring[i]))
			counter++;
	}return counter;
}
int countcapitalletter(string mystring)
{
	int counter=0;
	for (int i = 0; i < mystring.length(); i++)
	{
		if (isupper(mystring[i]))
			counter++;
	}return counter;
}
int main()
{
	string mystring = readstring();
	cout << "string length is " << mystring.length()<<endl;
	cout << "capital letter count is " << countcapitalletter(mystring)<<endl;
	cout << "small letter count is " << countsmallletter(mystring) << endl;
}