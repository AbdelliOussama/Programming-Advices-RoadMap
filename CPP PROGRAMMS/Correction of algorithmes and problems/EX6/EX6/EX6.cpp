#include <iostream>
#include<string>
using namespace std;
struct stinfo
{
	string firstname;
	string lastname;
};
stinfo readinfo()
{
	stinfo info;
	cout << "enter your first name\n";
	cin >> info.firstname;
	cout << "enter your last name\n";
	cin >> info.lastname;
	return info;
}
string getfullname(stinfo info,bool reversed)
{
	string fullname;
	if (reversed==true )
	 fullname = info.lastname + " " + info.firstname;
	else
	 fullname = info.firstname + " " + info.lastname;
	return fullname;
}
void printfullname(string fullname)
{
	cout << "your full name is\t" << fullname << endl;
}
int main()
{
	printfullname(getfullname(readinfo(),true));
}
