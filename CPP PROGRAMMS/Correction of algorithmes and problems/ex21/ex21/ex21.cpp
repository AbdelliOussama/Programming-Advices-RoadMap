#include <iostream>
#include<math.h>
using namespace std;
const float pi = 3.14;
float readcircomference()
{
	float c;
	cout << "\nenter the circomference of the circle \n" << endl;
	cin >> c;
	return c;

}

float   calculatearea(float c, const float pi)
{
	float area = pow(c, 2)/(4*pi);
	return  area;

}
void printarea(float area)
{
	cout << "\n the area of the circle  is:\t" << area;

}
int main()
{

	printarea(calculatearea(readcircomference(), pi));

}

