<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Error</h2>
    <p>Sorry, an Error has occured while processing your request.</p>
     <% if (TempData["message"] != null) { %>
    <h2 style="color:Red"><%= Html.Encode(TempData["message"]) %></h2>
  <% } %>
</asp:Content>
