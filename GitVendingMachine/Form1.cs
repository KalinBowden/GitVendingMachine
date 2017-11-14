using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitVendingMachine
{
    // This class will simulate a vending machine
    public partial class Form1 : Form
    {
        // Class level fields
        Item[] vendingItems = new Item[25];
        string[] names = {"Snickers", "Snickers", "Snickers", "Jelly Beans", "Coke", "Pepsi", "Coffee", "Cupcakes", "Mnt Dew", "MntDew", "Twix", "Code Red", "Code Red", "Code Red", "Twinkies", "Twinkies", "Twinkies", "Vannila Coke", "Red Bull", "Monster", "NOS", "Surge", "Twix", "Juicy Fruit", "Zebra Cakes", "Rice Krispy"};
        int[] counts = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5};
        double[] prices = { 1.25, 1.25, 1.25, 1.00, 1.50, 1.50, .85, 1.00, 1.10, 1.10, 1.50, 1.25, 1.25, 1.25, 1.25, 1.10, 1.25, 1.50, 1.50, 1.10, 1.25, 1.25, 1.10, 1.00, 1.00, .95 };

        bool isSwipped = false; 



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fill the vending machine
            for (int i = 0; i < vendingItems.Length; i++)
            {
                vendingItems[i] = new Item(names[i], counts[i], prices[i]);
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBxScreen.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBxScreen.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBxScreen.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBxScreen.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBxScreen.Text += 5;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtBxScreen.Text += 6;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtBxScreen.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBxScreen.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBxScreen.Text += 9;
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBxScreen.Text += 0;
        }

        private void btnPound_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBxScreen.Text = "";
            isSwipped = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxScreen.Text = "";
        }


        // When the user click enter attempt to vent an item
        private void btnEnter_Click(object sender, EventArgs e)
        {
            int temp;
            int.TryParse(txtBxScreen.Text, out temp);


            // If the user has swiped thier card and enters an item number
            // attempt to vend an item.
            if (isSwipped && temp < vendingItems.Length)
            {
                if (vendingItems[temp].Count > 0)
                {
                    vendingItems[temp].Count--;
                    txtBxScreen.Text = "Vending...";
                }
                else
                {
                    txtBxScreen.Text = "Out of Stock. Try again.";
                }
            }
            else
            {
                txtBxScreen.Text = "Please select another item";
            }


            // If the user has not swiped thier card and enters an item number
            // disply the price.
            if (!isSwipped && temp < vendingItems.Length)
            {
                if (vendingItems[temp].Count > 0)
                {
                    txtBxScreen.Text = string.Format("Price: {0:C2}", vendingItems[temp].Price);
                }
                else
                {
                    txtBxScreen.Text = "Out of Stock. Try again.";
                }
            }

            isSwipped = false;
        }

        private void btnSwipeCard_Click(object sender, EventArgs e)
        {
            isSwipped = true;
        }
    }
}
