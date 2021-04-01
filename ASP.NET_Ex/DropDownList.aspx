<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DropDownList.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="請選擇居住地點"></asp:Label>
            <br />
            <br />
            地區：<asp:DropDownList ID="dwnRegion" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="dwnRegion_SelectedIndexChanged">
                <asp:ListItem Selected="True" Value="0">居住地區</asp:ListItem>
                <asp:ListItem Value="1">美國</asp:ListItem>
                <asp:ListItem Value="2">大陸</asp:ListItem>
                <asp:ListItem Value="3">台灣</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            城市：<asp:DropDownList ID="dwnCity" runat="server" AutoPostBack="True" Height="19px" OnSelectedIndexChanged="dwnCity_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="labMsg" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
