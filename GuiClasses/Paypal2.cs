﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWarehose.GuiClasses
{
    public partial class Paypal2 : Form
    {

        public Paypal2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)//message about payment successful
        {
            MessageBox.Show("The payment successful");
        }

        private void Paypal2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
