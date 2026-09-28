<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="Authentication.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Session and State management</title>
</head>
<body>
    <form id="form1" runat="server">
<asp:TextBox ID="txtName"
    runat="server">
</asp:TextBox>

<asp:Button ID="btnSave"
    runat="server"
    Text="Save"
    OnClick="btnSave_Click" />

<asp:Button ID="btnNext"
    runat="server"
    Text="Go to Page 2"
    OnClick="btnNext_Click" />
    </form>
</body>
</html>
