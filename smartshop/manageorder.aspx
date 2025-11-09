<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="manageorder.aspx.cs" Inherits="smartshop.manageorder" %>
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
                           <h4>Order Details</h4>
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
                        <label>order ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="orderid" runat="server" placeholder="OrderID"></asp:TextBox>
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
                        <label>price</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="price" runat="server" placeholder="price" > </asp:TextBox>
                        </div>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col-md-6">
                        <label>quantity</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="quantity" runat="server" placeholder="quantity"    ></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>address</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="address" runat="server" placeholder="description" > </asp:TextBox>
                        </div>
                     </div>
                  </div>
                      <div class="row">
                     <div class="col-md-6">
                        <label>Shop Id</label>
                        <div class="form-group">
                          
                              <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                              <asp:ListItem Text="A1" Value="a1" />
                              <asp:ListItem Text="a2" Value="a2" />
                           </asp:DropDownList>
                          
                     </div>
                     
                  </div>
                          <div class="col-md-6">
                        <label>user Id</label>
                        <div class="form-group">
                          
                              <asp:DropDownList class="form-control" ID="DropDownList2" runat="server">
                              <asp:ListItem Text="A1" Value="a1" />
                              <asp:ListItem Text="a2" Value="a2" />
                           </asp:DropDownList>
                          
                     </div>
                     
                  </div>
                      </div>
                    <div class="row">
                     <div class="col-md-6">
                        <label>Payment Type</label>
                        <div class="form-group">
                          
                              <asp:DropDownList class="form-control" ID="DropDownList3" runat="server">
                              <asp:ListItem Text="COD" Value="COD" />
                              <asp:ListItem Text="Transfer" Value="Transfer" />
                           </asp:DropDownList>
                          
                     </div>
                     
                  </div>
                          <div class="col-md-6">
                        <label>Payment status</label>
                        <div class="form-group">
                          
                              <asp:DropDownList class="form-control" ID="DropDownList4" runat="server">
                              <asp:ListItem Text="pending" Value="pending" />
                              <asp:ListItem Text="paid" Value="paid" />
                           </asp:DropDownList>
                          
                     </div>
                     
                  </div>
                      </div>
                    <div class="row">
                     <div class="col-md-6">
                        <label>Order Status</label>
                        <div class="form-group">
                          
                              <asp:DropDownList class="form-control" ID="DropDownList5" runat="server">
                              <asp:ListItem Text="pending" Value="pending" />
                              <asp:ListItem Text="proccessing" Value="proccessing" />
                                  <asp:ListItem Text="complete" Value="complete" />
                              <asp:ListItem Text="cancel" Value="complete" />
                           </asp:DropDownList>
                          
                     </div>
                     
                  </div>
                         
                      </div>
                   </div>
                         
                      </div>
                    
                   <div class="row">
                     <div class="col-4">
                        <asp:Button ID="Button1" class="btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button1_Click" />
                     </div>
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
       <div class="container">
         <div class="col-md-10 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row text-center">
                      <div class="col-md mx-auto">
                      <center>
                           <h4>Order List</h4>
                      
                     
                 <div class="row">
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [orders]">
                     </asp:SqlDataSource>
                   
                     <div class="col">
                         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="order_id" DataSourceID="SqlDataSource1" Width="228px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" >
                             <Columns>
                                 <asp:BoundField DataField="order_id" HeaderText="order_id" ReadOnly="True" SortExpression="order_id" InsertVisible="False" />
                                 <asp:BoundField DataField="user_id" HeaderText="user_id" SortExpression="user_id" />
                                 <asp:BoundField DataField="product_id" HeaderText="product_id" SortExpression="product_id" />
                                 <asp:BoundField DataField="product_name" HeaderText="product_name" SortExpression="product_name" />
                                 <asp:BoundField DataField="image" HeaderText="image" SortExpression="image" />
                                 <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
                                 <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                                 <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                                 <asp:BoundField DataField="delivery_time" HeaderText="delivery_time" SortExpression="delivery_time" />
                                 <asp:BoundField DataField="order_date" HeaderText="order_date" SortExpression="order_date" />
                                 <asp:BoundField DataField="shop_id" HeaderText="shop_id" SortExpression="shop_id" />
                                 <asp:BoundField DataField="payment_type" HeaderText="payment_type" SortExpression="payment_type" />
                                 <asp:BoundField DataField="payment_status" HeaderText="payment_status" SortExpression="payment_status" />
                                 <asp:BoundField DataField="order_status" HeaderText="order_status" SortExpression="order_status" />
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
