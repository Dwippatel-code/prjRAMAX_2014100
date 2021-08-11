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
    public partial class frmHouse : Form
    {
        public frmHouse()
        {
            InitializeComponent();
        }
        DataSet myset;
        SqlConnection myCon;
        DataTable tabhouse, tabagent;
        int currentIndex;
        SqlDataAdapter adphouse, adpagent;
        string mode = "";

        private void Display()
        {
            txtTypHouse.Text = tabhouse.Rows[currentIndex]["houseType"].ToString();
            txtPrice.Text = tabhouse.Rows[currentIndex]["houseprice"].ToString();
            txtCity.Text = tabhouse.Rows[currentIndex]["housecity"].ToString();
            txtzip.Text = tabhouse.Rows[currentIndex]["housezip"].ToString();
            string agent = tabhouse.Rows[currentIndex]["agenthId"].ToString();


            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabagent.Columns["agentId"];
            tabagent.PrimaryKey = keys;


            DataRow myRow = tabagent.Rows.Find(agent);
            cobAgentname.Text = myRow["agentName"].ToString();

            ActivateButtons(true,true,true,false,false);
        }

        private void ActivateButtons(bool Add, bool Edit, bool Del, bool Save, bool cancel)
        {
            btnAdd.Enabled = Add;
            btnEdit.Enabled = Edit;
            btndelete.Enabled = Del;
            btnsave.Enabled = Save;
            button5.Enabled = cancel;
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            Display();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentIndex = tabhouse.Rows.Count - 1;
            Display();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < (tabhouse.Rows.Count - 1))
            {
                currentIndex = currentIndex + 1;

            }
            Display();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex = currentIndex - 1;
            }
            Display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        mode = "add";
            txtTypHouse.Text = txtPrice.Text = txtCity.Text = txtzip.Text = cobAgentname.Text = "";
            txtTypHouse.Focus();

            ActivateButtons(false, false, false, true, true);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DataRow myrow;
            if (mode == "add")
            {
                myrow = tabhouse.NewRow();
                myrow["houseType"] = txtTypHouse.Text;
                myrow["houseprice"] = txtPrice.Text;
                myrow["housecity"] = txtCity.Text;
                myrow["housezip"] = txtzip.Text;

                foreach (DataRow row in tabagent.Rows)
                {
                    if (row["agentName"].ToString() == cobAgentname.SelectedItem.ToString())
                    {
                        myrow["agenthId"] = row["agentId"];
                    }
                }
                tabhouse.Rows.Add(myrow);

                SqlCommandBuilder builder = new SqlCommandBuilder(adpagent);
                adpagent.Update(myset, "Agent");
                myset.Tables.Remove("Agent");
                adpagent.Fill(myset, "Agent");
                tabagent = myset.Tables["Agent"];
                currentIndex = tabagent.Rows.Count - 1;
            }
            else if(mode=="edit")
            {
                myrow = tabagent.Rows[currentIndex];
                myrow["houstType"] = txtTypHouse.Text;
                myrow["houseprice"] = txtPrice.Text;
                myrow["housecity"] = txtCity.Text;
                myrow["housezip"] = txtzip.Text;

                foreach (DataRow row in tabagent.Rows)
                {
                    if (row["agentName"].ToString() == cobAgentname.SelectedItem.ToString())
                    {
                        myrow["houseId"] = row["agentId"];
                    }
                }
                SqlCommandBuilder builder = new SqlCommandBuilder(adpagent);
                adpagent.Update(myset, "Agent");
                myset.Tables.Remove("Agent");
                adpagent.Fill(myset, "Agent");
                tabagent = myset.Tables["Agent"];

            }
            Display();
            mode = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtTypHouse.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this employee ?", "Deletion Warning",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tabagent.Rows[currentIndex].Delete();
                adpagent.Update(myset, "Agent");
                myset.Tables.Remove("Agent");
                adpagent.Fill(myset, "Agent");
                tabagent = myset.Tables["Agent"];
                currentIndex = 0;
                Display();
                ActivateButtons(true, true, true, false, false);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display();

        }

        private void frmHouse_Load(object sender, EventArgs e)
        {
            myset = new DataSet();
            myCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBReMax;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myCon.Open();

            SqlCommand mycmd = new SqlCommand("SELECT * FROM House", myCon);
            adphouse = new SqlDataAdapter(mycmd);
            adphouse.Fill(myset, "House");
            tabhouse = myset.Tables["House"];

            mycmd = new SqlCommand("SELECT agentId,agentName from Agent order by agentName",myCon);
            adpagent = new SqlDataAdapter(mycmd);
            adpagent.Fill(myset, "Agent");
            tabagent = myset.Tables["Agent"];
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabagent.Columns["houseId"];
            tabagent.PrimaryKey = keys;


            foreach(DataRow myrow in tabagent.Rows)
            {
                cobAgentname.Items.Add(myrow["agentName"].ToString());
            }
            currentIndex = 0;
            Display();
        }

       
    }
}
