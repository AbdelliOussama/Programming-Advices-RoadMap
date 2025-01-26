#include<iostream>
#include<string>
#include<cctype>
#include<vector>
using namespace std;
string joinstring(vector<string>vwords, string delim)
{
	string mystring = "";
	for (string& word : vwords)
	{
		mystring = mystring + word + delim;
	}
	return mystring.substr(0, mystring.length() - delim.length());
}

string joinstring(string arr, int arrlength, string delim)
{
	string mystring = "";
	for (int i = 0; i < arrlength; i++)
	{
		mystring = mystring + arr[i] + delim;
	}
	return mystring.substr(0, mystring.length() - delim.length());
}
int main()
{
	vector<string>vwords = { "oussama","salim","asma","sarra","saif" };
	string arr[5]= { "oussama","salim","asma","sarra","saif" };
	cout << "vector after  join is  : ";
	cout << joinstring(vwords, "#");
	cout << "array after join is :";
	cout << joinstring(arr, 5, " ");
	return 0;

}