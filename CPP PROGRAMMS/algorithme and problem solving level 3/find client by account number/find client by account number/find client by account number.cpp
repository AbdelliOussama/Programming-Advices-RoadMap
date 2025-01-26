#include<iostream>
#include<string>
#include<string>
#include<vector>
#include<fstream>
#include<iomanip>
using namespace std;
const string filename = "myclient_data_file.txt";
struct stclient_data
{
	string account_number;
	string pincode;
	string name;
	string phone;
	double account_balance;
};
vector<string>splitstring(string clientdatastring, string delim)
{
	vector<string>vdata;
	int pos = 0;
	string word;
	while ((pos = clientdatastring.find(delim)) != std::string::npos)
	{
		word = clientdatastring.substr(0, pos);
		if (word != "")
			vdata.push_back(word);
		clientdatastring.erase(0, pos + delim.length());
	}
	if (clientdatastring != "")
	{
		vdata.push_back(clientdatastring);
	}
	return vdata;
}
stclient_data convertlinedatatorecord(string clientdatastring, string delim)
{
	vector<string>vdata = splitstring(clientdatastring, delim);
	stclient_data client;
	client.account_number = vdata[0];
	client.pincode = vdata[1];
	client.name = vdata[2];
	client.phone = vdata[3];
	client.account_balance = stod(vdata[4]);
	return client;
}

vector< stclient_data>loaddatafromfile(string filename)
{
	vector< stclient_data>vclients;
	fstream myclientsfile;
	myclientsfile.open(filename, ios::in);
	if (myclientsfile.is_open())
	{
		string line;
		stclient_data client;
		while (getline(myclientsfile, line))
		{
			client = convertlinedatatorecord(line, "#//#");
			vclients.push_back(client);
		}
		myclientsfile.close();
	}
	return vclients;
}
string readaccountnumber()
{
	string accountnumber;
	cout << "please enter the account number\n";
	cin >> accountnumber;
	return accountnumber;
}
void printclientcard(stclient_data client)
{
	cout << "\nThe following are the client details:\n";   
	cout << "\nAccout Number: " << client.account_number;
	cout << "\nPin Code     : " << client.pincode;   
	cout << "\nName         : " << client.name;    
	cout << "\nPhone        : " << client.phone;   
	cout << "\nAccount Balance: " << client.account_balance;
}
bool findclientbyaccountnumber(string accountnumber, stclient_data& client)
{
	vector<stclient_data>vclients = loaddatafromfile(filename);
	for (stclient_data& C : vclients)
	{
		if (C.account_number == accountnumber)
		{
			  client=C;
			  return true;
		}
	
	}
	return false;
}

int main()
{
	stclient_data client;
	string accountnumber = readaccountnumber();
	if (findclientbyaccountnumber(accountnumber, client))
	{       
		printclientcard(client);
	}
	else
	{
		cout << "\nClient with Account Number (" << accountnumber << ") is Not Found!";
	}
	system("pause>0");
	return 0;
}
