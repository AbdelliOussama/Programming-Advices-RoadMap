#include <iostream>
using namespace std;
enum enoddoreven { odd = 1, even = 2 };
int readnumber()
{
	int N;
	cout << "\nenter a number" << endl;
	cin >> N;
	return N;
}

enoddoreven checkodd(int N)
{
	if (N % 2 != 0)
		return enoddoreven::odd;
	else
		return enoddoreven::even;
}
int  printsumevennumber_usingwhile(int N)
{
	int i = 0;
	int sum = 0;
	cout << "sum of even number using  while" << endl;

	while (i < N)
	{
		i++;
		if (checkodd(i) == enoddoreven::even)
			sum += i;
	}
	return sum;
}
int printsumevennumber_usingdowhile(int N)
{
	int sum = 0;
	int i = 0;
	cout << "sum of odd number using do while" << endl;
	do
	{
		i++;

		if (checkodd(i) == enoddoreven::even)
			sum += i;
	} while (i < N);
	return sum;
}

int printsumevennumber_usingfor(int N)
{
	int sum = 0;
	cout << "sum of odd number using for loop " << endl;

	for (int i = 0; i <= N; i++)
	{
		if (checkodd(i) == enoddoreven::even)
			sum += i;
	}
	return sum;
}
int main()
{
	int N = readnumber();
	cout << printsumevennumber_usingfor(N) << endl;
	cout << printsumevennumber_usingdowhile(N) << endl;
	cout << printsumevennumber_usingwhile(N) << endl;

}

