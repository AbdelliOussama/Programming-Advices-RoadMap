#include <iostream>
#include<math.h>
using namespace std;
void readnumbers(float& a, float& h)
{
	cout << "\nenter a \n" << endl;
	cin >> a;
	cout << "\nenter h" << endl;
	cin >> h;

}

float   calculatearea(float a, float h)
{
	float area =  (a*h)/2;
	return  area;

}
void printarea(float area)
{
	cout << "\n the area of the triangle  is:\t" << area;

}
int main()
{
	float a, h;
	readnumbers(a, h);
	printarea(calculatearea(a, h));

}

