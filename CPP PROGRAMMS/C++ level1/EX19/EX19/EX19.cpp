#include <iostream>
using namespace std;
const float pi = 3.14;
short int D, area;
int main()
{
    cout << "donner le diametre de la cercle  \n";
    cin >> D ;
    area = (pi * D*D) / 4;
    cout << "the area of cercle is :" << area<<"\a";

}