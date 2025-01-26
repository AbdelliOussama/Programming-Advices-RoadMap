#include<iostream>
using namespace std;
struct sDate
{
	short Year;
	short Month;
	short Day;
};
short ReadMonth()
{
	short Month;
	cout << "\nPlease enter a Month? ";
	cin >> Month;
	return Month;
}
short ReadYear()
{
	short Year;
	cout << "\nPlease enter a year? ";
	cin >> Year;
	return Year;
}
short ReadDay()
{
	short Day;
	cout << "\nPlease enter a Day? ";
	cin >> Day;
	return Day;
}

sDate ReadDate()
{
	sDate Date;
	Date.Year = ReadYear();
	Date.Month = ReadMonth();
	Date.Day = ReadDay();
	return Date;
}
bool CompareDate(sDate Date1, sDate Date2)
{
	return  (Date1.Year < Date2.Year) ? true : ((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) : false);
}
int main()
{
	sDate Date1 = ReadDate();
	sDate Date2 = ReadDate();
	if (CompareDate(Date1, Date2))
		cout << "Yes, Date 1 is less Than Date 2 . \n";
	else
		cout << "No, Date 2 is  less Than Date 1 . \n";
	system("pause>0");
	return 0;
}

