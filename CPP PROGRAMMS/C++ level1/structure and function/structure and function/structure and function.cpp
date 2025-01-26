#include<iostream>
#include<string>
using namespace std;
struct st_info {
	string name;
	string lastname;
	int age;
	int phone_number;
};
void read_info(st_info &info) {
	cout << "please enter your name ";
	getline(cin, info.name);
	cout << "please enter your last name ";
	getline(cin, info.lastname);
	cout << "please enter your age ";
	cin >> info.age;
	cout << "please enter your phone number ";
	cin >> info.phone_number;
}
void display_info(st_info info) {
	cout << "************************\n";
	cout << info.name << endl;
	cout << info.lastname << endl;
	cout << info.age << endl;
	cout << info.phone_number << endl;
	cout << "************************\n";

}
int main()
{
	st_info info,info_2;
	read_info( info);
	display_info( info);
	read_info(info_2);
	display_info(info_2);
}