#include <iostream>
using namespace std;
void readnumbers(float& longeur, float& largeur)
{
	cout << "\nenter the long of the rectangle \n" << endl;
	cin >> longeur;
	cout << "\nenter the larger of the rectangle" << endl;
	cin >> largeur;

}

float   calculatearea(float longeur, float largeur)
{
	return longeur * largeur;

}
void printarea(float area)
{
	cout << "\n the area of the rectangle  is:\t" << area;
	
}
int main()
{
	float longeur, largeur;
	readnumbers(longeur, largeur);
	printarea(calculatearea(longeur, largeur));
	
}

