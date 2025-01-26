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
void printfirstletterofstring(string mystring)
{
	bool isfirstletter = true;
	cout << "First letter of this string is : \n";
	for (int i = 0; i < mystring.length(); i++)
	{
		if (mystring[i] != ' ' && isfirstletter)
		{
			cout << mystring[i]<<endl;
		}
		isfirstletter = ((mystring[i] == ' ') ? true : false);

	}
}
int main()
{
	string mystring = readstring();
	printfirstletterofstring(mystring);
}