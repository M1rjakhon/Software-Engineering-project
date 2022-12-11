using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFinApp
{
    public partial class RegisterPage : Form
    {

        public  static string At;

        public RegisterPage()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e) // already have an account login label in case the user has the login detil already
        {
            new Loginpage().Show(); // open text client page
            this.Hide();
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  // register button
        {
            DBConnectionClass dbConn = DBConnectionClass.getInstanceDBConnectionClass();
            // capture the string taht the user will type



            bool flag = true; // variabile needs to check if a values filled are corrrect or not

            string FirstName = " ";// text is an attribute of the textBox, which gives as back an stiing 
            string LastName = " ";
            string Email = " ";
            string Password = " ";
            string at_rm = "@rm.gofinance.com"; // need for checking if the valeu is email and that belog to gofinace app // rm
            string at_idc = "@idc.gofinance.com"; // need for checking if the valeu is email and that belog to gofinace app // idc 
            if (flag)
            {
                if (textFirstName.Text.Length < 3 || textFirstName.Text.Length > 25 || (Regex.IsMatch(textFirstName.Text, @"^[0-9]+$")) )// Shortes name the prohram accept is 3 letters //  second conditon check if th estring conatin any number inside of it
                {
                    error_first_name.Text = "*Incorrect First Name, Please insert your First Name";
                    flag = false;
                }
                else
                {
                    FirstName = textFirstName.Text;/// text is an attribute of the textBox, which gives as back an stiing 

                }

                if (textLastName.Text.Length < 3 || textLastName.Text.Length > 25 || (Regex.IsMatch(textLastName.Text, @"^[0-9]+$"))) // same things of the first name 
                {
                    error_last_name.Text = "*Incorrect Last Name, Please insert your Last Name";
                    flag = false;
                }
                else
                {
                    LastName = textFirstName.Text;/// text is an attribute of the textBox, which gives as back an stiing 

                }


                if(textnewEmail.Text.Length > 50 || (Email.Contains(at_rm) != true || Email.Contains(at_idc) != true)) // Shortes name the prohram accept is 10 letters   // check if the email inserted is belong to gofincance
                {
                    error_email.Text = "*Incorrect Email, Please insert your Email";
                    flag = false;

                }
                else
                {
                     Email = textnewEmail.Text;/// text is an attribute of the textBox, which gives as back an stiing 

                }

                if (textNewPassord.Text.Length < 8) // Shortes name the prohram accept is 8 letters 
                {

                    error_password.Text = "*Incorrect Password, Password Must Be 8 Characters";
                    flag = false;
                    //   error_first_name.Text = "*Incorrect Password"; // 
                }
                else
                {

                    Password = textNewPassord.Text;
                    /// text is an attribute of the textBox, which gives as back an stiing 

                }


                if(flag == false)
                {
                    //label3_Click(sender, e);

                }
                else
                {

                    dbConn.saveToDB("INSERT INTO RelationManager (FirstName, LastName, Email , Password) VALUES (@FirstName, @LastName, @Email , @Password)", FirstName, LastName, Email, Password);
                    // we have 6 parameter + insert  = 7  // remember we do not send the values directlry this why used values AND WE WRITE HTE OTHER 6 PARAMETER 


                    new Loginpage().Show();
                    MessageBox.Show("You are registered");
                    this.Hide();
                }




            }
        
            // string FirstName = textFirstName.Text;// text is an attribute of the textBox, which gives as back an stiing 
            // string LastName = textLastName.Text;
            //string Email = textnewEmail.Text;
            //string Password = textNewPassord.Text;
            // int age = Convert.ToInt32(textAge.Text);

            // call  amethod that insert these data into the database from DBconnectionClass is called saveTpDB 

            //DataSet datasetRM = dbConn.getDataSet("SELECT * FROM RM"); // RM is the name of the table // now we have the dataset

            //dbConn.saveToDB("INSERT INTO RelationManager (FirstName, LastName, Email , Password) VALUES (@FirstName, @LastName, @Email , @Password)", FirstName, LastName, Email, Password);
            // we have 6 parameter + insert  = 7  // remember we do not send the values directlry this why used values AND WE WRITE HTE OTHER 6 PARAMETER 
            // 

            //new Loginpage().Show();
            //MessageBox.Show("You are registered");
            //this.Hide();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNewPassord_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e) // clear field label 
        {
            error_email.Text = " ";
            error_first_name.Text = " ";
            error_last_name.Text = " ";
            error_password.Text = " ";
            textFirstName.Clear();
            textLastName.Clear();
            textnewEmail.Clear();
            textNewPassord.Clear();
            textFirstName.Focus();

        }

        private void textnewEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void error_last_name_Click(object sender, EventArgs e)
        {

        }
    }
}
