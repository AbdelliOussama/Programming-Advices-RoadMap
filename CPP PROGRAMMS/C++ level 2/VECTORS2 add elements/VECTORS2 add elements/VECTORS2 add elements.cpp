#include<vector>
#include<iostream>
using namespace std;
int main()
{
	vector <int> vNumbers;  
	vNumbers.push_back(10);
	vNumbers.push_back(20); 
	vNumbers.push_back(30); 
	vNumbers.push_back(40);  
	vNumbers.push_back(50);  
	vNumbers.push_back(40);
	vNumbers.push_back(250);
	vNumbers.push_back(306);
	vNumbers.push_back(460);
	vNumbers.push_back(59);
	cout << "Numbers Vector: \n\n";
	// ranged loop
	for (int & Number : vNumbers)
	{        
		cout << Number << endl;  
	}  
	cout << endl;
	return 0; 
} 