using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagement
{
    
    public partial class Form1 : Form
    {
        MySqlConnection con = null;    //Instance variable
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)     
        {
            try
            {   // Login button

                string connstring = "server=localhost;uid=root;pwd=root;database=library";  // String holds the connection details of server, username,pw,database
                con = new MySqlConnection();    //An instance of MySqlConnection is created to establish a connection to the database
                con.ConnectionString = connstring;  
                con.Open();   //Open the connection   
                string sql = "select count(*) from logintable where user=@username and password=@password"; //Check for count of rows that match the username and password
                MySqlCommand cmd = new MySqlCommand(sql, con);  //MySqlCommand object (cmd) created with the SQL query and the established database connection
                cmd.Parameters.AddWithValue("@username", txtUser.Text);     //Parameters @username and @password  added to the command to prevent SQL injection
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                int count = Convert.ToInt32(cmd.ExecuteScalar());   

               
                if (count==1)
                {
                   
                    Form2 x = new Form2(con);   //Login and go to the next form
                    x.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or password");    //Display error message
                
                 
                }

            }
            catch (MySqlException ex)   //Allows to define a block of code to be executed, if an error occurs in the try block
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
              txtUser.Text = txtPassword.Text = "";  //Clear button
        }

        private void btnExit_Click(object sender, EventArgs e)
        { 
            this.Close();   //Exit button

             if(con!= null)
                     { 
                         con.Close();    //Close the connection
                     }
           

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtUser_MouseEnter(object sender, EventArgs e)
        {

           
        }

        private void txtUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }
    }
}