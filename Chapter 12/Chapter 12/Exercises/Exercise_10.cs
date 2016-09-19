using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_12.Exercises
{
    public partial class Exercise_10 : Form
    {
        Ex10.BankAccount account = new Ex10.BankAccount(220.25M);

        public Exercise_10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                account.Withdraw(numWithdraw.Value);
                label2.Text = account.Balance.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                account.Deposit(numDeposit.Value);
                label2.Text = account.Balance.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exercise_10_Load(object sender, EventArgs e)
        {
            label2.Text = account.Balance.ToString("C");
        }
    }
}
