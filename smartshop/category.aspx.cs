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
    public partial class category : System.Web.UI.Page
    {
        //connection string
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            getcategoryByID();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            addNewcategory();
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            updatecategoryByID();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            deletecategoryByID();
            GridView1.DataBind();
        }
        bool checkcategoryExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from category where category_id='" + TextBox1.Text.Trim() + "';", con);
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
        void addNewcategory()
        {  //Response.Write("<script>alert('Testing');</script>");
            try
            {
               
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO category(category_id,cat_name) values(@category_id,@cat_name)", con);
                cmd.Parameters.AddWithValue("@category_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@cat_name", TextBox2.Text.Trim());
                

                cmd.ExecuteNonQuery();
                con.Close();
               GridView1.DataBind();
                Response.Write("<script>alert('category added Successful.');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

     
          


        void deletecategoryByID()
        {
            if (checkcategoryExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE from category WHERE category_id='" + TextBox1.Text.Trim() + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    GridView1.DataBind();
                    Response.Write("<script>alert('category Deleted Successfully');</script>");

                   // GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Invalid category ID');</script>");
            }
        }

        void updatecategoryByID()
        {

            if (checkcategoryExists())
            {
                try
                {


                   



                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE category set cat_name=@cat_name where category_id='" + TextBox1.Text.Trim() + "'", con);


                    cmd.Parameters.AddWithValue("@cat_name", TextBox2.Text.Trim());
                   



                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                    Response.Write("<script>alert('Category Updated Successfully');</script>");
                   

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
        void getcategoryByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from category WHERE category_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0]["cat_name"].ToString();
                    // = dt.Rows[0]["image"].ToString();
                   





                }
                else
                {
                    Response.Write("<script>alert('Invalid category ID');</script>");
                }

            }
            catch (Exception ex)
            {

            }
        }
        void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
             


        }

    }
}