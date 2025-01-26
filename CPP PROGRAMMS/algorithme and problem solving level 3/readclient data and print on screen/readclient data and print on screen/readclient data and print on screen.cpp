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
	while (pos = clientdatastring.find(delim) != std::string::npos)
	{
		word = clientdatastring.substr(0, pos);
		if (word != "")
			vdata.push_back(word);
		clientdatastring.erase(0, clientdatastring.length() + delim.length());
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

void printclientdata(stclient_data client)
{
	cout << "| " << setw(15) << left << client.account_number;
	cout << "| " << setw(10) << left << client.pincode;
	cout << "| " << setw(40) << left << client.name;
	cout << "| " << setw(12) << left << client.phone;
	cout << "| " << setw(12) << left << client.account_balance;
}
void printallclientsdata(vector< stclient_data>vclients)
{
	cout << "\n\t\t\t\t\tclients liste(" << vclients.size() << ")client(s)\n";
	cout << "________________________________________________________________________________________________________________________________\n";
	cout << "| " << setw(15) << left << "account Number ";
	cout << "| " << setw(10) << left << "Pin code";
	cout << "| " << setw(40) << left << "Client name";
	cout << "| " << setw(12) << left << "Phone";
	cout << "| " << setw(12) << left << "Balance";
	cout << endl;
	for (stclient_data& client : vclients)
	{
		printclientdata(client);
		cout << endl;
	}
	cout << "________________________________________________________________________________________________________________________________\n";
}
int main()
{
	vector< stclient_data>vclients = loaddatafromfile(filename);
	printallclientsdata(vclients);
	return 0;
}
