<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P02AplikacjaBazodanowa.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <div style="float:left">
            <asp:Button ID="btnWczytaj" runat="server" OnClick="btnWczytaj_Click" Text="Wczytaj" />
            <br />
            <asp:ListBox ID="lbDane" Height="200" AutoPostBack="true" OnSelectedIndexChanged="lbDane_SelectedIndexChanged" runat="server"></asp:ListBox>
        </div>
        <div style="float:left; margin-left:10px">
            <table>
                <tr>
                    <td>Imie</td>
                    <td><asp:TextBox ID="txtImie" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Nazwisko</td>
                    <td><asp:TextBox ID="txtNazwisko" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Kraj</td>
                    <td><asp:TextBox ID="txtKraj" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Data urodzenia</td>
                    <td><asp:TextBox ID="txtDataUrodzenia" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Wzrost</td>
                    <td><asp:TextBox ID="txtWzrost" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Waga</td>
                    <td><asp:TextBox ID="txtWaga" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </div>
        <div style="float:left;margin-left:10px;display: inline-grid;">
            <asp:Button ID="btnZapisz" runat="server" OnClick="btnZapisz_Click" Text="Zapisz" />
            <asp:Button ID="btnDodaj" runat="server" OnClick="btnDodaj_Click" Text="Dodaj" />
            <asp:Button ID="btnUsun" runat="server" OnClick="btnUsun_Click" Text="Usun" />
        </div>
    </form>
</body>
</html>
