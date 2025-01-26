#pragma warning(disable :4996)
#include<iostream>
#include<ctime>
using namespace std;
enum encompareDate { Before = -1, Equal = 0, After = 1 };
struct stDate
{
	short Year;
	short Month;
	short Day;
};
struct stPeriode
{
	stDate StartDate;
	stDate EndDate;
};
bool IsDate1BeforeDate2(stDate Date1, stDate Date2)
{
	return  (Date1.Year < Date2.Year) ? true : ((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) : false);
}
bool Date1equalDate2(stDate Date1, stDate Date2)
{
	return  (Date1.Year == Date2.Year) ? ((Date1.Month == Date2.Month) ? ((Date1.Day == Date2.Day) ? true : false) : false) : false;
}
bool IsDate1AfterDate2(stDate Date1, stDate Date2)
{
	return  (!IsDate1BeforeDate2(Date1, Date2) && !Date1equalDate2(Date1, Date2));
}
int compareDates(stDate Date1, stDate Date2)
{
	if (IsDate1BeforeDate2(Date1, Date2))
		return encompareDate::Before;
	if (Date1equalDate2(Date1, Date2))
		return encompareDate::Equal;

	return encompareDate::After;
}
short ReadDay()
{
	short Day;
	cout << "\nPlease enter a Day? ";
	cin >> Day;
	return Day;
}
short ReadMonth()
{
	short Month;
	cout << "Please enter a Month? ";
	cin >> Month;
	return Month;
}
short ReadYear()
{
	short Year;
	cout << "Please enter a Year? ";
	cin >> Year;
	return Year;
}
stDate ReadFullDate()
{
	stDate Date;
	Date.Day = ReadDay();
	Date.Month = ReadMonth();
	Date.Year = ReadYear();
	return Date;
}
bool IsOverlapPeriode(stPeriode Periode1, stPeriode Periode2)
{
	if (compareDates(Periode2.EndDate, Periode1.StartDate) == encompareDate::Before || compareDates(Periode2.StartDate, Periode1.EndDate) == encompareDate::After)
		return false;
	else
		return true;
}
stPeriode ReadPeriode()
{
	stPeriode Periode;
	cout << "Enter Srart Date :\n";
	Periode.StartDate= ReadFullDate();

	cout << "Enter End Date :\n";

	Periode.EndDate = ReadFullDate();
	return Periode;
}
int main()
{
	stPeriode Periode1, Periode2;
	cout << "Enter Periode 1:\n";
	Periode1 = ReadPeriode();
	cout << "Enter Periode 2:\n";
	Periode2 = ReadPeriode();
	if (IsOverlapPeriode(Periode1, Periode2))
		cout << "Yes ,Periode Overload\n";
	else
		cout << "No ,Periode Does'nt Overload\n";
	system("pause>0");
	return 0;
}