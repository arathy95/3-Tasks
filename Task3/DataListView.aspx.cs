using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Task3
{
    public partial class DataListView : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D2RS25A9\SQLEXPRESS;Initial Catalog=ImageUpload;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void DataListViewBind()
        {
            SqlDataAdapter adpt = new SqlDataAdapter("select * from tbl_Task3", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            DataList1.DataSource = dt;
            DataList1.DataBind();
        }
    }
}