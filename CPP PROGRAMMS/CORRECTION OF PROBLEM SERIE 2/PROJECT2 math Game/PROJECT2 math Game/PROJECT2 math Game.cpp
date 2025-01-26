#include<iostream>
#include<cstdlib>
using namespace std;
enum enGame_level_option{easy=1,medium=2,Hard=3,mx=4 };
enum enoperation_type{Add=1,Sub=2,Mul=3,Div=4,Mix=5 };
enum enRightWrong{Wright_answer=1,Wrong_answer=2};
enum enpass_fail{Pass=1,Fail=2};
struct stquestion_info
{
	int question_number;
	int number1;
	int number2;
	char op_type;
	float correct_answer;
	float my_answer;
	enRightWrong answer_result;
};

struct stgame_result
{
	int number_of_question;
	enGame_level_option question_level;
	enoperation_type operation_type;
	int number_of_rightanswers=0;
	int number_of_wronganswers=0;
	enpass_fail Final_result;
};

char symbole_of_operator(enoperation_type op_type)
{
	char arrof_operator[4] = { '+','-','*','/' };
	return arrof_operator[op_type - 1];
}
string questionresult_name(enRightWrong answer)
{
	string arrquestionanswer[2] = { "Right answer:-)","Wrong answer :-(" };
	return arrquestionanswer[answer];
}
string Final_result_name(enpass_fail result)
{
	string final_result_name = "";
	if (result == enpass_fail::Pass)
		return final_result_name + "Pass -:)";
	else
		return final_result_name + "Fail-:(";
}
string operation_type_name(enoperation_type optype)
{
	string arroptype_name[5] = { "Add" ,"Sub" ,"Mul" ,"Div" ,"Mix" };
	return arroptype_name[optype - 1];
}
string questionlevel_name(enGame_level_option question_level)
{
	string arrlevel_name[4] = { "easy","Medium","Hard","Mix" };
	return arrlevel_name[question_level - 1];
}
enGame_level_option question_level()
{
	int questionlevel=1;
	do {
		cout << "Enter question_level[1]easy,[2]Med,[3]Hard,[4]Mix\n";
		cin >> questionlevel;
	} while (questionlevel < 1 || questionlevel>4);
	return (enGame_level_option) questionlevel;
}

enoperation_type operation_type()
{
	int operationtype;
	do
	{
		cout << "Eenter operation type[1]Add,[2]Sub,[3]Mul,[4]Div,[5]Mix \n";
		cin >> operationtype;
	} while (operationtype < 1 || operationtype>5);
	return (enoperation_type)operationtype;
}
int read_number(string message)
{
	int number;
	cout << message;
	cin >> number; 
	cout << endl;
	return number;
}
int randomnumber(int from, int to)
{
	int randomnumber=rand()%(to-from+1)+1;
	return randomnumber;
}
void reset_screen()
{
	system("cls");
	system("color 0F");
}

/*enGame_level_option choose_game_level(enGame_level_option level_option)
{
	switch (level_option)
	{
	
	}
}*/
char selectoperator(enoperation_type op_type)
{
	switch (op_type)
	{
		case  enoperation_type::Add:
			return symbole_of_operator(enoperation_type::Add); break;
		case enoperation_type::Sub:
			return symbole_of_operator(enoperation_type::Sub); break;
		case enoperation_type::Mul:
			return symbole_of_operator(enoperation_type::Mul); break;
		case enoperation_type::Div:
			return symbole_of_operator(enoperation_type::Div); break;
		default:return symbole_of_operator((enoperation_type)randomnumber(1,4));

	}
}
float calculate_question_result(stquestion_info questioninfo)
{
	switch (questioninfo.op_type)
	{
	case '+':
		return questioninfo.number1 + questioninfo.number2;
	case '-':
		return questioninfo.number1 - questioninfo.number2;
	case '*':
		return questioninfo.number1 * questioninfo.number2;
	default: return (float)questioninfo.number1 / (float)questioninfo.number2;
	}
}
void print_question(stquestion_info questioninfo)
{
	cout << questioninfo.number1 << endl;
	cout << questioninfo.number2;
	cout << " " << questioninfo.op_type << endl;
	cout << "\n_____________\n";
}
enRightWrong check_question_result(stquestion_info question_info)
{
	if (question_info.my_answer == question_info.correct_answer)
		return enRightWrong::Wright_answer;
	else 
		return enRightWrong::Wrong_answer;
}
void print_question_result(stquestion_info questioninfo)
{
	if (questioninfo.answer_result == enRightWrong::Wright_answer)
	{
		cout << questionresult_name(questioninfo.answer_result);
	}
	else
	{
		cout << questionresult_name(questioninfo.answer_result);
		cout << "the correct answer is:" << questioninfo.correct_answer;
	}
}
stgame_result FillGameResults(int number_of_questions, int number_of_right_answers, int number_of_wrong_answers)
{
	stgame_result game_result;
	game_result.number_of_question = number_of_questions;
	game_result.question_level = question_level();
	game_result.operation_type = operation_type();
	game_result.number_of_rightanswers = number_of_right_answers;
	game_result.number_of_wronganswers = number_of_wrong_answers;
	return game_result;
}
stgame_result play_game(enoperation_type operationtype,enGame_level_option question_level, int number_of_questions)
{
	stquestion_info question_info;
	short number_of_right_answers=0, number_of_wrong_answers=0;
	for (int i = 1; i <= number_of_questions; i++)
	{
		cout << "Question[" << i << "/" << number_of_questions << "]\n";
		question_info.number1 = randomnumber(1, 10);
		question_info.number2= randomnumber(1, 10);
		question_info.op_type = selectoperator(operationtype);
		print_question(question_info);
		question_info.my_answer = read_number("");
		question_info.correct_answer = calculate_question_result(question_info);
		question_info.answer_result = check_question_result(question_info);
		print_question_result(question_info);
		cout << endl;
		if (question_info.answer_result == enRightWrong::Wrong_answer)
			number_of_right_answers++;
		else
			number_of_wrong_answers++;
	}
	return FillGameResults(number_of_questions, number_of_right_answers, number_of_wrong_answers);

}
void show_final_result_screen(enpass_fail result)
{
	cout << "\n_______________________________________________\n";
	cout << "\nFinal Resultis  " + Final_result_name(result);
	cout << "\n_______________________________________________\n";
}

void show_game_final_result(stgame_result game_result)
{
	cout << "number of questions :" << game_result.number_of_question << endl;
	cout << "Question level :" << questionlevel_name( game_result.question_level) << endl;
	cout << "operation type: " << operation_type_name(game_result.operation_type);
	cout << "Number of Right answer: " << game_result.number_of_rightanswers << endl;
	cout << "Number ofWrong answer: " << game_result.number_of_wronganswers << endl;
	cout << "\n______________________________________________________________\n";
}
void start_game()
{
	char play_again = 'Y';
	do
	{
		reset_screen();
		stgame_result game_result = play_game(operation_type(), question_level(), read_number("how many question do you want to paly\n") );
		show_final_result_screen(game_result.Final_result);
		show_game_final_result(game_result);
		cout << "Do you want to play again ?\n";
		cin >> play_again;
		cout<< endl;
	} while (play_again == 'y' || play_again == 'Y');
}
int main()
{
	srand((unsigned)time(NULL));
	start_game();
}

