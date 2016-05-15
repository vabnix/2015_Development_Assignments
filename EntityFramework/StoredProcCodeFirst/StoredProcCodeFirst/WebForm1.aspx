<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StoredProcCodeFirst.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h2>Entity/Model Approach - using Stored Procedure</h2><hr />
     <table>
        <tr>
          <td>
              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                  CellPadding="4" DataKeyNames="ID" DataSourceID="EntityDataSource1" 
                  ForeColor="#333333" GridLines="None">
                  <AlternatingRowStyle BackColor="White" />
                  <Columns>
                      <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                      <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" 
                          SortExpression="ID" />
                      <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                      <asp:BoundField DataField="Gender" HeaderText="Gender" 
                          SortExpression="Gender" />
                      <asp:BoundField DataField="Salary" HeaderText="Salary" 
                          SortExpression="Salary" />
                  </Columns>
                  <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                  <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                  <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                  <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                  <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                  <SortedAscendingCellStyle BackColor="#FDF5AC" />
                  <SortedAscendingHeaderStyle BackColor="#4D0000" />
                  <SortedDescendingCellStyle BackColor="#FCF6C0" />
                  <SortedDescendingHeaderStyle BackColor="#820000" />
              </asp:GridView>
          </td>
          <td>
              <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="143px" 
                  AutoGenerateRows="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" 
                  BorderWidth="1px" CellPadding="2" DataKeyNames="ID" 
                  DataSourceID="EntityDataSource1" DefaultMode="Insert" ForeColor="Black" 
                  GridLines="None" oniteminserting="DetailsView1_ItemInserting">
                  <AlternatingRowStyle BackColor="PaleGoldenrod" />
                  <EditRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                  <Fields>
                      <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="false" ReadOnly="True" 
                          SortExpression="ID" />
                      <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                      <asp:BoundField DataField="Gender" HeaderText="Gender" 
                          SortExpression="Gender" />
                      <asp:BoundField DataField="Salary" HeaderText="Salary" 
                          SortExpression="Salary" />
                      <asp:CommandField ShowInsertButton="True" />
                  </Fields>
                  <FooterStyle BackColor="Tan" />
                  <HeaderStyle BackColor="Tan" Font-Bold="True" />
                  <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                      HorizontalAlign="Center" />
              </asp:DetailsView>
          </td>
          <td></td>
        </tr>
     </table>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" 
            ConnectionString="name=EmployeeDBContext" 
            DefaultContainerName="EmployeeDBContext" EnableDelete="True" 
            EnableFlattening="False" EnableInsert="True" EnableUpdate="True" 
            EntitySetName="Employees">
        </asp:EntityDataSource>
    </div>
    </form>
</body>
</html>
