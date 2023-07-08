using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Sign_Up f2 = new Sign_Up();
            f2.ShowDialog();
        }

        private void lbForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Forget f2 = new Forget();
            f2.ShowDialog(); // Shows Form2
        }

        private void btnSubmit(object sender, EventArgs e)
        {
            if(textBox1.Text=="snehal" && textBox2.Text == "123")

            {
                welcome f2 = new welcome();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter correct user id and password");
            }
        }
    }
}
