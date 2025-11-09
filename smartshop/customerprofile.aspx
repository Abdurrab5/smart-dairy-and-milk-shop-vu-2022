<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="customerprofile.aspx.cs" Inherits="smartshop.customerprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
      <div class="container-fluid">
      <div class="row">
         <div class="col-md-5 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Customer Profile</h4>
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
                        <label>Customer ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="customer ID"></asp:TextBox>
                              <asp:Button class="form-control btn btn-primary" ID="Button4" runat="server" Text="Go" OnClick="Button4_Click"  />
                           </div>
                        </div>
                     </div>
                     <div class="col-md-8">
                        <label>Customer Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="customer Name"></asp:TextBox>
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
                        <asp:Button ID="Button3" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button3_Click"   />
                     </div>
                      
                  </div>
               </div>
            </div>

              </div>
           
          
         <div class="col-md-7">
            <div class="card ">
               <div class="card-body">
                  <div class="row text-center">
                     <div class="col">
                        <center>
                           <h4>Customer Details</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                 <div class="row ">
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [customers] WHERE ([full_name] = @full_name)">
                         <SelectParameters>
                             <asp:SessionParameter Name="full_name" SessionField="fullname" Type="String" />
                         </SelectParameters>
                     </asp:SqlDataSource>
                   
                     <div class="col-6">
                         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="customer_id" DataSourceID="SqlDataSource1" Width="718px" CellPadding="4" ForeColor="#333333" GridLines="None">
                             <AlternatingRowStyle BackColor="White" />
                             <Columns>
                                
                                 <asp:BoundField DataField="customer_id" HeaderText="customer_id" ReadOnly="True" SortExpression="customer_id" />
                                 <asp:BoundField DataField="full_name" HeaderText="full_name" SortExpression="full_name" />
                                 <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                                 <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                                 <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" />
                                 <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                             
                                     </Columns>
                             <EditRowStyle BackColor="#7C6F57" />
                             <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                             <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                             <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                             <RowStyle BackColor="#E3EAEB" />
                             <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                             <SortedAscendingCellStyle BackColor="#F8FAFA" />
                             <SortedAscendingHeaderStyle BackColor="#246B61" />
                             <SortedDescendingCellStyle BackColor="#D4DFE1" />
                             <SortedDescendingHeaderStyle BackColor="#15524A" />
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
</asp:Content>
