<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <c:Choose runat="server">
        <c:Othewise runat="server">
            otherwise
        </c:Othewise>
    </c:Choose>
</asp:Content>