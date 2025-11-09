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
    public partial class rating : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string yelow = "~/images/yellow_star.png";
        string wht = "~/images/white_star.png";
       // string ratid = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
            GridView2.DataBind();
        }
        protected void image1(object sender, EventArgs e)
        {
            
            if (ImageButton1.ImageUrl== yelow)
            {
                ImageButton1.ImageUrl = wht;
            }else if (ImageButton1.ImageUrl == wht)
            {
                ImageButton1.ImageUrl = yelow;
            }
                
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            /*  if (ImageButton1.ImageUrl == yelow)
              {
                  ImageButton1.ImageUrl = wht;
                  ImageButton2.ImageUrl = wht;
                  ImageButton3.ImageUrl = wht;
                  ImageButton4.ImageUrl = wht;
                  ImageButton5.ImageUrl = wht;
              }
              else if (ImageButton1.ImageUrl == wht)
              {
                  ImageButton1.ImageUrl = yelow;
              }*/
            ImageButton1.ImageUrl = yelow;
            ImageButton2.ImageUrl = wht;
            ImageButton3.ImageUrl = wht;
            ImageButton4.ImageUrl = wht;
            ImageButton5.ImageUrl = wht;
            Label1.Text = "1";
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton1.ImageUrl = yelow;

            ImageButton2.ImageUrl = yelow;
            ImageButton3.ImageUrl = wht;
            ImageButton4.ImageUrl = wht;
            ImageButton5.ImageUrl = wht;
            Label1.Text = "2";
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton1.ImageUrl = yelow;

            ImageButton2.ImageUrl = yelow;
            ImageButton3.ImageUrl = yelow;
            ImageButton4.ImageUrl = wht;
            ImageButton5.ImageUrl = wht;
            Label1.Text = "3";
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton1.ImageUrl = yelow;

            ImageButton2.ImageUrl = yelow;
            ImageButton3.ImageUrl = yelow;
            ImageButton4.ImageUrl = yelow;
            ImageButton5.ImageUrl = wht;
            Label1.Text = "4";
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
             if (ImageButton5.ImageUrl == wht)
            {
                ImageButton1.ImageUrl = yelow;
                 
                ImageButton2.ImageUrl = yelow;
                ImageButton3.ImageUrl = yelow;
                ImageButton4.ImageUrl = yelow;
                ImageButton5.ImageUrl = yelow;
                Label1.Text = "5";
            }
        }
        bool checkratingExists()
        {
             
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from rating where order_id='" + TextBox1.Text.Trim() + "';", con);
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
        void getratingByID()
        {
            if (checkratingExists())
            {
                
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT * from rating WHERE order_id='" + TextBox1.Text.Trim() + "';", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                     string ratid = dt.Rows[0]["rating_id"].ToString();
                        Label2.Text = dt.Rows[0]["product_id"].ToString();
                        Image1.ImageUrl = dt.Rows[0]["image"].ToString();
                        Label3.Text = dt.Rows[0]["shop_id"].ToString().Trim();
                        Label1.Text = dt.Rows[0]["rating"].ToString().Trim();
                        TextBox2.Text = dt.Rows[0]["comments"].ToString().Trim();
                        if (Label1.Text == "1")
                        {
                            ImageButton1.ImageUrl = yelow;
                            ImageButton2.ImageUrl = wht;
                            ImageButton3.ImageUrl = wht;
                            ImageButton4.ImageUrl = wht;
                            ImageButton5.ImageUrl = wht;

                        }
                        if (Label1.Text == "2")
                        {
                            ImageButton1.ImageUrl = yelow;

                            ImageButton2.ImageUrl = yelow;
                            ImageButton3.ImageUrl = wht;
                            ImageButton4.ImageUrl = wht;
                            ImageButton5.ImageUrl = wht;
                        }
                        if (Label1.Text == "3")
                        {
                            ImageButton1.ImageUrl = yelow;

                            ImageButton2.ImageUrl = yelow;
                            ImageButton3.ImageUrl = yelow;
                            ImageButton4.ImageUrl = wht;
                            ImageButton5.ImageUrl = wht;

                        }
                        if (Label1.Text == "4")
                        {
                            ImageButton1.ImageUrl = yelow;

                            ImageButton2.ImageUrl = yelow;
                            ImageButton3.ImageUrl = yelow;
                            ImageButton4.ImageUrl = yelow;
                            ImageButton5.ImageUrl = wht;

                        }
                        if (Label1.Text == "5")
                        {
                            ImageButton1.ImageUrl = yelow;

                            ImageButton2.ImageUrl = yelow;
                            ImageButton3.ImageUrl = yelow;
                            ImageButton4.ImageUrl = yelow;
                            ImageButton5.ImageUrl = yelow;

                        }




                    }
                     

                
                

            }
            else
            {
                
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT * from orders WHERE order_id='" + TextBox1.Text.Trim() + "';", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        Label2.Text = dt.Rows[0]["product_id"].ToString();
                        Image1.ImageUrl = dt.Rows[0]["image"].ToString();
                        Label3.Text = dt.Rows[0]["shop_id"].ToString().Trim();






                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid   ID');</script>");
                    }

                 
            }
               
        }
      /*  void getproductByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from orders WHERE order_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    Label2.Text = dt.Rows[0]["product_id"].ToString();
                    Image1.ImageUrl = dt.Rows[0]["image"].ToString();
                    Label3.Text = dt.Rows[0]["shop_id"].ToString().Trim();






                }
                else
                {
                    Response.Write("<script>alert('Invalid   ID');</script>");
                }

            }
            catch (Exception ex)
            {

            }
        }*/
        protected void Button4_Click(object sender, EventArgs e)
        {
           // if (checkratingExists())
           // {
                getratingByID();
         //  }
           // else
           // {
              //  getproductByID();
           // }
           
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
           if ( checkratingExists())
            {
                Response.Write("<script>alert('You Already Rate this product');</script>"); 
            }
            else
            {
                ratNewproduct();
            }
        }
        void ratNewproduct()
        {
            //Response.Write("<script>alert('Testing');</script>");
            try
            {
                


                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO rating(product_id,order_id,user_id,shop_id,rating,comments,image) values(@product_id,@order_id,@user_id,@shop_id,@rating,@comments,@image)", con);
                cmd.Parameters.AddWithValue("@product_id", Label2.Text.Trim());
                cmd.Parameters.AddWithValue("@order_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@user_id", Session["userid"].ToString());
                cmd.Parameters.AddWithValue("@shop_id", Label3.Text.Trim());
                cmd.Parameters.AddWithValue("@rating", Label1.Text.Trim());
                cmd.Parameters.AddWithValue("@comments", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@image", Image1.ImageUrl);
                cmd.ExecuteNonQuery();
                con.Close();
                GridView1.DataBind();
                GridView2.DataBind();
                Response.Write("<script>alert(' Your Rating Added Successfuly.');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

    }
}