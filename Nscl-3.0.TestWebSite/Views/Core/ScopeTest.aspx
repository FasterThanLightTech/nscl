<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
     <c:Set Var="Application['application']" Value="'I am in application scope'" runat="server" />
    <c:Out Value="Application['application']" runat="server"/>
    <br />

    <c:Set Var="Session['session']" Value="'I am in session scope'" runat="server" />
    <c:Out Value="Session['session']" runat="server"/>
    <br />

    <c:Out Value="Request.HttpMethod" runat="server"/>
    <br />

    <c:Out Value="ViewData['msg']" runat="server"/>

</asp:Content>