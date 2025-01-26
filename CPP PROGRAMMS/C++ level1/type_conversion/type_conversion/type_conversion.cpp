#include <iostream>
#include<string>
using namespace std;
string st2,st1 = "43.22";
float A,N3=55.23;
double B,N2=33.5;
int C,N1=20;
int main()
{
    A = stof(st1);//convert string to float
    cout<<A << "\n";
    B = stod(st1);//convert string to double
    cout << B<< "\n";
    C= stoi(st1);
    cout << C << "\n";
    st2 = to_string(N1);//convert to string
    cout << st2 << "\n";




}

