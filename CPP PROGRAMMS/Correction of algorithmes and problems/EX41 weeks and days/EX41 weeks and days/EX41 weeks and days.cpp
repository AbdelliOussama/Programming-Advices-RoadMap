#include <iostream>
#include <string>
using namespace std;
int readpositivenumber(string message)
{
	int number;
	do {
		cout << message;
		cin >> number;
	} while (number < 0);
	return number;
}

float hourstodays(int hours)
{
	return hours / 24;
}
float daystoweeks(int days)
{
	return days / 7;
}

float hourstoweeks(int hours)
{
	return hours / 24 / 7;
}

int main()
{
	float hours = readpositivenumber("enter the number of hours");
	float days = hourstodays(hours);
	float weeks = daystoweeks(days);
	cout<<endl;
	cout << "tottal hours=: " << hours<<endl;
	cout << "total days =:" << days << endl;
	cout << "total weeks = :" << hourstoweeks(hours) << endl;

}

