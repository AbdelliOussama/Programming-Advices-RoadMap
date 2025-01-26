#include<iostream>
#include<string>
using namespace std;
enum enprimenotprime { prime = 1, notprime = 2 };
int readnumber(string message)
{
	int number;
	cout << message << endl;
	cin >> number;
	return number;
}
int calculateremainder(int cashpaid, int totallbills)
{
	return cashpaid - totallbills;
}
int main()
{
	int cashpaid = readnumber("enter your paidcsh   ");
	int totallbills= readnumber("enter your  totallbills  ");
	cout << "\ntotalbills=: " << totallbills<<endl;
	cout << "\ncashpaid=: " << cashpaid << endl;
	cout << "\n*******************************" << endl;
	cout << "remainder=:  " << calculateremainder(cashpaid, totallbills);
}