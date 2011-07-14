<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IfTestReturnsTrue.aspx.cs" Inherits="Core_IfTestReturnsTrue" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>If Test Returns True</title>
</head>
<body>
    <c:If Test="1==1" runat="server">
        You should see this
    </c:If>

</body>
</html>
