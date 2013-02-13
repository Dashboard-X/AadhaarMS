<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="unauthorized.aspx.cs" Inherits="unauthorized" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c" Runat="Server">
<h1>Access Denied:</h1>
<p>Access for your ID to the requested location (<%= offendingUrl %>) is denied. Please <a href='login.aspx?ReturnUrl=<%= offendingUrl %>'>Click Here</a> to Login Again with valid credentials to access this resource.</p>
</asp:Content>

