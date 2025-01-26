#include<iostream>
#include<string>
using namespace std;
struct strinfo {
	string firstname;
	string lastname;
	int age;
	string phone;
};
strinfo person[2];

int main() {

	person[1].firstname = "oussama";
	person[1].lastname = "abdelli";
	person[1].age = 24;
	person[1].phone = "96301996";

	person[2].firstname = "islem";
	person[2].lastname = "ferchichi";
	person[2].age = 26;
	person[2].phone = "27804501";

	cout << person[1].firstname << endl;
	cout << person[1].lastname << endl;
	cout << person[2].firstname << endl;
	cout << person[2].lastname << endl;


}