#include<iostream>
#include<string>
using namespace std;
int readnumber(string message)
{
	int number;
	cout << message << endl;
	cin >> number;
	return number;
}
float sumnofumbers()
{
	float sum = 0;
	int N = 0;
	int i=1;
	do
	{
		N = readnumber("enter a number "+ to_string(i));
		if (N == -99)
		{
			break;
		}
		sum += N;
		i++;
	} while (N != -99);
	
	return sum;

}

int main()
{
	cout << "sum of number= :" << sumnofumbers();
}