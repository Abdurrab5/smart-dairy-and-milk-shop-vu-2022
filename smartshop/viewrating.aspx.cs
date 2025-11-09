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
    public partial class viewrating : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string productid = "";
        string yelow = "~/images/yellow_star.png";
        string wht = "~/images/white_star.png";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        /*   void getproduct()
           {

               SqlConnection con = new SqlConnection(strcon);
               if (con.State == ConnectionState.Closed)
               {
                   con.Open();
               }
               SqlCommand cmd = new SqlCommand("SELECT * from products ", con);
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               DataTable dt = new DataTable();
               da.Fill(dt);
               if (dt.Rows.Count >= 1)
               {
                   foreach(DataRow dr in dt.Rows)
                   {
                       productname.Text += dr["product_name"].ToString();
                       Image1.ImageUrl += dr["image"].ToString();
                       price.Text +=dr["price"].ToString().Trim();
                   }











               }
               else
               {
                   Response.Write("<script>alert('Invalid   ID');</script>");
               }

           }
        void getratingByID()
        {
            
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from rating  ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                Label lbl = Datalist1.Item.FindControl("rating") as Label;
               
                   
                    if (rating.Text == "1")
                    {
                        ImageButton1.ImageUrl = yelow;
                        ImageButton2.ImageUrl = wht;
                        ImageButton3.ImageUrl = wht;
                        ImageButton4.ImageUrl = wht;
                        ImageButton5.ImageUrl = wht;

                    }
                    if (rating.Text == "2")
                    {
                        ImageButton1.ImageUrl = yelow;

                        ImageButton2.ImageUrl = yelow;
                        ImageButton3.ImageUrl = wht;
                        ImageButton4.ImageUrl = wht;
                        ImageButton5.ImageUrl = wht;
                    }
                    if (rating.Text == "3")
                    {
                        ImageButton1.ImageUrl = yelow;

                        ImageButton2.ImageUrl = yelow;
                        ImageButton3.ImageUrl = yelow;
                        ImageButton4.ImageUrl = wht;
                        ImageButton5.ImageUrl = wht;

                    }
                    if (rating.Text == "4")
                    {
                        ImageButton1.ImageUrl = yelow;

                        ImageButton2.ImageUrl = yelow;
                        ImageButton3.ImageUrl = yelow;
                        ImageButton4.ImageUrl = yelow;
                        ImageButton5.ImageUrl = wht;

                    }
                    if (rating.Text == "5")
                    {
                        ImageButton1.ImageUrl = yelow;

                        ImageButton2.ImageUrl = yelow;
                        ImageButton3.ImageUrl = yelow;
                        ImageButton4.ImageUrl = yelow;
                        ImageButton5.ImageUrl = yelow;

                    }




                }


        cmd = new SqlCommand("select count(Id) as NumberOfUsers,sum(Rating) as Total from Rating_Table", con);
SqlDataAdapter da = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();
da.Fill(dt);
float COUNT = float.Parse(dt.Rows[0]["NumberOfUsers"].ToString());
float RATING = float.Parse(dt.Rows[0]["Total"].ToString());
context.Response.ContentType = "text/plain";
try
{
float result = RATING / COUNT;
context.Response.Write(result.ToString("0.0"));
}// int us = Convert.ToInt32(Count(dt.Rows[0]["user_id"].ToString()));
             //   int RA  = Convert.ToInt32((dt.Rows[0]["rating"].ToString()));
              //  context.Response.ContentType = "text/plain";
                
                 //  string result = (RA  /1).ToString();
                  //  context.Response.Write(result.ToString("0.0"));


            } */

        protected void DataList1_ItemDataBound1(object sender, DataListItemEventArgs e)
        {
            Label product = e.Item.FindControl("Label3") as Label;
            

            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from rating where product_id='" + product.Text + "'; ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
              
                

                Label Label1 = e.Item.FindControl("rating") as Label;

                Label1.Text = dt.Rows[0]["rating"].ToString();
                ImageButton ImageButton1 = e.Item.FindControl("ImageButton1") as ImageButton;
                ImageButton ImageButton2 = e.Item.FindControl("ImageButton2") as ImageButton;
                ImageButton ImageButton3 = e.Item.FindControl("ImageButton3") as ImageButton;
                ImageButton ImageButton4 = e.Item.FindControl("ImageButton4") as ImageButton;
                ImageButton ImageButton5 = e.Item.FindControl("ImageButton5") as ImageButton;
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
    }
}