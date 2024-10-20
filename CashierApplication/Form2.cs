using CashierApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountnamespace;

namespace CashierApplicationEx2
{
    public partial class frmLoginAccount : Form
    {
       


        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void frmLoginAccount_Load(object sender, EventArgs e)
        {
            TBPassword.PasswordChar = '*'; //making password input asterisk
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier("Merilyn Ejido", "BSCS2.1A", "Mimer05", "IceCreamYummy"); // the initialization of fullname, department,username, and password

            // Log the input credentials
            string enteredUsername = TBUsername.Text;
            string enteredPassword = TBPassword.Text;
           

            if (cashier.validateLogin(enteredUsername, enteredPassword)) //to know if its true and equals to value
            {
                MessageBox.Show($"Welcome {cashier.getFullName()} of {cashier.getDepartment()} ");
                frmPurchaseDiscountedItem fdt = new frmPurchaseDiscountedItem();
                fdt.Show();
                this.Hide(); // Hide the login form after successful login
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if wrong input value
            }

        }
    }
    }

namespace UserAccountnamespace // namespace for useraccount
{
    public abstract class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string uName, string password)//the contructor
        {
            this.full_name = name;
            this.user_name = uName;
            this.user_password = password;
        }
        public abstract bool validateLogin(string uName, string password);//the abstract method for validation

        public string getFullName() //return the full name
        {
            
            return this.full_name;
        }
    }

    public class Cashier : UserAccount// inheritance 
    {
        private string department;

        public Cashier(string name, string department, string uName, string password) : base(name, uName, password)// the contructor
        
            {
                this.department = department;
            }
        public override bool validateLogin(string uName, string password)//overriding the validation
        {
           return this.user_name.Equals(uName) && this.user_password.Equals(password);
        }
        public string getDepartment()// return the department
        {
            return this.department;
        }
    }
    }

