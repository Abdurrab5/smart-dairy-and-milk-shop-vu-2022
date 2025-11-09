<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="complain.aspx.cs" Inherits="smartshop.complain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container-fluid">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row   text-center">
                            <div class="col   ">
                              <center> <h1>complain</h1></center> 
                                <table class="table">
                                    <tr>

                                        <td valign="top" rowspan="2">
                                            <div>
                                                <span >Order ID :</span> &nbsp;&nbsp;
         <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true"></asp:DropDownList>
                                            </div>
                                            <br />
                                            <div>
                                                <asp:Image ID="Image1" runat="server" />
                                            </div>
                                            <div>
                                                <span>Product Id :</span> &nbsp;&nbsp;
        <asp:Label ID="product_id" runat="server"></asp:Label>
                                            </div>
                                            <div>
                                                <span>Product Name :</span> &nbsp;&nbsp;
        <asp:Label ID="productname" runat="server"></asp:Label>
                                            </div>
                                            <div>
                                                <span>Shop ID :</span> &nbsp;&nbsp;
        <asp:Label ID="shop_id" runat="server"></asp:Label>
                                            </div>
                                            <div>
                                                <span>complain :</span> &nbsp;&nbsp;
        <asp:TextBox ID="description" runat="server"></asp:TextBox>
                                            </div>
                                            <br />

                                            <div>
                                                <asp:LinkButton ID="Submit" class="btn btn-success" runat="server" OnClick="Submit_Click">Submit</asp:LinkButton>
                                            </div>
                                        </td>
                                    </tr>
                                </table>  
                            </div>
                          
                        </div>
                    </div>
                </div>

            </div>
             
        </div>
     </div>
    <br />
     <br /> <br />
    <div class="container">
         <div class="col-md-12  ">
                    <div class="card">
               <div class="card-body">
                  <div class="row text-center">
                     <div class="col ">
                         <center>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:smartshopConnectionString %>" SelectCommand="SELECT * FROM [complain] WHERE ([user_id] = @user_id)">
                                    <SelectParameters>
                                        <asp:SessionParameter Name="user_id" SessionField="userid" Type="String" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="complain_id" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                                    <Columns>
                                        <asp:BoundField DataField="complain_id" HeaderText="Complain ID" InsertVisible="False" ReadOnly="True" SortExpression="complain_id" />
                                        <asp:BoundField DataField="order_id" HeaderText="Order ID" SortExpression="order_id" />
                                        <asp:BoundField DataField="product_id" HeaderText="Product ID" SortExpression="product_id" />
                                        <asp:BoundField DataField="product_name" HeaderText="Product Name" SortExpression="product_name" />
                                        <asp:TemplateField HeaderText="Image">
                                            <ItemTemplate>
                                                <asp:Image ID="Image2" runat="server" Width="40%" ImageUrl='<%# Eval("image") %>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        
                                        <asp:BoundField DataField="user_id" HeaderText="User ID" SortExpression="user_id" />
                                        <asp:BoundField DataField="shop_id" HeaderText="Shop ID" SortExpression="shop_id" />
                                        <asp:BoundField DataField="complain" HeaderText="Complain" SortExpression="complain" />
                                        <asp:BoundField DataField="action" HeaderText="Action" SortExpression="action" />
                                    </Columns>
                                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                                    <RowStyle BackColor="White" ForeColor="#330099" />
                                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                                </asp:GridView></center>
                         </div>
                       </div>
        </div>
     </div>
                            
         
         </div> 

    </div>
</asp:Content>
