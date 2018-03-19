using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BuyingAndSelling BASLogic;
        int threadsWanted;

        private void ButtonClick(object sender, EventArgs e)
        {
            Debug.Print("Palindromes");
            switchToPalindromes();
        }

        private void Buying_And_Selling_Click(object sender, EventArgs e)
        {
            Debug.Print("Buying and Selling");
            switchToBAS();
        }


        private void hidePrimaryWindow()
        {
            Palindrome_Input_Label.Hide();
            Palindrome_Input_Textbox.Hide();
            Find_Palindrome_Activation_Button.Hide();
            Find_If_Palindrome_Button.Hide();
            Palindrome_Output.Hide();

            BAS_Num_Products_Input.Hide();
            BAS_Product_Num_Label.Hide();
            BAS_Num_Threads_input.Hide();
            BAS_Thread_Label.Hide();
            Buying_And_Selling_Start_Button.Hide();
            Step_BAS_Simulation_Button.Hide();
            BAS_Chart.Hide();
        }

        private void switchToPalindromes()
        {
            hidePrimaryWindow();
            Palindrome_Input_Label.Show();
            Palindrome_Input_Textbox.Show();
            Find_Palindrome_Activation_Button.Show();
            Find_If_Palindrome_Button.Show();
            Palindrome_Output.Show();
        }

        private void Palindrome_Input_Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                checkIfPalindrome(Palindrome_Input_Textbox.Text);
            }
        }

        private void Find_Palindrome_Activation_Button_Click(object sender, EventArgs e)
        {
            checkIfPalindrome(Palindrome_Input_Textbox.Text);
        }

        private void checkIfPalindrome(String input)
        {
            Palindrome_Finder PalindromeLogic = new Palindrome_Finder(input);
            Palindrome_Output.Text = PalindromeLogic.findLargestPalindrome();
        }

        private void Find_If_Palindrome_Button_Click(object sender, EventArgs e)
        {
            Palindrome_Finder PalindromeLogic = new Palindrome_Finder(Palindrome_Input_Textbox.Text);
            Palindrome_Output.Text = PalindromeLogic.checkIfPalindrome().ToString();
        }


        private void switchToBAS()
        {
            hidePrimaryWindow();
            BAS_Num_Products_Input.Show();
            BAS_Num_Threads_input.Show();
            BAS_Product_Num_Label.Show();
            BAS_Thread_Label.Show();
            Buying_And_Selling_Start_Button.Show();
            Step_BAS_Simulation_Button.Show();
            BAS_Chart.Show();
        }

        private void Buying_And_Selling_Start_Button_Click(object sender, EventArgs e)
        {
            int productsWanted;
            if(BAS_Num_Products_Input.Text.Length == 0)
            {
                productsWanted = 1;//default value
            }
            else
            {
                productsWanted = int.Parse(BAS_Num_Products_Input.Text);
            }

            if(BAS_Num_Threads_input.Text.Length == 0)
            {
                threadsWanted = 4;//default value
            }
            else
            {
                threadsWanted = int.Parse(BAS_Num_Threads_input.Text);
            }
            BASLogic = new BuyingAndSelling(productsWanted, threadsWanted);
            BASLogic.RunSimulationStep();

            updateBASChart();
        }

        private void Step_BAS_Simulation_Button_Click(object sender, EventArgs e)
        {
            BASLogic.RunSimulationStep();
            updateBASChart();
        }

        private void updateBASChart()
        {

            //we do need to busy wait for the various threads in the background to complete their tasks
            //in a more refined solution, this would be programmed as a background worker so that the UI doesn't block on the update step
            //but for now this should be sufficient to see that the data is being updated correctly.
            Thread.Sleep(threadsWanted * 50);

            BAS_Chart.Series[0].Points.Clear();

            Product[] productInfo = BASLogic.getProductInformation();

            for (int i = 0; i < productInfo.Length; i++)
            {
                BAS_Chart.Series[0].Points.AddXY(i, (double)productInfo[i].getStock());
            }
            BAS_Chart.Invalidate();
        }


    }
}
