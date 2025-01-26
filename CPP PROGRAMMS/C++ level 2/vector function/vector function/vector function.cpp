/*
push_back = > Adds a new element at the end of the vector.
pop_back = > Remove elements from a vector from the back.
.cleear() = > Clear content.
.empty() = > used to check if the vector container is empty or not
.size() = > Return size / how many elements are there.
.front() = > Access first element.
.back() = > Access last element.
.capacity() = > Return size of allocated storage capacity / overall size.
*/

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
	cout << "First Element: " << vNumbers.front() << endl;
	cout << "Last Element: " << vNumbers.back() << endl; 
	//returns the number of elements present in the vector  
	 cout << "Size: " << vNumbers.size() << endl;
	//check the overall size of a vector   
	 cout << "Capacity : " << vNumbers.capacity() << endl;
	//returns 1 (true) if the vector is empty   
	 cout << "Empty : " << vNumbers.empty() << endl;
		return 0; 
} 