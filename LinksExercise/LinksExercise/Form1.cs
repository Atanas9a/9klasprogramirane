using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinksExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Travis Scott")
            {
                Process.Start("https://en.wikipedia.org/wiki/Travis_Scott");
            }
            else if (comboBox1.Text == "Juice WRLD")
            {
                Process.Start("https://en.wikipedia.org/wiki/Juice_Wrld");
            }
            else if (comboBox1.Text == "Kid Laroi")
            {
                Process.Start("https://bg.wikipedia.org/wiki/The_Kid_Laroi_(%D0%BF%D0%B5%D0%B2%D0%B5%D1%86)");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=M5JS3PulBPo");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"https://www.youtube.com/watch?v=T58FsDSJa-8";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
