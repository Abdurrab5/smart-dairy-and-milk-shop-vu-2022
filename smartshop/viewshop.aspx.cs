using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace smartshop
{
    public partial class viewshop : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                string idd = Request.QueryString["shop_id"].ToString();
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT * from shop WHERE shop_id='" + idd + "';", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        shopname.Text = dt.Rows[0]["shop_name"].ToString();
                        ownername.Text = dt.Rows[0]["owner_name"].ToString();

                        address.Text = dt.Rows[0]["address"].ToString().Trim();










                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid Book ID');</script>");
                    }

                }
                catch (Exception ex)
                {

                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
        }
    }
}