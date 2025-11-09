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
    public partial class feedback : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            getorder();


            if (Page.IsPostBack == false)
            {
                fillorderidValues();

                getorder();




            }
          

        }


        void fillorderidValues()
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }



                SqlCommand cmd = new SqlCommand("SELECT order_id from orders where   user_id='" + Session["userid"] + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataValueField = "order_id";
                DropDownList1.DataBind();



            }
            catch (Exception ex)
            {

            }

        }

        void getorder()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from orders where order_id= '" + DropDownList1.SelectedItem.Value + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {

                    product_id.Text = dt.Rows[0]["product_id"].ToString();
                    productname.Text = dt.Rows[0]["product_name"].ToString();
                    Image1.ImageUrl = dt.Rows[0]["image"].ToString();



                    shop_id.Text = dt.Rows[0]["shop_id"].ToString();








                }
                else
                {
                    Response.Write("<script>alert('Invalid order ID');</script>");
                }

            }
            catch (Exception ex)
            {

            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }




            SqlCommand cmd = new SqlCommand("INSERT INTO feedback(order_id,user_id,product_id,product_name,image,shop_id,feedback) values(@order_id,@user_id,@product_id,@product_name,@image,@shop_id,@feedback)", con);
            cmd.Parameters.AddWithValue("@order_id", DropDownList1.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@product_id", product_id.Text.Trim());
            cmd.Parameters.AddWithValue("@user_id", Session["userid"]);
            cmd.Parameters.AddWithValue("@product_name", productname.Text.Trim());
            

             
            cmd.Parameters.AddWithValue("@image", Image1.ImageUrl);
            cmd.Parameters.AddWithValue("@shop_id", shop_id.Text.Trim());
           
            cmd.Parameters.AddWithValue("@feedback", description.Text.Trim());
            

            cmd.ExecuteNonQuery();
            con.Close();

            Response.Write("<script>alert('feedback  Successful.');</script>");




            //Response.Redirect("cart.aspx);


        }
    }


}