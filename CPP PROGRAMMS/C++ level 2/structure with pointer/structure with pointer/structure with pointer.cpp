#include<iostream>
using namespace std;
struct stEmplyee
{
	string Name;
	float Salary;
	string country;
};
int main()
{ 
	stEmplyee Employee1, *ptr;  
	Employee1.Name = "Mohammed Abu-Hadhoud";   
	Employee1.Salary = 5000; 
	Employee1.country = "Jordan";
	cout << Employee1.Name << endl; 
	cout << Employee1.Salary << endl; 
	cout << Employee1.country << endl;
	ptr = &Employee1;  
	cout << "\nUsing Pointer:\n"; 
	cout << ptr->Name << endl;  
	cout << ptr->Salary << endl;
	cout << ptr->country<< endl;
	return 0;
} 