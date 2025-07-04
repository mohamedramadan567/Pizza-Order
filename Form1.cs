using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            lblSize.Text = "Small";
            CalculateTotalPrice();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            lblSize.Text = "Meduim";
            CalculateTotalPrice();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            lblSize.Text = "Large";
            CalculateTotalPrice();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustType.Text = "Thin Crust";
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustType.Text = "Think Crust";
            CalculateTotalPrice();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereToEat.Text = "Eat In";
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereToEat.Text = "Take Out";
        }

        private void UpdateToppingsLabel()
        {
            string Toppings = "";

            if (cbExtraCheese.Checked)
                Toppings += "Extra Cheese, ";

            if (cbMushrooms.Checked)
                Toppings += "Mushrooms, ";

            if (cbTomatoes.Checked)
                Toppings += "Tomatoes, ";

            if (cbOnion.Checked)
                Toppings += "Onion, ";

            if (cbOlives.Checked)
                Toppings += "Olives, ";

            if (cbGreenPeppers.Checked)
                Toppings += "Green Peppers, ";

            if (Toppings == "")
                lblToppings.Text = "No Toppings";

            else
            {
                Toppings = Toppings.Substring(0, Toppings.Length - 2);
                lblToppings.Text = Toppings;
            }
        }

        private void cbExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
            CalculateTotalPrice();
        }

        private void cbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
            CalculateTotalPrice();
        }

        private void cbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
            CalculateTotalPrice();
        }

        private void cbOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
            CalculateTotalPrice();
        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
            CalculateTotalPrice();
        }

        private void cbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice ()
        {
            int TotalPrice = 0;

            if (rbSmall.Checked)
                TotalPrice += 20;

            if (rbMeduim.Checked)
                TotalPrice += 30;

            if (rbLarge.Checked)
                TotalPrice += 40;

            if (rbThink.Checked)
                TotalPrice += 10;

            if (cbExtraCheese.Checked)
                TotalPrice += 5;

            if (cbOlives.Checked)
                TotalPrice += 5;

            if (cbMushrooms.Checked)
                TotalPrice += 5;

            if (cbTomatoes.Checked)
                TotalPrice += 5;

            if (cbOnion.Checked)
                TotalPrice += 5;

            if (cbGreenPeppers.Checked)
                TotalPrice += 5;

            
            lblTotalPrice.Text = "$" + TotalPrice;
            
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
            }
            
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrderPizza.Enabled = true;

            rbMeduim.Checked = true;
            rbThin.Checked = true;
            cbExtraCheese.Checked = false;
            cbMushrooms.Checked = false;
            cbTomatoes.Checked = false;
            cbOnion.Checked = false;
            cbOlives.Checked = false;
            cbGreenPeppers.Checked = false;

            rbEatIn.Checked = true;
        }
    }
}
