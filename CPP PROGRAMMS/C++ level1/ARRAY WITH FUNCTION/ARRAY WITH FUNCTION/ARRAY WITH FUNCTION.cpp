#include<iostream>
using namespace std;
void readdata(int x[3]) {
	cout << "enter the first elemnt ";
	cin >> x[1];
	cout << "enter the first elemnt ";
	cin >> x[2];
	cout << "enter the first elemnt ";
	cin >> x[3];
}
void printdata(int x[3]) {
	cout << x[1]<<endl;
	cout << x[2]<<endl;
	cout << x[3]<<endl;
}

int main() {
	int x[3];
	readdata(x);
	printdata(x);

}