#include<iostream>
#include<string>
#include<cctype>
using namespace std;
string readstring()
{
	string mystring;
	cout << "enter you string\n";
	getline(cin, mystring);
	return mystring;
}
char readchar()
{
	char mychar;
	cout << "please enter a caracter\n";
	cin >> mychar;
	return mychar;
}
bool checkvowel(char mychar)
{
	mychar = tolower(mychar);
	return ((mychar == 'a') || (mychar == 'e') || (mychar == 'i'), (mychar == 'u'), (mychar == 'o'));
}
void printvowelsinstring(string mystring)
{
	for (int i = 0; i < mystring.length(); i++)
	{
		if (checkvowel(mystring[i]))
			cout<< mystring[i]<<" ";
	}cout << endl;
}

int main()
{
	string mystring = readstring();
	cout << "vowels in string are:  ";
	 printvowelsinstring(mystring) ;

}