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
int Printdayorder(int Year, int  Month, int  Day)
{
	int a = (14 - Month) / 12;
	int y = Year - a;
	int m = Month + 12 * a - 2;
	int d = (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
	return d;

}
int Printdayorder(stDate Date)
{
	int a = (14 - Date.Month) / 12;
	int y = Date.Year - a;
	int m = Date.Month + 12 * a - 2;
	int d = (Date.Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
	return d;

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
string printdayname(int day)
{
	string arrdayname[] = { "Sun","Mon","tue","Wed","Thu","Fri","Sat" };
	return arrdayname[day];
}

bool IsWeekEnd(stDate Date)
{
	int Index = Printdayorder(Date);
	return(Index == 6 || Index == 0) ? true : false;
}
bool IsBusinessDay(stDate Date)
{
	return(!IsWeekEnd(Date)) ? true : false;
}

int CalculateVacationDays(stDate DateFrom, stDate DateTo)
{
	short DaysCount = 0;
		while (IsDate1BeforeDate2(DateFrom, DateTo))
		{
			if (IsBusinessDay(DateFrom))         
				DaysCount++;
			DateFrom = IncreaseDateByOneDay(DateFrom);
		}
		return DaysCount;
}


int main()
{
	cout << "Vacation Start : \n";
	stDate DateFrom = ReadFullDate();
	cout << "Vacation Ends : \n";
	stDate DateTo = ReadFullDate();
	int VacationStart = Printdayorder(DateFrom);
	int VacationEnd = Printdayorder(DateTo);
	cout << "Vacation From  :" << printdayname(VacationStart) << "," << DateFrom.Day << "/" << DateFrom.Month << "/" << DateFrom.Year << endl;
	cout << "Vacation To  :" << printdayname(VacationEnd) << "," << DateTo.Day << "/" << DateTo.Month << "/" << DateTo.Year << endl;
	cout << "Actual Vacations Days is :"<< CalculateVacationDays(DateFrom, DateTo);
	system("pause>0");
	return 0;
}