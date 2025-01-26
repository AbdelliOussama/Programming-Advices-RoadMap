#include <iostream>
using namespace std;
int a, b, TEMP ;
int main()
{
    cout << "donner 2 entiers \n";
    cin >> a >> b ;
    cout<<"la valeur de a est:"<<a <<"\tla valeur de b est:"<<b <<endl ;
    TEMP = a;
    a = b;
    b = TEMP;
    cout << "la  nouvelle valeur de a est:" << a << "\tla  nouvelle valeur de b est:" << b << endl;

}
