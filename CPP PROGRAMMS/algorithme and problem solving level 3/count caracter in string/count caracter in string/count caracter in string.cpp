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

char readchar()
{
	char mychar;
	cout << "please enter your caracter\n";
	cin>>mychar;
	return mychar;
}
short countcaracter(string  mystring, char mychar)
{
	int counter=0;
	for (int i = 0; i < mystring.length(); i++)
	{
		if (mystring[i] == mychar)
			counter++;
	}return counter;
}
int main()
{
	string mystring = readstring();
	char mychar = readchar();
	cout << "the letter " << mychar << "count= " << countcaracter(mystring, mychar)<<endl;

	
}