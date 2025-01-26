#include <iostream>
using namespace std;
int a, b, c, s, m;
int main()
{
    cout << "donner 3 notes\n";
    cin >> a >> b >> c;
    s = a + b + c;
    cout << "la somme de ses trois entiers est :" << s<<endl;
    m = s / 3;
    cout << "la moyenne de ses trois notes est :" << m;

}
