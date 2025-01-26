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
	bool MarkForDelete = false;
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
string ConvertRecordToLine(stclient_data Client, string delim = "#//#")
{
	string stClientRecord = "";
	stClientRecord += Client.account_number + delim;
	stClientRecord += Client.pincode + delim;
	stClientRecord += Client.name + delim;
	stClientRecord += Client.phone + delim;
	stClientRecord += to_string(Client.account_balance);
	return stClientRecord;
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
bool FindClientByAccountNumber(string AccountNumber, vector<stclient_data> vClients, stclient_data& Client)
{
	for (stclient_data C : vClients)
	{
		if (C.account_number == AccountNumber)
		{
			Client = C; return true;
		}
	} return false;
}
bool MarkClientForDeleteByAccountNumber(string AccountNumber, vector <stclient_data>& vClients)
{
	for (stclient_data& C : vClients)
	{
		if (C.account_number == AccountNumber)
		{
			C.MarkForDelete = true;
			return true;
		}
	}
	return false;
}
vector <stclient_data> SaveCleintsDataToFile(string FileName, vector<stclient_data> vClients)
{
	fstream MyFile;
	MyFile.open(FileName, ios::out);//overwrite
	string DataLine;
	if (MyFile.is_open())
	{
		for (stclient_data C : vClients)
		{
			if (C.MarkForDelete == false)
			{
				//we only write records that are not marked for delete.   
				DataLine = ConvertRecordToLine(C);
				MyFile << DataLine << endl;
			}
		}
		MyFile.close();
	}
	return vClients;
}
bool DeleteClientByAccountNumber(string AccountNumber, vector<stclient_data>& vClients)
{
	stclient_data Client;
	char Answer = 'n';
	if (FindClientByAccountNumber(AccountNumber, vClients, Client))
	{
		printclientcard(Client);
		cout << "\n\nAre you sure you want delete this client? y/n ? ";
		cin >> Answer;
		if (Answer == 'y' || Answer == 'Y')
		{
			MarkClientForDeleteByAccountNumber(AccountNumber, vClients);
			SaveCleintsDataToFile(filename, vClients); //Refresh Clients
			vClients = loaddatafromfile(filename);
			cout << "\n\nClient Deleted Successfully."; return true;
		}
	}
	else
	{
		cout << "\nClient with Account Number (" << AccountNumber << ") is Not Found!";
		return false;
	}
}

int main()
{
	vector <stclient_data> vClients = loaddatafromfile(filename);
	string AccountNumber = readaccountnumber();
	DeleteClientByAccountNumber(AccountNumber, vClients);
	system("pause>0");
	return 0;
}
