using System.Collections;

namespace Bagel_and_Coffee_Shop
{
    public partial class Form1 : Form
    {
        private String Bagel = "White";
        private String Coffee = "NoCoffee";
        private ArrayList Toppings = [];
        private const double TaxRate = 0.07;

        public Form1()
        {
            InitializeComponent();
        }

        private void ResetLabels()
        {
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(53, 26, 0);
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(53, 26, 0);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(53, 26, 0);
        }


        private void radWhite_CheckedChanged(object sender, EventArgs e)
        {
            this.Bagel = "White";
            ResetLabels();
        }

        private void radWheat_CheckedChanged(object sender, EventArgs e)
        {
            this.Bagel = "Whole wheat";
            ResetLabels();
        }

        private void addTopping(String topping, String toggle)
        {
            if (toggle == "True")
            {
                this.Toppings.Add(topping);
            }
            else
            {
                this.Toppings.Remove(topping);
            }
            ResetLabels();
        }

        private void chkCreamCheese_CheckedChanged(object sender, EventArgs e)
        {
            addTopping("CreamCheese", this.chkCreamCheese.Checked.ToString());
        }

        private void chkButter_CheckedChanged(object sender, EventArgs e)
        {
            addTopping("Butter", this.chkButter.Checked.ToString());
        }

        private void chkBlueberry_CheckedChanged(object sender, EventArgs e)
        {
            addTopping("Blueberry", this.chkBlueberry.Checked.ToString());

        }

        private void chkRaspberry_CheckedChanged(object sender, EventArgs e)
        {
            addTopping("Raspberry", this.chkRaspberry.Checked.ToString());

        }

        private void chkPeach_CheckedChanged(object sender, EventArgs e)
        {
            addTopping("Peach", this.chkPeach.Checked.ToString());

        }

        private void radNoCoffee_CheckedChanged(object sender, EventArgs e)
        {
            this.Coffee = "NoCoffee";
            ResetLabels();
        }

        private void radRegCoffee_CheckedChanged(object sender, EventArgs e)
        {
            this.Coffee = "RegCoffee";
            ResetLabels();

        }

        private void radCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            this.Coffee = "Cappuccino";
            ResetLabels();

        }

        private void radCafeAuLait_CheckedChanged(object sender, EventArgs e)
        {
            this.Coffee = "CafeAuLait";
            ResetLabels();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double BagelCost()
        {
            if (this.Bagel == "White")
                return 1.25;
            else if (this.Bagel == "Whole wheat")
                return 1.50;
            else
                return 0.0;
        }

        private double ToppingCost()
        {
            double cost = 0.0;
            foreach (string topping in this.Toppings)
            {
                switch (topping)
                {
                    case "CreamCheese":
                        cost += 0.50;
                        break;
                    case "Butter":
                        cost += 0.25;
                        break;
                    case "Blueberry":
                        cost += 0.75;
                        break;
                    case "Raspberry":
                        cost += 0.75;
                        break;
                    case "Peach":
                        cost += 0.75;
                        break;
                }
            }
            return cost;
        }

        private double CoffeeCost()
        {
            switch (this.Coffee)
            {
                case "RegCoffee":
                    return 1.25;
                case "Cappuccino":
                    return 2.00;
                case "CafeAuLait":
                    return 1.75;
                default:
                    return 0.0;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double bagelCost = BagelCost();
            double toppingCost = ToppingCost();
            double coffeeCost = CoffeeCost();

            double subtotal = bagelCost + toppingCost + coffeeCost;
            double tax = subtotal * TaxRate;
            double total = subtotal + tax;

            this.lblSubtotal.Text = "$" + subtotal.ToString("0.00");
            this.lblTax.Text = "$" + tax.ToString("0.00");
            this.lblTotal.Text = "$" + total.ToString("0.00");

            this.lblSubtotal.ForeColor = System.Drawing.Color.Green;
            this.lblTax.ForeColor = System.Drawing.Color.Green;
            this.lblTotal.ForeColor = System.Drawing.Color.Green;
        }

        private void ResetBagels()
        {
            this.Bagel = "White";
            this.radWhite.Checked = true;
        }

        private void ResetToppings()
        {
            this.Toppings.Clear();
            this.chkCreamCheese.Checked = false;
            this.chkButter.Checked = false;
            this.chkBlueberry.Checked = false;
            this.chkRaspberry.Checked = false;
            this.chkPeach.Checked = false;
        }

        private void ResetCoffee()
        {
            this.Coffee = "NoCoffee";
            this.radNoCoffee.Checked = true;
        }

        private void ResetPrice()
        {
            this.lblSubtotal.Text = "$0.00";
            this.lblTax.Text = "$0.00";
            this.lblTotal.Text = "$0.00";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetBagels();
            ResetToppings();
            ResetCoffee();
            ResetPrice();
            ResetLabels();
            radWhite.Focus();
        }
    }
}
