#include<iostream>
#include<string>
#include<cctype>
using namespace std;
char readchar()
{
	char mychar;
	cout << "please enter a caracter\n";
	cin >> mychar;
	return mychar;
}
bool checkvowel(char mychar)
{
	mychar =tolower(mychar);
	return ((mychar == 'a') || (mychar == 'e') || (mychar == 'i'), (mychar == 'u'), (mychar == 'o'));
}
int main()
{
	char mychar = readchar();
	if (checkvowel(mychar))
		cout << "Yes , letter " << mychar << " is vowel \n" << endl;
	else
		cout << "No , letter " << mychar << " is not vowel \n" << endl;
}