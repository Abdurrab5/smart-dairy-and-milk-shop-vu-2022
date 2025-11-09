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
    public partial class managefeedback : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            getfeedbackByID();
        }


        // update button click
        protected void Button3_Click(object sender, EventArgs e)
        {
            updatefeedbackByID();
            clearForm();
        }
        // delete button click
        protected void Button2_Click(object sender, EventArgs e)
        {
            deletefeedbackByID();
            clearForm();
        }



      
        bool checkfeedbackExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from feedback where feedback_id='" + feedbackid.Text.Trim() + "';", con);
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
      
       
        void deletefeedbackByID()
        {
            if (checkfeedbackExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE from feedback WHERE feedback_id='" + feedbackid.Text.Trim() + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('feedback Deleted Successfully');</script>");

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

        void updatefeedbackByID()
        {

            if (checkfeedbackExists())
            {
                try
                {







                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE feedback set  replay=@replay   where feedback_id='" + feedbackid.Text.Trim() + "'", con);
 
                    cmd.Parameters.AddWithValue("@replay", replay.Text.Trim());
                    
                    
                    
                    


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
                Response.Write("<script>alert('Invalid product ID');</script>");
            }
        }
        void getfeedbackByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from feedback WHERE feedback_id='" + feedbackid.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    productname.Text = dt.Rows[0]["product_name"].ToString();
                    Image1.ImageUrl = dt.Rows[0]["image"].ToString();
                    feedback.Text = dt.Rows[0]["feedback"].ToString().Trim();
                    replay.Text = dt.Rows[0]["replay"].ToString().Trim();
                    productid.Text = dt.Rows[0]["product_id"].ToString();
                    userid.Text = dt.Rows[0]["user_id"].ToString();
                    shopid.Text = dt.Rows[0]["shop_id"].ToString();
                    orderid.Text = dt.Rows[0]["order_id"].ToString();
                  


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
        void clearForm()
        {

            productname.Text = "";
            Image1.ImageUrl ="";
            feedback.Text = "";
            replay.Text = "";
            productid.Text = "";
            userid.Text = "";
            shopid.Text ="";
            orderid.Text = "";


        }
    }
}