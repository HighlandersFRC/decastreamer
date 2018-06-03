using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UWBPlotter_Forms
{
    public partial class Plot1 : Form
    {
        int screenHeight;
        int screenWidth;
        double scalingFactor;
        double x0;
        double y0;
        SerialPort sp = new SerialPort();
        bool _continue = true;
        double modifiedAlpha;
        double alpha = 0;
        bool isFirstTime = true;
        bool isFirstTimeRead = true;
        double xCoord, yCoord, zCoord = 0;
        double xtempPrev, ytempPrev = 0;
        Pen pen = new Pen(Brushes.DeepSkyBlue, 5);
        //Graphics formGraphics;
        double[] tempPrevCoords = new double[2];
        double[] tempCurrentCoords = new double[2];
        public Plot1()
        {
            InitializeComponent();
            screenHeight = 800;
            screenWidth = 1000;
            scalingFactor = screenWidth / 15;
            x0 = 3 * scalingFactor;
            y0 = 2 * scalingFactor;
            List<PictureBox> Anchors = new List<PictureBox>();
            Anchors.Add(Anchor1);
            Anchors.Add(Anchor2);
            Anchors.Add(Anchor3);
            Anchors.Add(Anchor4);
            foreach (PictureBox Anchor in Anchors)
            {
                string name = Anchor.AccessibleName;
                string[] coords = name.Split(',');
                double[] coord = new double[2];
                coord[0] = double.Parse(coords[0]);
                coord[1] = double.Parse(coords[1]);
                int[] scaledPoint = scalePoint(coord);
                Anchor.Location = new Point(scaledPoint[0], scaledPoint[1]);
                Anchor.BackColor = Color.Transparent;
            }
        }

        public int[] scalePoint(double[] coord)
        {
            int[] scaledCoord = new int[2];
            scaledCoord[0] = Int32.Parse(Math.Round(x0 + coord[0] * scalingFactor).ToString());
            scaledCoord[1] = Int32.Parse(Math.Round(800-(y0 + coord[1] * scalingFactor)).ToString());
            return scaledCoord;
        }

        private void Plot_Paint(object sender, PaintEventArgs e)
        {
            //System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            //System.Drawing.Graphics formGraphics;
            //formGraphics = this.CreateGraphics();
            //formGraphics.DrawLine(myPen, 0, 0, 200, 200);
            //myPen.Dispose();
            //formGraphics.Dispose();
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            bool isFirstTime = true;
            bool isSecondTime = false;
            string line;

            // set some port parameters
            sp.BaudRate = 115200;
            //sp.DataBits = 8;
            //sp.Parity = Parity.None;
            //sp.StopBits = StopBits.One;
            sp.ReadTimeout = 2000;
            sp.PortName = "COM8";
            try
            {
                sp.Open();
            }
            catch
            {
                //MessageBox.Show("Error opening serial port");
                return;
            }
            int i = 0;
            while (true)
            {
                try
                {
                    line = sp.ReadLine();  // Will read until carriage-return
                    ProcessLine(line); // Your method to parse the line
                    isFirstTime = false;
                    sp.DiscardInBuffer();
                }
                catch
                {
                    sp.Write("\r");
                    if (isSecondTime)
                    {
                        isFirstTime = false;
                        continue;
                    }
                    if (isFirstTime)
                    {
                        //sp.Close();
                        //sp.Open();
                        System.Threading.Thread.Sleep(500);
                        sp.Write("nmt\r\r");
                        System.Threading.Thread.Sleep(2000);
                        sp.Write("lep\r");
                    }
                    System.Threading.Thread.Sleep(20);
                    isSecondTime = false;
                    isFirstTime = false;
                }
            }
            sp.Close();
        }

        public void ProcessLine(string line)
        {
            //POS[10, 2, 3, 100]
            //POS,6.63,3.74,-1.86,100

            if (line != "")
            {
                string[] coords = line.Split(',');
                double xCoordCurrent = double.Parse(coords[1]);
                double yCoordCurrent = double.Parse(coords[2]);
                double zCoordCurrent = double.Parse(coords[3]);
                int confid = int.Parse(coords[4]);
                modifiedAlpha = (1 - alpha) * confid / 100;
                if (isFirstTimeRead)
                    modifiedAlpha = 1;
                modifiedAlpha = 1;
                xCoord = xCoordCurrent * (modifiedAlpha) + xCoord * (1 - modifiedAlpha);
                yCoord = yCoordCurrent * (modifiedAlpha) + yCoord * (1 - modifiedAlpha);
                //formGraphics = this.CreateGraphics();
                tempPrevCoords[0] = xtempPrev;
                tempPrevCoords[1] = ytempPrev;
                int[] scaledPrevPoint = scalePoint(tempPrevCoords);
                tempCurrentCoords[0] = xCoord;
                tempCurrentCoords[1] = yCoord;
                int[] scaledCurrentPoint = scalePoint(tempCurrentCoords);

                System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                formGraphics.DrawLine(myPen, scaledPrevPoint[0], scaledPrevPoint[1], scaledCurrentPoint[0], scaledCurrentPoint[1]);
                myPen.Dispose();
                formGraphics.Dispose();

                //if (!isFirstTimeRead)
                //formGraphics.DrawLine(pen, scaledPrevPoint[0], scaledPrevPoint[1], scaledCurrentPoint[0], scaledCurrentPoint[1]);
                xtempPrev = xCoord;
                ytempPrev = yCoord;
                //tag0.Location = new Point(scaledCurrentPoint[0], scaledCurrentPoint[1]);
                //zCoord = zCoordCurrent * (modifiedAlpha) + zCoord * (1 - modifiedAlpha);
                isFirstTimeRead = false;
                //double[] coord = new double[2];
                //coord[0] = xCoord;
                //coord[1] = yCoord;
                //int[] scaledPoint = scalePoint(coord);
                //tag0.Location = new Point(scaledPoint[0], scaledPoint[1]);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sp.Close();
            _continue = false;
        }
    }
}
