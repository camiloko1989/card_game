using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Game
{
    public partial class Form1 : Form
    {

        List<string> userCards = new List<string>() { "0", "0", "0", "0",};
        List<string> pcCards = new List<string>() { "0", "0", "0", "0", };

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

        private void buttonBet_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var tempUser = random.Next(1, 13);
            var tempPC = random.Next(1, 13);

            if(btnUser1.Text == "") //check the first card available for user
            {                   
                if( tempUser <= 10)
                {
                    userCards[0] = tempUser.ToString();
                    btnUser1.Text = tempUser.ToString();
                }
                else if(tempUser == 11)
                {
                    userCards[0] = "11";
                    btnUser1.Text = "J";
                }
                else if (tempUser == 12)
                {
                    userCards[0] = "12";
                    btnUser1.Text = "Q";
                }
                else if (tempUser == 13)
                {
                    userCards[0] = "13";
                    btnUser1.Text = "K";
                }
            }
            else if (btnUser2.Text == "")
            {
                if (tempUser <= 10)
                {
                    userCards[1] = tempUser.ToString();
                    btnUser2.Text = tempUser.ToString();
                }
                else if (tempUser == 11)
                {
                    userCards[1] = "11";
                    btnUser2.Text = "J";
                }
                else if (tempUser == 12)
                {
                    userCards[1] = "12";
                    btnUser2.Text = "Q";
                }
                else if (tempUser == 13)
                {
                    userCards[1] = "13";
                    btnUser2.Text = "K";
                }
            }
            else if (btnUser3.Text == "")
            {
                if (tempUser <= 10)
                {
                    userCards[2] = tempUser.ToString();
                    btnUser3.Text = tempUser.ToString();
                }
                else if (tempUser == 11)
                {
                    userCards[2] = "11";
                    btnUser3.Text = "J";
                }
                else if (tempUser == 12)
                {
                    userCards[2] = "12";
                    btnUser3.Text = "Q";
                }
                else if (tempUser == 13)
                {
                    userCards[2] = "13";
                    btnUser3.Text = "K";
                }
            }
            else if (btnUser4.Text == "")
            {
                if (tempUser <= 10)
                {
                    userCards[3] = tempUser.ToString();
                    btnUser4.Text = tempUser.ToString();
                }
                else if (tempUser == 11)
                {
                    userCards[3] = "11";
                    btnUser4.Text = "J";
                }
                else if (tempUser == 12)
                {
                    userCards[3] = "12";
                    btnUser4.Text = "Q";
                }
                else if (tempUser == 13)
                {
                    userCards[3] = "13";
                    btnUser4.Text = "K";
                }
                buttonBet.Enabled = false;
                
            }
            else
            {
                buttonBet.Enabled = false;
            }

            if (btnPc1.Text == "") //check the first card available for computer
            {
                if (tempPC <= 10)
                {
                    pcCards[0] = tempPC.ToString();
                    btnPc1.Text = tempPC.ToString();
                }
                else if (tempPC == 11)
                {
                    pcCards[0] = "11";
                    btnPc1.Text = "J";
                }
                else if (tempPC == 12)
                {
                    pcCards[0] = "12";
                    btnPc1.Text = "Q";
                }
                else if (tempPC == 13)
                {
                    pcCards[0] = "13";
                    btnPc1.Text = "K";
                }
            }
            else if (btnPc2.Text == "")
            {
                if (tempPC <= 10)
                {
                    pcCards[1] = tempPC.ToString();
                    btnPc2.Text = tempPC.ToString();
                }
                else if (tempPC == 11)
                {
                    pcCards[1] = "11";
                    btnPc2.Text = "J";
                }
                else if (tempPC == 12)
                {
                    pcCards[1] = "12";
                    btnPc2.Text = "Q";
                }
                else if (tempPC == 13)
                {
                    pcCards[1] = "13";
                    btnPc2.Text = "K";
                }
            }
            else if (btnPc3.Text == "")
            {
                if (tempPC <= 10)
                {
                    pcCards[2] = tempPC.ToString();
                    btnPc3.Text = tempPC.ToString();
                }
                else if (tempPC == 11)
                {
                    pcCards[2] = "11";
                    btnPc3.Text = "J";
                }
                else if (tempPC == 12)
                {
                    pcCards[2] = "12";
                    btnPc3.Text = "Q";
                }
                else if (tempPC == 13)
                {
                    pcCards[2] = "13";
                    btnPc3.Text = "K";
                }
            }
            else if (btnPc4.Text == "")
            {
                if (tempPC <= 10)
                {
                    pcCards[3] = tempPC.ToString();
                    btnPc4.Text = tempPC.ToString();
                }
                else if (tempPC == 11)
                {
                    pcCards[3] = "11";
                    btnPc4.Text = "J";
                }
                else if (tempPC == 12)
                {
                    pcCards[3] = "12";
                    btnPc4.Text = "Q";
                }
                else if (tempPC == 13)
                {
                    pcCards[3] = "13";
                    btnPc4.Text = "K";
                }
                buttonBet.Enabled = false;
                CalculateResults();  //Calculate result when all cards were played
            }
            else
            {
                
                buttonBet.Enabled = false;
                
            }

            buttonDone.Enabled = true;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            //list go back to original state
            for(int i=0 ; i<4; i++)
            {
                pcCards[i] = "0";
                userCards[i] = "0";
            }

            //all buttons are empty again
            btnPc1.Text = "";
            btnPc2.Text = "";
            btnPc3.Text = "";
            btnPc4.Text = "";

            btnUser1.Text = "";
            btnUser2.Text = "";
            btnUser3.Text = "";
            btnUser4.Text = "";

            buttonBet.Enabled = true;  //botton for Bet becomes available

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            CalculateResults();




        }


        private void CalculateResults()
        {
            double userResult = Results(userCards);
            double PcResult = Results(pcCards);

            if (userResult > 10 && PcResult > 10)
            {
                MessageBox.Show("Both Blast! Computer Wins!");
            }
            else if (userResult > 10 && PcResult <= 10)
            {
                MessageBox.Show("You Blast! Computer Wins!");
            }
            else if (userResult <= 10 && PcResult > 10)
            {
                MessageBox.Show("Computer Blast! You wins!");
            }
            else if (userResult <= 10 && PcResult <= 10)
            {
                if (userResult > PcResult)
                {
                    MessageBox.Show("You Win!");
                }
                else if (userResult < PcResult)
                {
                    MessageBox.Show("Computer Wins!");
                }
                else
                {
                    MessageBox.Show("You Win!");
                }
            }


        }

        private double Results(List<string> userCards)
        {
            double sum = 0;

            for (int i = 0; i < 4; i++)
            {
                if (double.Parse(userCards[i]) > 10)
                {
                    sum = sum + 0.5;
                }
                else
                {
                    sum = sum + double.Parse(userCards[i]);
                }
                
            }
            return sum;
        }

        
    }
}
