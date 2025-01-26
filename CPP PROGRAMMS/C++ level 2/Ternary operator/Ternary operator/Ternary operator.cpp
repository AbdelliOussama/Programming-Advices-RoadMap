#include<iostream>
using namespace std;
int main()
{ 
	int Mark = 90; string result; 
	//Using normal if 
    if (Mark >= 50)   
    {         
		result     =     "PASS";  
	}   
    else     
    {               result     =     "FAIL";    
    }   
    cout << result << endl; 
    //Using Short Hand IF     
    (Mark >= 50) ?cout<< "PASS" :cout<< "FAIL";
    
} 