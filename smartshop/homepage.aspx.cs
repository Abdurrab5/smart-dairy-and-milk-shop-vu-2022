using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace smartshop
{
    public partial class homepage : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string yelow = "~/images/yellow_star.png";
        string wht = "~/images/white_star.png";
        protected void Page_Load(object sender, EventArgs e)
        {



        }
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
           
           
                Response.Redirect("view.aspx?product_id=" + e.CommandArgument.ToString());
            
           
               // Response.Redirect("Viewshop.aspx?shop_id=" + e.CommandArgument.ToString());
           
           // Session["ABC"] = e.CommandArgument.ToString(); //gets the row index selected
            //TextBox1.Text = Session["ABC"].ToString();
        }
        protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
        {


            //Response.Redirect("Viewproduct.aspx?product_id=" + e.CommandArgument.ToString());


            Response.Redirect("viewshop.aspx?shop_id=" + e.CommandArgument.ToString());

            // Session["ABC"] = e.CommandArgument.ToString(); //gets the row index selected
            //TextBox1.Text = Session["ABC"].ToString();
        }

        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
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



        /*  protected void Button1_Click(object sender, CommandEventArgs e)
          {
              protected void LinkButton1_Click(object sender, EventArgs e)
              {
                  LinkButton lb = (LinkButton)sender;
                  GridViewRow row = (GridViewRow)lb.NamingContainer;
                  if (row != null)
                  {
                      int index = row.RowIndex; //gets the row index selected
                  }
              }

              try
              {
                  if (Session["role"] != null)
                  {


                       int rowindex = ((GridViewRow)((LinkButton)).NamingContainer).RowIndex;
                       GridView1.SelectRow(rowindex);
                       int product = Convert.ToInt32(GridView1.SelectedValue);
                       TextBox1.Text = product.ToString();


                  if (e.Row.RowType == DataControlRowType.DataRow)
                    {
                        ((LinkButton)e.Row.FindControl("LinkButton1")).CommandArgument
                            = DataBinder.Eval(e.Row.DataItem, "product_id").ToString();
                        ((LinkButton)e.Row.FindControl("LinkButton1")).Text
                            = DataBinder.Eval(e.Row.DataItem, "product_id").ToString();
                    }

                    void LinkButton_Command(Object sender, CommandEventArgs e)
                     {
                         if (e.CommandName == "view_user_naats_gv")
                         {
                             Resonse.Redirect("UserNaats.aspx?catID=" + e.CommandArgument.ToString());
                         }
                     }
                      // LinkButton lb = (LinkButton)sender;
                      // GridViewRow row = (GridViewRow)lb.NamingContainer;
                      //  if (row != null)
                      // {
                      //   Session["ABC"] = TextBox2.Text; //gets the row index selected
                      //   TextBox1.Text = Session["ABC"].ToString();
                      // }


                  }
                  else
                  {
                      Response.Redirect("customerlogin.aspx");

                  }
              }
              catch (Exception ex)
              {

              }


          }*/

    }
}