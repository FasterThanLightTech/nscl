<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <c:ForEach Items="ViewData['items']" runat="server">
        value is <c:Out Value="Items['item']" runat="server"/> <br/>
    </c:ForEach>
</asp:Content>