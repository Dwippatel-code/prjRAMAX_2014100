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
    public partial class frmAgent : Form
    {
        public frmAgent()
        {
            InitializeComponent();
        }
        SqlConnection myCon;
        int currentIndex;
        DataTable tabagent;
        DataSet myset;
        SqlDataAdapter myAdpter;
        string mode ="";

        private void frmAgent_Load(object sender, EventArgs e)
        {
            myset = new DataSet();
            myCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBReMax;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand mycmd = new SqlCommand("SELECT * FROM Agent", myCon);
            myAdpter = new SqlDataAdapter(mycmd);
            myAdpter.Fill(myset, "Agent");

            tabagent = myset.Tables["Agent"];
            currentIndex = 0;
            Display();

            ActivateButtons(true, true, true, false, true);

        }

        private void ActivateButtons(bool Add, bool Edit, bool Del, bool Save, bool Navigs)
        {
            btnadd.Enabled = Add;
            btnedit.Enabled = Edit;
            btndelete.Enabled = Del;
            btnsave.Enabled = Save;
            
            btnfirst.Enabled = btnnext.Enabled = btnpervious.Enabled = btnlast.Enabled = Navigs;
          
        }
        private void Display()
        {
            txtagentid.Text = tabagent.Rows[currentIndex]["agentId"].ToString();
            txtangname.Text = tabagent.Rows[currentIndex]["agentName"].ToString();
            txtangadd.Text = tabagent.Rows[currentIndex]["agentAddresss"].ToString();
            txtangcontact.Text = tabagent.Rows[currentIndex]["agentContact"].ToString();

        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            Display();

        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            currentIndex=tabagent.Rows.Count-1;
            Display();

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if(currentIndex < (tabagent.Rows.Count-1))
            {
                currentIndex = currentIndex + 1;
            }
            Display();
        }

        private void btnpervious_Click(object sender, EventArgs e)
        {
            if(currentIndex>0)
            {
                currentIndex = currentIndex - 1;
            }
            Display();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            mode = "add";
            txtagentid.Text = txtangname.Text = txtangadd.Text = txtangcontact.Text = "";
            txtagentid.Focus();
            ActivateButtons(false, false, false, true, false);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtagentid.Focus();
            ActivateButtons(false, false, false, true, false);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DataRow myrow;
            if (mode =="add")
            {
                myrow = tabagent.NewRow();
                myrow["agentId"] = txtagentid.Text;
                myrow["agentName"] = txtangname.Text;
                myrow["agentAddresss"] = txtangadd.Text;
                myrow["agentContact"] = txtangcontact.Text;
                tabagent.Rows.Add(myrow);
                SqlCommandBuilder builder=new SqlCommandBuilder(myAdpter);
          
                myAdpter.Update(myset, "Agent");
                tabagent = myset.Tables["Agent"];
            }
            else
            {
                myrow = tabagent.Rows[currentIndex];
                myrow["agentId"] = txtagentid.Text;
                myrow["agentName"] = txtangname.Text;
                myrow["agentAddresss"] = txtangadd.Text;
                myrow["agentContact"] = txtangcontact.Text;
                SqlCommandBuilder builder = new SqlCommandBuilder(myAdpter);
                myAdpter.Update(myset, "Agent");
            }
            mode = "";
            Display();
            ActivateButtons(true, true, true, false, true);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this Agent ?", "Deletion Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tabagent.Rows[currentIndex].Delete();
                SqlCommandBuilder builder = new SqlCommandBuilder(myAdpter);
                myAdpter.Update(myset, "Agent");
                currentIndex = 0;
                Display();
            }
        }
    }
}

