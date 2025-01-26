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
int frequence(int number, int digit)
{

    int remainder = 0, frequence = 0;
    while (number > 0)
    {
        remainder = number % 10;
        number = number / 10;
        if (remainder == digit)
            frequence++;

    }
    return frequence;
}
void printdigitfrequency(int number)
{
    for(int i=0;i<10;i++)
    {
        int frequency = 0;
        frequency = frequence(number,i);
        if (frequency > 0)
            cout << "digit " << i << " frequency is " << frequency << " times" << endl;
    }
}
int main()
{
    int number = readnumber("please enter a number");
   
    printdigitfrequency(number);
}

