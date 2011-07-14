<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <c:Choose runat="server">
        <c:When Test="1==1" runat="server">
            when 1
        </c:When>
        <c:When Test="1==1" runat="server">
            when 2
        </c:When>
    </c:Choose>
</asp:Content>