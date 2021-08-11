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
    public partial class HouseSearch : Form
    {
        public HouseSearch()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBReMax;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void radiohouse_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand mycmdHouse = new SqlCommand("SELECT houseType,houseprice,housecity,housezip,agentName,agentContact from House ,Agent", con);
            SqlDataAdapter dbHouse = new SqlDataAdapter(mycmdHouse);
            var dshouse = new DataSet();
            dbHouse.Fill(dshouse);

            gridsearchHouse.DataSource = dshouse.Tables[0];
            con.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                if(radiohouse.Checked==true)
                {
                    SqlCommand mycmdHouse = new SqlCommand("SELECT houseType,houseprice,housecity,housezip,agentName,agentContact from House , Agent where name='" + txtsearch.Text+"'",con);
                    SqlDataAdapter dbHouse = new SqlDataAdapter(mycmdHouse);
                    var dshouse = new DataSet();
                    dbHouse.Fill(dshouse);

                    gridsearchHouse.DataSource = dshouse.Tables[0];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
