using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace smartshop
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                /*   if (Session["role"].Equals(""))
                   {
                       LinkButton1.Visible = true; // user login link button
                       LinkButton5.Visible = true; // shop manager login

                       LinkButton3.Visible = false; // logout link button
                       LinkButton7.Visible = false; // hello user link button


                       LinkButton6.Visible = true; // admin login link button
                       LinkButton11.Visible = false; // approve shop  link button
                       LinkButton12.Visible = false; // shop management link button
                       LinkButton13.Visible = false; // view shop manager link button
                       LinkButton14.Visible = false; // add products link button
                       LinkButton8.Visible = false; // customer profile link button
                       LinkButton9.Visible = false; // shop manager profile link button
                       LinkButton10.Visible = false; // view customer link button
                       LinkButton8.Visible = false; // view products link button

                   }
                   else */

                 if (Session["role"] != null)
                    {
                    if (Session["role"].Equals("customer"))
                    {

                        ApproveShop.Visible = false;
                        RegisterShop.Visible = false;
                        AddProducts.Visible = false;
                        CustomerProfile.Visible = true;
                        ShopManagerProfile.Visible = false;
                        ViewCustomer.Visible = false;
                        ViewShopManager.Visible = false;
                        ViewProducts.Visible = false;
                        ManageOrder.Visible = false;
                        Reports.Visible = false;
                        Feedback.Visible = true;
                        Ratings.Visible = true;
                        complain.Visible = true;
                        location.Visible = false;
                        category.Visible = false;
                        Myorder.Visible = true;
                        checkorderstatus.Visible = false;
                        paybill.Visible = false;
                        Cart.Visible = true;
                        LinkButton1.Visible = false; // user login link button
                        LinkButton5.Visible = false; // shop manager login

                        LinkButton3.Visible = true; // logout link button
                        LinkButton7.Visible = true; // hello user link button
                        LinkButton7.Text = "Hello " + Session["fullname"].ToString();


                        LinkButton6.Visible = false; // admin login link button
                        LinkButton11.Visible = false; // approve shop  link button
                        LinkButton12.Visible = false; // shop management link button
                        LinkButton13.Visible = false; // view shop manager link button
                        LinkButton14.Visible = false; // add products link button
                        LinkButton8.Visible = true; // customer profile link button
                        LinkButton9.Visible = false; // shop manager profile link button
                        LinkButton10.Visible = false; // view customer link button
                        LinkButton15.Visible = false; // view products link button

                        LinkButton16.Visible = false; // manage order
                        LinkButton17.Visible = false; // reports
                        LinkButton18.Visible = true; // feedback
                        LinkButton19.Visible = true; // rating
                        LinkButton2.Visible = true; // complain
                        LinkButton4.Visible = false; // location
                        LinkButton20.Visible = false; // category
                        LinkButton21.Visible = true; // place order
                        LinkButton22.Visible = false; // check order status
                        LinkButton23.Visible = false; // pay bill
                        LinkButton24.Visible = false; // place order
                        LinkButton25.Visible = false; // check order status
                        LinkButton26.Visible =false; // pay bill
                        LinkButton27.Visible = true; // pay bill
                    }
                    else if (Session["role"].Equals("manager"))
                    {
                        LinkButton1.Visible = false; // user login link button
                        LinkButton5.Visible = false; // shop manager login

                        LinkButton3.Visible = true; // logout link button
                        LinkButton7.Visible = true; // hello user link button
                        LinkButton7.Text = "Hello " + Session["fullname"].ToString();


                        LinkButton6.Visible = false; // admin login link button
                        LinkButton11.Visible = false; // approve shop  link button
                        LinkButton12.Visible = true; // shop management link button
                        LinkButton13.Visible = false; // view shop manager link button
                        LinkButton14.Visible = true; // add products link button
                        LinkButton8.Visible = false; // customer profile link button
                        LinkButton9.Visible = true; // shop manager profile link button
                        LinkButton10.Visible = false; // view customer link button
                        LinkButton15.Visible = false; // view products link button
                        LinkButton16.Visible = true; // manage order
                        LinkButton17.Visible = true; // reports
                        LinkButton18.Visible = true; // feedback
                        LinkButton19.Visible = true; // rating
                        LinkButton2.Visible = true; // complain
                        LinkButton4.Visible = false; // location
                        LinkButton20.Visible = true; // category
                        LinkButton21.Visible = false; // place order
                        LinkButton22.Visible = false; // check order status
                        LinkButton23.Visible = false; // pay bill
                        LinkButton24.Visible = false; // place order
                        LinkButton25.Visible = false; // check order status
                        LinkButton26.Visible = false; // pay bill
                        LinkButton27.Visible = false; // pay bill
                        ApproveShop.Visible = false;
                        RegisterShop.Visible = true;
                        AddProducts.Visible = true;
                        CustomerProfile.Visible = false;
                        ShopManagerProfile.Visible = true;
                        ViewCustomer.Visible = false;
                        ViewShopManager.Visible = false;
                        ViewProducts.Visible = false;
                        ManageOrder.Visible = true;
                        Reports.Visible = false;
                        Feedback.Visible = true;
                        Ratings.Visible = true;
                        complain.Visible = true;
                        location.Visible = false;
                        category.Visible = true;
                        Myorder.Visible = false;
                        checkorderstatus.Visible = false;
                        paybill.Visible = false;
                        Cart.Visible = false;
                    }
                    else if (Session["role"].Equals("admin"))
                    {
                        LinkButton1.Visible = false; // user login link button
                        LinkButton5.Visible = false; // shop manager login

                        LinkButton3.Visible = true; // logout link button
                        LinkButton7.Visible = true; // hello user link button
                        LinkButton7.Text = "Hello " + Session["fullname"].ToString();




                        LinkButton6.Visible = false; // admin login link button
                        LinkButton11.Visible = true; // approve shop  link button
                        LinkButton12.Visible = false; // shop management link button
                        LinkButton13.Visible = true; // view shop manager link button
                        LinkButton14.Visible = false; // add products link button
                        LinkButton8.Visible = false; // customer profile link button
                        LinkButton9.Visible = false; // shop manager profile link button
                        LinkButton10.Visible = true; // view customer link button
                        LinkButton15.Visible = true; // view products link button
                        LinkButton16.Visible = true; // manage order
                        LinkButton17.Visible = false; // reports
                        LinkButton18.Visible = true; // feedback
                        LinkButton19.Visible = true; // rating
                        LinkButton2.Visible = true; // complain
                        LinkButton4.Visible = false; // location
                        LinkButton20.Visible = true; // category
                        LinkButton21.Visible = false; // place order
                        LinkButton22.Visible = false; // check order status
                        LinkButton23.Visible = false; // pay bill
                        LinkButton24.Visible = false; // place order
                        LinkButton25.Visible = false; // check order status
                        LinkButton26.Visible = false; // pay bill
                        LinkButton27.Visible = false; // pay bill
                        ApproveShop.Visible = true;
                        RegisterShop.Visible = false;
                        AddProducts.Visible = false;
                        CustomerProfile.Visible = false;
                        ShopManagerProfile.Visible = false;
                        ViewCustomer.Visible = true;
                        ViewShopManager.Visible = true;
                        ViewProducts.Visible = true;
                        ManageOrder.Visible = true;
                        Reports.Visible = true;
                        Feedback.Visible = true;
                        Ratings.Visible = true;
                        complain.Visible = true;
                        location.Visible = true;
                        category.Visible = true;
                        Myorder.Visible = false;
                        checkorderstatus.Visible =false;
                       
                        paybill.Visible = false;
                        Cart.Visible = false;
                    }
                }
                else
                {
                    LinkButton1.Visible = true; // user login link button
                    LinkButton5.Visible = true; // shop manager login

                    LinkButton3.Visible = false; // logout link button
                    LinkButton7.Visible = false; // hello user link button


                    LinkButton6.Visible = true; // admin login link button
                    LinkButton11.Visible = false; // approve shop  link button
                    LinkButton12.Visible = false; // shop management link button
                    LinkButton13.Visible = false; // view shop manager link button
                    LinkButton14.Visible = false; // add products link button
                    LinkButton8.Visible = false; // customer profile link button
                    LinkButton9.Visible = false; // shop manager profile link button
                    LinkButton10.Visible = false; // view customer link button
                    LinkButton8.Visible = false; // view products link button
                    LinkButton16.Visible = false; // manage order
                    LinkButton17.Visible = false; // reports
                    LinkButton18.Visible = false; // feedback
                    LinkButton19.Visible = false; // rating
                    LinkButton2.Visible = false; // complain
                    LinkButton4.Visible = false; // location
                    LinkButton20.Visible = false; // category
                    LinkButton21.Visible = false; // place order
                    LinkButton22.Visible = false; // check order status
                    LinkButton23.Visible = false; // pay bill
                    LinkButton24.Visible = true; // place order
                    LinkButton25.Visible = true; // check order status
                    LinkButton26.Visible = true; // pay bill
                    LinkButton27.Visible = false; // pay bill
                    ApproveShop.Visible = false;
                    RegisterShop.Visible = false;
                    AddProducts.Visible = false;
                    CustomerProfile.Visible = false;
                    ShopManagerProfile.Visible = false;
                    ViewCustomer.Visible = false;
                    ViewShopManager.Visible = false;
                    ViewProducts.Visible = false;
                    ManageOrder.Visible = false;
                    Reports.Visible = false;
                    Feedback.Visible = false;
                    Ratings.Visible = false;
                    complain.Visible = false;
                    location.Visible = false;
                    category.Visible = false;
                    Myorder.Visible = false;
                    checkorderstatus.Visible = false;
                    paybill.Visible = false;
                    Cart.Visible = false;
                }


            }
            catch (Exception ex)
            {
                 
            }

        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("managerlogin.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("customerlogin.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {

            Session["userid"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Response.Redirect("homepage.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("addshop.aspx");
        }

        protected void LinkButton14_Click(object sender, EventArgs e)
        {
            Response.Redirect("addproducts.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("customerprofile.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("managerprofile.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewscutomer.aspx");
        }

        protected void LinkButton13_Click(object sender, EventArgs e)
        {
            Response.Redirect("view manager.aspx");
        }

        protected void LinkButton15_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewproducts.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("approveshop.aspx");
        }

        protected void LinkButton24_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminsignup.aspx");
        }

        protected void LinkButton25_Click(object sender, EventArgs e)
        {

            Response.Redirect("managersignup.aspx");
        }

        protected void LinkButton26_Click(object sender, EventArgs e)
        {

            Response.Redirect("customersignup.aspx");
        }

        protected void LinkButton27_Click(object sender, EventArgs e)
        {
            Response.Redirect("cart.aspx");
        }

        protected void LinkButton21_Click(object sender, EventArgs e)
        {
            Response.Redirect("order.aspx");
        }

        protected void LinkButton18_Click(object sender, EventArgs e)
        {
            if (Session["role"].Equals("customer"))
            {
                Response.Redirect("feedback.aspx");
            }
            else
            {
                Response.Redirect("managefeedback.aspx");
            }
              

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            if (Session["role"].Equals("customer"))
            {
                Response.Redirect("complain.aspx");
            }
            else
            {
                Response.Redirect("managecomplain.aspx");
            }
           
        }

        protected void LinkButton16_Click(object sender, EventArgs e)
        {
            if (Session["role"].Equals("manager"))
            {
                Response.Redirect("shopmanageorder.aspx");
            }
            else
            {
                Response.Redirect("manageorder.aspx");
            }
           
        }

        protected void LinkButton20_Click(object sender, EventArgs e)
        {
            Response.Redirect("category.aspx");
        }

        protected void LinkButton19_Click(object sender, EventArgs e)
        {
            if (Session["role"].Equals("customer"))
            {
                Response.Redirect("rating.aspx");
            }
            else
            {
                Response.Redirect("viewrating.aspx");
            }
        }
    }
}