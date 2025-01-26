#include<iostream>
using namespace std;
void my_swapfunction(int &a, int &b) {
	int temp  ;
	temp = a;
	a = b;
	b = temp;
	cout << "after swap number 1 is and number 2 is :" << a << "\t" << b << "\n";
}
int main()
{
	int a;
	int b;
	cout << "please enter two number";
	cin >> a;
	cin>>b;
	my_swapfunction(a,b);
	cout << "after swap inside main number 1 is and number 2 is :"<<a << "\t" <<b<<endl;
}