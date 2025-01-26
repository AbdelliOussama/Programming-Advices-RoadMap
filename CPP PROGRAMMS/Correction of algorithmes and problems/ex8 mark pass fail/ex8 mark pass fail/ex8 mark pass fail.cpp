#include <iostream>
#include<string>
using namespace std;
enum enpassfail{pass=1,fail=2};
int readmark()
{
	int mark;
	cout << "enter your mark\n";
	cin >> mark;
	return mark;
}
enpassfail checkmark(int mark)
{
	
	if (mark > 50)
		return enpassfail::pass;
	else
		return enpassfail::fail;
}
void printresult(int mark)
{
	if (checkmark(mark) == enpassfail::pass)
		cout << "\nyou passed"<<endl;
	else
		cout << "\nyou failed"<<endl;
}

int main()
{
	printresult(readmark());
}
