<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="smartshop.order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:FormView ID="FormView1" runat="server"></asp:FormView>
     <div class="container-fluid">
        <div class="row">
            <div class="col-md  mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
    <center> <h1> My Order</h1>
   

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [orders] WHERE ([user_id] = @user_id)">
        <SelectParameters>
            <asp:SessionParameter Name="user_id" SessionField="userid" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="SqlDataSource1" DataKeyNames="order_id">
      <Columns>
          <asp:BoundField DataField="order_id" HeaderText="Order ID" InsertVisible="False" ReadOnly="True" SortExpression="order_id" />
          <asp:BoundField DataField="user_id" HeaderText="User" SortExpression="user_id" />
          <asp:BoundField DataField="product_id" HeaderText="Product ID" SortExpression="product_id" />
          <asp:BoundField DataField="product_name" HeaderText="Product Name" SortExpression="product_name" />
          <asp:TemplateField HeaderText="Image">
              <ItemTemplate>
                  <asp:Image ID="Image1" runat="server" width="40%" ImageUrl='<%# Eval("image") %>' />
              </ItemTemplate>
          </asp:TemplateField>
          <asp:BoundField DataField="quantity" HeaderText="Quantity" SortExpression="quantity" />
          <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price" />
          <asp:BoundField DataField="address" HeaderText="Address" SortExpression="address" />
          <asp:BoundField DataField="delivery_time" HeaderText="Delivery Time" SortExpression="delivery_time" />
          <asp:BoundField DataField="order_date" HeaderText="Order Date" SortExpression="order_date" />
          <asp:BoundField DataField="shop_id" HeaderText="Shop ID" SortExpression="shop_id" />
          <asp:BoundField DataField="payment_type" HeaderText="Payment Type" SortExpression="payment_type" />
          <asp:BoundField DataField="payment_status" HeaderText="Payment Status" SortExpression="payment_status" />
          <asp:BoundField DataField="order_status" HeaderText="Order Status" SortExpression="order_status" />
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
               

    </center> 
                                <br />
                                
                                <br />

                                <br />
                                
                                <br />
                                
                                <br />
                         </div>
                       </div>
        </div>
     </div>
                            
         
         </div> 

    </div>
 </div>

</asp:Content>
