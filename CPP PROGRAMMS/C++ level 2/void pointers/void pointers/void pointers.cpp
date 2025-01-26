#include<iostream>
using namespace std;
int main() 
{
	void * ptr;// void pointer is for generic type it work with all type
	float f1 = 10.5;
	int x = 50;  
	ptr = &f1;  
	cout << ptr <<endl;
	cout << *(static_cast<float*>(ptr)) <<endl;  //to chage pointer type to float when we read the value that pointing in
	ptr = &x;     cout << ptr << endl;  
	cout << *(static_cast<int*>(ptr)) << endl;
	return 0;
} 