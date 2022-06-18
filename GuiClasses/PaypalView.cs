using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TheWarehose.GuiClasses
{
    public partial class PaypalView : Form
    {
        public PaypalView()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';

        }

        private void Login_Click(object sender, EventArgs e)//the user must write correct informaion about paypal account
        {

            Paypal2 paypal = new Paypal2();


            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Plese Enter Email Address!");
            }
            else if (!textBox1.Text.Contains("@"))
            {
                MessageBox.Show("Plese Enter correct Email Address!");
            }
            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Plese Enter Password!");
            }
            else
                paypal.Show();


        }

        private void Cancel_Click(object sender, EventArgs e)
        {

            Paymentview payment = new Paymentview();
            payment.Show();
            this.Hide();


        }


    }
}
