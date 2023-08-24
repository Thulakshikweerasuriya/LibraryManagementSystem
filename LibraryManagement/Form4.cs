using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagement
{
    public partial class Form4 : Form
    {
        MySqlConnection con;    //Instance variable con
        public Form4(MySqlConnection con)   //Constructor with the parameter
        {
            InitializeComponent();
            this.con = con;     //Assign the value of parameter inside the constructor
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthorName.Text != "" && txtPrice.Text != "" && txtPublication.Text != "" && txtQuantity.Text != "")
            {
                string bookName = txtBookName.Text;
                string bookAuthor = txtAuthorName.Text;
                string publicarion = txtPublication.Text;
                string pDate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 quantity = Int64.Parse(txtQuantity.Text);



                //string sql = "select * from newbook";
                string sql = "insert into NewBook(bName, bAuthor, bPubl, bPDate, bPrice, bQuantity) values('" + bookName + "', '" + bookAuthor + "', '" + publicarion + "', '" + pDate + "', " + price + ", " + quantity + ")";
                MySqlCommand cmd = new MySqlCommand( sql, con); //MySqlCommand object (cmd) created with the SQL query and the established database connection
                //MySqlDataReader reader = cmd.ExecuteReader();
                cmd.ExecuteNonQuery();
        

   
                MessageBox.Show("Data saved");  //Display a message
                txtBookName.Clear();
                txtAuthorName.Clear();
                txtPublication.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show("All the fields are REQUIRED");     //Display an error message
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
               
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("want to EXIT?") == DialogResult.OK) // Display Exit message
            {
                this.Close();   //Exit from the form
            }
        }

        private void btnClear_Click(object sender, EventArgs e) //Clear button 
        {
            txtBookName.Clear();
            txtAuthorName.Clear();
            txtPublication.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }
    }
}
