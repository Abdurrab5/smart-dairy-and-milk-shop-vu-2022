<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="smartshop.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
     <div class="container-fluid">
        <div class="row">
            <div class="col-md  mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
    
    
    <center>  <h1> My cart</h1>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [cart] WHERE ([user_id] = @user_id)">
        <SelectParameters>
            <asp:SessionParameter Name="user_id" SessionField="userid" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
 
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" OnItemCommand="DataList1_ItemCommand">
        
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <ItemStyle CssClass="igrid" BackColor="#FFF7E7" ForeColor="#8C4510" />
                <ItemTemplate>
                      <table class="table" >
                           
                        </tr>
                           
                                 <td> <asp:Label ID="cartid" runat="server" Text='<%#Eval("cart_id") %>'></asp:Label>
                          </td>
                                 <td>  <asp:Label ID="userid" runat="server"  Text='<%#Eval("user_id") %>'></asp:Label>
                         </td>
                                <td><asp:Label ID="productid" runat="server" Text='<%#Eval("product_id") %>' ></asp:Label>
                         </td>
                                <td><asp:Label ID="productname" runat="server" Text='<%#Eval("product_name") %>' ></asp:Label>
                         </td>
                                <td style="width:20px;height:20px;:">   <asp:Image ID="Image1" runat="server"  Class="img-fluid" ImageUrl='<%#Eval("image") %>'   />
                         </td>
                                <td><asp:Label ID="quantity" runat="server" Text='<%#Eval("quantity") %>' ></asp:Label>
                         </td>
                          <td><asp:Label ID="Label1" runat="server" Text='<%#Eval("delivery_time") %>' ></asp:Label>
                         </td>
                                <td> <asp:Label ID="amount" runat="server" Text='<%#Eval("price") %>'></asp:Label>
                         </td>
                                <td><asp:Label ID="address" runat="server"  Text='<%#Eval("address") %>'></asp:Label>
                         </td>
                                <td><asp:Label ID="shopid" runat="server" Text='<%#Eval("shop_id") %>' ></asp:Label>
                         </td>
                                <td> <asp:LinkButton ID="LinkButton2" runat="server" class="btn btn-primary" CommandArgument='<%#Eval("cart_id") %>' >Checkout</asp:LinkButton>
                          </td> 
                                
                           
                           </tr>
                    </table>
                   
                </ItemTemplate>
                <SelectedItemStyle BackColor="#738A9C" ForeColor="White" Font-Bold="True" />

    </asp:DataList>
          </center>
     
             </div>
                       </div>
        </div>
     </div>
                            
         
         </div> 

    </div>
 </div>      
                

</asp:Content>
