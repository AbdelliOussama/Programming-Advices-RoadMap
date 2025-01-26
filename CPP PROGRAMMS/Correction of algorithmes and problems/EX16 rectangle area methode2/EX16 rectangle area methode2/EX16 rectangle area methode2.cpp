#include <iostream>
#include<math.h>
using namespace std;
void readnumbers(float& a, float& d)
{
	cout << "\nenter a \n" << endl;
	cin >>a;
	cout << "\nenter d" << endl;
	cin >> d;

}

float   calculatearea(float a, float d)
{
	float area = a * sqrt(pow(d, 2) - pow(a, 2));
	return  area;

}
void printarea(float area)
{
	cout << "\n the area of the rectangle  is:\t" << area;

}
int main()
{
	float a,d;
	readnumbers(a, d);
	printarea(calculatearea(a,d));

}

