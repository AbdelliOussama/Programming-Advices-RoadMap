#include<iostream>
#include<string>
#include<cctype>
#include<vector>
using namespace std;
string joinstring(vector<string>vwords,string delim)
{
	string mystring="";
	for (string& word : vwords)
	{
		mystring =mystring+ word + delim;
	}
	return mystring.substr(0, mystring.length() - delim.length());
}

int main()
{
	vector<string>vwords = { "oussama","salim","asma","sarra","saif" };
	cout << "mystring after join is  : ";
	cout<<joinstring(vwords, "#");

}