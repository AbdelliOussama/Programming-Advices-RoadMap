#include<iostream>
using namespace std;
short readyear()
{
	short year;
	cout << "Enter a year to check\n";
	cin >> year;
	return year;
}
bool isleapyear(short year)
{
	return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
}
int numberofdays(short year)
{
	return isleapyear(year) ? 366 : 365;
}
int numberofhours(short year)
{
	return numberofdays( year) * 24;
}
int numberofminutes(short year)
{
	return numberofhours(year) * 60;
}
int numberofsecond(short year)
{
	return numberofminutes(year) * 60;
}
int main()
{
	short year = readyear();
	cout << "number of days in year [" << year << "] is " << numberofdays(year) << endl;
	cout << "number of hours in year [" << year << "] is " << numberofhours(year) << endl;
	cout << "number of minutes in year [" << year << "] is " << numberofminutes(year) << endl;
	cout << "number of seconds in year [" << year << "] is " << numberofsecond(year) << endl;


}