namespace Course20.Events.TemperatureChangeEventExample_03
{
    public class Thermostat
    {
        public decimal OldTemperature { get; private set; }
        public decimal CurrentTemperature { get; private set; }

        public class TemperatureChangedEventArgs : EventArgs
        {
            public decimal OldTemperature { get; }
            public decimal CurrentTemperature { get; }

            public TemperatureChangedEventArgs(decimal oldTemperature, decimal currentTemperature)
            {
                OldTemperature = oldTemperature;
                CurrentTemperature = currentTemperature;
            }
        }

        public event EventHandler<TemperatureChangedEventArgs> temperatureChanged;
        public void onTemperatureChanged(decimal oldTemperature, decimal currentTemperature) => onTemperatureChanged(new TemperatureChangedEventArgs(oldTemperature, currentTemperature));
        protected void onTemperatureChanged(TemperatureChangedEventArgs e) => temperatureChanged?.Invoke(this, e);


        public void setTemperature(decimal newTemperature)
        {
            if (newTemperature != CurrentTemperature)
            {
                OldTemperature = CurrentTemperature;
                CurrentTemperature = newTemperature;
                onTemperatureChanged(OldTemperature, CurrentTemperature);
            }
        }
    }
}