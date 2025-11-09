<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="managerprofile.aspx.cs" Inherits="smartshop.managerprofile" %>
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
                           <h4>Manager Profile</h4>
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
                        <label>Manager ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Manager ID"></asp:TextBox>
                              <asp:Button class="form-control btn btn-primary" ID="Button4" runat="server" Text="Go" OnClick="Button4_Click"  />
                           </div>
                        </div>
                     </div>
                     <div class="col-md-8">
                        <label>Manager Name</label>
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
                        <asp:Button ID="Button3" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button3_Click"   />
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
                           <h4>Manager Profile</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                 <div class="row">
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [managers] WHERE ([full_name] = @full_name)">
                         <SelectParameters>
                             <asp:SessionParameter Name="full_name" SessionField="fullname" Type="String" />
                         </SelectParameters>
                     </asp:SqlDataSource>
                   
                     <div class="col">
                         
                        
                         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="manager_id" DataSourceID="SqlDataSource1" Width="744px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                             <Columns>
                                 <asp:BoundField DataField="manager_id" HeaderText="Manager ID" ReadOnly="True" SortExpression="manager_id" />
                                 <asp:BoundField DataField="full_name" HeaderText="Full Name" SortExpression="full_name" />
                                 <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                                 <asp:BoundField DataField="password" HeaderText="Password" SortExpression="password" />
                                 <asp:BoundField DataField="phone" HeaderText="Phone" SortExpression="phone" />
                                 <asp:BoundField DataField="address" HeaderText="Address" SortExpression="address" />
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
            </div>

              </div>
</asp:Content>
