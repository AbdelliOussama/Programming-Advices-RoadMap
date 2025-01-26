#include<iostream>
using namespace std;
short int a, b,c,d,e,f;
int main() {
	cout << "donner deux entier a et b \n";
	cin >> a>> b;
	c = a == b;
	d = a != b;
	e= a >= b;
	f= a <= b;
	cout << "a==b is :" << c<<endl;
	cout << "a!=b is :" << d << endl;
	cout << "a>=b is :" << e << endl;
	cout << "a<=b is :" << f << endl;


}