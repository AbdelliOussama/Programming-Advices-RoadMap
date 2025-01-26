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
bool Date1equalDate2(sDate Date1, sDate Date2)
{
	return  (Date1.Year == Date2.Year) ? ((Date1.Month == Date2.Month) ? ((Date1.Day == Date2.Day) ? true : false) : false) : false;
}
int main()
{
	sDate Date1 = ReadDate();
	sDate Date2 = ReadDate();
	if (Date1equalDate2(Date1, Date2))
		cout << "Yes, Date 1 is Eaual Date 2 . \n";
	else
		cout << "No, Date 1 is Not Eaual Than Date 1 . \n";
	system("pause>0");
	return 0;
}

