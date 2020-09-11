using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Bank_Account
{
    public partial class Form1 : Form
    {
        Bank_account acc_object = new Bank_account(3000);
        public Form1()
        {
            InitializeComponent();
            
        }
        private void printBalance(Bank_account bank)
        {
            labelTxt.Text = bank.balance.ToString();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (labelTxt.Text.Length > 0)
            {
                acc_object.Withdraw(Convert.ToInt32(labelTxt.Text));
                printBalance(acc_object);
            }
        }

        private void balanceBtn_Click(object sender, EventArgs e)
        {

        }

        private void depositBtn_Click(object sender, EventArgs e)
        {

        }

        private void labelTxt_Click(object sender, EventArgs e)
        {
           
            
        }

        private void InputText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
