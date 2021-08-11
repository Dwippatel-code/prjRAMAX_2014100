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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        SqlConnection myconn;
        int currentIndex;
        DataTable tabcust;
        DataSet myset;
        SqlDataAdapter myAdpter;
        string mode = "";

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            // tabcust = clsGlobalvariable.myset.Tables["Customer"];

            myset = new DataSet();

            myconn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBReMax;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand mycmd = new SqlCommand("SELECT * FROM Customer", myconn);
            myAdpter = new SqlDataAdapter(mycmd);
            myAdpter.Fill(myset, "Customer");

            tabcust = myset.Tables["Customer"];
            currentIndex = 0;
            Display();

        }
        private void ActivateButtons(bool Add, bool Edit, bool Del, bool Save, bool Cancel, bool Navigs)
        {
            btnAdd.Enabled = Add;
            btnedit.Enabled = Edit;
            btndelete.Enabled = Del;
            btnsave.Enabled = Save;
          
            btnFirst.Enabled = btnNext.Enabled = btnPrevious.Enabled = btnLast.Enabled = Navigs;
            button5.Enabled = Cancel;
        }
        private void Display()
        {
            //dispaly data in the form 
            
            txtFName.Text = tabcust.Rows[currentIndex]["custfname"].ToString();
            txtLName.Text = tabcust.Rows[currentIndex]["custlname"].ToString();
            txtEmail.Text = tabcust.Rows[currentIndex]["custemail"].ToString();
            txtContact.Text = tabcust.Rows[currentIndex]["custphone"].ToString();

            ActivateButtons(true,true,true,false,false,true);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            Display();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentIndex = tabcust.Rows.Count - 1;
            Display();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currentIndex < (tabcust.Rows.Count-1))
            {
                currentIndex = currentIndex + 1;

            }
            Display();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(currentIndex>0)
            {
                currentIndex = currentIndex - 1;
            }
            Display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            txtFName.Text = txtLName.Text=txtEmail.Text=txtContact.Text= " ";
            txtFName.Focus();
            ActivateButtons(false, false, false, true, true, false);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DataRow myrow;
            if(mode == "add")
            { 
                myrow = tabcust.NewRow();
                myrow["custfname"] = txtFName.Text;
                myrow["custlname"] = txtLName.Text;
                myrow["custemail"] = txtEmail.Text;
                myrow["custphone"] = txtContact.Text;
                tabcust.Rows.Add(myrow);

                SqlCommandBuilder builder = new SqlCommandBuilder(clsGlobalvariable.adpCustomere);
                clsGlobalvariable.adpCustomere.Update(clsGlobalvariable.myset, "Customer");
                clsGlobalvariable.myset.Tables.Remove("Customer");
                clsGlobalvariable.adpCustomere.Fill(clsGlobalvariable.myset, "Customer");
                
                currentIndex = tabcust.Rows.Count - 1;
                ActivateButtons(true, true, true, false, false, true);
            }
            else
            {
                myrow = tabcust.Rows[currentIndex];
                myrow["custfname"] = txtFName.Text;
                myrow["custlname"] = txtLName.Text;
                myrow["custemail"] = txtEmail.Text;
                myrow["custphone"] = txtContact.Text;
                SqlCommandBuilder builder = new SqlCommandBuilder(myAdpter);
                myAdpter.Update(myset, "Customer");

                //SqlCommandBuilder builder = new SqlCommandBuilder(clsGlobalvariable.adpCustomere);
                //clsGlobalvariable.adpCustomere.Update(clsGlobalvariable.myset, "Customer");
                //clsGlobalvariable.myset.Tables.Remove("Customer");
                //clsGlobalvariable.adpCustomere.Fill(clsGlobalvariable.myset, "Customer");
                ActivateButtons(true, true, true, false, false, true);
            }
            mode = "";
            Display();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtFName.Focus();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this Customer ?", "Deletion Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tabcust.Rows[currentIndex].Delete();
                SqlCommandBuilder builder = new SqlCommandBuilder(clsGlobalvariable.adpCustomere);
                //myAdpter.Update(myset, "CustomerSqlCommandBuilder builder = new SqlCommandBuilder(clsGlobalvariable.adpCustomere);
                clsGlobalvariable.adpCustomere.Update(clsGlobalvariable.myset, "Customer");
                clsGlobalvariable.myset.Tables.Remove("Customer");
                clsGlobalvariable.adpCustomere.Fill(clsGlobalvariable.myset, "Customer");



                currentIndex = 0;
                ActivateButtons(true, true, true, false, false, true);
                Display();
            }
        }
    }
}
