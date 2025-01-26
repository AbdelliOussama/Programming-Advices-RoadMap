#pragma warning(disable :4996)
#include<iostream>
#include<ctime>
using namespace std;
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
bool isLeapYear(short Year)
{
	return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
}
bool IsDate1BeforeDate2(stDate Date1, stDate Date2)
{
	return  (Date1.Year < Date2.Year) ? true : ((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) : false);
}
short NumberOfDaysInAMonth(short Month, short Year)
{
	if (Month < 1 || Month>12)
		return  0;
	int days[12] = { 31,28,31,30,31,30,31,31,30,31,30,31 };
	return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : days[Month - 1];
}
bool IsLastDayInMonth(stDate Date)
{
	return (Date.Day == NumberOfDaysInAMonth(Date.Month, Date.Year));
}

bool IsLastMonthInYear(short Month)
{
	return (Month == 12);
}

stDate IncreaseDateByOneDay(stDate Date)
{
	if (IsLastDayInMonth(Date))
	{
		if (IsLastMonthInYear(Date.Month))
		{
			Date.Month = 1;
			Date.Day = 1;
			Date.Year++;
		}
		else
		{
			Date.Day = 1;
			Date.Month++;
		}
	}
	else
	{
		Date.Day++;
	}
	return Date;
}
int GetDifferenceInDays(stDate Date1, stDate Date2, bool IncludeEndDay = false)
{
	int Days = 0;
	while (IsDate1BeforeDate2(Date1, Date2))
	{
		Days++;
		Date1 = IncreaseDateByOneDay(Date1);
	}
	return IncludeEndDay ? ++Days : Days;
}
int PeriodLengthInDays(stPeriode Period, bool IncludeEndDate = false) 
{
	return GetDifferenceInDays(Period.StartDate, Period.EndDate, IncludeEndDate);
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
stPeriode ReadPeriode()
{
	stPeriode Periode;
	cout << "Enter Srart Date :\n";
	Periode.StartDate = ReadFullDate();

	cout << "Enter End Date :\n";

	Periode.EndDate = ReadFullDate();
	return Periode;
}
int main()
{
	cout << "\nEnter Period 1:"; 
	stPeriode Period1 = ReadPeriode();
	cout << "\nPeriod Length is: " << PeriodLengthInDays(Period1);   
	cout << "\nPeriod Length (Including End Date) is: " << PeriodLengthInDays(Period1, true);
	system("pause>0");
	return 0;
}