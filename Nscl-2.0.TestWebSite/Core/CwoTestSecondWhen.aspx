<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CwoTestSecondWhen.aspx.cs" Inherits="Core_CwoTestSecondWhen" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <c:Choose runat="server">
        <c:When Test="1!=1" runat="server">
            when 1
        </c:When>
        <c:When Test="1==1" runat="server">
            when 2
        </c:When>
        <c:Othewise runat="server">
            otherwise
        </c:Othewise>
    </c:Choose>
</body>
</html>
