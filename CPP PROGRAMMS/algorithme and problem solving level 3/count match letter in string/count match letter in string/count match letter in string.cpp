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
	cin >> mychar;
	return mychar;
}
char invertchar(char mychar)
{
	return (isupper(mychar)) ? tolower(mychar) : toupper(mychar);
}
short countcaracter(string  mystring, char mychar,bool matchcase)
{
	int counter = 0;
	for (int i = 0; i < mystring.length(); i++)
	{
		if (matchcase)
		{
			if (mystring[i]==mychar)
				counter++;
		}
		else
		{
			if (tolower(mystring[i] == tolower(mychar)))
			{
				counter++;
			}
		}
	}return counter;
}

int main()
{
	bool matchcase=true;
	string mystring= readstring(); 
	char mychar = readchar();  
	cout << "\nLetter \'" << mychar << "\' Count = " << countcaracter(mystring, mychar,matchcase);
	cout << "\nLetter \'" << mychar << "\' "; 
	cout << "Or \'" << invertchar(mychar) << "\' ";
	cout << " Count = " << countcaracter(mystring, mychar, false);
	system("pause>0");
}