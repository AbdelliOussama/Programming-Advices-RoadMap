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
int  printsumoddnumber_usingwhile(int N)
{
	int i = 0;
	int sum = 0;
	cout << "sum of odd number using  while" << endl;

	while (i < N)
	{
		i++;
		if (checkodd(i) == enoddoreven::odd)
			sum += i;
	}
	return sum;
}
int printsumoddnumber_usingdowhile(int N)
{
	int sum = 0;
	int i =0;
	cout << "sum of odd number using do while" << endl;
	do
	{
		i++;
		
		if (checkodd(i) == enoddoreven::odd)
			sum += i;
	} while (i < N);
	return sum;
}

int printsumoddnumber_usingfor(int N)
{
	int sum=0;
	cout << "sum of odd number using for loop " << endl;

	for (int i = 0; i <= N; i++)
	{
		if (checkodd(i) == enoddoreven::odd)
			sum += i;
	}
	return sum;
}
int main()
{
	int N = readnumber();
	cout<<printsumoddnumber_usingfor(N) <<endl;
	cout<< printsumoddnumber_usingdowhile(N)<<endl;
	cout<<printsumoddnumber_usingwhile(N)<<endl;

}

