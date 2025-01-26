using static Course20.Events.TemperatureChangeEventExample_03.Thermostat;

namespace Course20.Events.TemperatureChangeEventExample_03
{
    public partial class FrmThermostat : Form
    {
        private decimal _currentTemperature = 15;
        public FrmThermostat() => InitializeComponent();
        private void FrmThermostat_Load(object sender, EventArgs e) => lblTemperatureAlarmLabel.Hide();

        private void subscribe(Thermostat thermostat) => thermostat.temperatureChanged += thermostatSubscribe;
        private void thermostatSubscribe(object sender, TemperatureChangedEventArgs e) => _currentTemperature = e.CurrentTemperature;

        private void shared(decimal temperature)
        {
            if (temperature > 30 || temperature < -10)
            {
                lblTemperatureAlarmLabel.Show();
                lblTemperatureAlarmLabel.Text = "Temperature Range\n must be between\n +30 and -10";
                return;
            }

            lblTemperatureAlarmLabel.Hide();

            Thermostat thermostat = new();
            subscribe(thermostat);
            thermostat.setTemperature(temperature);

            lblCurrentTemperature.Text = $"{_currentTemperature:00.00} C";
        }

        private void btnIncrementTemperature_Click(object sender, EventArgs e) => shared(++_currentTemperature);
        private void btnDecrementTemperature_Click(object sender, EventArgs e) => shared(--_currentTemperature);

        private void btnReset_Click(object sender, EventArgs e)
        {
            _currentTemperature = 15;
            lblCurrentTemperature.Text = $"{_currentTemperature:00.00} C";
        }
    }
}