using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form10 : Form
    {
        MySqlConnection con;
        public Form10(MySqlConnection con)
        {
            InitializeComponent();
            this.con = con;     //Assign the value of parameter inside the constructor
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=library";  // String holds the connection details of server, username,pw,database
            MySqlConnection con = new MySqlConnection();    //An instance of MySqlConnection is created to establish a connection to the database
            con.ConnectionString = connstring;
            con.Open(); //Open the connection   
            string sql = "select * from irbook";
            MySqlCommand cmd = new MySqlCommand(sql, con);      //MySqlCommand object (cmd) created with the SQL query and the established database connection


            //Data grid view 1
            cmd.CommandText = "select * from irbook where returndate is null";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource= ds.Tables[0];


            //Data grid view 2
            cmd.CommandText = "select * from irbook where returndate is not null";
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("want to EXIT?") == DialogResult.OK)   //Display message
            {
                this.Close();       //Exit button
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
