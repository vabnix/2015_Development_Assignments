<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>This is WebPage 2</h2>
    <hr />
      <table>
        <tr>
          <td colspan="2">
              <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td>
              <td>
              <asp:Label ID="lblEnterdName" runat="server" ></asp:Label></td>
        </tr>
        <tr>
          <td colspan="2">
              <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label></td>
              <td>
              <asp:Label ID="lblEmail" runat="server" ></asp:Label></td>
        </tr>
      </table>
    </div>
    </form>
</body>
</html>
