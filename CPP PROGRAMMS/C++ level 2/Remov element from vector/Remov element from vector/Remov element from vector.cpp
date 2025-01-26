#include<vector>
#include<iostream>
using namespace std; 
/* 
push_back => Adds a new element at the end of the vector.
pop_back => Remove elements from a vector from the back.
.cleear() => Clear content.
.empty() => used to check if the vector container is empty or not
.size() => Return size / how many elements are there.
.front() => Access first element.
.back() => Access last element.
.capacity() => Return size of allocated storage capacity / overall size.
*/
int main()
{
	vector <int> vNumbers;  
	vNumbers.push_back(10); 
	vNumbers.push_back(20);  
	vNumbers.push_back(30); 
	vNumbers.push_back(40);  
	vNumbers.push_back(50); 
	vNumbers.push_back(60);
	vNumbers.push_back(70);
	cout <<"the length of the vector is"<<vNumbers.size() << endl;
	vNumbers.pop_back();   
	vNumbers.pop_back(); 
	vNumbers.pop_back();  
	vNumbers.pop_back();
	vNumbers.pop_back();
	cout << "the length of the vector is" << vNumbers.size() << endl;
	vNumbers.clear();
	cout << vNumbers.size() << endl;
	cout << "Numbers Vector: \n\n";
	// ranged loop
	for (int & Number : vNumbers)
	{     
		cout << Number << endl;   
	}
	cout << endl; 
	return 0;
} 