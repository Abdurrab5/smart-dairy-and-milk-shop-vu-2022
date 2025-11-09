<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="smartshop.category" %>
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
                           <h4>Category Details</h4>
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
                        <label>Category ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="category ID"></asp:TextBox>
                              <asp:Button class="form-control btn btn-primary" ID="Button4" runat="server" Text="Go" OnClick="Button4_Click" />
                           </div>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>category name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="product name" ></asp:TextBox>
                        </div>
                     </div>
                  </div>
                      <div class="row">
                     <div class="col-4">
                        <asp:Button ID="Button1" class="btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button1_Click"  />
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
           <div class="col-md-6 mx-auto">
            <div class="card">
               <div class="card-body">
                   <div class="row text-center">
                     <div class="col">
                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [category]"></asp:SqlDataSource>
                         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="category_id" DataSourceID="SqlDataSource1" GridLines="Horizontal" Width="425px">
                             <Columns>
                                 <asp:BoundField DataField="category_id" HeaderText="Category ID" ReadOnly="True" SortExpression="category_id" />
                                 <asp:BoundField DataField="cat_name" HeaderText="category" SortExpression="cat_name" />
                             </Columns>
                             <FooterStyle BackColor="White" ForeColor="#333333" />
                             <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                             <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                             <RowStyle BackColor="White" ForeColor="#333333" />
                             <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                             <SortedAscendingCellStyle BackColor="#F7F7F7" />
                             <SortedAscendingHeaderStyle BackColor="#487575" />
                             <SortedDescendingCellStyle BackColor="#E5E5E5" />
                             <SortedDescendingHeaderStyle BackColor="#275353" />
                         </asp:GridView>
                     </div>
                  </div>
                   </div>
                  </div>
               </div>
                  </div>
         </div>
</asp:Content>
