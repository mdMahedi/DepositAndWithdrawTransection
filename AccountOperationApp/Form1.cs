using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account acc=new Account();
        private void createButton_Click(object sender, EventArgs e)
        {
            acc.id = accountNumberTextBox.Text;
            acc.name = customerNameTextBox.Text;
            accountNumberTextBox.Clear();
            customerNameTextBox.Clear();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(amountTextBox.Text);
            acc.DepositMoney(amount);
            amountTextBox.Clear();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {

            decimal amount = Convert.ToDecimal(amountTextBox.Text);
            if (acc.balance < amount)
            {
                MessageBox.Show("Not enough balance");
            }
            else
            {
                acc.WithdrawMoney(amount);
                amountTextBox.Clear();
            }
        }
        private void reportButton_Click(object sender, EventArgs e)
        {
            string id = acc.id;
            string name = acc.name;
            decimal amount = acc.balance;
            
            MessageBox.Show(name + ", Your Account Number is : " + id + " and it's balance : " + amount);
        }
    }
}
