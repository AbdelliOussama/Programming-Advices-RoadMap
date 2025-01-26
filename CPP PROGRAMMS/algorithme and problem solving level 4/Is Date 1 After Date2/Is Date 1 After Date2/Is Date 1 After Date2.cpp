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
bool IsDate1BeforeDate2(stDate Date1, stDate Date2)
{
	return  (Date1.Year < Date2.Year) ? true : ((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) : false);
}
bool Date1equalDate2(stDate Date1, stDate Date2)
{
	return  (Date1.Year == Date2.Year) ? ((Date1.Month == Date2.Month) ? ((Date1.Day == Date2.Day) ? true : false) : false) : false;
}
bool IsDate1AfterDate2(stDate Date1, stDate Date2)
{
	return  (!IsDate1BeforeDate2(Date1, Date2) && !Date1equalDate2(Date1, Date2));
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
int main()
{
	cout << "\nEnter Date 1: \n";
	stDate Date1 = ReadFullDate();


	cout << "\nEnter Date 2: \n";
	stDate Date2 = ReadFullDate();

	if(IsDate1AfterDate2(Date1, Date2))
		cout << "\nYes, Date1 is After Date2 \n";
	else
		cout << "\nNo, Date1 is Not After Date2 \n";
	system("pause>0");
	return 0;
}