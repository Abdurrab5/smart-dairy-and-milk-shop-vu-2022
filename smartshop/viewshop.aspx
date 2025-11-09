<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewshop.aspx.cs" Inherits="smartshop.viewshop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <h2>View Shop Detail</h2>
     <div class="card text-center ">
       <div class="card-body">
       <div class="row">


        <div class="col">
    <table class="table">
        <tr>
           
            <td valign="top" rowspan="2" >
                
                
                 
                 <br />
                <br />
 
                <span class="style8"><span class="style9">&nbsp;&nbsp;Shop Name : </span>
                </span><span class="style9">
                <asp:Label ID="shopname" runat="server" CssClass="style8"></asp:Label>
                </span>
                <br />
                <br />
                 <span class="style9"><span class="style8">&nbsp;&nbsp;
               owner name :
                </span>
                <asp:Label ID="ownername" runat="server" CssClass="style8"></asp:Label>
                <span class="style9"><span class="style8">&nbsp;&nbsp;
               Address :
                </span>
                <asp:Label ID="address" runat="server" CssClass="style8"></asp:Label>
                <br class="style8" />
                <br class="style8" />
                <span class="style8">&nbsp;&nbsp;
              
                <br />
                <br />
                <br />
                <br />
                &nbsp;&nbsp;
             
               
                &nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" Class="btn btn-info" 
                    Text="Back" Width="120px"  OnClick="Button3_Click" />
            </td>
        </tr>
      
        
    </table>
            </div>
         
            </div>
           </div>
            </div>
</asp:Content>
