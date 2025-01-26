#include<iostream>
#include<string>
#include<string>
#include<vector>
#include<fstream>
using namespace std;
struct stclient_data
{
	string account_number;
	string pincode;
	string name;
	string phone;
	double account_balance;
};
stclient_data fillclientdata()
{
	stclient_data clientdata;
	cout << "enter account number ?  ";
	getline(cin>>ws, clientdata.account_number);
	cout << endl;
	cout << "enter pin code ?  ";
	getline(cin, clientdata.pincode);
	cout << endl;
	cout << "Enter name ? ";
	getline(cin, clientdata.name);
	cout << endl;
	cout << "Enter phone?  ";
	getline(cin, clientdata.phone);
	cout << endl;
	cout << "Enter account balance ?  ";
	cin >> clientdata.account_balance;
	cout << endl;
	return clientdata;
}

string covertclientrecordtostring(stclient_data clientdata, string delim)
{
	string mystring = "";
	mystring = mystring + clientdata.account_number + delim;
	mystring = mystring + clientdata.pincode + delim;
	mystring = mystring + clientdata.name + delim;
	mystring = mystring + clientdata.phone + delim;
	mystring = mystring + to_string(clientdata.account_balance);
	return mystring;
}
int main()
{
	fstream  myfile;
	cout << "please enter client data\n";
	stclient_data clientdata;
	char addmoreclient = 'y';
	while (addmoreclient == 'y' || addmoreclient == 'Y')
	{
		clientdata = fillclientdata();
		myfile.open("myclient_data_file.text", ios::out|ios::app);
		if (myfile.is_open())
		{
			myfile << covertclientrecordtostring(clientdata, "#//#") << endl;
			myfile.close();
		}
		cout << "client added succesfully do you want to add another client\n";
		cin >> addmoreclient;
		cout << endl;
	}

}