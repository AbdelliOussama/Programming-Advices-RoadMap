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
short countWordsInString(string mystring)
{
	string delim = " ";
	int nbrwords = 0;
	// delimiter   
	cout << "\nYour string wrords are: \n\n";
	short pos = 0;
	string sWord;
	// define a string variable  // 
	// use find() function to get the position of the delimiters
	while ((pos = mystring.find(delim)) != std::string::npos)
	{
		sWord = mystring.substr(0, pos);

		// store the word  
		if (sWord != "")
		{
			nbrwords++;
		}
		mystring.erase(0, pos + delim.length());
		/* erase() until positon and move to next word. */
	}
	if (mystring != "")
	{
		nbrwords++;
	}
	return nbrwords;
}

int main()
{
	string mystring = readstring();
	cout << "the number of words in the string is \n";
	cout<< countWordsInString(mystring);


}