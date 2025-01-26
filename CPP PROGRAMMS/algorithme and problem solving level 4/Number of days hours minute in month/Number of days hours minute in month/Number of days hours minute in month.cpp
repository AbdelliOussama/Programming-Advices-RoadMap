#include<iostream>
using namespace std;
enum enmonths{January=1,February=2,March=3,April=4,May=5,June=6,July=7,Augst=8,September=9,October=10,November=11,December=12};
short readyear()
{
	short year;
	cout << "Enter a year to check\n";
	cin >> year;
	return year;
}
enmonths readMonth()
{
	short Month;
	cout << "Enter a Month to check ?\n";
	cin >> Month;
	return (enmonths)Month;
}
bool isleapyear(short year)
{
	return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
}
int numberofdays(enmonths month , short year)
{
	switch (month)
	{
	case enmonths::January:
		return 31;
	case enmonths::February:
	{
		return isleapyear(year) ? 29 : 28;	
	}
	case enmonths::March:
		return 31;
	case enmonths::April:
		return 30;
	case enmonths::May:
		return 31;
	case enmonths::June:
		return 30;
	case enmonths::July:
		return 31;
	case enmonths::Augst:
		return 31;
	case enmonths::September:
		return 30;
	case enmonths::October:
		return 31;
	case enmonths::November:
		return 30;
	case enmonths::December:
		return 31;
	}
}
int numberofhours(enmonths month , short year)
{
	return numberofdays(month, year) * 24;
}
int numberofminutes(enmonths month,short year)
{
	return numberofhours(month,year) * 60;
}
int numberofsecond(enmonths month,short year)
{
	return numberofminutes(month,year) * 60;
}
int main()
{
	short year = readyear();
	enmonths month = readMonth();
	cout << "number of days in Month [" << month << "] is " << numberofdays(month,year) << endl;
	cout << "number of hours in Month [" << month << "] is " << numberofhours(month,year) << endl;
	cout << "number of minutes in Month [" << month << "] is " << numberofminutes(month,year) << endl;
	cout << "number of seconds in Month [" << month << "] is " << numberofsecond(month,year) << endl;


}