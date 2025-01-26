#include<iostream>
using namespace std;
struct sDate
{
	short Year;
	short Month;
	short Day;
};

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
short Readnumberofdaystoadd()
{
	short NumberofDay;
	cout << "\nHow Many Days To Add?\ ";
	cin >> NumberofDay;
	return NumberofDay;
}
int NumberDaysFromtheBeginingOfYear(sDate Date)
{
	int totaldays = 0;

	for (int i = 1; i <= Date.Month - 1; i++)
	{
		totaldays += NumberOfDaysInAMonth(i, Date.Year);
	}
	totaldays += Date.Day;
	return totaldays;
}
sDate ReadDate()
{
	sDate Date;
	Date.Year = ReadYear();
	Date.Month = ReadMonth();
	Date.Day = ReadDay();
	return Date;
}
sDate DateAdddays(sDate Date,short NumberofDay)
{
	short DateOrderInYear = NumberDaysFromtheBeginingOfYear(Date);
	short RemainingDays = DateOrderInYear+ NumberofDay ;
	short MonthDays = 0;
	Date.Month = 1;
	while (true)
	{
		MonthDays = NumberOfDaysInAMonth(Date.Month, Date.Year);
		if (RemainingDays > MonthDays)
		{
			RemainingDays -= MonthDays;
			Date.Month++;
			if (Date.Month  > 12)
			{
				Date.Month = 1;
				Date.Year++;
			}

		}
		else
		{
			Date.Day = RemainingDays;
			break;
		}
	}
	return Date;
}
int main()
{
	sDate Date = ReadDate();
	short NumberofDays = Readnumberofdaystoadd();
	Date = DateAdddays(Date, NumberofDays);
	cout << "Date After Adding  [" << NumberofDays << "] is: ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year;
	system("pause>0");
	return 0;
}

