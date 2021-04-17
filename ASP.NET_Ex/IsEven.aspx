<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IsEven.aspx.cs" Inherits="IsEven" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            請輸入一個偶數：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="確定" Width="89px" />
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="不可為空白" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
&nbsp;<asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="請輸入偶數" Font-Bold="True" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            <br />
&nbsp;</form>

</body>
</html>
