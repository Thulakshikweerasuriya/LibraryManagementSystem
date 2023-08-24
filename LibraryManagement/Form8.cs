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
    public partial class Form8 : Form
    {
        MySqlConnection con;
        public Form8(MySqlConnection con)
        {
            InitializeComponent();
            this.con = con;     //Assign the value of parameter inside the constructor
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=root;database=library";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string sql = "select  bName from newbook";
            MySqlCommand cmd = new MySqlCommand(sql, con);  //MySqlCommand object (cmd) created with the SQL query and the established database connection


            cmd.CommandText = "select bName from newbook";
            MySqlDataAdapter ds = new MySqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            ds.Fill(ds1);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for(int i=0; i<dr.FieldCount;i++)
                {
                    comboBoxBook.Items.Add(dr.GetString(i));
                }
            }
            dr.Close();
            con.Close();
        }

        int count;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                string memno = txtSearch.Text;
                string connstring = "server=localhost;uid=root;pwd=root;database=library";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from newstudent";
                MySqlCommand cmd = new MySqlCommand(sql, con);


                cmd.CommandText = "select * from newstudent where memno='"+ memno +"'";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //Minimum 3 books issue for a student code -----
                cmd.CommandText = "select count(memno)  from irbook where memno='" + memno + "' and returndate is null";
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());


                //______

                if (ds.Tables[0].Rows.Count!=0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtContact.Text=ds.Tables[0].Rows[0][3].ToString();
                    txtEmail.Text= ds.Tables[0].Rows[0][4].ToString();
                    
                }
                else
                {
                    txtName.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Invalid Membership Number");//,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if(comboBoxBook.SelectedIndex != -1&& count<=2)
                {
                   // string memNo =txtSearch.Text;
                    string memName =txtName.Text;
                    Int64 contact =Int64.Parse(txtContact.Text);
                    string email =txtEmail.Text;
                    string bookName =comboBoxBook.Text;
                    string issueDate = dateTimePicker1.Text;


                    string memno = txtSearch.Text;
                    string connstring = "server=localhost;uid=root;pwd=root;database=library";
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = connstring;
                    con.Open();
                    string sql = "select * from newstudent";
                    MySqlCommand cmd = new MySqlCommand(sql, con);


                    cmd.CommandText = "insert into irbook(memno,memname,contact,email,bookname,issuedate)values('"+memno+"','"+memName+"',"+contact+",'"+email+"','"+bookName+"','"+issueDate+"')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book issued successfully");    //Display message
                    /*MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);*/

                    this.txtEmail.Clear();
                    this.txtContact.Clear();
                    this.txtName.Clear();
                    
                }
                else
                {
                    MessageBox.Show("You can only issue 3 books for one member");   //Error message display
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid membership number");  //Display error message
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                txtName.Clear();
                txtEmail.Clear();
                txtContact.Clear();
                
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("want to EXIT?") == DialogResult.OK) 
            {
                this.Close();
            }
           
        }

        private void comboBoxBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
