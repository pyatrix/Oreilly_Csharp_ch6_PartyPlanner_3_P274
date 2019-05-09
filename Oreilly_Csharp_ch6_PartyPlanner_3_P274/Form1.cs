using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oreilly_Csharp_ch6_PartyPlanner_3_P274
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)NumberDinnerChange.Value, DinnerHealthyCheak.Checked, DinnerFancyCheck.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)NumberBirthdayChange.Value, BirthdayFancyCheck.Checked, BirthdayTextBox.Text);
            DisplayBirthdayPartyCost();

        }

        private void NumberBirthdayChange_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)NumberBirthdayChange.Value;
            DisplayBirthdayPartyCost();
        }

        private void BirthdayFancyCheck_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = BirthdayFancyCheck.Checked;
            DisplayBirthdayPartyCost();
        }

        private void CakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = BirthdayTextBox.Text;
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            TooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal Birthdaycost = birthdayParty.Cost;
            BirthdayCostLabel.Text = Birthdaycost.ToString("c");
        }

        private void DisplayDinnerPartyCost()
        {
            decimal DinnerCost = dinnerParty.Cost;
            DinnerCostLabel.Text = DinnerCost.ToString("c");
        }

        private void DinnerHealthyCheak_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyDecorations = DinnerHealthyCheak.Checked;
            DisplayDinnerPartyCost();
        }

        private void DinnerFancyCheck_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = DinnerFancyCheck.Checked;
            DisplayDinnerPartyCost();
        }

        private void NumberDinnerChange_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)NumberDinnerChange.Value;
            DisplayDinnerPartyCost();
        }
    }
}
