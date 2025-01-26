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
void printperfectnumbers(int number)
{
	if (checkperfect(number) == 1)
		cout << number << "is a perfect number";
	else 
		cout << number << "is not a perfect number";
}
int main()
{
	printperfectnumbers(readnumber("please enter a number"));
}