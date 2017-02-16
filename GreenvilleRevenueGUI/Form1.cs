// Program written by: Erik Johnson, Jake Frasier
//       Program date: 2/15/17
//Program description:  Greenville Revenue Chapter 4, Case Problem 1
// Encountered issues: 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lastYearContestants, thisYearContestants, expectedRevenue;
            
            
            lastYearContestants = Convert.ToDouble(lastYearTextBox.Text);
            thisYearContestants = Convert.ToDouble(thisYearTextBox.Text);
            expectedRevenue = thisYearContestants * 25; // entrence fee is $25
            expectedRevenueLabel.Text=("This year's projected income is "+ expectedRevenue.ToString("C"));
           
            expectedRevenueLabel.Visible = true;
            greaterLabel.Visible = true;

            // check for twice as many contestants
             if ((lastYearContestants * 2) + 1 <= thisYearContestants)
            {
                greaterLabel.Text = "The competition is more than twice as big this year!";
            }
             
             // less than double
            else  
            {
                greaterLabel.Text = "The competition is bigger than ever!";
            }
            // less than or equal to last year
            if (lastYearContestants  >= thisYearContestants)
            {
                greaterLabel.Text = "A tighter race this year! Come out and cast your vote!";
                
            }


        }
    }
}
