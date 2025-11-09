<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addproducts.aspx.cs" Inherits="smartshop.addproducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
      <div class="row">
         <div class="col-md-5 mx-auto">
            <div class="card">
               <div class="card-body">
                   <div class="row">
                     <div class="col">
                        <center>
                           <h4>Product Details</h4>
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
                        <label>Product ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="product ID"></asp:TextBox>
                              <asp:Button class="form-control btn btn-primary" ID="Button4" runat="server" Text="Go" OnClick="Button4_Click" />
                           </div>
                        </div>
                     </div>
                       <div class="col-md-4">
                        <label>product Category</label>
                         <div class="form-group">
                          
                              <asp:DropDownList class="form-control" ID="DropDownList2" runat="server">
                              <asp:ListItem Text="A1" Value="a1" />
                              <asp:ListItem Text="a2" Value="a2" />
                           </asp:DropDownList>
                          
                     </div>
                     </div>
                 
                     <div class="col-md-4">
                        <label>product name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="product name" ></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  
                  <div class="row">
                     <div class="col-md-6">
                        <label>image</label>
                        <div class="form-group">
                            <asp:Image ID="Image2" width="40%" runat="server" />
                          <asp:FileUpload onchange="readURL(this);" class="form-control" ID="FileUpload1" runat="server" />
                     </div>
                     </div>
                     <div class="col-md-6">
                        <label>price</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="price" > </asp:TextBox>
                        </div>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col-md-6">
                        <label>quantity</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="quantity"    ></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Description</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="description" > </asp:TextBox>
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
                        <label>Delivery Time</label>
                        <div class="form-group">
                          
                              <asp:DropDownList class="form-control" ID="DropDownList3" runat="server">
                              <asp:ListItem Text="2 day" Value="2 day" />
                             <asp:ListItem Text="3 day" Value="3 day" />
                                  <asp:ListItem Text="4 day" Value="4 day" />
                                  <asp:ListItem Text="5 day" Value="5 day" />
                           </asp:DropDownList>
                          
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
             <div class="col-md-7 mx-auto">
            <div class="card">
               <div class="card-body">
                   <div class="row">
                     <div class="col">
                         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [products]">
                         </asp:SqlDataSource>
                         <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
                             <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                             <Columns>
                                 <asp:BoundField DataField="product_id" HeaderText="Product ID" SortExpression="product_id" />
                                 <asp:BoundField DataField="product_name" HeaderText="Product Name" SortExpression="product_name" />
                                 <asp:TemplateField HeaderText="Image">
                                     <ItemTemplate>
                                         <asp:Image ID="Image3" runat="server" width="50%" ImageUrl='<%# Eval("image") %>' />
                                     </ItemTemplate>
                                 </asp:TemplateField>
                                 <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price" />
                                 <asp:BoundField DataField="quantity" HeaderText="Quantity" SortExpression="quantity" />
                                 <asp:BoundField DataField="delivery_time" HeaderText="Delivery Time" SortExpression="delivery_time" />
                                 <asp:BoundField DataField="description" HeaderText="Description" SortExpression="description" />
                                 <asp:BoundField DataField="shop_id" HeaderText="Shop ID" SortExpression="shop_id" />
                                 <asp:BoundField DataField="category_id" HeaderText="Category" SortExpression="category_id" />
                             </Columns>
                             <EditRowStyle BackColor="#999999" />
                             <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                             <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                             <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                             <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                             <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                             <SortedAscendingCellStyle BackColor="#E9E7E2" />
                             <SortedAscendingHeaderStyle BackColor="#506C8C" />
                             <SortedDescendingCellStyle BackColor="#FFFDF8" />
                             <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                         </asp:GridView>

                         </div>
                  </div>
               </div>
            </div>
            
         </div>


      </div>
   </div>
    <div class="container">
      <div class="row">
         <div class="col-md-8 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                      <div class="col-md-8 mx-auto">
                        <center>
                           <h4>Product List</h4>
                        </center>
                     </div>
                  </div>
                 <div class="row">
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>
                   
                     <div class="col">
                         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="product_id" DataSourceID="SqlDataSource1" Width="778px">
                             <Columns>
                                <asp:TemplateField>

                                      <ItemTemplate>
 
                                                    <div class="card text-center">
                                                        <div class="card-body">
                                                            <div class="row">


                                                                <div class="col-12">


                                                                    <asp:Image ID="Image1" class="img-fluid"  runat="server" ImageUrl='<%# Eval("image") %>' />
                                                                     <h3 class="text-primary">

                                                                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("product_id") %>'></asp:Label>

                                                                    </h3>
                                                                    <h1>

                                                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("product_name") %>'></asp:Label>

                                                                    </h1>
                                                                    <p class="text-info">
                                                                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("description") %>'></asp:Label>

                                                                    </p>
                                                                     <p class="text-info">
                                                                        <asp:Label ID="Label8" runat="server" Text='<%# Eval("delivery_time") %>'></asp:Label>

                                                                    </p>
                                                                    <p class="text-danger">
                                                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("price") %>'></asp:Label>
                                                                   </p>
                                                                    <p class="text-dark">

                                                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("quantity") %>'></asp:Label>

                                                                  </p>  <asp:Label ID="Label6" runat="server" Text='<%# Eval("shop_id") %>'></asp:Label>

                                                                     </p>  <asp:Label ID="Label7" runat="server" Text='<%# Eval("category_id") %>'></asp:Label>

                                                               

                                                            </div>

                                                        
                                                        

                                                    </div>
                                                    </div>
                                                </ItemTemplate>

                                 </asp:TemplateField>
                             </Columns>
                         </asp:GridView>
                        <hr>
                     </div>
                      
                      </div>
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
</asp:Content>
