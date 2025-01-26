#include <iostream>
#include<string>
using namespace std;
void printtableheader()
{
	cout << "\n\n\t\t\t multiplication table from 1 to 10 \n\n";
	cout << "\t";
	for(int i=1;i<=10;i++)
	{
		cout << i << "\t";
		
	}
	cout << "\n___________________________________________________________________________________\n";
}
string colomnseparator(int i)
{
	if (i < 10)
		return"   |";
	else
		return "  |";

}
void printmultiplicationtable()
{
	printtableheader();
	for (int i = 1; i <= 10; i++)
	{
		cout << " " <<i<< colomnseparator(i)<<"\t";
		for (int j = 1; j <= 10; j++)
		{
			cout << i * j<<"\t";
		}
		cout << endl;
	}
}
int main()
{
	printmultiplicationtable();
}

