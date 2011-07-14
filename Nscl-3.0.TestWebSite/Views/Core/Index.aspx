<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Nscl_3._0.TestWebSite.Views.Core.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
See links below:<br/>
<%=Html.ActionLink("CwoTestExtraOtherwise", "CwoTestExtraOtherwise") %><br/>
<%=Html.ActionLink("CwoTestFirstWhen", "CwoTestFirstWhen")%><br/>
<%=Html.ActionLink("CwoTestMissingOtherwise", "CwoTestMissingOtherwise")%><br/>
<%=Html.ActionLink("CwoTestMissingWhen", "CwoTestMissingWhen")%><br/>
<%=Html.ActionLink("CwoTestSecondWhen", "CwoTestSecondWhen")%><br/>
<%=Html.ActionLink("CwoTestOtherwise", "CwoTestOtherwise")%><br/>
<%=Html.ActionLink("CwoTestSecondWhen", "CwoTestSecondWhen")%><br/>
<%=Html.ActionLink("ForEachTest", "ForEachTest")%><br/>
<%=Html.ActionLink("ForEachTestMissingItems", "ForEachTestMissingItems")%><br/>
<%=Html.ActionLink("IfTestConditionMissing", "IfTestConditionMissing")%><br/>
<%=Html.ActionLink("IfTestReturnsFalse", "IfTestReturnsFalse")%><br/>
<%=Html.ActionLink("IfTestReturnsTrue", "IfTestReturnsTrue")%><br/>
<%=Html.ActionLink("ScopeTest", "ScopeTest")%><br/>
</asp:Content>
