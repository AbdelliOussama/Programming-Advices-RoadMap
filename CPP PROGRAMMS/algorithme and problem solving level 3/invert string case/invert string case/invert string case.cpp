#include<iostream>
#include<string>
#include<cctype>
using namespace std;
string readstring()
{
	string mystring;
	cout << "please enter your string\n";
	cin >> mystring;
	return mystring;

}

char invertchar(char mychar)
{
	return (isupper(mychar)) ? tolower(mychar) : toupper(mychar);
}
string invertstringcase(string mystring)
{
	for (int i = 0; i < mystring.length(); i++)
	{
		mystring[i] = invertchar(mystring[i]);
	}
	return mystring;
}
int main()
{
	string mystring= readstring();
	cout << "string after inverting is\n";
	cout << invertstringcase(mystring);

}