#include <iostream>
using namespace std;
const float pi = 3.14;
short int a, area;
int main()
{
    cout << "donner le cote du carre \n";
    cin >> a;
    area = (pi * a * a) / 4;
    cout << "the area of cercle inscribed in a square  is :" << area << "\a";

}