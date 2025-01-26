#include<iostream>
#include<string>
#include<cctype>
using namespace std;
string readstring()
{
	string mystring;
	cout << "please enter your string?\n";
	getline(cin, mystring);
	return mystring;

}
string convertstringtoupper(string mystring)
{
	for (int i = 0; i < mystring.length(); i++)
	{
		mystring[i] = toupper(mystring[i]);
	}
	return mystring;
}

string convertstringtolower(string mystring)
{
	for (int i = 0; i < mystring.length(); i++)
	{
		mystring[i] = tolower(mystring[i]);
	}
	return mystring;
}

int main()
{
	string  mystring = readstring();
	cout << " string after upprer \n";
	cout << convertstringtoupper(mystring) << endl;
	cout << " string after lower \n";
	cout << convertstringtolower(mystring) << endl;
}