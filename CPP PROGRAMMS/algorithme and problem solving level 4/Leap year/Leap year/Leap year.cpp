#include<iostream>
using namespace std;
short readyear()
{
	short year;
	cout << "Enter a year to check\n";
	cin>> year;
	return year;
}
bool isleapyear(short year)
{
	if (year % 400 == 0)
	{
		return true;
	}
	else if (year % 100 == 0)
	{
		return false;
	}
	else if (year % 4 == 0)
	{
		return true;
	}
	else 
	{
		return false;
	}
}
int main()
{
	short year = readyear();
	if (isleapyear(year))
		cout << "\nYes,year[ " << year << "] is a leap year .\n";
	else
		cout << "\nNo,year[ " << year << "] is Not a leap year.\n";


}