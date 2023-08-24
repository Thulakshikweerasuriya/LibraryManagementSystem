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
    public partial class Form5 : Form
    {
        MySqlConnection con;    //Instance variable con
        public Form5(MySqlConnection con)   //Constructor with the parameter
        {
            InitializeComponent();
           this.con = con;  //Assign the value of parameter inside the constructor
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
           panel2.Visible = false;
           panel3.Visible = false;

            string connstring = "server=localhost;uid=root;pwd=root;database=library";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string sql = "select * from newbook";
            MySqlCommand cmd = new MySqlCommand(sql, con);  //MySqlCommand object (cmd) created with the SQL query and the established database connection


            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
           DataSet ds = new DataSet();
           da.Fill(ds);
           dataGridView1.DataSource = ds.Tables[0]; 

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int bid;
        Int64 rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
              
            }

            panel2.Visible = true;
            panel3.Visible = true;


            string connstring = "server=localhost;uid=root;pwd=root;database=library";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string sql = "select * from newbook";
            MySqlCommand cmd = new MySqlCommand(sql, con);  //MySqlCommand object (cmd) created with the SQL query and the established database connection


            cmd.CommandText = "select * from newbook where bid = "+ bid+"";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowId = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtBookName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthorName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPublication.Text = ds.Tables[0].Rows[0][3].ToString();
            txtPDate.Text = ds.Tables[0].Rows[0][4].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to EXIT.") == DialogResult.OK) //Display message
            {
                this.Close();   //Exit button
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                string connstring = "server=localhost;uid=root;pwd=root;database=library";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from newbook";
                MySqlCommand cmd = new MySqlCommand(sql, con);      //MySqlCommand object (cmd) created with the SQL query and the established database connection


                cmd.CommandText = "select * from newbook where bName LIKE '"+txtSearch.Text+"%'";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);



                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                string connstring = "server=localhost;uid=root;pwd=root;database=library";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from newbook";
                MySqlCommand cmd = new MySqlCommand(sql, con);


                cmd.CommandText = "select * from newbook";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);



                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated") == DialogResult.OK) 
            {


                string bName = txtBookName.Text;
                string bAuthor = txtAuthorName.Text;
                string publication = txtPublication.Text;
                string pDate = txtPDate.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 quantity = Int64.Parse(txtQuantity.Text);


                string connstring = "server=localhost;uid=root;pwd=root;database=library";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from newbook";
                MySqlCommand cmd = new MySqlCommand(sql, con);


                cmd.CommandText = "update newbook set bName = '" + bName + "',bAuthor='" + bAuthor + "',bPubl='" + publication + "',bPDate='" + pDate + "',bPrice=" + price + ",bQuantity=" + quantity + " where bid=" + rowId + "";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                this.txtAuthorName.Clear();
                this.txtBookName.Clear();
                this.txtPDate.Clear();
                this.txtPrice.Clear();
                this.txtPublication.Clear();
                this.txtQuantity.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be DELETED") == DialogResult.OK) 
            {


                string connstring = "server=localhost;uid=root;pwd=root;database=library";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from newbook";
                MySqlCommand cmd = new MySqlCommand(sql, con);


                cmd.CommandText = "delete from newbook where bid="+rowId+"";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                this.txtBookName.Clear();
                this.txtAuthorName.Clear();
                this.txtPublication.Clear();
                this.txtPrice.Clear();
                this.txtQuantity.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to EXIT.") == DialogResult.OK) 
            {
                this.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
