#include<iostream>
#include<string>
#include<cstdlib>
using namespace std;
enum enchoice{stone=1,paper=2,scissor=3};
enum enwinner{player=1,computer=2,draw=3};
struct stroundinfo
{
	short round_number = 0;
	enchoice player_choice;
	enchoice computer_choice;
	enwinner round_winner;
	string winner_name="";
};
struct stgameresult
{
	short game_rounds = 0;
	short player_won_times;
	short computer_won_times;
	short draw_times;
	enwinner gamewinner;
	string winner_name="";

};
int random_number(int from, int to)
{
	int random_number = rand() % (to - from + 1) + 1;
}
enchoice read_player_choice()
{
	int player_choice;
	do
	{
		cin >> player_choice;

	} while (player_choice > 3 || player_choice < 1);
	return (enchoice)player_choice;
}
enchoice get_computer_choice()
{
	int computer_choice = random_number(1, 3);
	return enchoice(computer_choice);
}
int how_many_rounds()
{
	int number_of_round=0;
	do
	{
		cout << "how many rounds you will play\n";
		cin >> number_of_round;
	} while (number_of_round < 1 || number_of_round>10);
}
enwinner how_won_the_round(stroundinfo round_info)
{
	if (round_info.computer_choice == round_info.player_choice)
		return enwinner::draw;
	switch (round_info.player_choice)
	{
	case enchoice::paper:
		if (round_info.computer_choice == enchoice::scissor)
			return enwinner::computer; break;
	case enchoice::scissor:
		if (round_info.computer_choice == enchoice::stone)
			return enwinner::computer; break;
	case enchoice::stone:
		if (round_info.computer_choice == enchoice::paper)
			return enwinner::computer; break;
	}
	return enwinner::player;
}
string winner_name(enwinner winner)
{
	string arrwinner_name[3]={"player","computer","draw"};
	return arrwinner_name[winner - 1];

}
string choice_name(enchoice choice)
{
	string arrchoice_name[3] = { "Stone","Paper","Scissor" };
	return arrchoice_name[choice - 1];
}
void Set_Winner_Screen_Color(enwinner winner)
{
	switch (winner)
	{
	case enwinner::player:
		 system("color 2F"); break;
	case enwinner::computer:
		system("color 4F"); break;
	default:   system("color 6F"); 
		break;
	}
}
void print_round_result(stroundinfo round_info)
{
	cout << "\n____________Round [" << round_info.round_number << "] ____________\n\n";
	cout << "Player1  Choice: " << choice_name(round_info.player_choice) << endl;
	cout << "Computer Choice: " << choice_name(round_info.computer_choice) << endl;
	cout << "Round Winner   : [" << round_info.winner_name << "] \n";
	cout << "__________________________________\n" << endl;
	Set_Winner_Screen_Color(round_info.round_winner);
}

stgameresult Fill_Game_Results(int how_many_rounds, int player_won_times, int computer_won_times, int  draw_times)
{
	stgameresult game_result;
	game_result.game_rounds = how_many_rounds;
	game_result.player_won_times = player_won_times;
	game_result.computer_won_times = computer_won_times;
	game_result.draw_times = draw_times;
	return game_result;
}

stgameresult playgame(int number_of_rounds)
{
	stroundinfo round_info;
	int player_won_times = 0, computer_won_times = 0, draw_times = 0;
	for (int i = 1; i <= number_of_rounds; i++)
	{
		cout << "Round[" << i << "]Begin\n";
		round_info.player_choice = read_player_choice();
		round_info.computer_choice = get_computer_choice();
		round_info.winner_name = how_won_the_round(round_info);
		round_info.winner_name = winner_name(round_info.round_winner);
		if (round_info.round_winner == enwinner::player)
			player_won_times++;
		else if (round_info.round_winner == enwinner::computer)
			computer_won_times++;
		else
			draw_times++;
		print_round_result(round_info);
	}
	return Fill_Game_Results(number_of_rounds, player_won_times, computer_won_times, draw_times);
}
string tabs(int number_of_tabs)
{
	string t = "";
	for (int i = 0; i <= number_of_tabs; i++)
	{
		t += "\t";
		cout << "t";

	}
	return t;
}
void show_game_over_screen()
{
	cout << tabs(2) << "\n________________________________________________\n";
	cout << tabs(2) << "                    +++GameOver+++                   ";
	cout << tabs(2) << "\n________________________________________________\n";
}
void resetscreen()
{
	system("cls");
	system("color 0F");
}
void show_final_result_screen(stgameresult game_result)
{
	cout << tabs(2) << "_____________________ [Game Results ]_____________________\n\n";
	cout << tabs(2) << "Game Rounds        : " << game_result.game_rounds << endl;
	cout << tabs(2) << "Player1 won times  : " << game_result.player_won_times << endl;
	cout << tabs(2) << "Computer won times : " << game_result.computer_won_times << endl;
	cout << tabs(2) << "Draw times         : " << game_result.draw_times << endl;
	cout << tabs(2) << "Final Winner       : " << game_result.winner_name << endl;
	cout << tabs(2) << "___________________________________________________________\n";
	Set_Winner_Screen_Color(game_result.gamewinner);
}
void startgame()
{
	char playagain = 'Y';
	do
	{
		resetscreen();
		stgameresult gameresult = playgame(how_many_rounds());
		show_game_over_screen();
		show_final_result_screen(gameresult);
		cout << endl << tabs(3) << "Do you want to play again? Y/N? ";
		cin >> playagain;

	} while (playagain == 'y' || playagain == 'Y');

}
int main()
{
	srand((unsigned)time(NULL));
	startgame();

}