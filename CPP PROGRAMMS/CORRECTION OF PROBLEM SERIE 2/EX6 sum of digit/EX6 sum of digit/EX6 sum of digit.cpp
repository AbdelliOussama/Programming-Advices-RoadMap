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
void printsigitsumofdigit(int number)
{
    int remainder=0;
    int sum = 0;
    while (number > 0)
    {
        remainder = number % 10;
        number = number / 10;
        sum += remainder;
    }
    cout <<"sum of digit is=:"<< sum << endl;
}
int main()
{
    printsigitsumofdigit(readnumber("please enter a number:  "));
}

