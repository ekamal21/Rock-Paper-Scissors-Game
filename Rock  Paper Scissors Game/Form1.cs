using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Ezedien kamal 
namespace Rock__Paper_Scissors_Game
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }   
        int vall;
        Random ran = new Random();
    

        
        private void button4_Click(object sender, EventArgs e)
        {
           vall = ran.Next(1, 4);

            label1.Text = "";
           
            Scissors();
            Paper();
            Rock();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            if (vall  == 1 )
            {
               label1.Text = "The Computer Selected Rock: "  + " Its Tie Game";
            }
            if (vall == 2 )
            {
                label1.Text = "The Computer Selected Paper: " + " The Computer Win";
            }
            if (vall == 3 )
            {
                label1.Text = "The Computer Selected Scissors: " + " You Win!!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Paper() == vall)
            {
                label1.Text = "The Computer Selected Paper: " + " Its Tie Game";
            }
            if (Paper() > vall)
            {
                label1.Text = "The Computer Selected Scissors: " + " The Computer Win!";
            }
            if (Paper() < vall)
            {  
                label1.Text = "The Computer Selected Rock: " + " You Win!!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Scissors() == vall)
            {
                label1.Text = "The Computer Selected Scissors: " + " Its Tie Game";
            }
        
            if (vall == 1)
            {
                label1.Text = "The Computer Selected  Rock: " + " The Computer Win";
            }
        
            if (vall == 2)
            {
                label1.Text = "The Computer Selected  Paper: " + " You Win!!";
            }

          
        }
        public int Rock()
        {
            int Rock = 1;
            return Rock;
        }
        public int Paper()
        {
            int Paper = 2;
            return Paper;
        }
        public int Scissors()
        {
            int Scissors = 3;
            return Scissors;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = "Select Your Choice ".ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
