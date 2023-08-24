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
    public partial class Form2 : Form
    {
        MySqlConnection con;    //Instance variable
        public Form2(MySqlConnection con)
        {
            InitializeComponent();
            this.con = con; //Assign the value of parameter inside the constructor
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 next = new Form3(con);    //Go to the next form
            next.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {    
          
            Application.Exit();     //Exit button
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
