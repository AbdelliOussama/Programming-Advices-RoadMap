#include <iostream>
#include<string>
using namespace std;
int readnumber(string message)
{
    int number;
    cout << message;
    cin >> number;
    return number;
}
int reversednumber(int number)
{
    int number2=0;
    int remainder = 0;
    while (number > 0)
    {
        remainder = number % 10;
        number = number / 10;
        number2 = number2 * 10 + remainder;
    }
    return number2;
}

void printreversednumber(int number)
{
        int remainder = 0;
    while (number > 0)
    {
        remainder = number % 10;
        number = number / 10;
        cout << remainder << endl;
    }
   
}

int main()
{
    int number2 = reversednumber(readnumber("please enter a number"));

    printreversednumber(number2);
}

