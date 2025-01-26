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
	int a = (14 -Date.Month) / 12;
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

string printdayname(int day)
{
	string arrdayname[] = { "Sun","Mon","tue","Wed","Thu","Fri","Sat" };
	return arrdayname[day];
}

stDate GetSystemDate()
{
	stDate Date;
	time_t t = time(0);
	tm* now = localtime(&t);
	Date.Day =now->tm_mday ;
	Date.Month =now->tm_mon+1 ;
	Date.Year =now->tm_year+1900 ;
	return Date;
}
bool IsendOfWeek(stDate Date)
{
	return(Printdayorder(Date) == 6) ? true : false;
}
bool IsWeekEnd(stDate Date)
{
	int Index = Printdayorder(Date);
	return(Index == 6|| Index == 0) ? true : false;
}
bool IsBusinessDay(stDate Date)
{
	return(!IsWeekEnd(Date)) ? true : false;
}
int DaysuntillEndOfWeek(stDate Date)
{
	return 6 - Printdayorder(Date);
}
int DaysuntillEndOfMonth(stDate Date)
{
	stDate EndOfMontDate;  
	EndOfMontDate.Day = NumberOfDaysInAMonth(Date.Month, Date.Year);  
	EndOfMontDate.Month = Date.Month; 
	EndOfMontDate.Year = Date.Year; 
	return GetDifferenceInDays(Date, EndOfMontDate, true);
}
int DaysuntillEndOfYear(stDate Date)
{
	stDate EndOfYearDate; 
	EndOfYearDate.Day = 31;   
	EndOfYearDate.Month = 12;
	EndOfYearDate.Year = Date.Year;
	return GetDifferenceInDays(Date, EndOfYearDate, true);
}

int main()
{
	stDate Date1 = GetSystemDate();
	int dayorder = Printdayorder(Date1);
	cout << "Today is :" << printdayname(dayorder) << "," << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;
	cout << "Is it End Of Week ?\n";
	if (IsendOfWeek(Date1))
		cout << "Yes It is End Of Week\n";
	else
		cout << "No It's Not End Of Week\n";
	cout << "Is it   WeekEnd ?\n";
	if (IsWeekEnd(Date1))
		cout << "Yes It is   WeekEnd\n";
	else
		cout << "No It's Not  WeekEnd\n";
	cout << "Is it   BusinessDay ?\n";
	if (IsBusinessDay(Date1))
		cout << "Yes It is   Business Day\n";
	else
		cout << "No It's Not  Business Day\n";
	cout << "Days Untill End Of Week : " << DaysuntillEndOfWeek(Date1) << " Day(s)"<<endl;
	cout << "Days Untill End Month : " << DaysuntillEndOfMonth(Date1) << " Day(s)" << endl;
	cout << "Days Untill End Year : " << DaysuntillEndOfYear(Date1) << " Day(s)" << endl;

	system("pause>0");
	return 0;
}