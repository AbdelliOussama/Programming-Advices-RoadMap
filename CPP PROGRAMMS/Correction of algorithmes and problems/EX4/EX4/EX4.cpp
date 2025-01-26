
#include <iostream>
using namespace std;
struct stinfo
{
	int age;
	bool hasdrivinglicenses;
};
stinfo readinfo()
{
	stinfo info;
	cout << "enter yor age\n";
	cin >> info.age;
	cout << "do you have a driver license";
	cin >> info.hasdrivinglicenses;
	return info;
}

bool is_accepted(stinfo info)
{
	return (info.age > 21 && info.hasdrivinglicenses);
}
void printresult(stinfo info)
{
	if (is_accepted(info))
		cout << "\nhired" << endl;
	else
		cout << "\nrejected" << endl;

}

int main()
{
	printresult(readinfo());
}



