using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace prjRAMAX_2014100
{
    public partial class frmlogin : Form
    {
        SqlConnection con = new SqlConnection();
        
        public frmlogin()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBReMax;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
            InitializeComponent();
        }
        //private void ActivateButtons(bool dashbo, bool Close)
        //{
        //    rEMAXToolStripMenuItem.Enabled = Add;
        //    btnEdit.Enabled = Edit;
        //    das
        //}
        private void frmlogin_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBReMax;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBReMax;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();
            string username = txtuswename.Text;
            string password = txtpassword.Text;
            SqlCommand cmd = new SqlCommand("SELECT username , password from login where username='" + txtuswename.Text + "'and password= '" + txtpassword
                .Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

         if(dt.Rows.Count>0)
            {
                MessageBox.Show("Login sucessfull","Done");
                clsGlobalvariable.dashboardremax.Visible = true;
                clsGlobalvariable.login.Visible = false;
                clsGlobalvariable.logout.Visible = true;
            }
         else
            {
                MessageBox.Show("Invalid Login");
            }
            con.Close();
            this.Close();
        }

        private void txtuswename_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

