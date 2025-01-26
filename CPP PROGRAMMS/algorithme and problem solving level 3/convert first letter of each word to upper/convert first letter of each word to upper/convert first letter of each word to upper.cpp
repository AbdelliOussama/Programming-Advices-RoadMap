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
string convertfirstletterofstring(string mystring)
{
	bool isfirstletter = true;
	cout << "First letter of this string is : \n";
	for (int i = 0; i < mystring.length(); i++)
	{
		if (mystring[i] != ' ' && isfirstletter)
		{
			mystring[i] = toupper(mystring[i]);
		}
		isfirstletter = ((mystring[i] == ' ') ? true : false);

	}
	return mystring;
}
int main()
{
	string convertedstring, mystring = readstring();
	cout << "after conversion my string is\n";
	convertedstring= convertfirstletterofstring(mystring);
	cout << convertedstring << endl;
}