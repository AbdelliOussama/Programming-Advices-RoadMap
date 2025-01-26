#include <iostream>
#include<math.h>
using namespace std;
const float pi = 3.14;
float readdiameter()
{
	float d;
	cout << "\nenter the radius of the circle \n" << endl;
	cin >> d;
	return d;

}

float   calculatearea(float d, const float pi)
{
	float area = (pow(d, 2) * pi)/4;
	return  area;

}
void printarea(float area)
{
	cout << "\n the area of the circle  is:\t" << area;

}
int main()
{

	printarea(calculatearea(readdiameter(), pi));

}

