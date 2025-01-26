using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trafic_Light_My_Version.Properties;
using System.Threading;

namespace Trafic_Light_My_Version
{
    public partial class ctrlTraficLight : UserControl
    {
        public enum enTraficLightColor { red = 1 ,yellow = 2 ,green = 3 }
        private enTraficLightColor _CurrentLightColor  = enTraficLightColor.red;

       


        public class TraficLightEventArgs : EventArgs
        {
            public enTraficLightColor CurrentLightColor { get; }
            public int LightDuration {  get;  }

            public TraficLightEventArgs(enTraficLightColor color,int Time)
            {
                this.CurrentLightColor = color;
                this.LightDuration = Time;
            }
        }

        public event EventHandler<TraficLightEventArgs>RedLightOn;


        public void RaiseRedLightOn()
        {
            RaiseRedLightOn(new TraficLightEventArgs(enTraficLightColor.red, _RedLightTime));
        }
        protected virtual void RaiseRedLightOn(TraficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }

        public event EventHandler<TraficLightEventArgs>RedLightOff;

        public void RaiseRedLightOff()
        {
            RaiseRedLightOff(new TraficLightEventArgs(enTraficLightColor.yellow,_YellowLightTime));
        }
        protected virtual void RaiseRedLightOff(TraficLightEventArgs e)
        {
            RedLightOff?.Invoke(this, e);
        }

        public event  EventHandler<TraficLightEventArgs>YellowLightOn;


        public void RaiseYellowLightOn()
        {
            RaiseYellowLightOn(new TraficLightEventArgs(enTraficLightColor.yellow, _YellowLightTime));
        }
        protected virtual void RaiseYellowLightOn(TraficLightEventArgs e)
        {
            YellowLightOn?.Invoke(this, e);
        }


        public event EventHandler<TraficLightEventArgs> GreenLightOn;


        public void RaiseGreenLightOn()
        {
            RaiseGreenLightOn(new TraficLightEventArgs(enTraficLightColor.green, _GreenLightTime));
        }
        protected virtual void RaiseGreenLightOn(TraficLightEventArgs e)
        {
            GreenLightOn?.Invoke(this, e);
        }

        public event EventHandler<TraficLightEventArgs> GreenLightOff;

        public void RaiseGreenLightOff()
        {
            RaiseGreenLightOff(new TraficLightEventArgs(enTraficLightColor.yellow, _YellowLightTime));
        }
        protected virtual void RaiseGreenLightOff(TraficLightEventArgs e)
        {
            GreenLightOff?.Invoke(this, e);
        }

        public enTraficLightColor CurrentLightColor
        {
            get { return _CurrentLightColor; }
            set
            {
                _CurrentLightColor = value;

                switch(_CurrentLightColor)
                {
                    case enTraficLightColor.red:
                        pbTraficLight.Image = Resources.Red;
                        lblCounterDown.ForeColor = Color.Red;
                        break;
                    case enTraficLightColor.green:
                        pbTraficLight.Image= Resources.Green;
                        lblCounterDown.ForeColor = Color.Green;
                        break;
                    case enTraficLightColor.yellow:
                        pbTraficLight.Image = Resources.Orange1;
                        lblCounterDown.ForeColor = Color.Yellow;
                        break;
                    default:
                        lblCounterDown.ForeColor= Color.Red;
                        break;
                }
            }
            
        }


        private int _RedLightTime = 10;
        private int _GreenLightTime = 10;
        private int _YellowLightTime = 5;

        private int _CurrentCountDownValue;

        public int RedLightTime
        {
            get { return _RedLightTime; }
            set
            {
                _RedLightTime = value;
            }
        }

        public int GreenLightTime
        {
            get { return _GreenLightTime; }

            set { _GreenLightTime = value; }
        }

        public int YellowLightTime
        {
            get { return _YellowLightTime; }
            set { _YellowLightTime = value; }
        }

        public int GetCurrentTime()
        {
           switch(_CurrentLightColor)
           {
                case enTraficLightColor.red:
                    return RedLightTime;
                case enTraficLightColor.green:
                    return GreenLightTime;
                case enTraficLightColor.yellow:
                    return YellowLightTime;
                default:
                    return RedLightTime;
           }
        }

        public void Start()
        {
            _CurrentCountDownValue = GetCurrentTime();
            TraficLightTimer.Start();

        }

        public void Stop()
        {
            TraficLightTimer.Stop();
        }
        public ctrlTraficLight()
        {
            InitializeComponent();
        }

        private void TraficLightTimer_Tick(object sender, EventArgs e)
        {
            lblCounterDown.Text = _CurrentCountDownValue.ToString();
            if(_CurrentCountDownValue == 0 )
            {
                _ChangeColor();
            }
            else
            {
                --_CurrentCountDownValue;
            }

            Thread.Sleep(100);

        }

        private enTraficLightColor _LightAfterGreenYellowOrRed; 

        private void _ChangeColor()
        {
            switch(_CurrentLightColor)
            {
                case enTraficLightColor.red:
                    _LightAfterGreenYellowOrRed = enTraficLightColor.green;
                    _CurrentLightColor = enTraficLightColor.yellow;
                    _CurrentCountDownValue  =YellowLightTime;
                    lblCounterDown.Text = _CurrentCountDownValue.ToString();
                    RaiseYellowLightOn();
                    break;
                case enTraficLightColor.yellow:
                    if(_LightAfterGreenYellowOrRed ==enTraficLightColor.green)
                    {
                        _CurrentCountDownValue = GreenLightTime;
                        CurrentLightColor = enTraficLightColor.green;
                        lblCounterDown.Text = _CurrentCountDownValue.ToString();

                        RaiseGreenLightOn();

                    }
                    else
                    {
                        CurrentLightColor = enTraficLightColor.red;
                        _CurrentCountDownValue = RedLightTime;
                        lblCounterDown.Text = _CurrentCountDownValue.ToString();

                        RaiseRedLightOn();
                    }
                    break;
                case enTraficLightColor.green:
                    _LightAfterGreenYellowOrRed = enTraficLightColor.red;
                    _CurrentCountDownValue = YellowLightTime;
                    CurrentLightColor = enTraficLightColor.yellow;
                    lblCounterDown.Text= _CurrentLightColor.ToString();

                    RaiseYellowLightOn();
                    break;
                default:
                    pbTraficLight.Image = Resources.Red;
                    break;

            }
        }

    }
}
