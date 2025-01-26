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
void printsigitinreversedorder(int number)
{
    int remainder;
    while (number > 0)
    {
        remainder = number % 10;
        number = number / 10;
        cout << remainder<<"\t";
    }
}
int main()
{
    printsigitinreversedorder(readnumber("please enter a number:  "));
}

