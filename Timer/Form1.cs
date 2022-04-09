using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region variables
        int Minute = 0;
        int Second = 0;
        int MiliSecond = 0;
        bool Count = true;
        #endregion

        #region start/stop
        private void button1_Click(object sender, EventArgs e)
        {
            if (Count==true)
            {
                timer1.Enabled = true;
                Count = false;
            }
            else
            {
                timer1.Enabled = false;
                Count=true;
                label6.Text = MiliSecond.ToString();
                label2.Text = Second.ToString();
                label1.Text = Minute.ToString();
            }

        }
        #endregion

        #region timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            MiliSecond = Convert.ToInt32(label6.Text);
            MiliSecond++;
            label6.Text = MiliSecond.ToString();
            if (MiliSecond==100)
            {
                Second++;
                MiliSecond = 0;
                label6.Text = MiliSecond.ToString();
                label2.Text = Second.ToString();
            }
            if (Second==60)
            {
                Minute++;
                Second = 0;
                label2.Text = Second.ToString();
                label1.Text = Minute.ToString();
            }
        }
        #endregion

        #region reset
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Minute = 0;
            Second = 0;
            MiliSecond = 0;
            Count = true;
            label6.Text = MiliSecond.ToString();
            label2.Text = Second.ToString();
            label1.Text = Minute.ToString();
        }
    }
    #endregion

}
