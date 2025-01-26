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
vector<string> splitWordInString(string mystring,string delim)
{
	vector<string>vwords;
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
			vwords.push_back(sWord);
		}
		mystring.erase(0, pos + delim.length());
		/* erase() until positon and move to next word. */
	}
	if (mystring != "")
	{
	vwords.push_back(mystring)	; // it fill the vector with last word of the string.  
	}

	return vwords;
}

void printvector(vector<string> vwords)
{
	cout << "tokens " << vwords.size()<<endl;
	for (string& word : vwords)
	{
		cout << word << endl;
	}
}
int main()
{
	string mystring = readstring();
	printvector(splitWordInString(mystring, " "));

}