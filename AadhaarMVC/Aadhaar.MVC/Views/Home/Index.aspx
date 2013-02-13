<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%= Html.Encode( ViewData["Message"] ) %></h2>
    <p>
    <div style="border:solid 1px #333333;">
<ul style="color:#ff0000">
<li>Please <%= Html.ActionLink("Register","Register","Account",null,null) %> and add yourself to "SUPER Admin" role.</li>
<li>"Permissions" page will be visible once you add yourself to "SUPER Admin" role.<b>(By clicking on the UserId on the "Users" window and adding yourself to "SUPER Admin" role in UserDetails window.)</b></li>
<li>Create "EXCLUSIVE" permissions to the locations (Controller\Action) at "Permissions" page {Visible after Login}.</li>
<li>Remove this message div from "Login.aspx" once you have created your Administrator login and created permission rules.</li>
</ul>
</div>
    </p>
</asp:Content>
