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
    public partial class viewscutomer : System.Web.UI.Page
    { //connection string
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

          

            
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
            updatecustomerByID();
            clearForm();
        }
        // delete button click
        protected void Button2_Click(object sender, EventArgs e)
        {
            deletecustomerByID();
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
                SqlCommand cmd = new SqlCommand("SELECT * from customers where customer_id='" + TextBox1.Text.Trim() + "';", con);
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
                SqlCommand cmd = new SqlCommand("INSERT INTO customers(customer_id,full_name,email,password,phone,address) values(@customer_id,@full_name,@email,@password,@phone,@address)", con);
                cmd.Parameters.AddWithValue("@customer_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@full_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@email", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@password", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@address", TextBox6.Text.Trim());


                cmd.ExecuteNonQuery();
                con.Close();
                GridView1.DataBind();
                Response.Write("<script>alert('customer add successfully');</script>");
                clearForm();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void deletecustomerByID()
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

                    SqlCommand cmd = new SqlCommand("DELETE from customers WHERE customer_id='" + TextBox1.Text.Trim() + "'", con);

                    cmd.ExecuteNonQuery();
                    GridView1.DataBind();
                    con.Close();
                   
                    Response.Write("<script>alert('customer Deleted Successfully');</script>");

                     

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

        void updatecustomerByID()
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
                    SqlCommand cmd = new SqlCommand("UPDATE customers set full_name=@full_name,email=@email,password=@password,phone=@phone,address=@address where customer_id='" + TextBox1.Text.Trim() + "'", con);

                    cmd.Parameters.AddWithValue("@full_name", TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", TextBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", TextBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", TextBox6.Text.Trim());


                    cmd.ExecuteNonQuery();
                    con.Close();
                    GridView1.DataBind();
                    Response.Write("<script>alert('customer Updated Successfully');</script>");
                    
                    clearForm();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid customer ID');</script>");
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
                SqlCommand cmd = new SqlCommand("SELECT * from customers WHERE customer_id='" + TextBox1.Text.Trim() + "';", con);
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
                    Response.Write("<script>alert('Invalid customer ID');</script>");
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