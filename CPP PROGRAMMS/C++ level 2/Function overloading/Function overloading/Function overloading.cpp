#include<iostream>
using namespace std;
//function overloading is the to name many  function wth the same name but different number or type  of parametres 
double  MySum(double a, double b)
{ 
	return (a + b);
}
int MySum(int a, int b) 
{
	return (a + b); 
} 
int MySum(int a, int b, int c)
{ 
	return (a + b + c);
} 
int MySum(int a, int b, int c, int d)
{ return (a + b + c + d); 
}
int main() 
{    
	cout << MySum(12.5,13.5) << endl;  
	return 0;
}