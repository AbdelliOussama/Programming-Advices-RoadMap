#include<iostream>
using namespace std;
int main() 
{ 
	string my_family[]={ "oussama ","salim","sarra","asma","saif","as3ed" };
	int Array1[] = { 1, 2, 3, 4 ,5,6}; 
	for (int n : Array1)
	{      
		cout << n << endl;    
	} 

	for (string n : my_family)
	{
		cout << n << endl;
	}
	return 0;
} 