<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ForEachTestMissingItems.aspx.cs" Inherits="Core_ForEachTestMissingItems" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ForEach test missing items</title>
</head>
<body>
     <c:ForEach runat="server">
        value is <c:Out ID="Out1" Value="Page['item']" runat="server"/> <br/>
    </c:ForEach>
</body>
</html>
