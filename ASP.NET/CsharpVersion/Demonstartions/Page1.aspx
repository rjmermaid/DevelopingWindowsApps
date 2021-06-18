<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="CsharpVersion.Demonstartions.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="mainText" Text="123" EnableViewState="false"/>
            <asp:Button runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
