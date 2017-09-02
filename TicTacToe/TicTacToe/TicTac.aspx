<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicTac.aspx.cs" Inherits="TicTacToe.TicTac" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Height="26px" OnClick="Button1_Click" Text="Button" />
        <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Button ID="Button3" runat="server" OnClick="Button1_Click"  Text="Button" />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Button ID="Button5" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Button ID="Button6" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <asp:Button ID="Button7" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Button ID="Button8" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Button ID="Button9" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Width="343px" Height="30px"></asp:Label>
        <br />
        <asp:Button ID="Button11" runat="server" Text="Restart" OnClick="RestartButton_Click" />
        <br />
    </form>
</body>
</html>
