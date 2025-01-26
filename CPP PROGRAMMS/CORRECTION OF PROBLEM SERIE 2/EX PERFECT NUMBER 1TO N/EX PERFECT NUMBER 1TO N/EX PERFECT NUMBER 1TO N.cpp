#include<iostream>
#include<string>
using namespace std;
int readnumber(string message)
{
	int number;
	cout << message;
	cin >> number;
	return number;
}

bool checkperfect(int number)
{

	int sum = 0;
	for (int i = 1; i < number; i++)
	{
		if (number % i == 0)
			sum += i;
	} return sum == number;
}
void printperfectnumbersfrom1toN(int number)
{
	for (int i = 1; i < number; i++)
	{

		if (checkperfect(i))
			cout << i<<endl;
	}
}
int main()
{
	printperfectnumbersfrom1toN(readnumber("please enter a number"));
}