﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>This is WebPage1</h2>
    <hr />
       <table>
         <tr>
           <td>
               <asp:Label ID="Label1" runat="server" Text="Enter Name"></asp:Label></td>
               <td>
                   <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
         </tr>
         <tr>
           <td>
               <asp:Label ID="Label2" runat="server" Text="Enter Email"></asp:Label></td>
               <td>
                   <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
         </tr>
       </table>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
            onclick="btnSubmit_Click" />
    </div>
    </form>
</body>
</html>
