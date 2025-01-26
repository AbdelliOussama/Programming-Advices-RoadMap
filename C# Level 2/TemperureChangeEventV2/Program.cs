using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace TemperureChangeEventV2
{
    public class TemperatureChangedEventArgs : EventArgs
    {
        public double OldTemperatue { get; }
        public double CurrentTemperature { get; }
        public double Difference { get; }


        public TemperatureChangedEventArgs(double oldTemperatue, double currentTemperature)
        {
            OldTemperatue = oldTemperatue;
            CurrentTemperature = currentTemperature;
            Difference = currentTemperature - OldTemperatue;
        }
    }


    public class Thermostat
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        public double OldTemperature { get; set; }
        public double CurrentTemperature { set; get; }

        public void SetTemperature(double NewTemperature)
        {
            if (NewTemperature != CurrentTemperature)
            {
                OldTemperature = CurrentTemperature;
                CurrentTemperature = NewTemperature;
                OnTemperatureChanged(OldTemperature,CurrentTemperature);

            }
        }

        public void OnTemperatureChanged(double OldTemperature,double CurrentTemperature)
        {
            OnTemperatureChanged(new TemperatureChangedEventArgs(OldTemperature,CurrentTemperature));
        }
        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }

    }


    public class Display
    {
        public void Subscribe(Thermostat thermostat)
        {
            thermostat.TemperatureChanged += ShowScreen;
        }

        public void ShowScreen(object sender,TemperatureChangedEventArgs e)
        {
            Console.WriteLine("The Temperature Changed !:)!");
            Console.WriteLine("The Old Temperature was  = "+e.OldTemperatue);
            Console.WriteLine("The Current Temperature is  = " + e.CurrentTemperature);
            Console.WriteLine("The Difference of  Temperature is  = " + e.Difference);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat();
            Display display = new Display();
            display.Subscribe(thermostat);

            thermostat.SetTemperature(10);

            Console.WriteLine("_________________________________");

            thermostat.SetTemperature(16);




            Console.ReadKey();

        }
    }
}
