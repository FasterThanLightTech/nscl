<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ScopeTest.aspx.cs" Inherits="Core_ScopeTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <c:Set Var="Application['application']" Value="'I am in application scope'" runat="server" />
    <c:Out Value="Application['application']" runat="server"/>
    <br />

    <c:Set Var="Session['session']" Value="'I am in session scope'" runat="server" />
    <c:Out Value="Session['session']" runat="server"/>
    <br />

    <c:Out Value="Request.HttpMethod" runat="server"/>
    <br />

    <c:Set Var="Items['page']" Value="'I am in page scope'" runat="server" />
    <c:Out Value="Items['page']" runat="server"/>

</body>
</html>
