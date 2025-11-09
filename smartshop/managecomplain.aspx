<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="managecomplain.aspx.cs" Inherits="smartshop.managecomplain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="container">
      <div class="row">
         <div class="col-md-8 mx-auto">
            <div class="card">
               <div class="card-body">
                   <div class="row">
                     <div class="col">
                        <center>
                           <h4>Complain Details</h4>
                        </center>
                     </div>
                  </div>
                  
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  
                  <div class="row">
                     <div class="col-md-4">
                        <label>Complain ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="complainid" runat="server" placeholder="complainID"></asp:TextBox>
                              <asp:Button class="form-control btn btn-primary" ID="Button4" runat="server" Text="Go" OnClick="Button4_Click" />
                           </div>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>product id  </label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="productid" runat="server" placeholder="product id" ></asp:TextBox>
                        </div>
                     </div>
                       <div class="col-md-6">
                        <label>product name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="productname" runat="server" placeholder="product name" ></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>image</label>
                        <div class="form-group">
                            <asp:Image ID="Image1" runat="server" />
                           </div>
                     </div>
                     <div class="col-md-6">
                        <label>order Id</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="orderid" runat="server" placeholder="orderid" > </asp:TextBox>
                        </div>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col-md-6">
                        <label>shop id</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="shopid" runat="server" placeholder="shop id "    ></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>user id</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="userid" runat="server" placeholder="userid" > </asp:TextBox>
                        </div>
                     </div>
                  </div>
                      <div class="row">
                     <div class="col-md-6">
                        <label>complain </label>
                         <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="complain" runat="server" placeholder="Complain" > </asp:TextBox>
                        </div>
                     </div>
                     
               
                          <div class="col-md-6">
                        <label>action</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="action" runat="server" placeholder="Action" > </asp:TextBox>
                        </div>
                     
                  </div>
                      </div>   
                   
                   <div class="row">
                      
                     <div class="col-4">
                        <asp:Button ID="Button3" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button3_Click" />
                     </div>
                     <div class="col-4">
                        <asp:Button ID="Button2" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button2_Click" />
                     </div>
                  </div>
               </div>
            </div>
            
         </div>
      </div>
   </div>
    
      <div class="container">
      <div class="row">
         <div class="col-md mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row text-center">
                      <div class="col-md mx-auto">
                      <center>
                           <h4>Order List</h4>
                       
                     
                 <div class="row">
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [complain]"></asp:SqlDataSource>
                   
                     <div class="col">
                         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="complain_id" DataSourceID="SqlDataSource1" Width="228px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" >
                             <Columns>
                                 <asp:BoundField DataField="complain_id" HeaderText="complain_id" ReadOnly="True" SortExpression="complain_id" InsertVisible="False" />
                                 <asp:BoundField DataField="order_id" HeaderText="order_id" SortExpression="order_id" />
                                 <asp:BoundField DataField="product_id" HeaderText="Product ID" SortExpression="product_id" />
                                 <asp:BoundField DataField="product_name" HeaderText="Product Name" SortExpression="product_name" />
                                 <asp:TemplateField HeaderText="Image">
                                     <ItemTemplate>
                                         <asp:Image ID="Image2" runat="server" Width="50%" ImageUrl='<%# Eval("image") %>' />
                                     </ItemTemplate>
                                 </asp:TemplateField>
                                 <asp:BoundField DataField="user_id" HeaderText="User ID" SortExpression="user_id" />
                                 <asp:BoundField DataField="shop_id" HeaderText="Shop ID" SortExpression="shop_id" />
                                 <asp:BoundField DataField="complain" HeaderText="Complain" SortExpression="complain" />
                                 <asp:BoundField DataField="action" HeaderText="Action" SortExpression="action" />
                             </Columns>
                             <FooterStyle BackColor="White" ForeColor="#000066" />
                             <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                             <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                             <RowStyle ForeColor="#000066" />
                             <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                             <SortedAscendingCellStyle BackColor="#F1F1F1" />
                             <SortedAscendingHeaderStyle BackColor="#007DBB" />
                             <SortedDescendingCellStyle BackColor="#CAC9C9" />
                             <SortedDescendingHeaderStyle BackColor="#00547E" />
                         </asp:GridView>
                          
                        <hr>
                        
                     </div>
                      
                      </div>
                          </center>
                  <div class="row">  
                  
                     <div class="col">
                     
                        <hr>
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
