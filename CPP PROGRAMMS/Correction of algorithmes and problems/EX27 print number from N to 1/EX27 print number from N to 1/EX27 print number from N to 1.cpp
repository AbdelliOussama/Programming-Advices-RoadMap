#include <iostream>
using namespace std;
int readnumber()
{
	int N;
	cout << "\nenter a number" << endl;
	cin >> N;
	return N;
}
void printnumberfromNto1_usingwhile(int N)
{
	int i = N+1;
	while (i > 1)
	{
		i--;
		cout << i << "\n";
	}
}
void printnumberfromNto1_usingdowhile(int N)
{
	int i = N;
	do
	{
		i--;
		cout << i << endl;

	} while (i >1);
}

void  printnumberfromNto1_usingfor(int N)
{
	for (int i = N; i >= 1; i--)
	{
		cout << i << endl;
	}
}
int main()
{
	int N = readnumber();
	printnumberfromNto1_usingfor(N);
	cout << endl;
	printnumberfromNto1_usingdowhile(N);
	cout << endl;
	printnumberfromNto1_usingwhile(N);

}

