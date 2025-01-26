#include <iostream>
using namespace std;
short int pennies,dollars, nbpeny , nbnickel , nbdime , nbquarter , nbdollar ;
int main()
{
    cout << "donner le  nombre de pennies  \n";
    cin >> nbpeny;
    cout << "donner le  nombre de nickel  \n";
    cin >> nbnickel;
    cout << "donner le  nombre de dime  \n";
    cin >> nbdime;
    cout << "donner le  nombre de quarter  \n";
    cin >> nbquarter;
    cout << "donner le  nombre de dollars  \n";
    cin >> nbdollar;
    pennies = nbpeny + nbnickel * 5 + nbdime * 10 + nbquarter * 25 + nbdollar * 100;
    dollars = pennies / 100;
    cout << "le nombre de pennies est:\t" << pennies << endl;
    cout << "le nombre de dollar est:\t" << dollars << endl;

}