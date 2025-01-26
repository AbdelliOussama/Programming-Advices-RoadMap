#include <iostream>
#include<string>
using namespace std;
int readnumber(string message)
{
	int N;
	do
	{
		cout << message << endl;
		cin >> N;
	} while (N < 0);
	return N;
}

int readpower(string message)
{
	int M;
	
		cout << message << endl;
		cin >> M;
	return M;
}

int powerofm(int N,int M)
{
	int p = 1;
	if (M == 0)
		return 1;
	for (int i = 1; i <= M; i++)
	{
		p *= N;
	}
	return p;
}

int main()
{
	cout << powerofm(readnumber("please enter a positif number \n"), readpower("please enter the power")) << endl;

}

