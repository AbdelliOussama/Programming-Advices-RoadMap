#include<iostream>
using namespace std;


short ReadMonth()
{
	short Month;
	cout << "\nPlease enter a Month ? ";
	cin >> Month;
	return Month;
}
short ReadYear()
{
	short Year;
	cout << "\nPlease enter a year ? ";
	cin >> Year;
	return Year;
}
short ReadDay()
{
	short Day;
	cout << "\nPlease enter a Day ? ";
	cin >> Day;
	return Day;
}
int Printdayorder(int Year, int  Month, int  Day)
{
	int a = (14 - Month) / 12;
	int y = Year - a;
	int m = Month + 12 * a - 2;
	int d = (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
	return d;

}
string printdayname(int day)
{
	string arrdayname[] = { "Sun","Mon","tue","Wed","Thu","Fri","Sat" };
	return arrdayname[day];
}

int main()
{
	short Year = ReadYear();
	short Month = ReadMonth();
	short Day = ReadDay();
	int dayorder = Printdayorder(Year, Month, Day);
	cout << "Date   :" << Day << "/" << Month << "/" << Year << endl;
	cout << "Day order :" << dayorder << endl;
	cout << "Day Name : " << printdayname(dayorder) << endl;
	system("pause>0");
	return 0;
}
