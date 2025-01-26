#include<iostream>
#include<fstream>
#include<string>
#include<vector>
#include<iomanip>
using namespace std;
const string ClientsFileName = "myclient_data_file.txt";
const string UserFileName = "User_data_file.txt";
void ShowMainMenue();
void showTransactionMenuScreen();
void showManageUsersMenuScreen();
void Login();
void GoBackToManageMenue();

struct sClient
{
	string AccountNumber;
	string PinCode;
	string Name;
	string Phone;
	double AccountBalance;
	bool MarkForDelete = false;
};
struct sUser
{
	string Username;
	string Password;
	int permission;
	bool MarkForDelete = false;
};
enum enMainMenueOptions
{
	eListClients = 1, eAddNewClient = 2, eDeleteClient = 3, eUpdateClient = 4, eFindClient = 5, eTransactionMenue = 6, ManageUsers = 7, Logout = 8
};
enum enTransactionMenueOption
{
	eDeposit = 1, eWithdraw = 2, eTotalBalance = 3, eMainmenue = 4
};
enum enManageUserOption
{
	List_Users = 1, Add_NewUser = 2, Delete_User = 3, Update_User = 4, Find_User = 5, MainMenue = 6
};
enum enPermeission { showclientlist = 1, AddnewClient = 2, Deleteclient = 4, UpdateClientData = 8, FindClient = 16, Transaction = 32, ManageUsersoption = 64 };
sUser User;
vector<string> SplitString(string S1, string Delim)
{
	vector<string> vString;
	short pos = 0;
	string sWord; // define a string variable  
	// use find() function to get the position of the delimiters 
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
		vString.push_back(S1); // it adds last word of the string.
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
sUser ConvertUserLinetoRecord(string Line, string Seperator = "#//#")
{
	sUser User;
	vector<string> vUserData;
	vUserData = SplitString(Line, Seperator);
	User.Username = vUserData[0];
	User.Password = vUserData[1];
	User.permission = stod(vUserData[2]);

	return User;
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
string ConvertUserRecordToLine(sUser User, string Seperator = "#//#")
{
	string stUserRecord = "";
	stUserRecord += User.Username + Seperator;
	stUserRecord += User.Password + Seperator;
	stUserRecord += User.permission;

	return stUserRecord;
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
			Client = ConvertLinetoRecord(Line, "#//#");
			if (Client.AccountNumber == AccountNumber)
			{
				MyFile.close();
				return true;
			}
			vClients.push_back(Client);
		}
		MyFile.close();
	}
	return false;
}

bool UserExistsByUserName(string Username, string FileName)
{
	vector <sUser> vUsers;
	fstream MyFile;
	MyFile.open(FileName, ios::in);//read Mode
	if (MyFile.is_open())
	{
		string Line;
		sUser User;
		while (getline(MyFile, Line))
		{
			User = ConvertUserLinetoRecord(Line, "#//#");
			if (User.Username == Username)
			{
				MyFile.close();
				return true;
			}
			vUsers.push_back(User);
		}
		MyFile.close();
	}
	return false;
}
bool FindUserByUserNameandPassword(string Username, string Password, vector<sUser> vUser, sUser& User)
{
	for (sUser U : vUser)
	{
		if (U.Username == Username && U.Password == Password)
		{
			User = U;
			return true;
		}
	} return false;
}
sClient ReadNewClient()
{
	sClient Client;
	cout << "Enter Account Number? ";
	// Usage of std::ws will extract allthe whitespace character 
	getline(cin >> ws, Client.AccountNumber);
	while (ClientExistsByAccountNumber(Client.AccountNumber, ClientsFileName))
	{
		cout << "\nClient with [" << Client.AccountNumber << "] already exists, Enter another Account Number? ";
		getline(cin >> ws, Client.AccountNumber);
	}
	cout << "Enter PinCode? ";
	getline(cin, Client.PinCode);
	cout << "Enter Name? ";
	getline(cin, Client.Name);
	cout << "Enter Phone? ";
	getline(cin, Client.Phone);
	cout << "Enter AccountBalance? ";
	cin >> Client.AccountBalance;
	return Client;
}
int GetPermession()
{

	char Answer = 'Y';
	int permession = 0;
	cout << "Do you want to give full access ? Y/N ? ";
	cin >> Answer;
	if (toupper(Answer) == 'Y')
	{
		permession = -1;
		return permession;
	}
	else
	{
		cout << "Dou you want to give accses to :\n";
		cout << "Show Client list ? Y/N ";
		cin >> Answer;
		if (Answer == 'Y')
			permession += enPermeission::showclientlist;

		cout << "Add Client  ? Y/N ";
		cin >> Answer;
		if (Answer == 'Y')
			permession += enPermeission::AddnewClient;
		cout << "Delete client  ? Y/N ";
		cin >> Answer;
		if (Answer == 'Y')
			permession += enPermeission::Deleteclient;
		cout << "Update client  ? Y/N ";
		cin >> Answer;
		if (Answer == 'Y')
			permession += enPermeission::UpdateClientData;
		cout << "Find client  ? Y/N  ";
		cin >> Answer;
		if (Answer == 'Y')
			permession += enPermeission::FindClient;
		cout << "Transaction ";
		cin >> Answer;
		if (Answer == 'Y')
			permession += enPermeission::Transaction;
		cout << "Manage Users  ? Y/N ";
		cin >> Answer;
		if (Answer == 'Y')
			permession += enPermeission::ManageUsersoption;
		return permession;

	}
}
sUser ReadNewUser()
{
	sUser User;
	cout << "Enter User Name? ";
	// Usage of std::ws will extract allthe whitespace character 
	getline(cin >> ws, User.Username);
	while (UserExistsByUserName(User.Username, UserFileName))
	{
		cout << "\nUser with [" << User.Username << "] already exists, Enter another Username? ";
		getline(cin >> ws, User.Username);
	}
	cout << "Enter Password? ";
	getline(cin, User.Password);
	User.permission = GetPermession();
	return User;
}
vector <sClient> LoadCleintsDataFromFile(string FileName)
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
			Client = ConvertLinetoRecord(Line, "#//#");
			vClients.push_back(Client);
		}
		MyFile.close();
	} return vClients;
}
void PrintClientRecordLine(sClient Client)
{
	cout << "| " << setw(15) << left << Client.AccountNumber;
	cout << "| " << setw(10) << left << Client.PinCode;
	cout << "| " << setw(40) << left << Client.Name;
	cout << "| " << setw(12) << left << Client.Phone;
	cout << "| " << setw(12) << left << Client.AccountBalance;
}
void PrintUserRecordLine(sUser User)
{
	cout << "| " << setw(15) << left << User.Username;
	cout << "| " << setw(10) << left << User.Password;
	cout << "| " << setw(40) << left << User.permission;
}
void PrintClientBalanceLine(sClient Client)
{
	cout << "| " << setw(15) << left << Client.AccountNumber;
	cout << "| " << setw(40) << left << Client.Name;
	cout << "| " << setw(12) << left << Client.AccountBalance;
}
void ShowTotalBalanceScreen()
{
	int TotalBalance = 0;
	vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
	cout << "\n\t\t\t\t\tClient List (" << vClients.size() << ") Client(s).";
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
	cout << "| " << left << setw(15) << "Accout Number";
	cout << "| " << left << setw(40) << "Client Name";
	cout << "| " << left << setw(12) << "Balance";
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
	if (vClients.size() == 0)
		cout << "\t\t\t\tNo Clients Available In the System!";
	else
		for (sClient Client : vClients)
		{
			PrintClientBalanceLine(Client);
			TotalBalance += Client.AccountBalance;
			cout << endl;
		}
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
	cout << "\t\t\tTotal Balance= " << TotalBalance << endl;
}

void ShowAllClientsScreen()
{
	vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
	cout << "\n\t\t\t\t\tClient List (" << vClients.size() << ") Client(s).";
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
	cout << "| " << left << setw(15) << "Accout Number";
	cout << "| " << left << setw(10) << "Pin Code";
	cout << "| " << left << setw(40) << "Client Name";
	cout << "| " << left << setw(12) << "Phone";
	cout << "| " << left << setw(12) << "Balance";
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
	if (vClients.size() == 0)
		cout << "\t\t\t\tNo Clients Available In the System!";
	else
		for (sClient Client : vClients)
		{
			PrintClientRecordLine(Client);
			cout << endl;
		}
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
}
sUser ConvertLinetoUserRecord(string Line, string Seperator = "#//#")
{
	sUser User;
	vector<string> vUsersData;
	vUsersData = SplitString(Line, Seperator);
	User.Username = vUsersData[0];
	User.Password = vUsersData[1];
	User.permission = stod(vUsersData[2]);
	return User;
}
vector <sUser> LoadUserDataFromFile(string FileName)
{
	vector <sUser> vUsers;
	fstream MyFile;
	MyFile.open(FileName, ios::in);//read Mode
	if (MyFile.is_open())
	{
		string Line;
		sUser User;
		while (getline(MyFile, Line))
		{
			User = ConvertLinetoUserRecord(Line, "#//#");
			vUsers.push_back(User);
		}
		MyFile.close();
	} return vUsers;
}
void ShowAllUserScreen()
{
	vector <sUser> vUsers = LoadUserDataFromFile(UserFileName);
	cout << "\n\t\t\t\t\tUser List (" << vUsers.size() << ") User(s).";
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
	cout << "| " << left << setw(15) << "User Name";
	cout << "| " << left << setw(10) << "Password";
	cout << "| " << left << setw(40) << "Permession";
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
	if (vUsers.size() == 0)
		cout << "\t\t\t\tNo Users Available In the System!";
	else
		for (sUser User : vUsers)
		{
			PrintUserRecordLine(User);
			cout << endl;
		}
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
}
void PrintClientCard(sClient Client)
{
	cout << "\nThe following are the client details:\n";
	cout << "-----------------------------------";
	cout << "\nAccout Number: " << Client.AccountNumber;
	cout << "\nPin Code     : " << Client.PinCode;
	cout << "\nName         : " << Client.Name;
	cout << "\nPhone        : " << Client.Phone;
	cout << "\nAccount Balance: " << Client.AccountBalance;
	cout << "\n-----------------------------------\n";
}
void PrintUserCard(sUser User)
{
	cout << "\nThe following are the User details:\n";
	cout << "-----------------------------------";
	cout << "\nUser Name: " << User.Username;
	cout << "\nPassword     : " << User.Password;
	cout << "\nPermession        : " << User.permission;
	cout << "\n-----------------------------------\n";
}
bool FindClientByAccountNumber(string AccountNumber, vector<sClient> vClients, sClient& Client)
{
	for (sClient C : vClients)
	{
		if (C.AccountNumber == AccountNumber)
		{
			Client = C;
			return true;
		}
	} return false;
}
bool FindUsreByUserName(string UserName, vector<sUser> vUsers, sUser& User)
{
	for (sUser U : vUsers)
	{
		if (U.Username == UserName)
		{
			User = U;
			return true;
		}
	} return false;
}

sClient ChangeClientRecord(string AccountNumber)
{
	sClient Client;
	Client.AccountNumber = AccountNumber;
	cout << "\n\nEnter PinCode? ";
	getline(cin >> ws, Client.PinCode);
	cout << "Enter Name? ";
	getline(cin, Client.Name);
	cout << "Enter Phone? ";
	getline(cin, Client.Phone);
	cout << "Enter AccountBalance? ";
	cin >> Client.AccountBalance;
	return Client;
}
sUser ChangeUserRecord(string UserName)
{
	sUser User;
	User.Username = UserName;
	cout << "\n\nEnter Password? ";
	getline(cin >> ws, User.Password);
	User.permission = GetPermession();
	return User;
}
bool MarkClientForDeleteByAccountNumber(string AccountNumber, vector <sClient>& vClients)
{
	for (sClient& C : vClients)
	{
		if (C.AccountNumber == AccountNumber)
		{
			C.MarkForDelete = true;
			return true;
		}
	}
	return false;
}
bool MarkUserForDeleteByAccountNumber(string UserName, vector <sUser>& vUsers)
{
	for (sUser& U : vUsers)
	{
		if (U.Username == UserName)
		{
			U.MarkForDelete = true;
			return true;
		}
	}
	return false;
}
vector <sClient> SaveCleintsDataToFile(string FileName, vector<sClient> vClients)
{
	fstream MyFile;
	MyFile.open(FileName, ios::out);//overwrite
	string DataLine;
	if (MyFile.is_open())
	{
		for (sClient C : vClients)
		{
			if (C.MarkForDelete == false)
			{
				//we only write records that are not marked for delete.      
				DataLine = ConvertRecordToLine(C, "#//#");
				MyFile << DataLine << endl;
			}
		}
		MyFile.close();
	}
	return vClients;
}
vector <sUser> SaveUsersDataToFile(string FileName, vector<sUser> vUsers)
{
	fstream MyFile;
	MyFile.open(FileName, ios::out);//overwrite
	string DataLine;
	if (MyFile.is_open())
	{
		for (sUser U : vUsers)
		{
			if (U.MarkForDelete == false)
			{
				//we only write records that are not marked for delete.      
				DataLine = ConvertUserRecordToLine(U, "#//#");
				MyFile << DataLine << endl;
			}
		}
		MyFile.close();
	}
	return vUsers;
}
void AddDataLineToFile(string FileName, string stDataLine)
{
	fstream MyFile;
	MyFile.open(FileName, ios::out | ios::app);
	if (MyFile.is_open())
	{
		MyFile << stDataLine << endl;
		MyFile.close();
	}
}
void AddNewClient()
{
	sClient Client;
	Client = ReadNewClient();
	AddDataLineToFile(ClientsFileName, ConvertRecordToLine(Client, "#//#"));
}
void AddNewClients()
{
	char AddMore = 'Y';
	do {
		system("cls");
		cout << "Adding New Client:\n\n";
		AddNewClient();
		cout << "\nClient Added Successfully, do you want to add more clients? Y/N? ";
		cin >> AddMore;
	} while (toupper(AddMore) == 'Y');
}
void AddNewUser()
{
	sUser User;
	User = ReadNewUser();
	AddDataLineToFile(UserFileName, ConvertUserRecordToLine(User, "#//#"));
}
void AddNewUsers()
{
	char AddMore = 'Y';
	do {
		system("cls");
		cout << "Adding New User:\n\n";
		AddNewUser();
		cout << "\nUser Added Successfully, do you want to add more clients? Y/N? ";
		cin >> AddMore;
	} while (toupper(AddMore) == 'Y');
}
bool DeleteClientByAccountNumber(string AccountNumber, vector<sClient>& vClients)
{
	sClient Client;
	char Answer = 'n';
	if (FindClientByAccountNumber(AccountNumber, vClients, Client))
	{
		PrintClientCard(Client);
		cout << "\n\nAre you sure you want delete this client? y/n ? ";
		cin >> Answer;
		if (Answer == 'y' || Answer == 'Y')
		{
			MarkClientForDeleteByAccountNumber(AccountNumber, vClients);
			SaveCleintsDataToFile(ClientsFileName, vClients);
			//Refresh Clients
			vClients = LoadCleintsDataFromFile(ClientsFileName);
			cout << "\n\nClient Deleted Successfully."; return true;
		}
	}
	else
	{
		cout << "\nClient with Account Number (" << AccountNumber << ") is Not Found!";
		return false;
	}
}
bool DeleteUserByUserName(string UserName, vector<sUser>& vUsers)
{
	sUser User;
	char Answer = 'n';
	if (FindUsreByUserName(UserName, vUsers, User))
	{
		PrintUserCard(User);
		cout << "\n\nAre you sure you want delete this User? y/n ? ";
		cin >> Answer;
		if (Answer == 'y' || Answer == 'Y')
		{
			MarkUserForDeleteByAccountNumber(UserName, vUsers);
			SaveUsersDataToFile(UserFileName, vUsers);
			//Refresh Clients
			vUsers = LoadUserDataFromFile(UserFileName);
			cout << "\n\nUser Deleted Successfully.";
			return true;
		}
	}
	else
	{
		cout << "\nUser with User Name (" << UserName << ") is Not Found!";
		return false;
	}
}
bool UpdateClientByAccountNumber(string AccountNumber, vector<sClient>& vClients)
{
	sClient Client;
	char Answer = 'n';
	if (FindClientByAccountNumber(AccountNumber, vClients, Client))
	{
		PrintClientCard(Client);
		cout << "\n\nAre you sure you want update this client? y/n ? ";
		cin >> Answer;
		if (Answer == 'y' || Answer == 'Y')
		{
			for (sClient& C : vClients)
			{
				if (C.AccountNumber == AccountNumber)
				{
					C = ChangeClientRecord(AccountNumber);
					break;
				}
			}
			SaveCleintsDataToFile(ClientsFileName, vClients);
			cout << "\n\nClient Updated Successfully.";
			return true;
		}
	}
	else
	{
		cout << "\nClient with Account Number (" << AccountNumber << ") is Not Found!";
		return false;
	}
}
bool UpdateUserByUserName(string UserName, vector<sUser>& vUsers)
{
	sUser User;
	char Answer = 'n';
	if (FindUsreByUserName(UserName, vUsers, User))
	{
		PrintUserCard(User);
		cout << "\n\nAre you sure you want update this User? y/n ? ";
		cin >> Answer;
		if (Answer == 'y' || Answer == 'Y')
		{
			for (sUser& U : vUsers)
			{
				if (U.Username == UserName)
				{
					U = ChangeUserRecord(UserName);
					break;
				}
			}
			SaveUsersDataToFile(UserFileName, vUsers);
			cout << "\n\nClient Updated Successfully.";
			return true;
		}
	}
	else
	{
		cout << "\nUser with User Name (" << UserName << ") is Not Found!";
		return false;
	}
}
string ReadClientAccountNumber()
{
	string AccountNumber = "";
	cout << "\nPlease enter AccountNumber? ";
	cin >> AccountNumber;
	return AccountNumber;
}
string readusername()
{
	string Username;
	cout << "Enter user name ?";
	getline(cin >> ws, Username);
	return Username;
}
string readPassword()
{
	string Password;
	cout << "Enter Password ?";
	getline(cin >> ws, Password);
	return Password;
}
void ShowDeleteClientScreen()
{
	cout << "\n-----------------------------------\n";
	cout << "\tDelete Client Screen";
	cout << "\n-----------------------------------\n";
	vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
	string AccountNumber = ReadClientAccountNumber();
	DeleteClientByAccountNumber(AccountNumber, vClients);
}
void ShowDeleteUserScreen()
{
	cout << "\n-----------------------------------\n";
	cout << "\tDelete User Screen";
	cout << "\n-----------------------------------\n";
	vector <sUser> vUsers = LoadUserDataFromFile(UserFileName);
	string UserName = readusername();
	if (UserName == "Admin")
	{
		cout << "You can not delete This user\n";
		GoBackToManageMenue();
	}
	else
	{
		DeleteUserByUserName(UserName, vUsers);
	}
}
void ShowUpdateClientScreen()
{
	cout << "\n-----------------------------------\n";
	cout << "\tUpdate Client Info Screen";
	cout << "\n-----------------------------------\n";
	vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
	string AccountNumber = ReadClientAccountNumber();
	UpdateClientByAccountNumber(AccountNumber, vClients);
}
void ShowUpdateUserScreen()
{
	cout << "\n-----------------------------------\n";
	cout << "\tUpdate User Info Screen";
	cout << "\n-----------------------------------\n";
	vector <sUser> vUsers = LoadUserDataFromFile(UserFileName);
	string UserName = readusername();
	UpdateUserByUserName(UserName, vUsers);
}
void ShowAddNewClientsScreen()
{
	cout << "\n-----------------------------------\n";
	cout << "\tAdd New Clients Screen";
	cout << "\n-----------------------------------\n";
	AddNewClients();
}
void ShowAddNewUserScreen()
{
	cout << "\n-----------------------------------\n";
	cout << "\tAdd New User Screen";
	cout << "\n-----------------------------------\n";
	AddNewUsers();
}
void ShowFindClientScreen()
{
	cout << "\n-----------------------------------\n";
	cout << "\tFind Client Screen";
	cout << "\n-----------------------------------\n";
	vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
	sClient Client; string AccountNumber = ReadClientAccountNumber();
	if (FindClientByAccountNumber(AccountNumber, vClients, Client))
		PrintClientCard(Client);
	else
		cout << "\nClient with Account Number[" << AccountNumber << "] is not found!";
}
void ShowFindUserScreen()
{
	cout << "\n-----------------------------------\n";
	cout << "\tFind User Screen";
	cout << "\n-----------------------------------\n";
	vector <sUser> vUsers = LoadUserDataFromFile(UserFileName);
	sUser User;
	string UserName = readusername();
	if (FindUsreByUserName(UserName, vUsers, User))
		PrintUserCard(User);
	else
		cout << "\nUser with UserName[" << UserName << "] is not found!";
}
void ShowEndScreen()
{
	cout << "\n-----------------------------------\n";
	cout << "\tProgram Ends :-)";
	cout << "\n-----------------------------------\n";
}

void GoBackToMainMenue()
{
	cout << "\n\nPress any key to go back to Main Menue...";
	system("pause>0");
	ShowMainMenue();
}
void GoBackToManageMenue()
{
	cout << "\n\nPress any key to go back to Manage User Menue...";
	system("pause>0");
	showManageUsersMenuScreen();
}
void GoBackToTransactionMenue()
{
	cout << "\n\nPress any key to go back to Transaction Menue...";
	system("pause>0");
	showTransactionMenuScreen();
}
short ReadMainMenueOption()
{
	cout << "Choose what do you want to do? [1 to 8]? ";
	short Choice = 0;
	cin >> Choice;
	return Choice;
}
bool DeposittoClientByAccountNumber(string AccountNumber, vector<sClient>& vClients, double amount)
{
	sClient Client;
	char Answer = 'n';
	if (FindClientByAccountNumber(AccountNumber, vClients, Client))
	{
		cout << "\n\nAre you sure you want to Perform this Transaction ? y/n ? ";
		cin >> Answer;
		if (Answer == 'y' || Answer == 'Y')
		{
			for (sClient& C : vClients)
			{
				if (C.AccountNumber == AccountNumber)
				{
					C.AccountBalance += amount;
					SaveCleintsDataToFile(ClientsFileName, vClients);
					cout << "\nDone succesfully New account balance is " << C.AccountBalance;
					return true;
				}
			}
			return false;
		}
	}
}
bool WithdrawfromClientByAccountNumber(string AccountNumber, vector<sClient>& vClients, double amount)
{
	sClient Client;
	char Answer = 'n';
	if (FindClientByAccountNumber(AccountNumber, vClients, Client))
	{
		cout << "\n\nAre you sure you want to Perform this Transaction ? y/n ? ";
		cin >> Answer;
		if (Answer == 'y' || Answer == 'Y')
		{
			for (sClient& C : vClients)
			{
				if (C.AccountNumber == AccountNumber)
				{
					C.AccountBalance -= amount;
					SaveCleintsDataToFile(ClientsFileName, vClients);
					cout << "\nDone succesfully New account balance is " << C.AccountBalance;
					return true;
				}
			}
			return false;
		}
	}
}
void showdepositscreen()
{
	sClient Client;
	cout << "\n-----------------------------------\n";
	cout << "\tDeposit Screen";
	cout << "\n-----------------------------------\n";
	vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
	string AccountNumber = ReadClientAccountNumber();
	while (!FindClientByAccountNumber(AccountNumber, vClients, Client))
	{
		cout << "\nClient with [" << AccountNumber << "] does not exist.\n";
		AccountNumber = ReadClientAccountNumber();
	}
	PrintClientCard(Client);
	double Amount = 0;
	cout << "\nPlease enter deposit amount? ";
	cin >> Amount;
	DeposittoClientByAccountNumber(AccountNumber, vClients, Amount);
}
void showdWithdrawscreen()
{
	sClient Client;
	cout << "\n-----------------------------------\n";
	cout << "\tWithdraw Screen";
	cout << "\n-----------------------------------\n";
	vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
	string AccountNumber = ReadClientAccountNumber();
	while (!FindClientByAccountNumber(AccountNumber, vClients, Client))
	{
		cout << "\nClient with [" << AccountNumber << "] does not exist.\n";
		AccountNumber = ReadClientAccountNumber();
	}
	PrintClientCard(Client);
	double Amount = 0;
	cout << "\nPlease enter Withdraw amount? ";
	cin >> Amount;
	while (Amount > Client.AccountBalance)
	{
		cout << "Amount Exceeds the Balance you can withdraw is up to: " << Client.AccountBalance;
		cout << "\nPlease enter Withdraw amount? ";
		cin >> Amount;
	}
	WithdrawfromClientByAccountNumber(AccountNumber, vClients, Amount);
}
short ReadTransactionOption()
{
	cout << "Choose what do you want to do? [1 to 4]? ";
	short Choice = 0;
	cin >> Choice;
	return Choice;
}
short ReadManageUserOption()
{
	cout << "Choose what do you want to do? [1 to 6]? ";
	short Choice = 0;
	cin >> Choice;
	return Choice;
}
void PerfromTransactionOption(enTransactionMenueOption TransactionMenueOption)
{
	switch (TransactionMenueOption)
	{
	case enTransactionMenueOption::eDeposit:
	{
		system("cls");
		showdepositscreen();
		GoBackToTransactionMenue();
		break;
	}
	case enTransactionMenueOption::eWithdraw:
	{	system("cls");
	showdWithdrawscreen();
	GoBackToTransactionMenue();
	break;
	}
	case enTransactionMenueOption::eTotalBalance:
	{
		system("cls");
		ShowTotalBalanceScreen();
		GoBackToTransactionMenue();
		break;
	}

	case  enTransactionMenueOption::eMainmenue:
	{
		system("cls");
		ShowMainMenue();
		break;
	}
	}
}
void PerfromManageUserOption(enManageUserOption  ManageUserOption)
{
	switch (ManageUserOption)
	{
	case enManageUserOption::List_Users:
	{
		system("cls");
		ShowAllUserScreen();
		GoBackToManageMenue();
	}
	case enManageUserOption::Add_NewUser:
	{
		system("cls");
		ShowAddNewUserScreen();
		GoBackToManageMenue();
	}
	case enManageUserOption::Delete_User:
	{
		system("cls");
		ShowDeleteUserScreen();
		GoBackToManageMenue();
	}
	case  enManageUserOption::Update_User:
	{
		system("cls");
		ShowUpdateUserScreen();
		GoBackToManageMenue();
	}
	case  enManageUserOption::Find_User:
	{
		system("cls");
		ShowFindUserScreen();
		GoBackToManageMenue();
	}
	case  enManageUserOption::MainMenue:
	{
		system("cls");
		ShowMainMenue();
		break;
	}
	}
}
void showManageUsersMenuScreen()
{
	system("cls");
	cout << "===========================================\n";
	cout << "\t\tManage Users Menue Screen\n";
	cout << "===========================================\n";
	cout << "\t[1] List Users.\n";
	cout << "\t[2] Add New User.\n";
	cout << "\t[3] Delete User.\n";
	cout << "\t[4] Update User.\n";
	cout << "\t[5] Find User.\n";
	cout << "\t[6] Main Menue.\n";
	cout << "===========================================\n";
	PerfromManageUserOption((enManageUserOption)ReadManageUserOption());
}
void showTransactionMenuScreen()
{
	system("cls");
	cout << "===========================================\n";
	cout << "\t\tTransaction Menue Screen\n";
	cout << "===========================================\n";
	cout << "\t[1] Deosit.\n";
	cout << "\t[2] Withdraw.\n";
	cout << "\t[3] Total Balance.\n";
	cout << "\t[4] Main Menue.\n";
	cout << "===========================================\n";
	PerfromTransactionOption((enTransactionMenueOption)ReadTransactionOption());
}
void ShowAccessDeniedScreen()
{
	cout << "Access denied you d'ont have permession to do this ,Please Contact your Admin\n";
}
void PerfromMainMenueOption(enMainMenueOptions MainMenueOption)
{

	switch (MainMenueOption)
	{
	case enMainMenueOptions::eListClients:
	{
		system("cls");
		ShowAllClientsScreen();
		GoBackToMainMenue();
		break;
	}
	case enMainMenueOptions::eAddNewClient:
	{	system("cls");
	ShowAddNewClientsScreen();
	GoBackToMainMenue();
	break;
	}
	case enMainMenueOptions::eDeleteClient:
	{
		system("cls");
		ShowDeleteClientScreen();
		GoBackToMainMenue();
		break;
	}

	case enMainMenueOptions::eUpdateClient:
	{
		system("cls");
		ShowUpdateClientScreen();
		GoBackToMainMenue();
		break;
	}
	case enMainMenueOptions::eFindClient:
	{
		system("cls");
		ShowFindClientScreen();
		GoBackToMainMenue();
		break;
	}
	case enMainMenueOptions::eTransactionMenue:
	{
		system("cls");
		showTransactionMenuScreen();
		break;
	}
	case enMainMenueOptions::ManageUsers:
	{
		system("cls");
		showManageUsersMenuScreen();
		break;
	}
	case enMainMenueOptions::Logout:
	{
		system("cls");
		Login();
		break;
	}

	}

}

void ShowMainMenue()
{
	system("cls");
	cout << "===========================================\n";
	cout << "\t\tMain Menue Screen\n";
	cout << "===========================================\n";
	cout << "\t[1] Show Client List.\n";
	cout << "\t[2] Add New Client.\n";
	cout << "\t[3] Delete Client.\n";
	cout << "\t[4] Update Client Info.\n";
	cout << "\t[5] Find Client.\n";
	cout << "\t[6] Transaction.\n";
	cout << "\t[7] Manage Users.\n";
	cout << "\t[8] Logout.\n";
	cout << "===========================================\n";
	PerfromMainMenueOption((enMainMenueOptions)ReadMainMenueOption());
}

void Login()
{
	cout << "\n-----------------------------------\n";
	cout << "\tLogin Screen";
	cout << "\n-----------------------------------\n";
	vector <sUser> vUsers = LoadUserDataFromFile(UserFileName);
	sUser User;
	string Username;
	string Paswword;
	do {
		Username = readusername();
		Paswword = readPassword();
		if (!FindUserByUserNameandPassword(Username, Paswword, vUsers, User))
			cout << "Invalid UserName/password\n";
	} while (!FindUserByUserNameandPassword(Username, Paswword, vUsers, User));
	ShowMainMenue();
}
int main()
{
	Login();
	system("pause>0");
	return 0;
}
