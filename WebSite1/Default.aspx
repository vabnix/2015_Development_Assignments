<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <h2>This is Page 1</h2><hr />
      <table>
         <tr>
           <td>Enter Name</td>
           <td>
               <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
         </tr>
         <tr>
           <td>Enter Email</td>
           <td>
               <asp:TextBox ID="txtemail" runat="server"></asp:TextBox></td>
         </tr>
      </table>
        <asp:Button ID="submit" runat="server" Text="submit" onclick="submit_Click" />
    </div>
    </form>
</body>
</html>
