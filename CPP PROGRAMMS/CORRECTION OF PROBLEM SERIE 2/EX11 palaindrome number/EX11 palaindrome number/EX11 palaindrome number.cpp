#include <iostream>
#include<string>
enum enpalindromenotpalindrome{palindrome=1,notpalindrome=2};
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
    int remainder = 0, number2 = 0;
    while (number > 0)
    {
        remainder = number % 10;
        number = number / 10;
        number2 = number2 * 10 + remainder;
    }
    return number2;
     
}

enpalindromenotpalindrome chekpalindrome(int number)
{
   
    if (number== reversednumber(number))
        return enpalindromenotpalindrome::palindrome;
    else
        return enpalindromenotpalindrome::notpalindrome;
}

void printpalindrome(int number)
{
    if (chekpalindrome(number) == enpalindromenotpalindrome::palindrome)
        cout << number << " is a palindrome number"<<endl;
    else
        cout << number << " is not a palindrome number"<<endl;
}


int main()
{
    int number = readnumber("please entera number");
    printpalindrome(number);
}

