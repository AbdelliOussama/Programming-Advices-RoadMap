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
int frequence(int number,int digit)
{
    
    int remainder = 0, frequence=0;
    while (number > 0)
    {
        remainder = number % 10;
        number = number / 10;
        if (remainder == digit)
            frequence++;
       
    }
    return frequence;
}
int main()
{
    int number = readnumber("please enter a number");
    int digit = readnumber("please enter a digit");
    cout << "digit " << digit << "  frequency is =: " << frequence(number, digit)<<" times" <<endl;
}

