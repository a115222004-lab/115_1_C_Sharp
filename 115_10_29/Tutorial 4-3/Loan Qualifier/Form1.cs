using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            const decimal MIN_SALARY = 30000m; // Minimum salary requirement
            const int MIN_YEARS = 2; // Minimum years of employment requirement

            decimal salary;
            int yearsOnJob;

            try
            {
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                if (salary >= MIN_SALARY)
                {
                    if (yearsOnJob >= MIN_YEARS)
                    {
                        decisionLabel.Text = "You qualify for the loan.";
                    }
                    else
                    {
                        decisionLabel.Text = "You do not qualify for the loan.";
                    }
                }
                else
                {
                    decisionLabel.Text = "You do not qualify for the loan.";
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Input Error");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the decisionLabel.
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // Reset the focus.
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
