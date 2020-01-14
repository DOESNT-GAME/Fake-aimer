using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int Game = 1;
        int Rand1;
        int Rand2;
        int counter;
        int kills;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int X = label1.Location.X;
            MessageBox.Show("Убить 5 человек кликая на прицел не менее чем за 15 секунд на 1 человека и не промазав по прицелу 20 раз");
            label1.Location = new Point(X, -1);
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum)
            {
                Rand1 = rnd.Next(20, 700);
                Rand2 = rnd.Next(20, 400);
                progressBar1.Value += 1;
                button1.Location = new Point(Rand1, Rand2);
            }
            else
            {
                timer1.Stop();
                kills++;
                label2.Text = "kills: " + kills;
                MessageBox.Show("You kill Bot Andrey with your StatTrack''|ClickPower| for " + label1.Text + "sec", "Message of kill");
                counter = 0;
                progressBar1.Value = 0;
                progressBar2.Value = 100;
                label1.Text = "";
                Game = 1;
            }
            if (Game == 1)
            {
                timer1.Start();
                Game = 0;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (progressBar2.Value !=0)
            {
                progressBar2.Value -= 5;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Bot Andrey killed you with their StatTrack'' |ConsolePower|","Message of Dead");
                counter = 0;
                progressBar1.Value = 0;
                progressBar2.Value = 100;
                Game = 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            if (counter == 15)
            {
                timer1.Stop();
                MessageBox.Show("Bot Andrey killed you with their StatTrack'' |ConsolePower|", "Message of Dead");
                counter = 0;
                progressBar1.Value = 0;
                progressBar2.Value = 100;
                Game = 1;
            }
        }

        private void youACrazyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void thisButtonCrackProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while(true)
            {
                MessageBox.Show("I HACK YOUR PROGRAMM HahahAHhaahAHHA","sorry for this");
            }
        }

        private void whyUKickExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello i am MessageBox", "Hello");
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
