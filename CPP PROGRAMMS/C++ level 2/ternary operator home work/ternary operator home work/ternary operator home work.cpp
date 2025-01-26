#include<iostream>
using namespace std;
int read_number(string message)
{
    int number;
    cout << message;
    cin >> number;
    return number;
}
int main()
{
    int number = read_number("please enter a number\n");
    (number >= 0) ? cout << "Positive\n" : cout << "Negtive\n";
    //nested ternary operator
    (number == 0) ? cout << "the number is equal to Zero" : (number > 0)? cout<<"positive":cout<<"Negative";

}

