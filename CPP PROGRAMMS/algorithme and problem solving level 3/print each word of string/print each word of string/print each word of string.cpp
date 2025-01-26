#include<iostream>
#include<string>
#include<cctype>
using namespace std;
string readstring()
{
	string mystring;
	cout << "enter you string\n";
	getline(cin, mystring);
	return mystring;
}
void PrintEachWordInString(string mystring) 
{
	string delim = " "; 
	// delimiter   
	   cout <<"\nYour string wrords are: \n\n";
	   short pos = 0;
	   string sWord; 
	   // define a string variable  // 
	   // use find() function to get the position of the delimiters
	     while ((pos = mystring.find(delim)) != std::string::npos)   
		 {         sWord = mystring.substr(0, pos); 
		 // store the word  
		  if (sWord !="")   
		  {          
			  cout << sWord << endl; 
		  }
		  mystring.erase(0, pos + delim.length());
		  /* erase() until positon and move to next word. */  
		 }
		 if (mystring !="")   
		 {       
			 cout << mystring << endl; // it print last word of the string.  
		 }
} 

int main()
{
	string mystring = readstring();
	cout << "your string words are\n";
	PrintEachWordInString(mystring);


}