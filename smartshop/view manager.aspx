<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="view manager.aspx.cs" Inherits="smartshop.view_manager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <div class="container-fluid">
      <div class="row">
         <div class="col-md-5">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>manager Details</h4>
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
                        <label>manager ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="managerID"></asp:TextBox>
                              <asp:Button class="form-control btn btn-primary" ID="Button4" runat="server" Text="Go" OnClick="Button4_Click" />
                           </div>
                        </div>
                     </div>
                     <div class="col-md-8">
                        <label>manager Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="manager Name"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Email</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="email" TextMode="email"  ></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="password" ></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                    <div class="col-md-6">
                        <label>Phone</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="phone" TextMode="number"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Address</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox6" runat="server" placeholder="address"></asp:TextBox>
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
         <div class="col-md-7">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>manager List</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [managers]"></asp:SqlDataSource>

                       <div class="col">
                           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="manager_id" DataSourceID="SqlDataSource1" Width="731px" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                               <Columns>
                                   <asp:BoundField DataField="manager_id" HeaderText="Manager ID" ReadOnly="True" SortExpression="manager_id" />
                                   <asp:BoundField DataField="full_name" HeaderText="Full Name" SortExpression="full_name" />
                                   <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                                   <asp:BoundField DataField="password" HeaderText="Password" SortExpression="password" />
                                   <asp:BoundField DataField="phone" HeaderText="Phone" SortExpression="phone" />
                                   <asp:BoundField DataField="address" HeaderText="Address" SortExpression="address" />
                               </Columns>
                               <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                               <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                               <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                               <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                               <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                               <SortedAscendingCellStyle BackColor="#F1F1F1" />
                               <SortedAscendingHeaderStyle BackColor="#594B9C" />
                               <SortedDescendingCellStyle BackColor="#CAC9C9" />
                               <SortedDescendingHeaderStyle BackColor="#33276A" />
                           </asp:GridView>
                      </div>
                  </div>
               </div>
            </div>    
                  </div>
                  </div>
               </div>
                  
</asp:Content>
