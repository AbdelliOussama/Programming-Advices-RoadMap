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

int minofarrayofrandom(int arr[100], int arrlength)
{
    int min = arr[0];
    for (int i = 0; i <= arrlength - 1; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
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
    cout << "max of number is:" << minofarrayofrandom(arr, arrLength);

    return 0;
}
