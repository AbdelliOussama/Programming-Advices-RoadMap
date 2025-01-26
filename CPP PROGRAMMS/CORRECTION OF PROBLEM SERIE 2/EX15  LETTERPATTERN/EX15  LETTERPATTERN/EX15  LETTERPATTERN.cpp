#include <iostream>
#include<string>
using namespace std;
int readnumber(string message, int from, int to)
{
    int number;
    do
    {
        cout << message;
        cin >> number;
        return number;
    } while (number <= from && number >= to);
}
void printiletterattern(int number)
{

    for (int i = 65 ; i <= 65+number-1; i++)
    {
        for (int j = 65; j <= i; j++)
        {
            cout << char(i);
        }
        cout << endl;
    }
}


int main()
{
    cout << "Input:\n";
    int N = readnumber("enter a number", 65, 97);
    cout << "output\n";
    printiletterattern(N);
}

