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
    public partial class Form9 : Form
    {
        MySqlConnection con;
        public Form9(MySqlConnection con)
        {
            InitializeComponent();
            this.con = con;     //Assign the value of parameter inside the constructor
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            txtSearch.Clear();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e) 
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=library";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string sql = "select * from irbook";
            MySqlCommand cmd = new MySqlCommand(sql, con);      //MySqlCommand object (cmd) created with the SQL query and the established database connection


            cmd.CommandText = "select * from irbook where memno='" +txtSearch.Text+ "'and returndate IS NULL";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Please enter valid ID ");// display error message

            }
        }

        String bName;
        string bDate;
        Int64 rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible=true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowId = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bName = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                bDate = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
           
            
                txtBookName.Text = bName;
                txtIssueDate.Text = bDate;
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=library";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string sql = "select * from irbook";
            MySqlCommand cmd = new MySqlCommand(sql, con);      //MySqlCommand object (cmd) created with the SQL query and the established database connection


            cmd.CommandText = "update irbook set returndate='" + dateTimePicker1.Text + "'where memno = '"+txtSearch.Text+"'and id="+rowId+"";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Return successfully");//,Display message
          //  Form9_Load(this, null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                panel1.Visible=true;
                dataGridView1.DataSource = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=library";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string sql = "select * from irbook";
            MySqlCommand cmd = new MySqlCommand(sql, con);  //MySqlCommand object (cmd) created with the SQL query and the established database connection


            cmd.CommandText = "update irbook set returndate='" + dateTimePicker1.Text + "'where memno = '" + txtSearch.Text + "'and id=" + rowId + "";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Return successfully"); //Display message
            //  Form9_Load(this, null);

            this.txtBookName.Clear();
            this.txtIssueDate.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("want to EXIT?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("want to cancel?") == DialogResult.OK) //, "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
