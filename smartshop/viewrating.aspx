<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewrating.aspx.cs" Inherits="smartshop.viewrating" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container  ">
      <div class="row text-center">
         <div class="col-md mx-auto">
            <div class="card align-content-center">
               <div class="card-body">
                  <div class="row">
                      <div class="col-md mx-auto">
                        <center>
                           <h4>Product </h4>
                        </center>
                          
                     </div>
                  </div>
                 <div class="row ">
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>
                   
                     <div class="col ">
                          <asp:DataList ID="DataList1" runat="server"  
                RepeatDirection="Horizontal" Width="100%" RepeatColumns="3"
                
               
                BackColor="#DEBA84" BorderColor="#DEBA84" BorderWidth="1px" 
                CellPadding="3" BorderStyle="None" CellSpacing="2" GridLines="Both" DataSourceID="SqlDataSource1" OnItemDataBound="DataList1_ItemDataBound1">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <ItemStyle CssClass="igrid" BackColor="#FFF7E7" ForeColor="#8C4510" />
                <ItemTemplate>
                    <table class="table" >
                        <tr>
                            <td style="text-align: center">
                                <asp:Image ID="Image2" runat="server" width="70%" CssClass="img" ImageUrl='<%#Eval("image") %>' />
                            </td>
                        </tr>
                         <tr>
                            <td>
                                ID :
                                <asp:Label ID="Label3" runat="server" Text='<%#Eval("product_id") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Name :
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("product_name") %>'></asp:Label>
                            </td>
                        </tr>
                         <tr>
                            <td>
                                Rating :<br />

     <asp:ImageButton ID="ImageButton1" runat="server"  ImageUrl="~/images/white_star.png"    Width="20px" hieght="20px"  />
     <asp:ImageButton ID="ImageButton2" runat="server"  ImageUrl="~/images/white_star.png"    Width="20px" hieght="20px"  />
     <asp:ImageButton ID="ImageButton3" runat="server"  ImageUrl="~/images/white_star.png"    Width="20px" hieght="20px"  />
     <asp:ImageButton ID="ImageButton4" runat="server"  ImageUrl="~/images/white_star.png"    Width="20px" hieght="20px" />
     <asp:ImageButton ID="ImageButton5" runat="server"  ImageUrl="~/images/white_star.png"   Width="20px" hieght="20px"  />
  
                               <asp:Label ID="rating" runat="server"  ></asp:Label>

                            </td>
                            
                        </tr>
                        <tr>
                            <td>
                                Price :
                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("price") %>'></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("product_id") %>'>View..</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <SelectedItemStyle BackColor="#738A9C" ForeColor="White" Font-Bold="True" />
            </asp:DataList>
        </div>
                        <hr>
                     </div>
                      
                      </div>
                     </div>
                      
                      </div>
               </div>
                      
                      </div>
                        
                        
</asp:Content>
