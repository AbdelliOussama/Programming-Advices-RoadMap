#include<iostream>
#include<string>
#include<cstdlib>
using namespace std;
int ReadPositiveNumber(string Message)
{
    int Number = 0;
    do
    {
        cout << Message << endl;
        cin >> Number;
    } while (Number <= 0);
    return Number;
}
int randomnumber(int from, int to)
{
    int randomnum = rand() % (to - from + 1) + 1;
    return randomnum;
}
void fillarraywithrandomnumbers(int arr[100], int& arrlength)
{
    cout << "enter the array length" << endl;
    cin >> arrlength;
    for (int i = 0; i <= arrlength - 1; i++)
    {
        arr[i] = randomnumber(0, 100);
    }
}

void PrintArray(int arr[100], int arrLength)
{
    for (int i = 0; i < arrLength; i++)

    {
        cout << arr[i] << " ";
    }
}

int sumofarrayofrandom(int arr[100], int arrlength)
{
    int sum = 0;
    for (int i = 0; i <= arrlength - 1; i++)
    {
        sum += arr[i];
    }
    return sum;
}
int averageofarrayofrandom(int arr[100], int arrlength)
{
    float avg = sumofarrayofrandom(arr, arrlength) / arrlength;
    return avg;
}

int main()
{
    srand((unsigned)time(NULL));
    int arr[100], arrLength;
    fillarraywithrandomnumbers(arr, arrLength);
    cout << "\nOutput: ";
    cout << "array elements:";
    PrintArray(arr, arrLength);
    cout << endl;
    cout << "sum of number is:" << sumofarrayofrandom(arr, arrLength);
    cout<<"\naverage of all numbers is: "<<averageofarrayofrandom(arr, arrLength);

    return 0;
}
