#include<iostream>
#include<string>
using namespace std;
string readstring(string message)
{
	string mystring;
	cout << message;
	getline(cin, mystring);
	return mystring;
}
string replacewordsinstringusingbuiltinfunction(string mystring, string wordtoreplace, string replaceto)
{
	int pos = mystring.find(wordtoreplace);
	while (pos != std::string::npos)
	{
		mystring.replace(pos, wordtoreplace.length(), replaceto);
		pos = mystring.find(wordtoreplace);//find the next word
	}
	return mystring;
}
int main()
{
	string  mystring = readstring("please enter your string\n");
	string replaceto= readstring("please enter the word to replce\n");
	cout << replacewordsinstringusingbuiltinfunction(mystring, "oussama", replaceto);
	
}