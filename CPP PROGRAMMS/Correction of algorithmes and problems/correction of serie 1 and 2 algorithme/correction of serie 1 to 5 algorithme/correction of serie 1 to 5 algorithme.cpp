#include<iostream>
#include<string>
using namespace std;
/* //procedure exercice 1 // 
void printname(string name)
{
	cout << "\n  your name is " << name;
}
*/

string readname()
{
	string name;
	cout << "enter your name"<<endl;
	getline(cin, name);
	return name;
}
void printname(string name)
{
	cout << "\n  your name is " << name;
}

int main() {
	// ex1  printname("oussama");
	printname(readname());
}