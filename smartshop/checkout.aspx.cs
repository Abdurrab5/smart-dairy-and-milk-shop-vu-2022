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
    public partial class checkout : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string idd = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            idd = Request.QueryString["cart_id"].ToString();
            if (Page.IsPostBack == false)
            {
                
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT * from cart WHERE cart_id='" + idd + "';", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {

                        userid.Text = dt.Rows[0]["user_id"].ToString();
                        pid.Text = dt.Rows[0]["product_id"].ToString();
                        lblname.Text = dt.Rows[0]["product_name"].ToString();
                        Image1.ImageUrl = dt.Rows[0]["image"].ToString();
                        lblprice.Text = dt.Rows[0]["price"].ToString().Trim();
                        lblqnt.Text = dt.Rows[0]["quantity"].ToString().Trim();
                        address.Text = dt.Rows[0]["address"].ToString();
                       deliver.Text = dt.Rows[0]["delivery_time"].ToString();
                        lblqnt0.Text = dt.Rows[0]["shop_id"].ToString();




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


           
           
           // string pending = "pending";

            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
             
            DateTime dtt = DateTime.Now; // Or whatever
            string s = dtt.ToString("dd-MM-yyyy");


            SqlCommand cmd = new SqlCommand("INSERT INTO orders(user_id,product_id,product_name,quantity,price,address,image,delivery_time,order_date,shop_id,payment_type,payment_status,order_status) values(@user_id,@product_id,@product_name,@quantity,@price,@address,@image,@delivery_time,@order_date,@shop_id,@payment_type,@payment_status,@order_status)", con);

            cmd.Parameters.AddWithValue("@product_id", pid.Text.Trim());
            cmd.Parameters.AddWithValue("@user_id", userid.Text.Trim());
            cmd.Parameters.AddWithValue("@product_name", lblname.Text.Trim());
            cmd.Parameters.AddWithValue("@quantity", lblqnt.Text.Trim());
            cmd.Parameters.AddWithValue("@order_date", s);
            cmd.Parameters.AddWithValue("@price", lblprice.Text.Trim());
            cmd.Parameters.AddWithValue("@delivery_time", deliver.Text.Trim());
            cmd.Parameters.AddWithValue("@address", address.Text.Trim());
            cmd.Parameters.AddWithValue("@image", Image1.ImageUrl);
            cmd.Parameters.AddWithValue("@shop_id", lblqnt0.Text.Trim());
            cmd.Parameters.AddWithValue("@payment_type", DropDownList1.SelectedItem.Value);
           cmd.Parameters.AddWithValue("@payment_status", "pending");
             cmd.Parameters.AddWithValue("@order_status", "pending");

            cmd.ExecuteNonQuery();
            con.Close();

            Response.Write("<script>alert('Order Confirm.');</script>");

            deletecartByID();


             Response.Redirect("order.aspx");



        }
        void deletecartByID()
        {
            
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE from cart WHERE cart_id='" + idd + "';", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('cart Deleted Successfully');</script>");
                 

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }

            
        }

    }
}