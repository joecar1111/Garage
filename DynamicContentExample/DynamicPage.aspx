<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="DynamicPage.aspx.cs" Inherits="DynamicContentExample.DynamicPage" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<!DOCTYPE html>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<div class="col-md-4">
    This is a dynamic page.
</div>
<div class="col-md-4">
    <asp:Button ID="ShowItNow" runat="server" Text="Show It" OnClick="ShowIt_Click" />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <asp:Label runat="server" Text="Label"></asp:Label>    </asp:UpdatePanel>
    <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></asp:Panel>
</div>
</asp:Content>