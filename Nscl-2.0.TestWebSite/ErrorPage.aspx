<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ErrorPage.aspx.cs" Inherits="ErrorPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Error Page</title>
</head>
<body>
    <%
    Exception error = (Exception)HttpContext.Current.Application["Error"]; 
    if (error != null)
    {
        Response.Write(error.Message+"<br/>");
        if (error.InnerException != null)
        {
            Response.Write(error.InnerException.Message);
            Response.Write(error.InnerException.StackTrace);
        }
    }
    %>
</body>
</html>
