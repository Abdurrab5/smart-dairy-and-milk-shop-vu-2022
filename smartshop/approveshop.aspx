<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="approveshop.aspx.cs" Inherits="smartshop.approveshop" %>
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
                           <h4>Shop Details</h4>
                        </center>
                     </div>
                  </div>
                  
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-3">
                        <label>shop ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="shop ID"></asp:TextBox>
                              <asp:LinkButton class="btn btn-primary" ID="LinkButton4" runat="server" OnClick="LinkButton4_Click" ><i class="fas fa-check-circle"></i></asp:LinkButton>
                           </div>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Shop name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Full Name" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                   <div class="row">
                     <div class="col-md-5">
                          
                        <label>owner Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="owner name" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                      <div class="col-md-5">
                          
                        <label>Address</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="address" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                      
                    
                  </div>
                  <div class="row">
                      <label>Status</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-1" ID="TextBox7" runat="server" placeholder="Account Status" ReadOnly="True"></asp:TextBox>
                              <asp:LinkButton class="btn btn-success mr-1" ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" ><i class="fas fa-check-circle"></i></asp:LinkButton>
                              <asp:LinkButton class="btn btn-warning mr-1" ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" ><i class="far fa-pause-circle"></i></asp:LinkButton>
                              <asp:LinkButton class="btn btn-danger mr-1" ID="LinkButton3" runat="server"  OnClick="LinkButton3_Click"><i class="fas fa-times-circle"></i></asp:LinkButton>
                           </div>
                        </div>
                        </div>
                  <div class="row">
                     <div class="col mx-auto">
                        <asp:Button ID="Button2" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete shop Permanently" OnClick="Button2_Click1"  />
                     </div>
                  </div>
               </div>
               
            </div>
           <br>
            <br>
         </div> </div>
         <div class="col-md-7">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>shop List</h4>
                        </center>
                     </div>
                  </div>
                 <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                      
                      </div>
                  <div class="row">  
                      
                   <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [shop]"></asp:SqlDataSource>
                 
                     <div class="col">
                      <asp:GridView ID="GridView1" runat="server" Width="716px" AutoGenerateColumns="False" DataKeyNames="shop_id" DataSourceID="SqlDataSource2" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                          <Columns>
                              <asp:BoundField DataField="shop_id" HeaderText="shop_id" ReadOnly="True" SortExpression="shop_id" />
                              <asp:BoundField DataField="shop_name" HeaderText="shop_name" SortExpression="shop_name" />
                              <asp:BoundField DataField="owner_name" HeaderText="owner_name" SortExpression="owner_name" />
                              <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                              <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
                          </Columns>
                          <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                          <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                          <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                          <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                          <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                          <SortedAscendingCellStyle BackColor="#FFF1D4" />
                          <SortedAscendingHeaderStyle BackColor="#B95C30" />
                          <SortedDescendingCellStyle BackColor="#F1E5CE" />
                          <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
                        <hr>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
</asp:Content>
