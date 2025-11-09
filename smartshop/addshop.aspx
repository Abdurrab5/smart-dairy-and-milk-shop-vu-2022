<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addshop.aspx.cs" Inherits="smartshop.addshop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
      <div class="row text-center">
         <div class="col-md-6 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                       
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Register Shop</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Shop Id</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="shop id"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Shop name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="shop name" ></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Owner Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="owner name"    ></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Address</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="address" > </asp:TextBox>
                        </div>
                     </div>
                  </div>
                  
                     
                    
                  <div class="row">
                     <div class="col">
                        <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Register" OnClick="Button1_Click"     />
                        </div>
                     </div>
                  </div>
               </div>
            </div>
            
         </div>
           <div class="col-md-6 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [shop] WHERE ([owner_name] = @owner_name)">
                             <SelectParameters>
                                 <asp:SessionParameter Name="owner_name" SessionField="fullname" Type="String" />
                             </SelectParameters>
                         </asp:SqlDataSource>
                         
                         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="shop_id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Width="502px">
                             <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                             <Columns>
                                 <asp:BoundField DataField="shop_id" HeaderText="Shop ID" ReadOnly="True" SortExpression="shop_id" />
                                 <asp:BoundField DataField="shop_name" HeaderText="Shop Name" SortExpression="shop_name" />
                                 <asp:BoundField DataField="owner_name" HeaderText="Owner" SortExpression="owner_name" />
                                 <asp:BoundField DataField="address" HeaderText="Address" SortExpression="address" />
                                 <asp:BoundField DataField="status" HeaderText="Status" SortExpression="status" />
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

</asp:Content>
