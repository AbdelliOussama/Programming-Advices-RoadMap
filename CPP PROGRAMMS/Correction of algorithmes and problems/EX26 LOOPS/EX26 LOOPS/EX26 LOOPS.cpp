#include <iostream>
using namespace std;
int readnumber()
{
	int N;
	cout << "\nenter a number" << endl;
	cin >> N;
	return N;
}
void printnumberfrom1toN_usingwhile(int N)
{
	int i=0;
	while (i < N)
	{
		i++;
		cout << i << "\n";
	}
}
void printnumberfrom1toN_usingdowhile(int N)
{
	int i=0;
	do
	{
		i++;
		cout << i << endl;

	} while (i<N);
}

void  printnumberfrom1toN_usingfor(int N)
{
	for (int i = 0; i <= N; i++)
	{
		cout << i << endl;
	}
}
int main()
{
	int N = readnumber();
	printnumberfrom1toN_usingfor(N);
	cout << endl;
	printnumberfrom1toN_usingdowhile(N);
	cout << endl;
	printnumberfrom1toN_usingwhile(N);

}

