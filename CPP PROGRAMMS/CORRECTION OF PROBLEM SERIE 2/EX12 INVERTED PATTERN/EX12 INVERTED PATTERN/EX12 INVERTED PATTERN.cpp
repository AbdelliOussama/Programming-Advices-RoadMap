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
void printinvertedpattern(int number)
{

    for (int i = number; i >= 1; i--)
    {
        for (int j = 1; j <= i; j++)
        {
            cout << i;
        }
        cout << endl;
    }
}


int main()
{
    cout << "Input:\n";
    int N = readnumber("enter a number");
    cout << "output\n";
    printinvertedpattern(N);
}

