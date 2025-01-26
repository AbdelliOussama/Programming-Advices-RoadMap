#include<iostream>
#include<string>
#include<vector>
using namespace std;
vector<string>splitstring(string mystring, string delim)
{
	vector<string>vwords;
	int pos = 0;
	string word = "";
	while (pos = mystring.find(delim) != std::string::npos)
		word = mystring.substr(0, pos);
	if (word != "")
	{
		vwords.push_back(word);
	}
	mystring.erase(0, pos + delim.length());
	if (mystring != "")
	{
		vwords.push_back(mystring);
	}
	return vwords;
}

string lowerallstring(string mystring)
{
	for (int i = 0; i < mystring.length(); i++)
	{
		mystring[i] = tolower(mystring[i]);
	}
	return mystring;
}
string joinstring(vector<string>vwords,string delim)
{
	string mystring = "";
	for (string& word : vwords)
	{
		mystring = mystring + word + delim;
	}
	mystring= mystring.substr(0, mystring.length() - delim.length());
	return mystring;
}
string replacewordinstringcustomfunction(string mystring, string toreplace, string replaceto,bool matchcase=true)
{
	vector<string>vwords;
	vwords = splitstring(mystring, " ");
	for (string& word : vwords)
	{
		if (matchcase)
		{
			if (word == toreplace)
				word = replaceto;
		}
		
		else
			if (lowerallstring(word) == lowerallstring(toreplace))
			{
				word = replaceto;
			}
	}
	return joinstring(vwords,"#");
}
int main()
{
	string S1 = "Welcome to Jordan , Jordan is a nice country";
	string StringToReplace = "jordan";
	string ReplaceTo = "USA";
	cout << "original string:\n";
	cout << S1 <<endl;
	cout << "replace with match case:\n";
	cout << replacewordinstringcustomfunction(S1, StringToReplace, ReplaceTo, true)<<endl;
	cout << "replace without match case:\n";
	cout << replacewordinstringcustomfunction(S1, StringToReplace, ReplaceTo, false) << endl;


}