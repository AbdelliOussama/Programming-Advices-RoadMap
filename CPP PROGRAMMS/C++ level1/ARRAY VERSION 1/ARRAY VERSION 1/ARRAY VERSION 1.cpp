#include<iostream>
using namespace std;
float grades[3];


int main() {
    cout << "enter the first elemnt of the array \n";
    cin >> grades[1];
    cout << "enter the second elemnt of the array \n";
    cin >> grades[2];
    cout << "enter the third elemnt of the array \n";
    cin >> grades[3];
    float avg = (grades[1] + grades[2] + grades[3]) / 3;
    cout << "the average of array elemnt are  \n" << avg;
} 