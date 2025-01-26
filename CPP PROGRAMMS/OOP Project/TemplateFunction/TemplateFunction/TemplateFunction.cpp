#include<iostream>
using namespace std;
template <typename T>T Max(T Number1, T Number2)
{
	return (Number1 > Number2) ? Number1 : Number2;
}
int main()
{
	cout << Max<int>(3, 4)<<endl;
	cout << Max<float>(7.5, 4) << endl;
}