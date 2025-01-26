#include <iostream>
#include<math.h>
using namespace std;
const float pi = 3.14;
float readradius()
{
	float r;
	cout << "\nenter the radius of the circle \n" << endl;
	cin >> r;
	return r;

}

float   calculatearea(float r, const float pi)
{
	float area =pow(r,2)*pi ;
	return  area;

}
void printarea(float area)
{
	cout << "\n the area of the circle  is:\t" << area;

}
int main()
{
	
	printarea(calculatearea(readradius(),pi));

}

