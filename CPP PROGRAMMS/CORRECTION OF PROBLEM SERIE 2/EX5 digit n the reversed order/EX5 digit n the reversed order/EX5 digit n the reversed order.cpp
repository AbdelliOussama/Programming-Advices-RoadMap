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
    for (int i = number; i >= 0; i--)
    {
        cout << i<<endl;
    }
}
int main()
{
    printsigitinreversedorder(readnumber("please enter a number:  "));
}

