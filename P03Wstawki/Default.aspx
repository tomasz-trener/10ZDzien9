<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P03Wstawki.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       

        <% 

            for (int i = 0; i < 10; i++)
            {
          %>
              
              <%--<p><% Response.Write("hej " + i); %></p>--%>
            <p><%=  Napis + i %></p>

        <%   }
            %>

         <p>ala ma kota</p>
         

    </form>
</body>
</html>
