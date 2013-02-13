<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" Title="Login" %>

<asp:Content ID="logincontent" ContentPlaceHolderID="c" runat="server">
<br />

<hr />
<div style="border:solid 1px #333333;">
<ul style="color:#ff0000">
<li>Please <a href="Register.aspx">register</a> and add yourself to "SUPER Admin" role.</li>
<li>Create exclusive permissions to the locations (Folder\File.aspx) at "Permissions" page {Visible after Login}.</li>
<li>Remove this message div from "Login.aspx" once you have created your Administrator login and created permission rules.</li>
</ul>
</div>
<br />

    <table class="tblAllBorders">
    <tr><th colspan="2"><h1>Login:</h1></th></tr>
        <tr>
            <td>User Name: 
            </td>
            <td style="width: 160px">
                <asp:TextBox ID="txtUsrId" runat="server" Width="150px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                Password:</td>
            <td style="width: 160px">
                <asp:TextBox ID="txtUsrPass" runat="server" TextMode="Password" Width="150px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login!" /></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Label ID="ErrorLabel" runat="server"></asp:Label></td>
        </tr>
    </table>
</asp:Content>