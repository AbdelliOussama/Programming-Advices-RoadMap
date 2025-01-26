using Course20.Properties;

namespace Course20.TraficLight_008
{
    public partial class CtrlTraficLight : UserControl
    {
        public enum enLightColors { Red, Orange, Green }
        private enLightColors _currentLight = enLightColors.Red;
        private enLightColors _lightAfterOrangeGreenOrRed;
        private int _redTime = 10;
        private int _orangeTime = 3;
        private int _greenTime = 10;
        private int _currentCountDownValue;

        public CtrlTraficLight() => InitializeComponent();

        public class TraficLightEventArgs : EventArgs
        {
            public enLightColors CurrentLight { get; }
            public int LightDuration { get; }

            public TraficLightEventArgs(enLightColors CurrentLight, int LightDuration)
            {
                this.CurrentLight = CurrentLight;
                this.LightDuration = LightDuration;
            }
        }

        public event EventHandler<TraficLightEventArgs> RedLightOn;
        public void RaiseRedLightOn()
        {
            RaiseRedLightOn(new TraficLightEventArgs(enLightColors.Red, _redTime));
        }
        protected virtual void RaiseRedLightOn(TraficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }

        public event EventHandler<TraficLightEventArgs> RedLightOff;

        public void RaiseRedLightOff()
        {
            RaiseRedLightOff(new TraficLightEventArgs(enLightColors.Orange, _orangeTime));
        }

        protected virtual void RaiseRedLightOff(TraficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }


        public event EventHandler<TraficLightEventArgs> OrangeLightOn;
        public void RaiseOrangeLightOn()
        {
            RaiseOrangeLightOn(new TraficLightEventArgs(enLightColors.Orange, _orangeTime));
        }
        protected virtual void RaiseOrangeLightOn(TraficLightEventArgs e)
        {
            OrangeLightOn?.Invoke(this, e);
        }


        public event EventHandler<TraficLightEventArgs> GreenLightOn;
        public void RaiseGreenLightOn()
        {
            RaiseGreenLightOn(new TraficLightEventArgs(enLightColors.Green, _greenTime));
        }
        protected virtual void RaiseGreenLightOn(TraficLightEventArgs e)
        {
            GreenLightOn?.Invoke(this, e);
        }

        public event EventHandler<TraficLightEventArgs> GreenLightOff;
        public void RaiseGreenLightOff()
        {
            RaiseGreenLightOff(new TraficLightEventArgs(enLightColors.Orange, _orangeTime));
        }
        protected virtual void RaiseGreenLightOff(TraficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }

        public enLightColors CurrentLight
        {
            get
            {
                return _currentLight;
            }

            set
            {
                _currentLight = value;

                switch (_currentLight)
                {
                    case enLightColors.Red:
                        pbLight.Image = Resources.Red;
                        lblCountDown.ForeColor = Color.Red;
                        //  _currentCountDownValue = RedTime;
                        //  lblCountDown.Text = _currentCountDownValue.ToString();
                        break;
                    case enLightColors.Orange:
                        pbLight.Image = Resources.Orange;
                        lblCountDown.ForeColor = Color.Orange;
                        // _currentCountDownValue = OrangeTime;
                        // lblCountDown.Text = _currentCountDownValue.ToString();
                        break;
                    case enLightColors.Green:
                        pbLight.Image = Resources.Green;
                        lblCountDown.ForeColor = Color.Green;
                        // _currentCountDownValue = GreenTime;
                        //  lblCountDown.Text = _currentCountDownValue.ToString();
                        break;
                    default:
                        lblCountDown.ForeColor = Color.Red;
                        // _currentCountDownValue = RedTime;
                        //  lblCountDown.Text = _currentCountDownValue.ToString();
                        break;
                }

            }

        }


        public int RedTime
        {
            get
            {
                return _redTime;
            }
            set
            {
                _redTime = value;

            }
        }

        public int OrangeTime
        {
            get
            {
                return _orangeTime;
            }
            set
            {
                _orangeTime = value;
            }
        }

        public int GreenTime
        {
            get
            {
                return _greenTime;
            }
            set
            {
                _greenTime = value;
            }
        }

        public int GetCurrentTime()
        {

            switch (_currentLight)
            {
                case enLightColors.Orange:
                    return OrangeTime;

                case enLightColors.Green:
                    return GreenTime;
                case enLightColors.Red:
                    return RedTime;
                default: return RedTime;
            }



        }


        public void Start()
        {
            _currentCountDownValue = GetCurrentTime();
            lightTimer.Start();

        }

        public void Stop()
        {
            lightTimer.Stop();

        }

        private void lightTimer_Tick(object sender, EventArgs e)
        {
            lblCountDown.Text = _currentCountDownValue.ToString();
            if (_currentCountDownValue == 0)
            {
                // LightTimer.Stop();
                _changeLight();

            }
            else
            {
                --_currentCountDownValue;
            }

        }

        private void _changeLight()
        {
            switch (_currentLight)
            {
                case enLightColors.Red:
                    _lightAfterOrangeGreenOrRed = enLightColors.Green;
                    CurrentLight = enLightColors.Orange;
                    _currentCountDownValue = OrangeTime;
                    lblCountDown.Text = _currentCountDownValue.ToString();

                    RaiseOrangeLightOn();

                    break;

                case enLightColors.Orange:
                    if (_lightAfterOrangeGreenOrRed == enLightColors.Green)
                    {
                        CurrentLight = enLightColors.Green;
                        _currentCountDownValue = GreenTime;
                        lblCountDown.Text = _currentCountDownValue.ToString();

                        RaiseGreenLightOn();


                    }
                    else
                    {
                        CurrentLight = enLightColors.Red;
                        _currentCountDownValue = RedTime;
                        lblCountDown.Text = _currentCountDownValue.ToString();
                        RaiseRedLightOn();



                    }

                    break;

                case enLightColors.Green:
                    _lightAfterOrangeGreenOrRed = enLightColors.Red;

                    CurrentLight = enLightColors.Orange;
                    _currentCountDownValue = OrangeTime;
                    lblCountDown.Text = _currentCountDownValue.ToString();
                    RaiseOrangeLightOn();

                    break;

                default:
                    pbLight.Image = Resources.Red;
                    break;
            }


        }
    }
}
