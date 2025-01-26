#include<queue>
#include<iostream>
using namespace std;
int main()
{
	queue<int>MyQueue;
	MyQueue.push(10);
	MyQueue.push(20);
	MyQueue.push(30);
	MyQueue.push(40);
	MyQueue.push(50);
	MyQueue.push(60);

	cout << "Count : " << MyQueue.size()<<endl;
	cout << "Front : " << MyQueue.front() << endl;
	cout << "Back : " << MyQueue.back() << endl;

	while (!MyQueue.empty())
	{
		cout << MyQueue.front()<<" ";
		MyQueue.pop();
	}
}