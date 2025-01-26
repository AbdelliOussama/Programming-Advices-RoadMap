#include <iostream>
#include <string>
using namespace std;
struct sttaskduration {
	int numofhours;
	int numofdays;
	int numofminute;
	int numofseconde;
};
int readpositivenumber(string message)
{
	int number;
	do {
		cout << message;
		cin >> number;
	} while (number < 0);
	return number;
}

sttaskduration readtaskduration()
{
	sttaskduration duration;
	duration.numofseconde = readpositivenumber("enter the number of seconde");
	duration.numofminute = readpositivenumber("enter the number of minute");
	duration.numofhours = readpositivenumber("enter the number of hours");
	duration.numofdays = readpositivenumber("enter the number of days");
	return duration;
}
int durationinseconde(sttaskduration duration)
{
	return duration.numofseconde + duration.numofminute * 60 + duration.numofhours * 3600 + duration.numofdays * 24 * 3600;
}




int main()
{
	sttaskduration duration = readtaskduration();
	cout <<"the time is seconde is=:" << durationinseconde(duration);

}

