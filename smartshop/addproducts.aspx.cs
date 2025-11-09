using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace smartshop
{
    public partial class addproducts : System.Web.UI.Page
    {
        //connection string
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        static string global_filepath;
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (!IsPostBack)
            {
                FillshopidValues();
                FillcategoryidValues();
            }

            GridView1.DataBind();
            GridView2.DataBind();



        }


        // go button click
        protected void Button4_Click(object sender, EventArgs e)
        {
            GetproductByID();
            
        }


        // update button click
        protected void Button3_Click(object sender, EventArgs e)
        {



            UpdateproductByID();


            ClearForm();
             

        }
        // delete button click
        protected void Button2_Click(object sender, EventArgs e)
        {
            DeleteproductByID();
            
            ClearForm();
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckproductExists())
            {

                Response.Write("<script>alert('product Already Exist with this Product ID, try other ID');</script>");
            }
            else
            {
                AddNewproduct();
            }
        }
        bool CheckproductExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from products where product_id='" + TextBox1.Text.Trim() + "';", con);
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
        void AddNewproduct()
        {  //Response.Write("<script>alert('Testing');</script>");
            try
            {
            string filepath = "~/products/img1";
                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                if (filename == "" || filename == null)
                {
                    filepath = global_filepath;
}
                else
                {
                    FileUpload1.SaveAs(Server.MapPath("~/products/" + filename));
                    filepath = "~/products/" + filename;
                }
 SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                
                SqlCommand cmd = new SqlCommand("INSERT INTO products(product_id,product_name,image,price,quantity,delivery_time,description,shop_id,category_id) values(@product_id,@product_name,@image,@price,@quantity,@delivery_time,@description,@shop_id,@category_id)", con);
                cmd.Parameters.AddWithValue("@product_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@product_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@image", filepath);
                cmd.Parameters.AddWithValue("@price", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@quantity", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@description", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@shop_id", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@category_id", DropDownList2.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@delivery_time", DropDownList3.SelectedItem.Value);
                
                cmd.ExecuteNonQuery();
                con.Close();
                GridView1.DataBind();
                GridView2.DataBind();
                Response.Write("<script>alert('product register Successful.');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void FillshopidValues()
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }



                SqlCommand cmd = new SqlCommand("SELECT shop_id from shop where status='active' AND owner_name='" + Session["fullname"] + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataValueField = "shop_id";
                DropDownList1.DataBind();

                Session["shopid"] = "shop_id";

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void FillcategoryidValues()
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }



                SqlCommand cmd = new SqlCommand("SELECT category_id from category", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList2.DataSource = dt;
                DropDownList2.DataValueField = "category_id";
                DropDownList2.DataBind();



            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void DeleteproductByID()
        {
            if (CheckproductExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE from products WHERE product_id='" + TextBox1.Text.Trim() + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('product Deleted Successfully');</script>");

                    GridView1.DataBind();
                    GridView2.DataBind();

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

        void UpdateproductByID()
        {

            if (CheckproductExists())
            {
                try
                {


                    string filepath = "~/products/img1";
                    string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    if (filename == "" || filename == null)
                    {
                        filepath = global_filepath;

                    }
                    else
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/products/" + filename));
                        filepath = "~/products/" + filename;
                    }




                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    
                   SqlCommand cmd = new SqlCommand("UPDATE products set product_name=@product_name,image=@image,delivery_time=@delivery_time,price=@price,quantity=@quantity,description=@description,shop_id=@shop_id,category_id=@category_id where product_id='" + TextBox1.Text.Trim() + "';", con);


                    cmd.Parameters.AddWithValue("@product_name", TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@image", filepath);
                    cmd.Parameters.AddWithValue("@price", TextBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@quantity", TextBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@description", TextBox6.Text.Trim());
                    cmd.Parameters.AddWithValue("@shop_id", DropDownList1.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@category_id", DropDownList2.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@delivery_time", DropDownList3.SelectedItem.Value);
                    

                    cmd.ExecuteNonQuery();
                    con.Close();
                 GridView1.DataBind();
                   GridView2.DataBind();
                    Response.Write("<script>alert('product Updated Successfully');</script>");


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
        void GetproductByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from products WHERE product_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0]["product_name"].ToString();
                    Image2.ImageUrl = dt.Rows[0]["image"].ToString();
                    global_filepath = dt.Rows[0]["image"].ToString();
                    TextBox4.Text = dt.Rows[0]["price"].ToString().Trim();
                    TextBox5.Text = dt.Rows[0]["quantity"].ToString().Trim();
                    TextBox6.Text = dt.Rows[0]["description"].ToString();
                   
                    DropDownList1.SelectedItem.Value = dt.Rows[0]["shop_id"].ToString();
                    DropDownList2.SelectedItem.Value = dt.Rows[0]["category_id"].ToString();
                    DropDownList3.SelectedItem.Value = dt.Rows[0]["delivery_time"].ToString();
                    




                }
                else
                {
                    Response.Write("<script>alert('InvalidProduct ID');</script>");
                }
                

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void ClearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox5.Text = "";
            Image2.ImageUrl = "";

           TextBox6.Text = "";
            TextBox4.Text = "";
            DropDownList1.SelectedItem.Value ="";
            DropDownList2.SelectedItem.Value ="";
            DropDownList3.SelectedItem.Value = "";

        }
    }
}