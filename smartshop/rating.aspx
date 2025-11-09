<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="rating.aspx.cs" Inherits="smartshop.rating" %>
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
                          <h1> Rating</h1>
                        </center>
                           <label>Order ID</label>
                         <div class="col-5">
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="order ID"></asp:TextBox>
                              <asp:Button class="form-control btn btn-primary" ID="Button4" runat="server" Text="Go" OnClick="Button4_Click" />
                           </div>
                        </div></div>
                     <div>
                           <asp:Image ID="Image1" width="50%" runat="server" />
                     </div>
    
  <div>
      <span > product ID :</span > <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
  </div>
<div>
    <span > shop ID :</span > <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
</div>

<div>
    <asp:ImageButton ID="ImageButton1" runat="server"  ImageUrl="~/images/white_star.png"    Width="20px" hieght="20px" OnClick="ImageButton1_Click"/>
     <asp:ImageButton ID="ImageButton2" runat="server"  ImageUrl="~/images/white_star.png"    Width="20px" hieght="20px" OnClick="ImageButton2_Click"/>
     <asp:ImageButton ID="ImageButton3" runat="server"  ImageUrl="~/images/white_star.png"    Width="20px" hieght="20px" OnClick="ImageButton3_Click"/>
     <asp:ImageButton ID="ImageButton4" runat="server"  ImageUrl="~/images/white_star.png"    Width="20px" hieght="20px" OnClick="ImageButton4_Click"/>
     <asp:ImageButton ID="ImageButton5" runat="server"  ImageUrl="~/images/white_star.png"   Width="20px" hieght="20px" OnClick="ImageButton5_Click"/>
   <span >  your rating:</span > 
    <asp:Label ID="Label1" runat="server"  ></asp:Label>

                </div>          
                  <div>
                       <span >  comments:</span > 
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                     
                  </div>  
                         <div>
                             <asp:LinkButton ID="LinkButton1" Class="btn btn-success" runat="server" OnClick="LinkButton1_Click">Save</asp:LinkButton>
                         </div>
                     </div>
          
            </div>
           </div>
            </div>
                   
               </div>
           
          <div class="col-6">
                <h1> Rating</h1>
               <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [rating]">
               </asp:SqlDataSource>
              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="rating_id" DataSourceID="SqlDataSource1">
                  <Columns>
                      <asp:BoundField DataField="rating_id" HeaderText="rating_id" InsertVisible="False" ReadOnly="True" SortExpression="rating_id" />
                      <asp:BoundField DataField="order_id" HeaderText="order_id" SortExpression="order_id" />
                      <asp:BoundField DataField="product_id" HeaderText="product_id" SortExpression="product_id" />
                      <asp:BoundField DataField="shop_id" HeaderText="shop_id" SortExpression="shop_id" />
                      <asp:BoundField DataField="rating" HeaderText="rating" SortExpression="rating" />
                      <asp:BoundField DataField="comments" HeaderText="comments" SortExpression="comments" />
                  </Columns>
                  <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                  <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                  <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                  <RowStyle BackColor="White" ForeColor="#003399" />
                  <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                  <SortedAscendingCellStyle BackColor="#EDF6F6" />
                  <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                  <SortedDescendingCellStyle BackColor="#D6DFDF" />
                  <SortedDescendingHeaderStyle BackColor="#002876" />
               </asp:GridView>

             
          </div>

            </div>
              </div>
             <div class="container">
      <div class="row">
         <div class="col-md mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                          <h1> Products</h1>  
     
               <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [orders] WHERE ([user_id] = @user_id)">
                   <SelectParameters>
                       <asp:SessionParameter Name="user_id" SessionField="userid" Type="String" />
                   </SelectParameters>
               </asp:SqlDataSource>
              <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="order_id" DataSourceID="SqlDataSource2">
                  <Columns>
                      <asp:BoundField DataField="order_id" HeaderText="order_id" InsertVisible="False" ReadOnly="True" SortExpression="order_id" />
                      <asp:BoundField DataField="user_id" HeaderText="user_id" SortExpression="user_id" />
                      <asp:BoundField DataField="product_id" HeaderText="product_id" SortExpression="product_id" />
                      <asp:BoundField DataField="product_name" HeaderText="product_name" SortExpression="product_name" />
                      <asp:BoundField DataField="image" HeaderText="image" SortExpression="image" />
                      <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
                      <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                      <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                      <asp:BoundField DataField="shop_id" HeaderText="shop_id" SortExpression="shop_id" />
                      <asp:BoundField DataField="payment_type" HeaderText="payment_type" SortExpression="payment_type" />
                      <asp:BoundField DataField="payment_status" HeaderText="payment_status" SortExpression="payment_status" />
                      <asp:BoundField DataField="order_status" HeaderText="order_status" SortExpression="order_status" />
                  </Columns>
                  <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                  <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                  <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                  <RowStyle BackColor="White" ForeColor="#003399" />
                  <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                  <SortedAscendingCellStyle BackColor="#EDF6F6" />
                  <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                  <SortedDescendingCellStyle BackColor="#D6DFDF" />
                  <SortedDescendingHeaderStyle BackColor="#002876" />
               </asp:GridView>
    
</center>
            </div>
              </div>
                   </div>

            </div></div>

            </div>
              </div>  
</asp:Content>

