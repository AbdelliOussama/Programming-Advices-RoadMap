#include <iostream>
#include<string>
using namespace std;
int readtotalsale()
{
	int totalsales;
	
		cout << "enter total sales" << endl;
		cin >> totalsales;
	
	return totalsales;
}
float getcommissionpourcentage(int totalsales)
{
	if (totalsales >= 1000000)
		return 0.01;
	else if (totalsales >= 500000 && totalsales<1000000)
		return 0.02;
	else if (totalsales >=100000 && totalsales<500000)
		return 0.03;
	else if (totalsales >= 50000 && totalsales <100000)
		return 0.05;
	
	else
		return 0;

}

float calculatetotalcommission(int totalsales)
{
	return getcommissionpourcentage(totalsales) * totalsales;
}


int main()
{
	int totalsales = readtotalsale();
	cout << "commission :\t" << getcommissionpourcentage(totalsales) << endl;
	cout << "totalcommission:\t" << calculatetotalcommission(totalsales) << endl;
}

