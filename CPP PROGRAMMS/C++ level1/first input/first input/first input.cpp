
#include <iostream>
#include<string.h>
#include<stdbool.h>
using namespace std; 
string name, city, country;
int monthly_salary, years_salary;
char gender;
bool married=0;
int age;

int main()
{
    cout << " donner votre nom\n";
    cin >> name;
    cout << "donner votre ville \n";
    cin >> city;
    cout << "donner votre country \n";
    cin >> country;
    cout << "donner votre gendre\n";
    cin >> gender;
    cout << "donner votre age \n";
    cin >> age;
    cout<<("donner votre salire mensuel");
    cin >> monthly_salary;

    cout << "\n\n********************************\n\n";
    cout << "name:\\" << name << "\n\n";
    cout << "age:\\" << age << "\n\n";
    cout << "city:\\" << city << "\n\n";
    cout << "county:\\" << country << "\n\n";
    cout << "monthly_salary:\\" << monthly_salary << "\n\n";
    cout << "years_salary:\\" << monthly_salary*12 << "\n\n";
    cout << "married:\\" << married << "\n\n";
    cout << "\n\n********************************\n\n";









    


}