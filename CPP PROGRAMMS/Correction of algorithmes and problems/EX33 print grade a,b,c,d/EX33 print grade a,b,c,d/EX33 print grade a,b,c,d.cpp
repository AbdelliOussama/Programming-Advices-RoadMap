#include <iostream>
#include<string>
using namespace std;
int readmark(int from ,int to)
{
	int mark;
	do
	{
		cout <<"enter your mark" << endl;
		cin >> mark;
	} while (mark <from || mark> to);
	return mark;
}

char getgradeletter(int mark)
{
	if (mark >= 90)
		return 'A';
	if (mark >= 80)
		return 'B';
	if (mark >= 70)
		return 'C';
	if (mark >= 60)
		return 'D';
	if (mark >= 50)
		return 'E';
	else
		return 'F';

}



int main()
{
	cout << "result =:"<< getgradeletter(readmark(0, 100)) << endl;

}

