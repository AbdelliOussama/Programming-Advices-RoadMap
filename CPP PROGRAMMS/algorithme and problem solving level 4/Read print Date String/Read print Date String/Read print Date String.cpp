#pragma warning(disable :4996)
#include<iostream>
#include<ctime>
#include<vector>
#include<string>
using namespace std;
struct stDate
{
	short Year;
	short Month;
	short Day;
};
string ReadDateString()
{
	string Datestring;
	cout << "Please Enter Date dd/mm/yyyy ?\n";
	cin>> Datestring;
	return Datestring;
}
vector<string> splitstring(string Datestring,string delim)
{
	vector<string>vdatestring;
	int pos = 0;
	string sword="";
	while ((pos = Datestring.find(delim)) != std::string::npos)
	{
		sword = Datestring.substr(0, pos);
		if (sword != "")
		{
			vdatestring.push_back(sword);
		}
		Datestring.erase(0, sword.length() + delim.length());
	}
	if (Datestring != "")
	{
		vdatestring.push_back(Datestring);
	}
	return vdatestring;
}
stDate stringtoDate(string Datestring)
{
	vector<string>vdatestring;
	vdatestring = splitstring(Datestring, "/");
	stDate Date;
	Date.Day = stoi(vdatestring[0]);
	Date.Month = stoi(vdatestring[1]);
	Date.Year = stoi(vdatestring[2]);
	return Date;
}
void printDateonScreen(stDate Date)
{
	cout << "Day : " << Date.Day<<endl;
	cout << "Month : " << Date.Month << endl;
	cout << "Year : " << Date.Year << endl;
}
string DateTostring(stDate Date)
{
	return to_string(Date.Day) + "/" + to_string(Date.Month) + "/" + to_string(Date.Year);
}
int main()
{
	string Datestring = ReadDateString();
	stDate Date = stringtoDate(Datestring);
	printDateonScreen(Date);
	cout << endl;

	cout << "You Entered : " << DateTostring(Date)<<endl;
	system("pause>0");
	return 0;
}