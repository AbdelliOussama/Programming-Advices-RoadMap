#include<iostream>
#include<string>
using namespace std;
struct strinfo {
	string firstname;
	string lastname;
	int age;
	string phone;
};

void readinfo( strinfo &person ) {
	cout << "enter the firstname\n";
	cin >> person.firstname;
	cout << "enter the lastname\n";
	cin >> person.lastname;
	cout << "enter the age\n";
	cin >> person.age;
	cout << "enter the phone\n";
	cin >> person.phone;
}
void printinfo(strinfo person) {
	cout << "*************************\n";
	cout << person.firstname<<endl;
	cout << person.lastname<<endl;
	cout << person.age<<endl;
	cout << person.phone<<endl;
	cout << "*************************\n";

}
void readpersonsinfo(strinfo  person[2]) {
	readinfo( person[0]);
	readinfo( person[1]);

}
void printpersonsinfo(strinfo person[2]) {
	cout << "***********************";
	printinfo(person[0]);
	printinfo(person[1]);

}

int main() {
	strinfo person[2];
	readpersonsinfo(person);
	printpersonsinfo(person);
}