using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class CoffeShopUi : Form
    {
        public CoffeShopUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int quantity,totalPrice=0;
            string name, contact, address, orderItem;

            name = nameTextBox.Text;
            contact = contactTextBox.Text;
            address = addressTextBox.Text;
            orderItem = orderComboBox.Text;
            quantity = Convert.ToInt16(quantityTextBox.Text);

            if (orderItem == "")
            {
                MessageBox.Show("Select your ITEM");
                return;
            }
            else { 
            if (orderItem =="Black")
            {
                totalPrice = quantity * 120;
            }
            else if (orderItem == "Cold")
            {
                totalPrice = quantity * 100;
            }
            else if (orderItem == "Hot")
            {
                totalPrice = quantity * 90;
            }
            else if (orderItem == "Reguler")
            {
                totalPrice = quantity * 80;
            }
            richTextBox.Text = ("\t Purchase order \t" + "\n Name :" + name + "\n Contact No. :" + contact +
                "\n Address :" + address + "\n Order :" + orderItem + "\n Quantity :" + quantity + "\n Total Price:" + totalPrice + "\n\t **** Thank You**** \t");
            }
        }
    }
}
