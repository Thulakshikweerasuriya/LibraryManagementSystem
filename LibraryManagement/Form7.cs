using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form7 : Form
    {
        MySqlConnection con;    //Instance variable con
        public Form7(MySqlConnection con)   //Constructor with the parameter
        {
            InitializeComponent();
            this.con = con;     //Assign the value of parameter inside the constructor
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                string connstring = "server=localhost;uid=root;pwd=root;database=library";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from newstudent";
                MySqlCommand cmd = new MySqlCommand(sql, con);  //MySqlCommand object (cmd) created with the SQL query and the established database connection


                cmd.CommandText = "select * from newstudent where memno LIKE '" + txtSearch.Text + "%'";
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
                string sql = "select * from newstudent";
                MySqlCommand cmd = new MySqlCommand(sql, con);      //MySqlCommand object (cmd) created with the SQL query and the established database connection


                // cmd.CommandText = "select * from newstudent";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);



                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;

            string connstring = "server=localhost;uid=root;pwd=root;database=library";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string sql = "select * from newstudent";
            MySqlCommand cmd = new MySqlCommand(sql, con);  //MySqlCommand object (cmd) created with the SQL query and the established database connection


            //  cmd.CommandText = "select * from newstudent";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);



            dataGridView1.DataSource = ds.Tables[0];

        }
        int stuid;
        Int64 rowId;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                stuid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            panel3.Visible = true;


            string connstring = "server=localhost;uid=root;pwd=root;database=library";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string sql = "select * from newstudent";
            MySqlCommand cmd = new MySqlCommand(sql, con);


            cmd.CommandText = "select * from newstudent where stuid = " + stuid + "";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowId = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtMemberName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtMemberNo.Text = ds.Tables[0].Rows[0][2].ToString();
            txtContact.Text = ds.Tables[0].Rows[0][3].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][4].ToString();
           

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated") == DialogResult.OK) //.To update the data go back to the dashboard and refresh. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                string sName =txtMemberName.Text;
                string sMembNo =txtMemberNo.Text;
                string email = txtEmail.Text;
                Int64 contact = Int64.Parse(txtContact.Text);
                


                string connstring = "server=localhost;uid=root;pwd=root;database=library";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from newstudent";
                MySqlCommand cmd = new MySqlCommand(sql, con);


                cmd.CommandText = "update newstudent set sname = '" +sName + "',memno='" + sMembNo + "',contact='" +contact + "',email='" + email + "' where stuid=" + rowId + "";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                this.txtContact.Clear();
                this.txtMemberNo.Clear();
                this.txtMemberName.Clear();
                this.txtEmail.Clear();

               // ViewStudentInformation_Load(this, null);
               
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You want to EXIT.") == DialogResult.OK) //,"Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
      
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be DELETED") == DialogResult.OK) //.To delete the data go back to the dashboard and refresh. Confirm?", "Confirm Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                string connstring = "server=localhost;uid=root;pwd=root;database=library";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from newstudent";
                MySqlCommand cmd = new MySqlCommand(sql, con);


                cmd.CommandText = "delete from newstudent where stuid=" + rowId + "";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                this.txtMemberNo.Clear();
                this.txtMemberName.Clear();
                this.txtEmail.Clear();
                this.txtContact.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to EXIT.") == DialogResult.OK) 
            {
                this.Close();
            }
        }
    }
}
