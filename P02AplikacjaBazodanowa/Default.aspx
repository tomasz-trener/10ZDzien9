<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P02AplikacjaBazodanowa.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <asp:Button ID="btnWczytaj" runat="server" OnClick="btnWczytaj_Click" Text="Wczytaj" />

        <asp:ListBox ID="lbDane" runat="server"></asp:ListBox>

    </form>
</body>
</html>
