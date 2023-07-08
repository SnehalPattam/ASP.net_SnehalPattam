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
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void lbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtFN.Text == "snehal" && txtLN.Text == "Pattam" && txtEID.Text == "sp@gmail.com" && txtPass.Text == "123") 
            
            {
                welcome f2 = new welcome();
                f2.ShowDialog();
            }
            else {
                MessageBox.Show("please fill the requirement");
            }
        }
    }
}
