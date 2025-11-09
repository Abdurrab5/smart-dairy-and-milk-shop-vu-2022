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
    public partial class view : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                string idd = Request.QueryString["product_id"].ToString();
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT * from products WHERE product_id='" + idd + "';", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                       pid.Text = dt.Rows[0]["product_id"].ToString();
                        lblname.Text = dt.Rows[0]["product_name"].ToString();
                        Image1.ImageUrl= dt.Rows[0]["image"].ToString();
                        lblprice.Text = dt.Rows[0]["price"].ToString().Trim();
                        lblqnt.Text = dt.Rows[0]["quantity"].ToString().Trim();
                        lbldetil.Text = dt.Rows[0]["description"].ToString();
                        lbldeliver.Text = dt.Rows[0]["delivery_time"].ToString();
                        lblqnt0.Text = dt.Rows[0]["shop_id"].ToString();
                        category.Text = dt.Rows[0]["category_id"].ToString();
                        int qty= Convert.ToInt32(dt.Rows[0]["quantity"].ToString().Trim());
                        for(int i = 1; i<= qty; i++)
                        {
                            DropDownList1.Items.Add(i.ToString());
                                                  }
                        // DropDownList1.DataSource = dt;
                        // DropDownList1.DataValueField = "shop_id";
                        //  DropDownList1.DataBind();

                        string qa = DropDownList1.SelectedItem.Value;
                        int pa = Convert.ToInt32(lblprice.Text);
                         int qt  = Convert.ToInt32(qa);

                        totalamount.Text = (pa * qt).ToString();
                        

                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid  ID');</script>");
                    }

                }
                catch (Exception ex)
                {

                }
               /* IDT = IAdapter.ITEM_SELECT_BUYIID(Convert.ToInt32(idd));

                lblname.Text = IDT.Rows[0]["iname"].ToString();
                lbldetil.Text = IDT.Rows[0]["detail"].ToString();
                lblprice.Text = IDT.Rows[0]["price"].ToString();
                lblqnt.Text = IDT.Rows[0]["qnt"].ToString();
                
                lblqnt0.Text = IDT.Rows[0]["size"].ToString();
                IDT = IAdapter.SeleectTOP7();
                DataList1.DataSource = IDT;
                DataList1.DataBind();*/
            }

        }
        

        protected void Button3_Click(object sender, EventArgs e)
        {

            if (Session["role"] != null)
            {
               string user = Session["userid"].ToString();
                string address ="";
                
               
               SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand add = new SqlCommand("SELECT * from customers WHERE customer_id='" + Session["userid"].ToString().Trim() + "';", con);
                SqlDataAdapter dda = new SqlDataAdapter(add);
                DataTable dt = new DataTable();
                dda.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                   address = dt.Rows[0]["address"].ToString();
                   
                     }
               
                
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(product_id,user_id,product_name,delivery_time,quantity,price,address,image,shop_id) values(@product_id,@user_id,@product_name,@delivery_time,@quantity,@price,@address,@image,@shop_id)", con);
                
                cmd.Parameters.AddWithValue("@product_id", pid.Text.Trim());
                cmd.Parameters.AddWithValue("@user_id", user);
                cmd.Parameters.AddWithValue("@product_name", lblname.Text.Trim());
                cmd.Parameters.AddWithValue("@quantity", DropDownList1.SelectedItem.Value);
               
                cmd.Parameters.AddWithValue("@price", totalamount.Text.Trim());
                cmd.Parameters.AddWithValue("@delivery_time", lbldeliver.Text.Trim());
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@image",Image1.ImageUrl);
                cmd.Parameters.AddWithValue("@shop_id", lblqnt0.Text.Trim());
               

                cmd.ExecuteNonQuery();
                con.Close();
                updateproduct();
                Response.Write("<script>alert('Add to cart  Successful.');</script>");
 



                Response.Redirect("cart.aspx");
                
            }
            else
            {
                Response.Redirect("customerlogin.aspx");
            }

               // Session["ABC"] = pid.Text; //gets the row index selected
                   // Label1.Text = Session["ABC"].ToString();


                


               
                 

            

         }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {


            string qa = DropDownList1.SelectedItem.Value;
            int pa = Convert.ToInt32(lblprice.Text);
            int qty = Convert.ToInt32(qa);

            totalamount.Text = (pa * qty).ToString();
        }
        void updateproduct()
        {
           string quanty = DropDownList1.SelectedItem.Value;
            string qty = lblqnt.Text.ToString();
            int qua = Convert.ToInt32(quanty);
            int qt = Convert.ToInt32(qty);
            string totalqty=(qt-qua).ToString();

            SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE products set quantity=@quantity where product_id='" + pid.Text.Trim() + "'", con);


                    
                    cmd.Parameters.AddWithValue("@quantity", totalqty);
                     
                    


                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                    Response.Write("<script>alert('product Updated Successfully');</script>");


                }
                
             
            
        }
    }
 