<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Login_page_with_Bootstrap.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login page</title>
    <link href="Style.css" rel="stylesheet" />
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <nav class="pt-3">
                <a href="#" class="px-5">Grow</a>
                <asp:Button ID="Button1" CssClass="btn btn-success mr-4 mt-3 px-4" runat="server" Text="Sign Up" />
            </nav>
                <div class="row">
                    <div class="col-6 cols1">
                        <asp:TextBox ID="TextBox1" placeholder="UserName" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBox2" placeholder="Password" CssClass="form-control" TextMode="Password" runat ="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="Submit" CssClass="btn px-5" runat="server" Text="Log In" />
                        
                    </div>

                   
                    <div class="col-6">
                        <p>
                            If you can<br />
                            Think it,<br />
                            We can make<br />
                            it.
                        </p>
                    
                    </div>

                </div>
        </div>
    </form>
</body>
</html>
