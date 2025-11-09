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
    public partial class view_manager : System.Web.UI.Page
    {
        //connection string
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


            }
            GridView1.DataBind();
            

            
           
        }


        // go button click
        protected void Button4_Click(object sender, EventArgs e)
        {
            getMemberByID();
        }


        // update button click
        protected void Button3_Click(object sender, EventArgs e)
        {
            updatemanagerByID();
            clearForm();
        }
        // delete button click
        protected void Button2_Click(object sender, EventArgs e)
        {
            deletemanagerByID();
            clearForm();
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkMemberExists())
            {

                Response.Write("<script>alert('Member Already Exist with this Member ID, try other ID');</script>");
            }
            else
            {
                signUpNewMember();
            }
        }
        bool checkMemberExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from managers where manager_id='" + TextBox1.Text.Trim() + "';", con);
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
        void signUpNewMember()
        {
            //Response.Write("<script>alert('Testing');</script>");
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO managers(manager_id,full_name,email,password,phone,address) values(@manager_id,@full_name,@email,@password,@phone,@address)", con);
                cmd.Parameters.AddWithValue("@manager_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@full_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@email", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@password", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@address", TextBox6.Text.Trim());


                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('manager add successfully');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void deletemanagerByID()
        {
            if (checkMemberExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE from managers WHERE manager_id='" + TextBox1.Text.Trim() + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Book Deleted Successfully');</script>");

                    GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Invalid Member ID');</script>");
            }
        }

        void updatemanagerByID()
        {

            if (checkMemberExists())
            {
                try
                {

                   

                    

                    

                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE managers set full_name=@full_name,email=@email,password=@password,phone=@phone,address=@address where manager_id='" + TextBox1.Text.Trim() + "'", con);

                    cmd.Parameters.AddWithValue("@full_name", TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", TextBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", TextBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", TextBox6.Text.Trim());


                    cmd.ExecuteNonQuery();
                    con.Close();
                    GridView1.DataBind();
                    Response.Write("<script>alert('manager profile Updated Successfully');</script>");

                    
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('manger with this ID not exists try another');</script>");
            }
        }
        void getMemberByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from managers WHERE manager_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0]["full_name"].ToString();
                    TextBox3.Text = dt.Rows[0]["email"].ToString();
                     TextBox4.Text = dt.Rows[0]["password"].ToString().Trim();
                    TextBox5.Text = dt.Rows[0]["phone"].ToString().Trim();
                    TextBox6.Text = dt.Rows[0]["address"].ToString();
                     
                     
                    
 

                }
                else
                {
                    Response.Write("<script>alert('manger with this ID not exists try another');</script>");
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
            TextBox5.Text = "";

            TextBox3.Text = "";
            TextBox6.Text = "";
            TextBox4.Text = "";


        }
    }
}