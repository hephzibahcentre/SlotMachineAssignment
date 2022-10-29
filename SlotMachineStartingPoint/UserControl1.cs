using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace SlotMachineStartingPoint
{
    public partial class UserControl1: UserControl
    {
        //Initialize/declare class level variables

        Bitmap spinbar = Properties.Resources.bar;
        Bitmap spinbell = Properties.Resources.bell;
        Bitmap spincherry = Properties.Resources.cherry;
        Bitmap spingrape = Properties.Resources.grape;
        Bitmap spinlemon = Properties.Resources.lemon;
        Bitmap spinmelon = Properties.Resources.melon;
        /*Bitmap spinorange = Properties.Resources.orange;
        Bitmap spinplum = Properties.Resources.plum;
        Bitmap spinseven = Properties.Resources.seven;*/

        double currentMultiplier = 0.00;

        double totalWin = 0.00;
        double totalLoss = 0.00;
        double totalNet = 0.00;

        int spin1 = 0;
        int spin2 = 0;
        int spin3 = 0;

        int milliseconds = 2000;

        public UserControl1()
        {
            InitializeComponent();
        }

        //Increment win and format to two decimal places
        private void outputWinIncrement()
        {
            outputWin.Text = "$"+String.Format("{0:0.00}", totalWin);
        }

        //Increment loss and format to two decimal places
        private void outputLossIncrement()
        {
            outputLoss.Text = "$" + String.Format("{0:0.00}", totalLoss);
        }

        //Increment net and format to two decimal places
        private void outputNetTotal()
        {
            totalNet = totalWin - totalLoss;
            outputNet.Text = "($" + String.Format("{0:0.00}", totalNet) + ")";
        }

        //Spin button functionality and code
        private async void runSpin()
        {
            //Switch to a compressed version for background image
            spinButton.BackgroundImage = Properties.Resources.handle_compressed;

            Image[] images = { spinbar, spinbell, spincherry, spingrape, spinlemon, spinmelon };
            double[] spinvalues = { 2.00, 3.25, 4.5, 5.75, 8.25, 16.00 };

            //Initialize rolling images
            spinBox1.Image = Properties.Resources.spinning;
            spinBox2.Image = Properties.Resources.spinning;
            spinBox3.Image = Properties.Resources.spinning;

            //Random integers for choosing spin images
            Random rnd = new Random();
            spin1 = rnd.Next(1, 7);
            spin2 = rnd.Next(1, 7);
            spin3 = rnd.Next(1, 7);

            //add a delay to allow animation
            await Task.Delay(milliseconds);

            //pick displayed spin images based on random numbers
            spinBox1.Image = images[spin1 - 1];
            spinBox2.Image = images[spin2 - 1];
            spinBox3.Image = images[spin3 - 1];

            //Test to see if it's a win or loss
            if (spin1 == spin2 && spin1 == spin3)
            {
                totalWin = totalWin + (spinvalues[spin1 - 1] + (currentMultiplier * spinvalues[spin1 - 1]));
                outputWinIncrement(); //Increment win
            }
            else
            {
                totalLoss = totalLoss + currentMultiplier;
                outputLossIncrement(); //Increment loss
            }

            outputNetTotal(); //Increment Net
            
            //Change backround image to full handle image
            spinButton.BackgroundImage = Properties.Resources.handle;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        //Run spin on click of spin button
        private void spinButton_Click(object sender, EventArgs e)
        {
            runSpin();
        }

        //Run click on mouse up
        private void spinButton_MouseUp()
        {
            runSpin();
        }

        //Reset background for bet amount buttons
        private void clearMultiplierBG()
        {
            multi10cents.BackColor = SystemColors.Control;
            multi5cents.BackColor = SystemColors.Control;
            multi25cents.BackColor = SystemColors.Control;
            multi1dollar.BackColor = SystemColors.Control;
        }

        //Actions for 5 cents button click
        private void multi5cents_Click(object sender, EventArgs e)
        {
            currentMultiplier = 0.05;
            clearMultiplierBG();
            multi5cents.BackColor = Color.OrangeRed;
        }

        //Actions for 10 cents button click
        private void multi10cents_Click(object sender, EventArgs e)
        {
            currentMultiplier = 0.10;
            clearMultiplierBG();
            multi10cents.BackColor = Color.OrangeRed;
        }

        //Actions for 25 cents button click
        private void multi25cents_Click(object sender, EventArgs e)
        {
            currentMultiplier = 0.25;
            clearMultiplierBG();
            multi25cents.BackColor = Color.OrangeRed;
        }

        //Actions for 1 dollar button click
        private void multi1dollar_Click(object sender, EventArgs e)
        {
            currentMultiplier = 1.00;
            clearMultiplierBG();
            multi1dollar.BackColor = Color.OrangeRed;
        }
    }
}
