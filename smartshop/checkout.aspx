<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="checkout.aspx.cs" Inherits="smartshop.checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
      <div class="container">
      <div class="row">
         <div class="col-md-6 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                          <h2>Checkout</h2>
                        </center>
                     </div>
                  </div>
    
   

     <div class="card text-center ">
       <div class="card-body">
       <div class="row">


        <div class="col">
    <table class="table">
        <tr>
           
            <td valign="top" rowspan="2" >
                
                
                 <span >
                    <asp:Image ID="Image1" runat="server" />
               
                </span>
                 <br />
                <br /><span > USER ID :</span > 
<asp:Label ID="userid" runat="server" Text="Label"></asp:Label>
                <br /><span >Item ID :</span >
<asp:Label ID="pid" runat="server" Text="Label"></asp:Label> <br />
                <span class="style8"><span class="style9">&nbsp;&nbsp; Item Name : </span>
                </span><span class="style9">
                <asp:Label ID="lblname" runat="server" CssClass="style8"></asp:Label>
                </span>
                 
                <br />
                 <span class="style9"><span class="style8">&nbsp;&nbsp;
                ItemCategory :
                </span>
                <asp:Label ID="category" runat="server" CssClass="style8"></asp:Label><br />
                <span class="style9"><span class="style8">&nbsp;&nbsp;
                       <span class="style9"><span class="style8">&nbsp;&nbsp;
                Delivery time :
                </span>
                <asp:Label ID="deliver" runat="server" CssClass="style8"></asp:Label><br />
                <span class="style9"><span class="style8">&nbsp;&nbsp;
                Item Price :
                </span>
                <asp:Label ID="lblprice" runat="server" CssClass="style8"></asp:Label>
                <br class="style8" />
                     
                <span class="style8">&nbsp;&nbsp;
              
                  Quantity:
                </span>
                <asp:Label ID="lblqnt" runat="server" CssClass="style8"></asp:Label>
                <br />
               
               
               total amount :
                </span>
                <asp:Label ID="totalamount" runat="server" CssClass="style8"></asp:Label>
                <br />
                <span class="style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Shop :
                </span>
                <asp:Label ID="lblqnt0" runat="server" CssClass="style8"></asp:Label>
                </span>
                <br />
                 
                &nbsp;&nbsp;
                Detail : 
                <asp:Label ID="address" runat="server"></asp:Label>
                
                &nbsp;&nbsp;  <br /> <span class="style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Payment Type :
                </span>
               <span >  <asp:DropDownList ID="DropDownList1" runat="server">
                   <asp:ListItem Text="COD" Value="COD"></asp:ListItem>
                   <asp:ListItem Text="Transfer" Value="Transfer"></asp:ListItem>
                        </asp:DropDownList>
                </span> <br /> 
               <asp:Button ID="Button3" runat="server" Class="btn btn-success" 
                    Text="conform order" Width="120px"   OnClick="Button3_Click" />
            </td>
        </tr>
      
        
    </table>
            </div>
          
            </div>
           </div>
            </div>
                   
               </div>
            </div>
              </div>
               </div>
            </div>
</asp:Content>
