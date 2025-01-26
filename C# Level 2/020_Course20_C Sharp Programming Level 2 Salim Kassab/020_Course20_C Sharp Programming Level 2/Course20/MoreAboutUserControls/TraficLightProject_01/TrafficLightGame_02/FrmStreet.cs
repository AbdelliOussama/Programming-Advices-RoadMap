using System.Media;
using static Course20.TraficLight_008.CtrlTraficLight;

namespace Course20.TraficLight_008
{
    public partial class FrmStreet : Form
    {
        private int trafficViolationsCount = 0;
        public FrmStreet() => InitializeComponent();

        private void appearTrafficCop()
        {
            trafficViolationsCount++;
            FrmTrafficViolation frmTrafficViolation = new(trafficViolationsCount);
            frmTrafficViolation.ShowDialog();
            if (trafficViolationsCount >= 3)
            {
                btnMove.Enabled = false;
                btnBack.Enabled = false;
            }
        }

        private void carMove(Point carCurrentLocation)
        {
            //buttom
            if (carCurrentLocation.X == 798 && carCurrentLocation.Y == 416)
                pbCar.Location = new Point(520, 410);

            else if (carCurrentLocation.X == 520 && carCurrentLocation.Y == 410)
            {
                if (ctrlTraficLight4.CurrentLight != enLightColors.Green)
                {
                    appearTrafficCop();
                    return;
                }

                pbCar.Location = new Point(311, 411);
            }

            else if (carCurrentLocation.X == 311 && carCurrentLocation.Y == 411)
                pbCar.Location = new Point(100, 410);

            //left
            else if (carCurrentLocation.X == 100 && carCurrentLocation.Y == 410)
            {
                pbCar.Location = new Point(1, 339);
                pbCar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pbCar.Size = new Size(100, 100);
                pbCar.Refresh();
            }
            else if (carCurrentLocation.X == 1 && carCurrentLocation.Y == 339)
            {
                if (ctrlTraficLight1.CurrentLight != enLightColors.Green)
                {
                    appearTrafficCop();
                    return;
                }
                pbCar.Location = new Point(1, 60);
            }

            //top
            else if (carCurrentLocation.X == 1 && carCurrentLocation.Y == 60)
            {
                pbCar.Location = new Point(259, 9);
                pbCar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pbCar.Size = new Size(100, 100);
                pbCar.Refresh();
            }
            else if (carCurrentLocation.X == 259 && carCurrentLocation.Y == 9)
            {
                if (ctrlTraficLight2.CurrentLight != enLightColors.Green)
                {
                    appearTrafficCop();
                    return;
                }
                pbCar.Location = new Point(500, 9);
            }

            else if (carCurrentLocation.X == 500 && carCurrentLocation.Y == 9)
                pbCar.Location = new Point(800, 9);


            //right
            else if (carCurrentLocation.X == 800 && carCurrentLocation.Y == 9)
            {
                pbCar.Location = new Point(800, 90);
                pbCar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pbCar.Size = new Size(100, 100);
                pbCar.Refresh();
            }
            else if (carCurrentLocation.X == 800 && carCurrentLocation.Y == 90)
            {
                if (ctrlTraficLight3.CurrentLight != enLightColors.Green)
                {
                    appearTrafficCop();
                    return;
                }
                pbCar.Location = new Point(800, 350);
            }

            //start postion
            else if (carCurrentLocation.X == 800 && carCurrentLocation.Y == 350)
            {
                pbCar.Location = new Point(798, 416);
                pbCar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pbCar.Size = new Size(100, 100);
                pbCar.Refresh();
            }
        }

        private void carMoveBack(Point carCurrentLocation)
        {
            //buttom
            if (carCurrentLocation.X == 520 && carCurrentLocation.Y == 410)
                pbCar.Location = new Point(798, 416);

            else if (carCurrentLocation.X == 311 && carCurrentLocation.Y == 411)
                pbCar.Location = new Point(520, 410);

            else if (carCurrentLocation.X == 100 && carCurrentLocation.Y == 410)
                pbCar.Location = new Point(311, 411);

            //left
            else if (carCurrentLocation.X == 1 && carCurrentLocation.Y == 339)
            {
                pbCar.Location = new Point(100, 410);
                pbCar.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pbCar.Size = new Size(100, 100);
                pbCar.Refresh();
            }
            else if (carCurrentLocation.X == 1 && carCurrentLocation.Y == 60)
                pbCar.Location = new Point(1, 339);

            //top
            else if (carCurrentLocation.X == 259 && carCurrentLocation.Y == 9)
            {
                pbCar.Location = new Point(1, 60);
                pbCar.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pbCar.Size = new Size(100, 100);
                pbCar.Refresh();
            }
            else if (carCurrentLocation.X == 500 && carCurrentLocation.Y == 9)
                pbCar.Location = new Point(259, 9);

            else if (carCurrentLocation.X == 800 && carCurrentLocation.Y == 9)
                pbCar.Location = new Point(500, 9);

            //right
            else if (carCurrentLocation.X == 800 && carCurrentLocation.Y == 90)
            {
                pbCar.Location = new Point(800, 9);
                pbCar.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pbCar.Size = new Size(100, 100);
                pbCar.Refresh();
            }
            else if (carCurrentLocation.X == 800 && carCurrentLocation.Y == 350)
                pbCar.Location = new Point(800, 90);
        }

        private void FrmStreet_Load(object sender, EventArgs e)
        {
            ctrlTraficLight1.Start();
            ctrlTraficLight2.Start();
            ctrlTraficLight3.Start();
            ctrlTraficLight4.Start();
        }

        private void btnMove_Click(object sender, EventArgs e) => carMove(pbCar.Location);

        private void btnBack_Click(object sender, EventArgs e) => carMoveBack(pbCar.Location);
    }
}