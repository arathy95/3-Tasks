using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["img"] != null)
            {
                byte[] data = (byte[])Session["img"];
                Context.Response.ContentType = "image/jpeg";
                Context.Response.BinaryWrite(data);
            }
        }
    }
}