<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicPage.aspx.cs" Inherits="DynamicContentExample.DynamicPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<head runat="server">
    <title>Dynamic Page</title>
</head>
<body>
    <form id="DynamicPage" runat="server">
        <div class="col-md-4">
            This is a dynamic page.
        </div>
        <div class="col-md-4">
            <asp:Button ID="ShowIt" runat="server" Text="Show It" OnClick="ShowIt_Click" />
        </div>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </form>
</body>
</html>
