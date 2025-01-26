#include<iostream>
using namespace std;
int grades[3];

void readdata(int grades[3]) {
	cout << "enter the first elemnt ";
	cin >> grades[1];
	cout << "enter the first elemnt ";
	cin >> grades[2];
	cout << "enter the first elemnt ";
	cin >> grades[3];
}
void printdata(int grades[3]) {
	cout << grades[1] << endl;
	cout << grades[2] << endl;
	cout << grades[3] << endl;

}
float avgarray(int grades[3]) {
	int avg = (grades[1] + grades[2] + grades[3]) / 3;
	return avg;
}

int main() {
	readdata(grades);
	printdata(grades);
	cout << "the average of the array is " << avgarray(grades);
}