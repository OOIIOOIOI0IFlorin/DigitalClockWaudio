using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        public void label1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\justm\source\repos\Digital-Clock-in-windows-forms\audio\sound.wav");
            
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            player.PlayLooping();

        }
        public void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(@"C:\Users\justm\source\repos\Digital-Clock-in-windows-forms\audio\beep1h.wav");
        

                    if (mm == 17 && ss == 00) { 
                        player2.Play();           
                    }
              
             

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;

                label1.Text = time;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
