<%@ Page Language="C#" AutoEventWireup="true" CodeFile="install.aspx.cs" Inherits="install_install" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td colspan="2">
                    Hi, The database for the application has not been installed yet. Below is 
                    information regarding installation of Database to Mysql. The sql script for 
                    other databaes is needed to be ported yet.<br />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Literal ID="lblMessage" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td>
                    Step 1 (Check Database Connection ):</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Server Name</td>
                <td>
                    <asp:TextBox ID="txtDbSrvrName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
&nbsp;Database Name to Check</td>
                <td>
                    <asp:TextBox ID="txtDbName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtDbName" ErrorMessage="*Please input database name."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Database User Id</td>
                <td>
                    <asp:TextBox ID="txtDbUserId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Database Password</td>
                <td>
                    <asp:TextBox ID="txtDbPass" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Database Type</td>
                <td>
                    <asp:DropDownList ID="drpDbType" runat="server">
                        <asp:ListItem Value="-1">--Select--</asp:ListItem>
                        <asp:ListItem>Mysql</asp:ListItem>
                        <asp:ListItem Value="MSSql">Sql Server</asp:ListItem>
                        <asp:ListItem>Oracle</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnCreateDb" runat="server" onclick="btnCreateDb_Click" 
                        Text="Test" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Nhibernate Connection String (From Web.Config):</td>
                <td>
                    <asp:Literal ID="lblConnStrName" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td>
                    Nhibernate Dialect (From Web.Config):</td>
                <td>
                    <asp:Literal ID="lblNHDialect" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Step 2:</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Below&nbsp; is the Database script for the specified Database type. Click on the 
                    execute button to run the script.</td>
                <td>
                    <asp:Button ID="btnExecuteScript" runat="server" 
                        onclick="btnExecuteScript_Click" Text="Execute" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Literal ID="lblDbScript" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
