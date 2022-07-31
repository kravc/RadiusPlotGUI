using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiusPlotGUI
{
    partial class Form1 : Form
    {
        double spRad;
        double toolRad;
        double startAng;
        double spAng;
        double baseLine;
        double zOff;
        private Font fnt = new Font("Arial", 10);


        public Form1()
        {
            InitializeComponent();
            
        }

        private void sphereRadius_TextChanged(object sender, EventArgs e)
        {
            try
            {
                spRad = Convert.ToDouble(sphereRadius.Text);
            }
            catch
            {
                sphereRadius.Text = "Не, нихуя";
            }

        }

        private void run_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            Pen pn = new Pen(Color.Black, 1);  // Перо для рисования
            Graphics g = CreateGraphics();
            g.DrawEllipse(pn, 200, 200, 300, 200);  //200, 200 - координаты верхнего левого угла прямоугольника, 
                                                    //300, 200 - его ширина и высота. Сюда вписывается эллипс.     

            double radiusVector = spRad + toolRad ;// вычисляем радиус-вектор

            double dlinaDugi = Math.PI * radiusVector / 180.0 * spAng;// вычисляем длину дуги 

            int linesQuant = Convert.ToInt32(dlinaDugi / baseLine);//вычисляем количество линий

            double angleRad = Math.PI * startAng / 180.0; //переводим угол в радианы



            for (int i = 0; i < linesQuant; i++)
            {
                double currentRadDlin = i * baseLine;

                double currentAngleCalc = currentRadDlin / (Math.PI * radiusVector / 180);
                //Console.WriteLine(i + "текущий угол" + currentAngleCalc);
                double currentAngle = startAng + currentAngleCalc;
                // Console.Write(currentAngle + " ");
                double currentAngleRad = Math.PI * currentAngle / 180;
                // Console.Write(currentAngleRad + " ");
                double ycur = 2 * (radiusVector * Math.Sin(currentAngleRad) - toolRad);
                double zcur = (radiusVector * Math.Cos(currentAngleRad)) - zOff;

                string sent = ("G1 " + "Y" + ycur.ToString("##0.###") + " " + "Z" + zcur.ToString("##0.###"));
                textBox8.Text += sent + "\r\n";

                //Console.Write("y=" + ycur + " ");
                // Console.WriteLine("  " + i + "  ");
                //Console.WriteLine("z=" + zcur + ";");

                //writer.WriteLine("G1 " + "Y" + ycur.ToString("###.###") + " " + "Z" + zcur.ToString("###.###"));

            }
        }

        private void toolRadius_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                toolRad = Convert.ToDouble(toolRadius.Text);
            }
            catch
            {
                sphereRadius.Text = "Не, нихуя";
            }
        }

        private void startAngle_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                startAng = Convert.ToDouble(startAngle.Text);
            }
            catch
            {
                startAngle.Text = "Не, нихуя";
            }

        }

        private void sphereAngle_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                spAng = Convert.ToDouble(sphereAngle.Text);
            }
            catch
            {
                sphereAngle.Text = "Не, нихуя";
            }
        }

        private void lineLengh_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                baseLine = Convert.ToDouble(lineLengh.Text);
            }
            catch
            {
                lineLengh.Text = "Не, нихуя";
            }
        }

        private void zOffset_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                zOff = Convert.ToDouble(zOffset.Text);
            }
            catch
            {
                zOffset.Text = "Не, нихуя";
            }
        }

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            Graphics g = e.Graphics;

            // Draw a string on the PictureBox.
            g.DrawString("This is a diagonal line drawn on the control",
                fnt, System.Drawing.Brushes.Blue, new Point(30, 30));
            // Draw a line in the PictureBox.
            g.DrawLine(System.Drawing.Pens.Red, pictureBox1.Left, pictureBox1.Top,
                pictureBox1.Right, pictureBox1.Bottom);
        }
    }
}
