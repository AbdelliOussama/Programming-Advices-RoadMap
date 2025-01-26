#include<iostream>
#include<string>
using namespace std;
long readnumber(string message)
{
	long number;
	cout << message;
	cin >> number;
	return number;
}
string numbertotext(long number)
{
	if (number == 0)
	{
		return "";
	}

	if (number >= 1 && number <= 19)
	{
		string arr[] =
		{
		"","One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Eleven","Twelve","Thirteen","Fourteen","fifteen","Sixteen","Seventeen","Eighteen","Nineteen" };
		return arr[number];
	}
	if (number >= 20 && number <= 99)
	{
		string arr[] = { "","","Twenty","thirty","Forty","Fifty","Sixty","Seventy","Eighty","Ninety" };
		return arr[number / 10] + " " + numbertotext(number % 10);
	}
	if (number >= 100 && number <= 199)
	{
		return  +" One Hundred " + numbertotext(number % 100);
	}
	if (number >= 200 && number <= 999)
	{
		return numbertotext(number / 100) + " Hundreds " + numbertotext(number % 100);
	}
	if (number >= 1000 && number <= 1999)
	{
		return  +" One Thousnd " + numbertotext(number % 1000);
	}
	if (number >= 2000 && number <= 999999)
	{
		return numbertotext(number / 1000) + " Thousnds " + numbertotext(number % 1000);
	}
	if (number >= 1000000 && number <= 1999999)
	{
		return   "One Million " + numbertotext(number % 1000000);
	}
	if (number >= 1000000 && number <= 1999999)
	{
		return numbertotext(number / 1000000) + " Millions " + numbertotext(number % 1000000);
	}
	if (number >= 1000000000 && number <= 1999999999)
	{
		return   "One Billion " + numbertotext(number % 1000000000);
	}
	else
	{
		return numbertotext(number / 1000000000) + " Billions " + numbertotext(number % 1000000000);
	}
}
int main()
{
	cout << numbertotext(readnumber("Enter a number ?\n"));
}