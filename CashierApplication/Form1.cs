using System.Diagnostics;
using System.Runtime.CompilerServices;
using CashierApplication;
using ItemNamespace;
using CashierApplicationEx2;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private DiscountedItem item; //declaring object of the other classes in other namespace
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();

        }
        private void frmPurchaseDiscountedItem_Load(object sender, EventArgs e)
        {
        }
        private void BCompute_Click(object sender, EventArgs e)
        {
            try
            {
                // To know if the text box is empty 
                if (string.IsNullOrWhiteSpace(TBItem.Text) ||
                    string.IsNullOrWhiteSpace(TBPrice.Text) ||
                    string.IsNullOrWhiteSpace(TBQuantity.Text) ||
                    string.IsNullOrWhiteSpace(TBDiscount.Text))
                {
                    MessageBox.Show("Please input the item name, price, discount, and quantity.");
                    return;
                }
                // the inputs of user
                string ItemName = TBItem.Text;
                double ItemPrice = Convert.ToDouble(TBPrice.Text);
                int ItemQuantity = Convert.ToInt32(TBQuantity.Text);
                double Discount = Convert.ToDouble(TBDiscount.Text);

                item = new DiscountedItem(ItemName, ItemPrice, ItemQuantity, Discount); // instance of DiscountedItem and then get the input of user

                double TotalAmount = item.getTotalPrice();  // Calculate total amount and display it in label
                LBAmount.Text = TotalAmount.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter numbers for price, discount, and quantity."); //when the input of user is not a number to calculate then show this
            }
        }
        private void BSubmit_Click(object sender, EventArgs e)
        {
            if (item == null) // when the item is no input and payment then you cant change
            {
                MessageBox.Show("Compute first the item.");
                return;
            }
            try
            {
                double Payment = Convert.ToDouble(TBPayment.Text); // input of user in payment 

                item.setPayment(Payment); // Set the payment to calculate the change
                double change = item.getChange();

                LBChange.Text = change.ToString("F2"); // Display the change
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a number for payment."); //when the payment is not number 
            }
        }


        private void MTFile_Click(object sender, EventArgs e)
        {


        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question); //if want to exit the application
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Exit the application
            }
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to Logout?", "Logout Confirmation",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);// if they want to logout or not
            if (result == DialogResult.Yes)
            {
                frmLoginAccount fla = new frmLoginAccount();// object of the class form1 to back again 
                fla.Show();
                this.Hide();// Exit the previous application
            }
        }
    }
}
    namespace ItemNamespace // new namespace for the 2 class
    {
        public abstract class Item // making it abstract class for security purposes and efficient
        {  //declaring the needed variable
            protected string item_name;
            protected double item_price;
            protected int item_quantity;
            private double total_price;

            public Item(string name, double price, int quantity) // the constructor
            {
                this.item_name = name;
                this.item_price = price;
                this.item_quantity = quantity;
            }
            public abstract double getTotalPrice(); // abstract method
            public abstract void setPayment(double amount); //this one too

        }
    
        public class DiscountedItem : Item //discountedItem the subclass of baseclass Item
        {// the needed variable and declaring it to show the access modiffier 
            private double item_discount;
            private double discounted_price;
            private double payment_amount;
            private double change;

            public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity) // the constructor
            {
                this.item_discount = discount;
            }
            public override double getTotalPrice() // overriding the abstract method of gettotalprice
            {
                double total = item_price * item_quantity;
                double discountAmount = total * (this.item_discount * 0.01);
                return total - discountAmount;
            }
            public override void setPayment(double amount) // overriding the abstract method setpayment
            {
                this.payment_amount = amount;
            }
            public double getChange() //the method that calculate the change
            {
                double total = getTotalPrice();
                return this.payment_amount - total;
            }
        }
    }