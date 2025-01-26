#include<iostream>
#include<stack>
using namespace std;
int main()
{
	stack<int>stkMystack1;
	stkMystack1.push(10);
	stkMystack1.push(20);
	stkMystack1.push(30);
	stkMystack1.push(40);
	stkMystack1.push(50);

	stack<int>stkMystack2;
	stkMystack2.push(40);
	stkMystack2.push(50);
	stkMystack2.push(60);
	stkMystack2.push(70);
	stkMystack2.push(80);

	stkMystack1.swap(stkMystack2);

	cout << "My stack 1 size is : " << stkMystack1.size() << endl;
	cout << "My Stack 1 : ";
	while (!stkMystack1.empty())
	{
		cout << stkMystack1.top() << " ";
		stkMystack1.pop();
	}


	cout << "\nMy stack 2 size is : " << stkMystack2.size() << endl;
	cout << "My Stack 2 : ";
	while (!stkMystack2.empty())
	{
		cout << stkMystack2.top() << " ";
		stkMystack2.pop();
	}
}