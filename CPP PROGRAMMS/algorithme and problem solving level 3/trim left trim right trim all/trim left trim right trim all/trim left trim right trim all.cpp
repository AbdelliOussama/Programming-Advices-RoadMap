#include<iostream>
#include<string>
#include<cctype>
#include<vector>
using namespace std;
string readstring()
{
	string mystring;
	cout << "enter you string\n";
	getline(cin, mystring);
	return mystring;
}
string trimleft(string mystring)
{
	for (int i = 0; i < mystring.length(); i++)
	{
		if(mystring[i]!=' ')
			return mystring.substr(i, mystring.length()-i);
	}
	return "";
}

string trimright(string mystring)
{
	for (int i = mystring.length(); i >= 0; i--)
	{
		if (mystring[i] != ' ')
			return mystring.substr(0,i+1);
	}
	return "";
}
string trim(string mystring)
{
	return trimleft(trimright(mystring));
}
int main()
{
	string mystring = readstring();
	cout << endl; 
	cout <<"trim left "<< trimleft(mystring)<<endl;
	cout << "trim right " << trimright(mystring)<<endl;
	cout << "trim " << trim(mystring) << endl;
}