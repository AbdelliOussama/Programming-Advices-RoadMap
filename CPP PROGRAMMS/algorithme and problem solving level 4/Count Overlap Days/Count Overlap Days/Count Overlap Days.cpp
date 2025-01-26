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
bool isLeapYear(short Year)
{
	return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
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
bool IsDate1BeforeDate2(stDate Date1, stDate Date2)
{
	return  (Date1.Year < Date2.Year) ? true : ((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) : false);
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
stPeriode ReadPeriode()
{
	stPeriode Periode;
	cout << "Enter Srart Date :\n";
	Periode.StartDate = ReadFullDate();

	cout << "Enter End Date :\n";

	Periode.EndDate = ReadFullDate();
	return Periode;
}
bool IsDateInPeriod(stPeriode Period, stDate Date)
{
	return !(compareDates(Date, Period.StartDate) == encompareDate::Before || compareDates(Date, Period.EndDate) == encompareDate::After);
}
bool IsOverlapPeriode(stPeriode Periode1, stPeriode Periode2)
{
	if (compareDates(Periode2.EndDate, Periode1.StartDate) == encompareDate::Before || compareDates(Periode2.StartDate, Periode1.EndDate) == encompareDate::After)
		return false;
	else
		return true;
}
int PeriodLengthInDays(stPeriode Period, bool IncludeEndDate = false)
{
	return GetDifferenceInDays(Period.StartDate, Period.EndDate, IncludeEndDate);
}
int CountoverlapDays(stPeriode Period1, stPeriode Period2)
{
	 int Period1Length = PeriodLengthInDays(Period1, true);
	 int Period2Length = PeriodLengthInDays(Period2, true);
	 int OverlapDays = 0; if (!IsOverlapPeriode(Period1, Period2)) 
		 return 0;
	 if (Period1Length < Period2Length)
	 {
		 while (IsDate1BeforeDate2(Period1.StartDate, Period1.EndDate))
		 { 
			 if (IsDateInPeriod( Period2, Period1.StartDate))
				 OverlapDays++;
			 Period1.StartDate = IncreaseDateByOneDay(Period1.StartDate);
		 } 
	 }
	 else
	 {
		 while (IsDate1BeforeDate2(Period2.StartDate, Period2.EndDate))
		 { 
			 if (IsDateInPeriod( Period1, Period2.StartDate))
				 OverlapDays++; 
			 Period2.StartDate = IncreaseDateByOneDay(Period2.StartDate);
		 }
	 }
	 return OverlapDays;
}
int main()
{
	cout << "\nEnter Period 1:";
	stPeriode Period1 = ReadPeriode();

	cout << "\nEnter Period 2:";
	stPeriode Period2 = ReadPeriode();
	
	cout << "Over Lap Days Count Is :" << CountoverlapDays(Period1, Period2);
	system("pause>0");
	return 0;
}