using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace prjRAMAX_2014100
{
    public static class clsGlobalvariable
    {
        public static DataSet myset;
        public static SqlDataAdapter adpCustomere;
        public static SqlDataAdapter adpagent;
        public static SqlDataAdapter adphouse;
        public static System.Windows.Forms.ToolStripMenuItem logout;
        public static System.Windows.Forms.ToolStripMenuItem login;
        public static System.Windows.Forms.ToolStripMenuItem dashboardremax;
    }
}
