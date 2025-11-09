<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="smartshop.view" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style4
        {
        }
        .style5
        {
        }
        .style6
        {
            width: 318px;
        }
        .style7
        {
            width: 100px;
        }
    .style8
    {
        color: #FF6600;
    }
    .style9
    {
        font-size: large;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <h2>View Product Detail</h2>
     <div class="card text-center ">
       <div class="card-body">
       <div class="row">


        <div class="col">
    <table class="style2">
        <tr>
           
            <td valign="top" rowspan="2" >
                
                
                 <span >
                    <asp:Image ID="Image1" runat="server" />
               
                </span>
                 <br />
                <br />
<asp:Label ID="pid" runat="server" Text="Label"></asp:Label>
                <span class="style8"><span class="style9">&nbsp;&nbsp; Item Name : </span>
                </span><span class="style9">
                <asp:Label ID="lblname" runat="server" CssClass="style8"></asp:Label>
                </span>
                <br />
                <br />
                 <span class="style9"><span class="style8">&nbsp;&nbsp;
                ItemCategory :
                </span>
                <asp:Label ID="category" runat="server" CssClass="style8"></asp:Label>
                <span class="style9"><span class="style8">&nbsp;&nbsp;
                Item Price :
                </span>
                <asp:Label ID="lblprice" runat="server" CssClass="style8"></asp:Label>
               
                     <br class="style8" />
                <span class="style8">&nbsp;&nbsp;
              
                   Available:
                </span>
                <asp:Label ID="lblqnt" runat="server" CssClass="style8"></asp:Label>
                
                <br class="style8" />
                <span class="style8">&nbsp;&nbsp;
               
                <span class="style8">&nbsp;&nbsp;
              
                   Delivery:
                </span>
                <asp:Label ID="lbldeliver" runat="server" CssClass="style8"></asp:Label>
                <br /><span class="style8">&nbsp;&nbsp;
                   Select Quantity :
                </span>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                <br />
                      <span class="style9"><span class="style8">&nbsp;&nbsp;
               total amount :
                </span>
                <asp:Label ID="totalamount" runat="server" CssClass="style8"></asp:Label>
                <br />
                <span class="style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Shop :
                </span>
                <asp:Label ID="lblqnt0" runat="server" CssClass="style8"></asp:Label>
                </span>
                <br />
                <br />
                <br />
                <br />
                &nbsp;&nbsp;
                Detail : 
                <asp:Label ID="lbldetil" runat="server"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                     
                <br />
                <br />
                &nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" Class="btn btn-success" 
                    Text="Buy Now" Width="120px"  OnClick="Button3_Click" />
            </td>
        </tr>
      
        
    </table>
            </div>
          
            </div>
           </div>
            </div>
</asp:Content>
