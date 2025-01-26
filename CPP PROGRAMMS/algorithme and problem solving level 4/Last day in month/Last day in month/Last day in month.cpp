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
	Date.Day = ReadDay();
	Date.Month = ReadMonth();
	Date.Year = ReadYear();
	return Date;
}
bool isLeapYear(short Year)
{
	// if year is divisible by 4 AND not divisible by 100// OR if year is divisible by 400// then it is a leap year
	return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
}
short NumberOfDaysInAMonth(short Month, short Year)
{
	if (Month < 1 || Month>12)
		return  0;
	int days[12] = { 31,28,31,30,31,30,31,31,30,31,30,31 };
	return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : days[Month - 1];
}
bool lastdaysinmonth(sDate Date)
{
	return Date.Day == NumberOfDaysInAMonth(Date.Month, Date.Year);
}
bool LastMonthinYear(short Month)
{
	return Month == 12;

}
int main()
{
	sDate Date1 = ReadDate();
	if (lastdaysinmonth(Date1))
		cout << "Yes,Day is Last day in Month.\n";
	else
		cout << "No,Day is Not Last day in Month.\n";
	if (LastMonthinYear(Date1.Month))
		cout << "Yes,Month is Last Month in Year.\n";
	else
		cout << "No,Month is Not Last Month in Year.\n";
	system("pause>0");
	return 0;
}

