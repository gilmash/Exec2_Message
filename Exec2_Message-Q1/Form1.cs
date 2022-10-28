﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resultLabel.Text = string.Empty;
            
        }

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            int hours = datetime.Hour;

           
            string result = GetHello(hours);

            resultLabel.Text = result+$"目前時間:{datetime}";

        }

        private string GetHello(int hours)
        {
            string value = string.Empty;
            if(hours < 12)
            {
                value = "您好，早安";
            }
            else if (hours > 12)
            {
                value = "您好，晚安";
            }
            else
            {
                value = "您好，午安";
            }

            return value;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            MessageBox.Show(now.ToString());
        }
    }
}
