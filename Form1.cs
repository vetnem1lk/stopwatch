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

namespace stopwatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stopwatch st = new Stopwatch();
        private void timer1_Tick(object sender, EventArgs e)
        {
            string text = "";

            int tenths = st.Elapsed.Milliseconds / 100;

            text +=
                st.Elapsed.Hours.ToString("00") + ":" +
                 st.Elapsed.Minutes.ToString("00") + ":" +
                 st.Elapsed.Seconds.ToString("00") + "." +
                 tenths.ToString("0");

            lbltimer.Text = text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            st.Start();
            timer1.Enabled = true;
            btnStart.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            st.Stop();
            button1.Enabled = false;
            button2.Enabled = false;
            btnStart.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            btnStart.Enabled = true;
            st.Reset();
        }
    }
}
