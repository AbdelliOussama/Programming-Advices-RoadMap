#pragma once
#include<iostream>
using namespace std;
namespace MyDateLib 
{
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

	stDate IncreaseDateByXDay(stDate Date, int xDays)
	{
		for (int i = 1; i <= xDays; i++)
		{
			Date = IncreaseDateByOneDay(Date);
		}
		return Date;
	}
	stDate IncreaseDateByOneWeek(stDate Date)
	{
		for (int i = 1; i <= 7; i++)
		{
			Date = IncreaseDateByOneDay(Date);
		}
		return Date;
	}
	stDate IncreaseDateByXWeek(stDate Date, int Xweek)
	{
		for (int i = 1; i <= Xweek; i++)
		{
			Date = IncreaseDateByOneWeek(Date);
		}
		return Date;
	}
	stDate IncreaseDateByOneMonth(stDate Date)
	{
		if (IsLastMonthInYear(Date.Month))
		{
			Date.Month = 1;
			Date.Year++;
		}
		else
		{
			Date.Month++;
		}
		short NumberOfDaysInCurrentMonth = NumberOfDaysInAMonth(Date.Month, Date.Year);
		if (Date.Day > NumberOfDaysInCurrentMonth)
		{
			Date.Day = NumberOfDaysInCurrentMonth;
		}
		return Date;
	}
	stDate IncreaseDateByXMonth(stDate Date, int Xmonth)
	{
		for (int i = 1; i <= Xmonth; i++)
		{
			if (IsLastMonthInYear(Date.Month))
			{
				Date.Month = 1;
				Date.Year++;
			}
			else
			{
				Date.Month++;
			}
		}
		return Date;
	}
	stDate IncreaseDateByOneYear(stDate Date)
	{
		Date.Year++;
		return Date;
	}
	stDate IncreaseDateByXYear(stDate Date, int Xyear)
	{
		for (int i = 1; i <= Xyear; i++)
		{
			Date = IncreaseDateByOneYear(Date);
		}
		return Date;
	}
	stDate IncreaseDateByXYearFaster(stDate Date, int Xyear)
	{
		Date.Year += Xyear;
		return Date;
	}
	stDate IncreaseDateByOneDecade(stDate Date)
	{
		Date.Year += 10;
		return Date;
	}
	stDate IncreaseDateByXDecade(stDate Date, int Xdecade)
	{
		for (int i = 1; i <= Xdecade; i++)
		{
			Date = IncreaseDateByOneDecade(Date);
		}
		return Date;
	}
	stDate IncreaseDateByXDecadeFaster(stDate Date, int Xdecade)
	{

		Date.Year += Xdecade * 10;
		return Date;
	}
	stDate IncreaseDateByOneCentury(stDate Date)
	{
		Date.Year += 100;
		return Date;
	}
	stDate IncreaseDateByOneMillineum(stDate Date)
	{
		Date.Year += 1000;
		return Date;
	}

	stDate DecreaseDateByOneDay(stDate Date)
	{
		if (Date.Day == 1)
		{
			if (Date.Month == 1)
			{
				Date.Month = 12;
				Date.Day = 31;
				Date.Year--;
			}
			else
			{
				Date.Day = NumberOfDaysInAMonth(Date.Month, Date.Year);
				Date.Month--;
			}
		}
		else
		{
			Date.Day--;
		}
		return Date;
	}

	stDate DecreaseDateByXDay(stDate Date, int xDays)
	{
		for (int i = 1; i <= xDays; i++)
		{
			Date = DecreaseDateByOneDay(Date);
		}
		return Date;
	}
	stDate DecreaseDateByOneWeek(stDate Date)
	{
		for (int i = 1; i <= 7; i++)
		{
			Date = DecreaseDateByOneDay(Date);
		}
		return Date;
	}
	stDate DecreaseDateByXWeek(stDate Date, int Xweek)
	{
		for (int i = 1; i <= Xweek; i++)
		{
			Date = DecreaseDateByOneWeek(Date);
		}
		return Date;
	}
	stDate DecreaseDateByOneMonth(stDate Date)
	{
		if (Date.Month == 1)
		{
			Date.Month = 12;
			Date.Year--;
		}
		else
		{
			Date.Month--;
		}
		short NumberOfDaysInCurrentMonth = NumberOfDaysInAMonth(Date.Month, Date.Year);
		if (Date.Day > NumberOfDaysInCurrentMonth)
		{
			Date.Day = NumberOfDaysInCurrentMonth;
		}
		return Date;
	}
	stDate DecreaseDateByXMonth(stDate Date, int Xmonth)
	{
		for (int i = 1; i <= Xmonth; i++)
		{
			Date = DecreaseDateByOneMonth(Date);
		}
		return Date;
	}
	stDate DecreaseDateByOneYear(stDate Date)
	{
		Date.Year--;
		return Date;
	}
	stDate DecreaseDateByXYear(stDate Date, int Xyear)
	{
		for (int i = 1; i <= Xyear; i++)
		{
			Date = DecreaseDateByOneYear(Date);
		}
		return Date;
	}
	stDate DecreaseDateByXYearFaster(stDate Date, int Xyear)
	{
		Date.Year -= Xyear;
		return Date;
	}
	stDate DecreaseDateByOneDecade(stDate Date)
	{
		Date.Year -= 10;
		return Date;
	}
	stDate DecreaseDateByXDecade(stDate Date, int Xdecade)
	{
		for (int i = 1; i <= Xdecade; i++)
		{
			Date = DecreaseDateByOneDecade(Date);
		}
		return Date;
	}
	stDate DecreaseDateByXDecadeFaster(stDate Date, int Xdecade)
	{

		Date.Year -= Xdecade * 10;
		return Date;
	}
	stDate DecreaseDateByOneCentury(stDate Date)
	{
		Date.Year -= 100;
		return Date;
	}
	stDate DecreaseDateByOneMillineum(stDate Date)
	{
		Date.Year -= 1000;
		return Date;
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
}

