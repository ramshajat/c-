using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lstyrA{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hour,minutes, seconds,miliseconds=0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            miliseconds = miliseconds + 1;
            if (miliseconds == 9)
            {
                miliseconds = 0;
                seconds = seconds+1;
                label1.Text = seconds.ToString();
                if (seconds == 59)
                {
                    seconds = 0;
                    minutes = minutes + 1;
                    label2.Text = minutes.ToString();
                    if (minutes == 59)
                    {
                        minutes = 0;
                        hour = hour + 1;
                        label3.Text = hour.ToString();

                    }

                }
            }
        }
    }
}
