#include<iostream>
#include<string>
#include<cctype>
using namespace std;
char readcaracter()
{
	char caracter;
	cout << "please enter your caracter\n";
	cin>>caracter;
	return caracter;

}

char invertcarater(char caracter)
{
	return(isupper(caracter))? tolower(caracter): toupper(caracter);
}
int main()
{
	char  mychar = readcaracter();
	cout << "Char after inverting is\n";
	cout << invertcarater(mychar);
	
}