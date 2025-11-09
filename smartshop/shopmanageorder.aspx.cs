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
    public partial class shopmanageorder : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                fillshopidValues();
            }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            getorderByID();
        }


        // update button click
        protected void Button3_Click(object sender, EventArgs e)
        {
            updateorderByID();
            clearForm();
        }
        // delete button click
        protected void Button2_Click(object sender, EventArgs e)
        {
            deleteorderByID();
            clearForm();
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkorderExists())
            {

                Response.Write("<script>alert('product Already Exist with this Product ID, try other ID');</script>");
            }
            else
            {
                addNeworder();
            }
        }
        bool checkorderExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from orders where order_id='" + orderid.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }
        void addNeworder()
        {
            //Response.Write("<script>alert('Testing');</script>");
            try
            {



                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO orders(user_id,product_id,product_name,image,price,quantity,address,shop_id,payment_type,payment_status,order_status) values(@user_id,@product_id,@product_name,@image,@price,@quantity,@address,@shop_id,@payment_type,@payment_status,@order_status)", con);


                cmd.Parameters.AddWithValue("@user_id", DropDownList2.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@product_id", productid.Text.Trim());
                cmd.Parameters.AddWithValue("@product_name", productname.Text.Trim());
                cmd.Parameters.AddWithValue("@image", Image1.ImageUrl);
                cmd.Parameters.AddWithValue("@price", price.Text.Trim());
                cmd.Parameters.AddWithValue("@quantity", quantity.Text.Trim());
                cmd.Parameters.AddWithValue("@address", address.Text.Trim());
                cmd.Parameters.AddWithValue("@shop_id", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@payment_type", DropDownList3.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@payment_status", DropDownList4.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@order_status", DropDownList5.SelectedItem.Value);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Order added Successful.');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void fillshopidValues()
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }



                SqlCommand cmd = new SqlCommand("SELECT shop_id from shop where owner_name='" + Session["fullname"].ToString() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataValueField = "shop_id";
                DropDownList1.DataBind();
                
                
                    
                


            }
            catch (Exception ex)
            {

            }
        }
        void filluseridValues()
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }



                SqlCommand cmd = new SqlCommand("SELECT customer_id from customers;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList2.DataSource = dt;
                DropDownList2.DataValueField = "customer_id";
                DropDownList2.DataBind();



            }
            catch (Exception ex)
            {

            }
        }
        void deleteorderByID()
        {
            if (checkorderExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE from orders WHERE order_id='" + orderid.Text.Trim() + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('order Deleted Successfully');</script>");

                    GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Invalid order ID');</script>");
            }
        }

        void updateorderByID()
        {

            if (checkorderExists())
            {
                try
                {







                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE orders set user_id=@user_id,product_name=@product_name,image=@image,price=@price,quantity=@quantity,address=@address,shop_id=@shop_id,payment_type=@payment_type,payment_status=@payment_status,order_status=@order_status where order_id='" + orderid.Text.Trim() + "'", con);

                    cmd.Parameters.AddWithValue("@user_id", DropDownList2.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@product_id", productid.Text.Trim());
                    cmd.Parameters.AddWithValue("@product_name", productname.Text.Trim());
                    cmd.Parameters.AddWithValue("@image", Image1.ImageUrl);
                    cmd.Parameters.AddWithValue("@price", price.Text.Trim());
                    cmd.Parameters.AddWithValue("@quantity", quantity.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", address.Text.Trim());
                    cmd.Parameters.AddWithValue("@shop_id", DropDownList1.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@payment_type", DropDownList3.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@payment_status", DropDownList4.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@order_status", DropDownList5.SelectedItem.Value);



                    cmd.ExecuteNonQuery();
                    con.Close();
                    GridView1.DataBind();
                    Response.Write("<script>alert('order Updated Successfully');</script>");


                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid order ID');</script>");
            }
        }
        void getorderByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from orders WHERE order_id='" + orderid.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    productname.Text = dt.Rows[0]["product_name"].ToString();
                    Image1.ImageUrl = dt.Rows[0]["image"].ToString();
                    price.Text = dt.Rows[0]["price"].ToString().Trim();
                    quantity.Text = dt.Rows[0]["quantity"].ToString().Trim();
                    address.Text = dt.Rows[0]["address"].ToString();
                    DropDownList2.SelectedItem.Value = dt.Rows[0]["user_id"].ToString();
                    DropDownList1.SelectedItem.Value = dt.Rows[0]["shop_id"].ToString();
                    DropDownList3.SelectedItem.Value = dt.Rows[0]["payment_type"].ToString();
                    DropDownList4.SelectedItem.Value = dt.Rows[0]["payment_status"].ToString();
                    DropDownList5.SelectedItem.Value = dt.Rows[0]["order_status"].ToString();




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
        void clearForm()
        {
            orderid.Text = "";
            productname.Text = "";
            Image1.ImageUrl = "";
            price.Text = "";
            quantity.Text = "";
            address.Text = "";
            DropDownList2.SelectedItem.Value = "";
            DropDownList1.SelectedItem.Value = "";
            DropDownList3.SelectedItem.Value = "";
            DropDownList4.SelectedItem.Value = "";
            DropDownList5.SelectedItem.Value = "";


        }

    }
}
 