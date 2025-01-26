#include <iostream>
#include<math.h>
using namespace std;
const float pi = 3.14;
void readtriangledata(float& a,float& b)
{
	cout << "\nenter the triangle side a: \n" << endl;
	cin >> a;
	cout << "\nenter the triangle base  b: \n" << endl;
	cin >> b;

}

float   calculatearea(float a,float b, const float pi)
{
	float area = pi *(pow(b,2)/4)*((2*a - b)/(2*a+b));
	return  area;

}
void printarea(float area)
{
	cout << "\n the area of the circle inside the isoccele triangle  is:\t" << area;

}
int main()
{
	float a, b;
	readtriangledata(a, b);
	printarea(calculatearea(a,b,pi));

}

