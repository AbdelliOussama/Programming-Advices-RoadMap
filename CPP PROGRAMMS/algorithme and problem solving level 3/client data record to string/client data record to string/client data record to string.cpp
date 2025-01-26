#include<iostream>
#include<string>
#include<string>
#include<vector>
using namespace std;
struct stclient_data
{
	string account_number;
	string pincode;
	string name;
	string phone;
	string account_balance;
};
stclient_data fillclientdata()
{
	stclient_data clientdata;
	cout << "enter account number ?  ";
	getline(cin, clientdata.account_number);
	cout << endl;
	cout << "enter pin code ?  ";
	getline(cin, clientdata.pincode);
	cout << endl;
	cout << "Enter name ?\n";
	getline(cin, clientdata.name);
	cout << endl;
	cout << "Enter phone?  ";
	getline(cin, clientdata.phone);
	cout << endl;
	cout << "Enter account balance ?  ";
	getline(cin, clientdata.account_balance);
	cout << endl;
	return clientdata;
}
vector<string>fillvectorwithstruct(stclient_data clientdata)
{
	vector<string>vmystring;
	vmystring.push_back(clientdata.account_number);
	vmystring.push_back(clientdata.pincode);
	vmystring.push_back(clientdata.name);
	vmystring.push_back(clientdata.phone);
	vmystring.push_back(clientdata.account_balance);
	return vmystring;
}
string joinstring(vector<string> vmystring, string delim)
{
	string mystring = "";
	for (string& word : vmystring)
	{
		mystring = mystring + word + delim;
	}
	return mystring.substr(0, mystring.length() - delim.length());
}
int main()
{
	cout << "please enter client data\n";
	cout << joinstring(fillvectorwithstruct(fillclientdata()), "#//#");
}