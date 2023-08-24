using MySql.Data.MySqlClient;
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

namespace LibraryManagement
{
    public partial class Form6 : Form
    {
        MySqlConnection con;    //Instance variable con
        public Form6(MySqlConnection con)   //Constructor with the parameter
        {
            InitializeComponent();
            this.con = con;     //Assign the value of parameter inside the constructor
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Want to EXIT?") == DialogResult.OK)    //Display message
            {
                this.Close();       //Exit button
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)   //Refresh button
        {
            txtMemberName.Clear();
            txtMemberNo.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMemberName.Text != "" && txtMemberNo.Text != "" && txtContactNo.Text != "" && txtEmail.Text != "")   
            {
                string name = txtMemberName.Text;
                string memberNo = txtMemberNo.Text;
                Int64 contactNo = Int64.Parse(txtContactNo.Text);
                string email = txtEmail.Text;

                /*string connstring = "server=localhost;uid=root;pwd=root;database=library";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();*/
                string sql = "select * from newstudent";
                MySqlCommand cmd = new MySqlCommand(sql, con);  //MySqlCommand object (cmd) created with the SQL query and the established database connection
                MySqlDataReader reader = cmd.ExecuteReader();


                cmd.CommandText = "insert into newstudent  (sname,memno,contact,email) values ('" + name + "','" + memberNo + "'," + contactNo + ",'" + email + "')";
                reader.Close();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data saved!");     //Display message

                txtContactNo.Clear();
                txtEmail.Clear();
                txtMemberName.Clear();
                txtMemberNo.Clear();
                
            }
            else
            {
                MessageBox.Show("All the fileds are REQUIRED");     //Display message
            }
        }
    }
}
