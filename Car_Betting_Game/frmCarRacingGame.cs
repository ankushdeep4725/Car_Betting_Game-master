using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Betting_Game
{
    public partial class frmCarRacingGame : MetroFramework.Forms.MetroForm
    {

        //Initialize array of person
        person_module[] person = new person_module[3];
        public int Money;
        //intialize array of car
        car_module[] CarCount = new car_module[4];
        // System.Windows.Forms.Timer ty = new System.Windows.Forms.Timer();
        


        public frmCarRacingGame()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();

            string str = string.Empty;
            for (int i = 0; i < 1000; i++)
                Thread.Sleep(10);
            t.Abort();
            InitializeComponent();
            Application.DoEvents();

            person[0] = new person_module() { Money = 50, Name = "Joe", MyLabel = lblJoe, MyRadioButton = metroRadioButton1 };
            person[1] = new person_module() { Money = 50, Name = "Bob", MyLabel = lblBob, MyRadioButton = metroRadioButton2 };
            person[2] = new person_module() { Money = 50, Name = "Al", MyLabel = lblAI, MyRadioButton = metroRadioButton3 };
            foreach (person_module guy in person)
                guy.PlaceBet(0, 0);

            //set the default bet name to Joe
            lblName.Text = person[0].Name;

            CarCount[0] = new car_module()
            {
                MyPictureBox = car1,
                StartingPosition = car1.Left,
                RacetrackLength = racetrack.Width - car1.Width,
                Randomizer = new Random()
            };

            CarCount[1] = new car_module()
            {
                MyPictureBox = car2,
                StartingPosition = car2.Left,
                RacetrackLength = racetrack.Width - car2.Width,
                Randomizer = CarCount[0].Randomizer
            };

            CarCount[2] = new car_module()
            {
                MyPictureBox = car3,
                StartingPosition = car3.Left,
                RacetrackLength = racetrack.Width - car3.Width,
                Randomizer = CarCount[0].Randomizer
            };

            CarCount[3] = new car_module()
            {
                MyPictureBox = car4,
                StartingPosition = car4.Left,
                RacetrackLength = racetrack.Width - car4.Width,
                Randomizer = CarCount[0].Randomizer
            };

            updateForm();



        }



        void Splash()
        {
            frmSplash frm = new frmSplash();
            Application.Run(frm);
        }

        public void updateForm()
        {
            metroRadioButton1.Text = person[0].Name + " has $" + person[0].Money;
            metroRadioButton2.Text = person[1].Name + " has $" + person[1].Money;
            metroRadioButton3.Text = person[2].Name + " has $" + person[2].Money;
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            int guy;
            if (metroRadioButton1.Checked)
            {
                guy = 0;
            }
            else if (metroRadioButton2.Checked)
            {
                guy = 1;
            }
            else
            {
                guy = 2;
            }
            if (person[guy].Money >= numBets.Value)
            {

                foreach (car_module g in CarCount)
                {
                    g.MyPictureBox.Left = g.StartingPosition;
                }

                //start timer for race
               
                timer6.Enabled = true;


            }

            else
            {
                MessageBox.Show(person[guy].Name + " didn't have enough to bet");

            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBets_Click_1(object sender, EventArgs e)
        {
            int guy;
            if (metroRadioButton1.Checked)
            {
                guy = 0;
            }
            else if (metroRadioButton2.Checked)
            {
                guy = 1;
            }
            else
            {
                guy = 2;
            }
            person[guy].PlaceBet((int)numBets.Value, (int)numCar.Value - 1);

            Console.WriteLine(person[guy].Name + " bets $" + person[guy].Bet.Amount + " on Car " + (person[guy].Bet.Car + 1));
        }

        private void timer6_Tick_1(object sender, EventArgs e)
        {
            int winner;

           

                for (int i = 0; i < CarCount.Length; i++)
                {
                    if (CarCount[i].Run(racetrack))
                    {
                        winner = i;
                        timer6.Enabled = false;
                        MessageBox.Show("Car #" + (winner + 1) + " Wins!");

                        for (int j = 0; j < person.Length; j++)
                        {
                            if (person[j].MyLabel.Text != "BUSTED")
                            {

                                if (person[j].Bet.PayOut(winner) != 0)
                                {

                                    person[j].Money += person[j].Bet.PayOut(winner);


                                    if (person[j].Money > 0)
                                    {
                                        person[j].MyRadioButton.Text = person[j].Name + " has $" + person[j].Money;
                                    }
                                    else
                                    {
                                        person[j].MyRadioButton.Checked = false;
                                        person[j].MyRadioButton.Enabled = false;
                                        numBets.Value = 0;
                                        person[j].PlaceBet((int)numBets.Value, (int)numCar.Value - 1);
                                        person[j].MyRadioButton.Text = person[j].Name + " has $" + person[j].Money;
                                        person[j].MyLabel.Text = "BUSTED";

                                    if (person[0].MyLabel.Text == "BUSTED" && person[1].MyLabel.Text == "BUSTED" && person[2].MyLabel.Text == "BUSTED")
                                    {
                                        DialogResult res = MessageBox.Show("Game Over !!!! Click OK for Exit..", "Exit", MessageBoxButtons.OK
);
                                        if (res == System.Windows.Forms.DialogResult.OK)
                                        {
                                            System.Windows.Forms.Application.Exit();
                                        }
                                    }

                                    }

                                }

                            }
                        }
                        break;
                    }
                }
           
        }

        private void Reset_Click_1(object sender, EventArgs e)
        {
            foreach (car_module g in CarCount)
            {
                g.MyPictureBox.Left = g.StartingPosition;
            }
        }

        private void metroRadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            lblName.Text = person[0].Name;
        }

        private void metroRadioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            lblName.Text = person[1].Name;
        }

        private void metroRadioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            lblName.Text = person[2].Name;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Would you like to Exit?", "Confirm", MessageBoxButtons.YesNo
            );
            if (res == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            else
            {
                System.Windows.Forms.Application.Exit();
            }
           // base.OnClick(e);
        }

        class RoundedButton : Button
        {
            GraphicsPath GetRoundPath(RectangleF Rect, int radius)
            {
                float r2 = radius / 2f;
                GraphicsPath GraphPath = new GraphicsPath();

                GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
                GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
                GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
                GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
                GraphPath.AddArc(Rect.X + Rect.Width - radius,
                                 Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
                GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
                GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
                GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

                GraphPath.CloseFigure();
                return GraphPath;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
                GraphicsPath GraphPath = GetRoundPath(Rect, 50);

                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }

     

        private void btnExit_Click_2(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Would you like to Exit?", "Confirm", MessageBoxButtons.YesNo
         );
            if (res == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            else
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
