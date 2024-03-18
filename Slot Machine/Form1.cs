



using System.Drawing.Imaging;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Slot_Machine
{
    public partial class Form1 : Form
    {

        private Timer timer;
        private Timer timer2;
        private Timer timer3;
        private bool spinning = false;
        private Random Random = new Random();
        private double totalWins;
        //private int currentIndex;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;

            timer2 = new Timer();
            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;

            timer3 = new Timer();
            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;
        }



        private void stopButton2_Click(object sender, EventArgs e)
        {
            spinning = false;
            CheckIfWin();

            timer1.Stop();
        }

        private void spinButton_Click(object sender, EventArgs e)
        {

            spinning = true;
            timer1.Start();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool CheckIfWin()
        {
            if (!spinning)
            {

                bool pictureBox1and2Match = ImageEquals(pictureBox1.Image, pictureBox2.Image);
                bool pictureBox1and3Match = ImageEquals(pictureBox1.Image, pictureBox3.Image);
                bool pictureBox2and3Match = ImageEquals(pictureBox2.Image, pictureBox3.Image);

                if (pictureBox1and2Match && pictureBox1and3Match && pictureBox2and3Match)
                {
                    if (Double.TryParse(textBox1.Text, out double number))
                    {
                        double result = number * 3.0;
                        totalWins += result;
                        MessageBox.Show($"You have inserted {number}$ and you have Won {result} dollars! Total Wins: {totalWins}");
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid number?");
                    }


                    return true;
                }


                else if (pictureBox1and2Match || pictureBox1and3Match || pictureBox2and3Match)
                {
                    if (Double.TryParse(textBox1.Text, out double number))
                    {
                        double result = number * 2.0;
                        totalWins += result;
                        MessageBox.Show($"You have inserted {number}$ Won {result} dollars! Total Wins: {totalWins}");
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid number?");
                    }

                }

            }
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (spinning)
            {
                int randomIndex = Random.Next(0, imageList1.Images.Count);
                int randomIndex1 = Random.Next(0, imageList1.Images.Count);
                int randomIndex2 = Random.Next(0, imageList1.Images.Count);
                pictureBox1.Image = imageList1.Images[randomIndex];
                pictureBox2.Image = imageList1.Images[randomIndex1];
                pictureBox3.Image = imageList1.Images[randomIndex2];
            }
        }

        private bool ImageEquals(Image image1, Image image2)
        {
            if (image1 == null || image2 == null)
            {
                return false;
            }

            using (MemoryStream ms1 = new MemoryStream())
            using (MemoryStream ms2 = new MemoryStream())

            {
                image1.Save(ms1, ImageFormat.Png);
                image2.Save(ms2, ImageFormat.Png);

                return ms1.ToArray().SequenceEqual(ms2.ToArray());

            }
        }


    }
}