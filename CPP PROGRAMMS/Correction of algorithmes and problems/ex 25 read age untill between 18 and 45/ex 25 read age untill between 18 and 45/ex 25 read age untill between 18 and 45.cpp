#include <iostream>
#include<string>
using namespace std;
int readage()
{
    int age;
    cout << "\nenter your age" << endl;
    cin >> age;
    return age;
}
bool validatenumberinrange(int age, int from, int to)
{
    if (age >= from && age <= to)
        return true;
    else
        return false;

}
int readnumberuntillinrange(int from, int to)
{
    int age = 0;
    do
    {
        readage();
    } while (validatenumberinrange(age,from,to) == false);
    return age;
}
void printresult(int age)
{
    cout << "\nyour age is\t" << age;
}
int main()
{
    printresult(readnumberuntillinrange(18, 45));
}

