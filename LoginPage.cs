using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFinApp
{
    public partial class Loginpage : Form
    {

        private static String email; // current email loged in 
        private static String password; // current email loged in

        public Loginpage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void textUsarname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e) // not register yet label 
        {

            new RegisterPage().Show();
            this.Hide();
        }
          
        private void button1_Click(object sender, EventArgs e)  // LOGIN BUTTON
        {
            string at_rm = "@rm.gofinance.com";  // variables needs to decide if a user is rm or idea creator
            string at_idc = "@idc.gofinance.com";



            DBConnectionClass dbConn = DBConnectionClass.getInstanceDBConnectionClass();



            string emailLogin = textUsarname.Text;
            string passwordLogin = textPassword.Text;


            bool ValueLogin = dbConn.getUsurnamPass("SELECT * FROM [RelationManager] ", emailLogin, passwordLogin);
           
            if (ValueLogin == true)// && emailLogin.Contains(at_rm))  //remeber to put it back
            {
                email = emailLogin; // give the value to email so can be used in setting page
                password = passwordLogin;
               

                MessageBox.Show("Welcome back!");
                
                var OpenMenu = new Menu(); // if the valuelogin is true e message is shows and opens a dashboard page
                OpenMenu.Show();
                this.Hide();// hide the window login 

            }
            else if(ValueLogin == true && emailLogin.Contains(at_idc)) // the value is equal at_idc is going to open product page for idc idea creator
            {
                email = emailLogin;
                password = passwordLogin;
                new ProductPage().Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("The Email or Password you entered is incorrect, TRY AGAIN!");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

      


        }

        private void label3_Click(object sender, EventArgs e) // FORGET PASSWORD LABEL 
        {
            new forgetPasswordPage().Show(); // open forrget passsword page
            this.Hide();// hide the window login 
        }

        private void label5_Click(object sender, EventArgs e) // CLEAR FIELD label 
        {
            textUsarname.Clear();
            textPassword.Clear();
            textUsarname.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        public string getEmail() // methods  need for setting page 
        {
            return email;
        }

        public string getPassword()
        {
            return password;
        }
    }
}
