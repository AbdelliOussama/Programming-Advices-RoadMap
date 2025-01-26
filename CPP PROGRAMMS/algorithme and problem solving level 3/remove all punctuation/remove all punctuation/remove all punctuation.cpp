#include<iostream>
#include<string>
#include<vector>
#include<cctype>
using namespace std;
string removepunctuation(string S1)
{
	string S2="";
	for (int i = 0; i < S1.length(); i++)
	{
		if (!ispunct(S1[i]))
		{
			S2 = S2 + S1[i];
		}
	}return S2;
}
int main()
{
	string S1 = "Welcome: to ,Jordan , Jordan is a nice country;it's, amazing";
	cout << "original string\n";
	cout << S1 << endl;
	cout << "punctuation removed\n";
	cout << removepunctuation(S1);

}