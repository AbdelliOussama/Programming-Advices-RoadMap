#include<iostream>
#include<string>
#include<cstdlib>
using namespace std;
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
void copyelementofarray(int arr[100], int arr2[100],int arrlength)
{
    for (int i = 0; i <= arrlength; i++)
    {
        arr2[i] = arr[i];
    }
}
int main()
{
    srand((unsigned)time(NULL));
    int arr[100], arrLength, arr2[100];
    fillarraywithrandomnumbers(arr, arrLength);
    cout << "Input:" << endl;
    cout<<arrLength << endl;;
    cout << "\nOutput: "<<endl;
    cout << "array 1 elements:"<<endl;
    PrintArray(arr, arrLength);
    cout << endl;
    copyelementofarray(arr,arr2, arrLength);
    cout << "array 2 elements:" << endl;
    PrintArray(arr2, arrLength);
    cout << endl;
    return 0;
}
