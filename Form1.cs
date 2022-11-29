using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace lab1._4
{
    public partial class Form1 : Form
    {
        System.Drawing.Pen newPen = new System.Drawing.Pen(System.Drawing.Color.Black);
        Graphics gr;
        bool SPause = true;
        private MediaPlayer player = new MediaPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void exiT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pen_CheckedChanged(object sender, EventArgs e)
        {
            newPen.Width = 1;
            drawTool.Enabled = true;
        }

        private void showShape_Enter(object sender, EventArgs e)
        {

        }

        private void voicE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pen_CheckedChanged(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void brusH_CheckedChanged(object sender, EventArgs e)
        {
            newPen.Width = 15;
            drawTool.Enabled = true;
        }

        private void myFigure_CheckedChanged(object sender, EventArgs e)
        {
            linE.Enabled = false;
            circle.Enabled = false;
            square.Enabled = false;

            newPen.Width = 5;

            pictureBox1.Image = null;
            Bitmap map = new Bitmap(702, 405);
            Point point1;
            point1 = showShape.Location;
            gr = Graphics.FromImage(map);

            gr.DrawEllipse(newPen, point1.X - 275, point1.Y + 25, point1.X - 375, point1.Y + 125);//perfect2.0
            gr.DrawEllipse(newPen, point1.X - 50, point1.Y + 30, point1.X - 400, point1.Y + 100);//perfect
            gr.DrawEllipse(newPen, point1.X - 180, point1.Y + 60, point1.X - 580, point1.Y + 60);//perfect 3.0

            gr.DrawLine(newPen, point1.X + 35, point1.Y +148, point1.X - 210, point1.Y + 172);
            gr.DrawLine(newPen, point1.X + 20, point1.Y +30, point1.X - 210, point1.Y + 26);
            pictureBox1.Image = map;

            if (!myFigure.Checked)
            {
                linE.Enabled = true;
                circle.Enabled = true;
                square.Enabled = true;
            }
        }

        private void black__CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color = System.Drawing.Color.Black;
        }

        private void blue__CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color = System.Drawing.Color.Blue;
        }

        private void green__CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color = System.Drawing.Color.Green;
        }

        private void cyan__CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color = System.Drawing.Color.Cyan;
        }

        private void red__CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color = System.Drawing.Color.Red;
        }

        private void magenta__CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color = System.Drawing.Color.Magenta;
        }

        private void yellow__CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color = System.Drawing.Color.Yellow;
        }

        private void white__CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color = System.Drawing.Color.White;
        }

        private void linE_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            Bitmap map = new Bitmap(702, 405);
            Point point1;
            point1 = drawShape.Location;
            gr = Graphics.FromImage(map);
            gr.DrawLine(newPen, point1.X + 25, point1.Y - 25, point1.X + 250, point1.Y - 50);
            pictureBox1.Image = map;
        }

        private void circle_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            Bitmap map = new Bitmap(702, 405);
            Point point1;
            point1 = drawShape.Location;
            gr = Graphics.FromImage(map);
            gr.DrawEllipse(newPen, point1.X + 62, point1.Y - 108, point1.X + 138, point1.Y + 10);
            pictureBox1.Image = map;
        }

        private void square_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            Bitmap map = new Bitmap(702, 405);
            Point point1;
            point1 = drawShape.Location;
            gr = Graphics.FromImage(map);
            gr.DrawRectangle(newPen, point1.X + 62, point1.Y - 108, point1.X + 138, point1.Y + 10);

            pictureBox1.Image = map;
        }

        private void starT_Click(object sender, EventArgs e)
        {
            if (SPause)
            {
                if (voicE.Text == "Love me again")
                {
                    player.Open(new Uri("D:\\studying\\2 course (2022-2023)\\1sem\\Human-computer interaction\\lab1.4\\lab1.4\\john-newman-love-me-again.wav", UriKind.Relative));
                    player.Play();
                    SPause = false;
                    starT.Text = "Stop";
                    voicE.Enabled = false;
                }

                else if (voicE.Text == "Born to die")
                {
                    player.Open(new Uri("D:\\studying\\2 course (2022-2023)\\1sem\\Human-computer interaction\\lab1.4\\lab1.4\\Lana Del Rey - Born to Die (dizer.net).wav", UriKind.Relative));
                    player.Play();
                    SPause = false;
                    starT.Text = "Stop";
                    voicE.Enabled = false;
                }

                else if (voicE.Text == "Smells like teen spirit")
                {
                    player.Open(new Uri("D:\\studying\\2 course (2022-2023)\\1sem\\Human-computer interaction\\lab1.4\\lab1.4\\Nirvana_-_Smells_Like_Teen_Spirit_(musmore.com).wav", UriKind.Relative));
                    player.Play();
                    SPause = false;
                    starT.Text = "Stop";
                    voicE.Enabled = false;
                }

                else if (voicE.Text == "Alien blues")
                {
                    player.Open(new Uri("D:\\studying\\2 course (2022-2023)\\1sem\\Human-computer interaction\\lab1.4\\lab1.4\\Vundabar_-_Alien_Blues_(musmore.com).wav", UriKind.Relative));
                    player.Play();
                    SPause = false;
                    starT.Text = "Stop";
                    voicE.Enabled = false;
                }

                else if (voicE.Text == "Щедрик")
                {
                    player.Open(new Uri("D:\\studying\\2 course (2022-2023)\\1sem\\Human-computer interaction\\lab1.4\\lab1.4\\ukranska_narodna_shchedrivka_obr_leontovicha_-_shchedrik_-_shchedrik__shchedrik__shchedrivochka__priletila_lastivochka_(z2.fm).wav", UriKind.Relative));
                    player.Play();
                    SPause = false;
                    starT.Text = "Stop";
                    voicE.Enabled = false;
                }
            }

            else if (!SPause)
            {
                player.Stop();
                starT.Text = "Start";
                voicE.Enabled = true;
                SPause = true;
            }
        }
    }
}
