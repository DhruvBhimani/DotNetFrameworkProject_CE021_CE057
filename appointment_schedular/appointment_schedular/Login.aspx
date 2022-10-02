<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="appointment_schedular.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.1.3/dist/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.14.3/dist/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.1.3/dist/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 178px;
        }
        .auto-style3 {
            width: 178px;
            text-align: right;
        }
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            font-size: xx-large;
        }
        .auto-style6 {
            width: 362px;
        }
        .auto-style7 {
            width: 362px;
            text-align: left;
        }
        .auto-style8 {
            width: 178px;
            text-align: right;
            height: 29px;
        }
        .auto-style9 {
            width: 362px;
            text-align: left;
            height: 29px;
        }
        .auto-style10 {
            height: 29px;
            text-align: left;
        }
        .auto-style11 {
            text-align: left;
        }
        .auto-style12 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style4">
            <div class="auto-style4">
                <strong><span class="auto-style5">Login Page</span><br class="auto-style5" />
                </strong>
            </div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style8"><strong>UserName:</strong></td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUserName" CssClass="auto-style12" ErrorMessage="please enter user name"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"><strong>Password:</strong></td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPassword" CssClass="auto-style12" ErrorMessage="please enter password"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Button ID="Button_login" runat="server" CssClass="auto-style12" OnClick="Button_login_Click" Text="Login" />
                    </td>
                    <td class="auto-style11">
                        <asp:HyperLink ID="HyperLinkReg" runat="server" ForeColor="Red" NavigateUrl="~/registration.aspx">New User? Register here</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
