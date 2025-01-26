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
	cin >> Datestring;
	return Datestring;
}
vector<string> splitstring(string Datestring, string delim)
{
	vector<string>vdatestring;
	int pos = 0;
	string sword = "";
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

string DateTostring(stDate Date)
{
	return to_string(Date.Day) + "/" + to_string(Date.Month) + "/" + to_string(Date.Year);
	
}
string ReplaceWordInString(string S1, string StringToReplace, string RepalceTo)
{
	short pos = S1.find(StringToReplace); 
	while (pos != std::string::npos) 
	{
		S1 = S1.replace(pos, StringToReplace.length(), RepalceTo);   
		pos = S1.find(StringToReplace);//find next  
	} 
	return S1;
} 
string FormateDate(stDate Date, string DateFormat = "dd/mm/yyyy") 
{
	string FormattedDateString = "";  
	FormattedDateString = ReplaceWordInString(DateFormat, "dd", to_string(Date.Day)); 
	FormattedDateString = ReplaceWordInString(FormattedDateString, "mm", to_string(Date.Month));
	FormattedDateString = ReplaceWordInString(FormattedDateString, "yyyy", to_string(Date.Year)); 
	return  FormattedDateString;
}
int main()
{
	string Datestring = ReadDateString();
	stDate Date = stringtoDate(Datestring);
	cout << "\n" << FormateDate(Date) << "\n";  
	cout << "\n" << FormateDate(Date, "yyyy/dd/mm") << "\n";
	cout << "\n" << FormateDate(Date, "mm/dd/yyyy") << "\n";
	cout << "\n" << FormateDate(Date, "mm-dd-yyyy") << "\n"; 
	cout << "\n" << FormateDate(Date, "dd-mm-yyyy") << "\n"; 
	cout << "\n" << FormateDate(Date, "Day:dd, Month:mm, Year:yyyy") << "\n";
	system("pause>0");
	return 0;
}