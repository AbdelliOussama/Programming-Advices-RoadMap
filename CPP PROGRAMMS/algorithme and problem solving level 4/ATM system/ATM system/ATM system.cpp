#include<iostream>
#include<string>
#include<iomanip>
#include<vector>
#include<fstream>
using namespace std;
const string ClientsFileName = "myclient_data_file.txt";
enum enATMMainMenueOptions { QuickWithdraw = 1, Normalwithdraw = 2, Deposit = 3, CheckBalancce = 4, Logout = 5 };
void Login();
void ShowATMMainMenue();
void ShowNormalWithdrawScreen();
struct sClient
{
	string AccountNumber;
	string PinCode;
	string Name;
	string Phone;
	double AccountBalance;
	bool MarkForDelete = false;
};
sClient CurrentClient;
vector<string> SplitString(string S1, string Delim)
{
	vector<string> vString;
	short pos = 0;
	string sWord; // define a string variable  // use find() function to get the position of the delimiters 
	while ((pos = S1.find(Delim)) != std::string::npos)
	{
		sWord = S1.substr(0, pos); // store the word  
		if (sWord != "")
		{
			vString.push_back(sWord);
		}
		S1.erase(0, pos + Delim.length());
		/* erase() until positon and move to next word. */
	}
	if (S1 != "")
	{
		vString.push_back(S1);
		// it adds last word of the string.  
	}
	return vString;
}
sClient ConvertLinetoRecord(string Line, string Seperator = "#//#")
{
	sClient Client;
	vector<string> vClientData;
	vClientData = SplitString(Line, Seperator);
	Client.AccountNumber = vClientData[0];
	Client.PinCode = vClientData[1];
	Client.Name = vClientData[2];
	Client.Phone = vClientData[3];
	Client.AccountBalance = stod(vClientData[4]);//cast string to double
	return Client;
}
string ConvertRecordToLine(sClient Client, string Seperator = "#//#")
{
	string stClientRecord = "";
	stClientRecord += Client.AccountNumber + Seperator;
	stClientRecord += Client.PinCode + Seperator;
	stClientRecord += Client.Name + Seperator;
	stClientRecord += Client.Phone + Seperator;
	stClientRecord += to_string(Client.AccountBalance);
	return stClientRecord;
}
bool ClientExistsByAccountNumber(string AccountNumber, string FileName)
{
	vector <sClient> vClients;
	fstream MyFile;
	MyFile.open(FileName, ios::in);//read Mode 
	if (MyFile.is_open())
	{
		string Line;
		sClient Client;
		while (getline(MyFile, Line))
		{
			Client = ConvertLinetoRecord(Line);
			if (Client.AccountNumber == AccountNumber)
			{
				MyFile.close();
				return true;
			}
			vClients.push_back(Client);
		}
		MyFile.close();
	} return false;
}
vector <sClient> LoadCleintsDataFromFile(string FileName)
{
	vector <sClient> vClients;
	fstream MyFile;
	MyFile.open(FileName, ios::in);
	//read Mode 
	if (MyFile.is_open())
	{
		string Line;
		sClient Client;
		while (getline(MyFile, Line))
		{
			Client = ConvertLinetoRecord(Line);
			vClients.push_back(Client);
		}
		MyFile.close();
	} return vClients;
}
bool FindClientByAccountNumberAndPinCode(string AccountNumber,string PinCode, sClient& Client)
{
	vector<sClient>vClients = LoadCleintsDataFromFile(ClientsFileName);
	for (sClient C : vClients)
	{
		if (C.AccountNumber == AccountNumber && C.PinCode == PinCode)
		{
			Client = C;
			return true;
		}
	}
	return false;
}

vector <sClient> SaveCleintsDataToFile(string FileName, vector<sClient> vClients)
{
	fstream MyFile;
	MyFile.open(FileName, ios::out);
	//overwrite
	string DataLine;
	if (MyFile.is_open())
	{
		for (sClient C : vClients)
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
short ReadATMMainMenueOption()
{
	cout << "Choose what do you want to do? [1 to 5]? ";
	short Choice = 0;
	cin >> Choice;
	return Choice;
}
short ReadQuickWithdrawOption()
{
	int choice;
	cout << "Choose what to withdraw from [1] to[8] ?  ";
	cin >> choice;
	return choice;
}
int GetQuickWithdrawOption(int options)
{
	switch (options)
	{
	case 1:
		return 20;
	case 2:
		return 50;
	case 3:
		return 100;
	case 4:
		return 200;
	case 5:
		return 400;
	case 6:
		return 600;
	case 7:
		return 800;
	case 8:
		return 1000;
	default:
		return 0;
	}
}

void PerfromQuickWithdrawMenueOption(sClient& CurrentClient)
{
	int option = ReadQuickWithdrawOption();
	char Answer;
	if (option == 9)
		return;
	int withdrawamount = GetQuickWithdrawOption(option);
	if (withdrawamount > CurrentClient.AccountBalance)
		cout << "Your account excced\n";

	cout << "Are you sure you want to perform this transaction Y/N ? ";
	cin >> Answer;
	if (Answer == 'Y' || Answer == 'y')
	{
		CurrentClient.AccountBalance -= withdrawamount;
		cout << "Done succefully ,Now Balance is :" << CurrentClient.AccountBalance;
	}
}
void ShowQuickWithdrawScreen()
{
	cout << "===========================================\n";
	cout << "\t\tQuick Withdraw \n";
	cout << "===========================================\n";
	cout << "\t[1] 20";
	cout << "\t\t[2] 50\n";
	cout << "\t[3] 100";
	cout << "\t\t[4] 200\n";
	cout << "\t[5] 400";
	cout << "\t\t[6] 600\n";
	cout << "\t[7] 800";
	cout << "\t\t[8] 1000\n";
	cout << "\t[9] Exit\n";
	cout << "===========================================\n";
	cout << "Your Balance is : " << CurrentClient.AccountBalance << endl;
	PerfromQuickWithdrawMenueOption(CurrentClient);
}
int ReadNormalwithdrawAmount()
{
	int withdrawamount;
	do
	{
		cout << "Enter an amount multiple of 5's ? ";
		cin >> withdrawamount;
	} while (withdrawamount % 5 != 0);
	return withdrawamount;
}
void GobacktoNormalWithdrawscreen()
{
	cout << "Press any key to continue \n";
	system("pause>0");
}
void PerformNormalWithdrawOption(sClient& CurrentClient, int Amount)
{
	char Answer='Y';
	while (Amount > CurrentClient.AccountBalance)
	{
		cout << "The Amount exceed your balance , Make onther choice.";
		GobacktoNormalWithdrawscreen();
	}
	cout << "Are you sure you want to perform this transaction Y/N ? :";
	cin >> Answer;
	if (Answer == 'Y' || Answer == 'y')
	{
		CurrentClient.AccountBalance -= Amount;
		cout << "Done Succefuly . New balance is :" << CurrentClient.AccountBalance;
	}
	
}
void ShowNormalWithdrawScreen()
{
	cout << "===========================================\n";
	cout << "\t\tNormal Withdraw Screen \n";
	cout << "===========================================\n";
	int Amount = ReadNormalwithdrawAmount();
	PerformNormalWithdrawOption(CurrentClient, Amount);

}
void CheckBalance()
{
	system("cls");
	cout << "===========================================\n";
	cout << "\t\tCheck Balance \n";
	cout << "===========================================\n";
	cout << "Your Balance is :" << CurrentClient.AccountBalance << endl;
}
void GoBacktoMenueScreen()
{
	cout << "\nPress Any key To Go Back To Main Menue .......\n";
	system("pause>0");
	ShowATMMainMenue();
}

void PerfromATMMainMenueOption(enATMMainMenueOptions ATMMainMenueOption)
{
	switch (ATMMainMenueOption)
	{
		case enATMMainMenueOptions::QuickWithdraw:
		{
			system("cls");
			ShowQuickWithdrawScreen();
			GoBacktoMenueScreen();
			break;
		}
		case enATMMainMenueOptions::Normalwithdraw:
			system("cls");
			ShowNormalWithdrawScreen();
			GoBacktoMenueScreen();
			break;
		case enATMMainMenueOptions::Deposit:
			system("cls");
		
			
			break;
		case enATMMainMenueOptions::CheckBalancce:
			system("cls");
			CheckBalance();
			GoBacktoMenueScreen();
			break;
		case enATMMainMenueOptions::Logout:
			system("cls");
			Login();
			break;
		
	}
}

void ShowATMMainMenue()
{
	system("cls");
	cout << "===========================================\n";
	cout << "\t\tMain Menue Screen\n";
	cout << "===========================================\n";
	cout << "\t[1] Quick Withdraw.\n";
	cout << "\t[2] Normal Withdraw.\n";
	cout << "\t[3] Deposit.\n";
	cout << "\t[4] Check Balance.\n";
	cout << "\t[5] Logout.\n";
	
	cout << "===========================================\n";
	PerfromATMMainMenueOption((enATMMainMenueOptions)ReadATMMainMenueOption());
}
bool  LoadClientInfo(string AccountNumber, string PinCode)
{

	if (FindClientByAccountNumberAndPinCode(AccountNumber, PinCode, CurrentClient))
		return true;
	else
		return false;
}
void Login()
{
	bool LoginFaild = false;
	string ClientAccountNumber, PinCode;
	do
	{
		system("cls");
		cout << "\n---------------------------------\n";
		cout << "\tLogin Screen";
		cout << "\n---------------------------------\n";
		if (LoginFaild)
		{
			cout << "Invlaid AccountNumber/PinCoded!\n";
		}
		cout << "Enter Account Number? ";
		cin >> ClientAccountNumber;
		cout << "Enter PinCode? ";
		cin >> PinCode;
		LoginFaild = !LoadClientInfo(ClientAccountNumber,  PinCode);
	} while (LoginFaild);
	ShowATMMainMenue();
}
int main()
{
	Login();
}