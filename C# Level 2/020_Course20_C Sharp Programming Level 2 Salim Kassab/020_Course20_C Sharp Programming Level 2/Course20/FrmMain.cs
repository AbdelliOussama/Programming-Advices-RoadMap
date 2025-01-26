using Course20.Events.MakeSimpleEvent;
using Course20.Events.NewOrderEvent_05.Classes;
using Course20.Events.NewOrderEvent_05.Classes.Services;
using Course20.Events.NewOrderEvent_05.Forms;
using Course20.Events.NewsPublisher_04;
using Course20.Events.NewsPublisher_04.Classes;
using Course20.Events.NewsPublisher_04.Forms.Subscribers;
using Course20.Events.SimpleEventWithParametersUsingArguments_02;
using Course20.Events.TemperatureChangeEventExample_03;
using Course20.Lesson1;
using Course20.MoreAboutDelegation.LoggerExample_01;
using Course20.MoreAboutUserControls.PoolClubProject_02;
using Course20.MoreAboutUserControls.TraficLightProject_01.MyTrafficLight_01;
using Course20.TraficLight_008;
using Course20.UserControlsExposeProperty;

namespace Course20
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			poolClub();
		}

		/////////////////////// Lesson1: Send Data Back To Form Using Delegate //////////////////////
		// without delegate
		private void sendDataFromFrm2ToFrm1WithoutDelegate()
		{
			Frm1 frm1 = new();
			frm1.ShowDialog();
		}

		//using delegate
		private void sendDataFromFrm2ToFrm1UsingTheDelegate()
		{
			Lesson1_001.Send_Data_from_Form1_To_Form2_using_Delegate.Form1 frm = new();
			frm.ShowDialog();
		}

		/////////////////////////   User Controls Expose Property ////////////////////////////////////////////
		private void userControlsExposeProperty()
		{
			FrmSimpleCalc frmSimpleCalc = new();
			frmSimpleCalc.ShowDialog();
		}

		/////////////////////////   Simple Event With Parameter /////////////////
		private void simpleEventWithParameter()
		{
			FrmMakeSimpleEvent frm = new();
			frm.ShowDialog();
		}

		/////////////////////////    Simple Event With Parameters Using Arguments /////////////////
		private void simpleEventWithParametersUsingArguments()
		{
			FrmSimpleCalc2 frm = new();
			frm.ShowDialog();
		}

		///////////////////////// Temperature Change Event Example /////////////////
		private void temperatureChangeEventExample()
		{
			FrmThermostat frm = new();
			frm.ShowDialog();
		}

		///////////////////////// News Publisher /////////////////

		public static ArticlePublisher articlesPublisher;
		public static FrmSubscriber subscriber1;
		public static FrmSubscriber subscriber2;

		private void newPublisher()
		{
			ArticlePublisher publisher = new();
			articlesPublisher = publisher;

			FrmArticlesPublisherHome home = new();
			home.Show();

			FrmSubscriber frmSubscriber1 = new(1);
			subscriber1 = frmSubscriber1;
			subscriber1.Show();

			FrmSubscriber frmSubscriber2 = new(2);
			subscriber1 = frmSubscriber2;
			subscriber1.Show();
		}

		/////////////////////////  New Order Event /////////////////

		public static Order orderAlarm = new();
		public static Order shippingServiceAlarm = new();

		private void newOrderEvent()
		{
			FrmShoppingMarketHome frmShoppingMarketHome = new();
			frmShoppingMarketHome.Show();

			Order order = new();
			orderAlarm = order;

			EmailService emailService = new();
			emailService.subscribe(order);

			ShippingService shippingService = new();
			shippingService.subscribe(order);
		}

		/////////////////////////  Logger Example /////////////////

		private void loggerExample(string errorMessage)
		{
			Logger logToScreen = new(LogType.onScreen);
			Logger logToFile = new(LogType.toFile);

			logToScreen.log(errorMessage);
			//logToFile.log(errorMessage);
		}

		/////////////////////////  My Traffic Light /////////////////
		private void myTrafficLight()
		{
			FrmMyTrafficLight frm = new();
			frm.ShowDialog();
		}

		/////////////////////////  Traffic Light Game /////////////////
		private void trafficLightGame()
		{
			FrmStreet frmStreet = new();
			frmStreet.ShowDialog();
		}

		/////////////////////////  Pool Club /////////////////
		private void poolClub()
		{
			FrmPoolClub frmPoolClub = new();
			frmPoolClub.ShowDialog();
		}
	}
}