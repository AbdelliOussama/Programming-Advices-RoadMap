#include<iostream>
#include<vector>
using namespace std;
//it is used to avoid crashing of program it send message of the error we can modify message
int main()
{ 
	vector<int> num{ 1, 2, 3, 4, 5 }; 
	try
	{   
		cout << num.at(5);   
	}
	catch (...)    
	{       
		cout << "out of bound\a"; 
	} 
	return 0;
} 