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
    public partial class cart : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            /*  if (Page.IsPostBack == false)
              {
                  userid.Text = Session["userid"].ToString();
                  try
                  {
                      SqlConnection con = new SqlConnection(strcon);
                      if (con.State == ConnectionState.Closed)
                      {
                          con.Open();
                      }
                      SqlCommand cmd = new SqlCommand("SELECT * from cart WHERE user_id='" + Session["userid"].ToString() + "';", con);
                      SqlDataAdapter da = new SqlDataAdapter(cmd);
                      DataTable dt = new DataTable();
                      da.Fill(dt);
                      if (dt.Rows.Count >= 1)
                      {
                          cartid.Text = dt.Rows[0]["cart_id"].ToString();
                          productid.Text = dt.Rows[0]["product_id"].ToString();
                          productname.Text = dt.Rows[0]["product_name"].ToString();
                          Image1.ImageUrl = dt.Rows[0]["image"].ToString();
                          amount.Text = dt.Rows[0]["price"].ToString().Trim();
                          quantity.Text = dt.Rows[0]["quantity"].ToString().Trim();
                          address.Text = dt.Rows[0]["address"].ToString();

                          shopid.Text = dt.Rows[0]["shop_id"].ToString();

                          /* int qty = Convert.ToInt32(dt.Rows[0]["quantity"].ToString().Trim());
                           for (int i = 0; i <= qty; i++)
                           {
                               DropDownList1.Items.Add(i.ToString());
                           }
                           // DropDownList1.DataSource = dt;
                           // DropDownList1.DataValueField = "shop_id";
                           //  DropDownList1.DataBind();

                           totalamount.Text = DropDownList1.SelectedItem.Value;

                      }
                      else
                      {
                          Response.Write("<script>alert('Invalid Book ID');</script>");
                      }

                  }
                  catch (Exception ex)
                  {

                  }
              }*/
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Response.Redirect("checkout.aspx?cart_id=" + e.CommandArgument.ToString());




            /*  SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("DELETE from cart WHERE cart_id='" + e.CommandArgument + "'", con);

            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('product Deleted Successfully');</script>");
          */
        }


    }
}