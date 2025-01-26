#include <iostream>
#include <string>
using namespace std;

string readpincode()
{
	string  pincode;
	
		cout << "read pin code\n";
		cin >> pincode;
	return pincode;
}

bool login()
{
	string pincode;
	int i=3;
	do 
	{
		i--;
		pincode = readpincode();
		if (pincode == "1234")
			return 1;
		else
			cout << "Wrong pin ,you have\t "<<i<<"more chance\n ";
		system("color 4F"); //return red color to the screen
	} while ( i >=1 && pincode != "1234" );
	return 0;
}



int main()
{
	if (login())
	{
		system("color 2F");//green color
		cout << "your account balance is 7500\n";

	}
	else cout << "your count is locked please contact your bank\n";


}

