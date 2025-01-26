#include <iostream>
#include<math.h>
using namespace std;
const float pi = 3.14;
float readsquarecote()
{
	float A;
	cout << "\nenter the radius of the circle \n" << endl;
	cin >> A;
	return A;

}

float   calculatearea(float A, const float pi)
{
	float area = (pow(A,2) * pi)/4 ;
	return  area;

}
void printarea(float area)
{
	cout << "\n the area of the circle in the square  is:\t" << area;

}
int main()
{

	printarea(calculatearea(readsquarecote(), pi));

}

