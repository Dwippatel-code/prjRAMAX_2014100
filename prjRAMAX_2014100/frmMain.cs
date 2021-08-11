using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prjRAMAX_2014100
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            clsGlobalvariable.myset = new DataSet();

            SqlConnection myCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBReMax;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            myCon.Open();

            //customer calling
            SqlCommand myCmd = new SqlCommand("SELECT * FROM Customer", myCon);
            clsGlobalvariable.adpCustomere = new SqlDataAdapter(myCmd);
            clsGlobalvariable.adpCustomere.Fill(clsGlobalvariable.myset, "Customer");

            //agent calling
            myCmd = new SqlCommand("SELECT * FROM Agent", myCon);
            clsGlobalvariable.adpagent = new SqlDataAdapter(myCmd);
            clsGlobalvariable.adpagent.Fill(clsGlobalvariable.myset, "Agent");

            //House Calling
            myCmd = new SqlCommand("SELECT * FROM House", myCon);
            clsGlobalvariable.adphouse=new SqlDataAdapter (myCmd);
            clsGlobalvariable.adphouse.Fill(clsGlobalvariable.myset, "House");

            clsGlobalvariable.dashboardremax = dashboardremax;
            clsGlobalvariable.login = MnuLogin;
            clsGlobalvariable.logout = logout;
            dashboardremax.Visible = false;
            logout.Visible = false;

            myCon.Close();
            


        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer fc = new frmCustomer();
           // fc.MdiParent = this;
            fc.Show();
        }

        private void agentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgent fa = new frmAgent();
          //  fa.MdiParent = this;
            fa.Show();

        }

        private void houseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHouse fh = new frmHouse();
           // fh.MdiParent = this;
            fh.Show();
        }

        private void houseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HouseSearch hs = new HouseSearch();
          //hs.MdiParent = this;
            hs.Show();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin frmlogin = new frmlogin();
            frmlogin.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            HouseSearch hs = new HouseSearch();
            hs.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmlogin frmlogin = new frmlogin();
            frmlogin.Show();
        }
    }
}
