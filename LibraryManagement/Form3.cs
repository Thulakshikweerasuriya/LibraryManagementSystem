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
    public partial class Form3 : Form
    {
        MySqlConnection con;    //Instance variable
        public Form3(MySqlConnection con)
        {
            InitializeComponent();
            this.con = con;     //Assign the value of parameter inside the constructor
        }

        private void bOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 addBooks = new Form4(con);    
            addBooks.Show();     //Display Add books form
        }

        private void vIEWBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 viewBooks = new Form5(con);  
            viewBooks.Show();   //Display view books form
        }

        private void aDDMEMBERSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form6 addMembers = new Form6(con);
            addMembers.Show();  //Display add members form
        }

        private void vIEWMEMBERINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form7 viewMembers = new Form7(con);
            viewMembers.Show(); //Display view members form
        }

        private void iSSUEBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form8 issueBooks = new Form8(con);
            issueBooks.Show();  //Display issue books form
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rETURNBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 returnBooks = new Form9(con);
            returnBooks.Show();     //Display return books form
        }

        private void bOOKDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 bookDetail = new Form10(con);
            bookDetail.Show();  //Display All book details
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Exit?") == DialogResult.OK) //Display a message to exit
            {
                Application.Exit();
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
