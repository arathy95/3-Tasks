using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;


namespace Task3
{
    public partial class UploadImage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D2RS25A9\SQLEXPRESS;Initial Catalog=ImageUpload;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnuploadimage_Click(object sender, EventArgs e)
        {
            try
            {
               
                byte[] imagedata = uploadimage.FileBytes;

                Session["img"] = imagedata;

                //string imgpath = Server.MapPath("images");
                //if (!Directory.Exists(imgpath))
                //{
                //    Directory.CreateDirectory(imgpath);
                //}

                //string filepath = imgpath + "\\" + uploadimage.FileName;
                //uploadimage.SaveAs(filepath);

                //string urlpath = "~/images/" + uploadimage.FileName;

                //Session["imgurl"] = urlpath;

                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tbl_Task3 (productname,productprice,imageURL) values (@productname,@productprice,@imageURL)", con);
                cmd.Parameters.AddWithValue("@productname", txtproductname.Text);
                cmd.Parameters.AddWithValue("@productprice", txtproductprice.Text);
                cmd.Parameters.AddWithValue("@imageURL", imagedata);

                
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

                Response.Write(ex.Message);
            }
        }

        protected void btnredirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("DataListView.aspx");
        }
    }
}