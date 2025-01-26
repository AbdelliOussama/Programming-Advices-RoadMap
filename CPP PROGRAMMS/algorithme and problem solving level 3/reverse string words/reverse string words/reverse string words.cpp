#include<iostream>
#include<string>
#include<vector>
using namespace std;
string readstring()
{
	string mystring;
	cout << "please enter your string\n";
	getline(cin, mystring);
	return mystring;
}
vector<string> splitstring( string mystring,string delim)
{
	vector<string>vwords;
	int pos = 0;
	int i = 0;
	string sword ;
	while (pos = mystring.find(delim) != std::string::npos)
	{
		sword = mystring.substr(0, pos);
		if (sword != "")
		{
			vwords.push_back(sword);
		}
		mystring.erase(0, pos + delim.length());
		if (mystring != "")
		{
			vwords.push_back(mystring);
		}
	}return vwords;
}
string reversewordinstring(string mystring)
{
	vector<string>reversedstringvector;
	string reversedstring ="";
	reversedstringvector = splitstring(mystring," ");
	//declare iterator
	vector<string>::iterator iter = reversedstringvector.end();
	while (iter != reversedstringvector.begin())
	{
	--iter;
	reversedstring += *iter + " ";
	}
	reversedstring = reversedstring.substr(0, reversedstring.length() - 1);//remove last space
	return reversedstring;

}

int main()
{
	string  mystring = readstring();
	vector<string>vwords;
	cout << "string after reversion is: \n";
	cout << reversewordinstring(mystring);


}