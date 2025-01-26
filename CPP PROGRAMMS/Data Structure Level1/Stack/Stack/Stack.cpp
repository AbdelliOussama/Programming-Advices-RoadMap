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

	cout<<"My stack size is : "<< stkMystack1.size()<<endl;
	cout << "My Stack 1 : ";
	while (!stkMystack1.empty())
	{
		cout << stkMystack1.top() << " ";
		stkMystack1.pop();
	}
}