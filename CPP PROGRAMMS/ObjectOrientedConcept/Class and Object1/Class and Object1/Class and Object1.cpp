#include<iostream>
#include <string>
using namespace std;
class clsPerson
{
private://by default are the variable different then public are private we can not see  in main
	int x;
public:
	string Firstname;//Data membre
	string Lastname;//Data membre
	string fullname()//Member Methode(Function and precedures)
	{
		return Firstname + " " + Lastname;
	}
};
int main()
{
	clsPerson person1;//person is an object ::object is variable dt type class 
	person1.Firstname = "Oussama";
	person1.Lastname = "Abdelli";
	cout << person1.fullname() << endl;
}