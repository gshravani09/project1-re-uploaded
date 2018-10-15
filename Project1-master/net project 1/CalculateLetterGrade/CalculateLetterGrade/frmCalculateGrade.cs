using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /************* 
             * this method calculates the Letter grade 
             * based on the Number grade
             **************/

            // get the numberGrade variable from the Number grade text box
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);

            // set the letterGrade variable based 
            // on the value of the numberGrade variable
            string letterGrade = "";
            if (numberGrade >= 88)
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80 && numberGrade <= 87)
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 68 && numberGrade <= 79)
            {
                letterGrade = "C";
            }
            else if (numberGrade >= 60 && numberGrade <= 67)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            // display letterGrade in the text box
            txtLetterGrade.Text = letterGrade;

            // move the focus to the numberGrade text box
            txtNumberGrade.Focus();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
