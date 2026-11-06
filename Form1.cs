using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukyCafeOrder
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            btnCalculate.Click += btnCalculate_Click;
            btnSave.Click += btnSave_Click;
            btnLoad.Click += btnLoad_Click;
            btnClear.Click += btnClear_Click;
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblLuckyMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int quantity;
            double price = 0;
            string drink = "";

            //if (txtCustomerName.Text == "")
            //{
            //  MessageBox.Show("Enter Customer Name");
            //   return;
            //}

            if (txtCustomerName.Text == "" || !txtCustomerName.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Enter correct Customer Name");
                return;
            }


            if (!int.TryParse(textQuantity.Text, out quantity) || quantity < 1)
            {
                MessageBox.Show("Enter correct Quantity");
                return;
            }

            if (rdoTea.Checked)
            {
                price = 1;
                drink = "Tea";
            }
            else if (rdoCoffee.Checked)
            {
                price = 2;
                drink = "Coffee";
            }
            else if (rdoJuice.Checked)
            {
                price = 3;
                drink = "Juice";
            }
            else
            {
                MessageBox.Show("Choose a Drink");
                return;
            }

            ListBoxOrder.Items.Clear();

            Random rand = new Random();
            double total = price * quantity;
            bool lucky = false;

            for (int i = 1; i <= quantity; i++)
            {
                int number = rand.Next(1, 51);

                if (number == 7 || number == 17)
                {
                    lucky = true;
                }

                ListBoxOrder.Items.Add(i + ". " + txtCustomerName.Text +
                    " - " + drink + " - Lucky: " + number +
                    " - $" + price.ToString("0.00"));
            }

            double finalTotal = total;

            if (chkStudentMember.Checked)
            {
                finalTotal = total * 0.90;
                ListBoxOrder.Items.Add("Member Discount: 10%");
            }

            ListBoxOrder.Items.Add("Total Before Discount: $" + total.ToString("0.00"));
            ListBoxOrder.Items.Add("Total After Discount: $" + finalTotal.ToString("0.00"));

            string message;

            if (lucky)
            {
                message = "You got a Free Cookie!";
            }
            else
            {
                message = "No prize this time.";
            }

            ListBoxOrder.Items.Add("Lucky Message: " + message);

            lblTotalPrice.Text = "Total Price: $" + finalTotal.ToString("0.00");
            lblLuckyMessage.Text = "Lucky Message: " + message;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ListBoxOrder.Items.Count == 0)
            {
                MessageBox.Show("No order to save.");
                return;
            }

            StreamWriter sw = new StreamWriter("orders.txt", true);

            foreach (var item in ListBoxOrder.Items)
            {
                sw.WriteLine(item);
            }

            sw.Close();

            MessageBox.Show("Order saved.");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists("orders.txt"))
            {
                ListBoxOrder.Items.Clear();

                StreamReader sr = new StreamReader("orders.txt");

                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    ListBoxOrder.Items.Add(line);
                }

                sr.Close();
            }
            else
            {
                MessageBox.Show("No file found.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            textQuantity.Clear();

            ListBoxOrder.Items.Clear();

            lblTotalPrice.Text = "Total Price: $0.00";
            lblLuckyMessage.Text = "";

            rdoTea.Checked = false; 
            rdoCoffee.Checked = false;
            rdoJuice.Checked = false;

            chkStudentMember.Checked = false;
        }
    }
}





