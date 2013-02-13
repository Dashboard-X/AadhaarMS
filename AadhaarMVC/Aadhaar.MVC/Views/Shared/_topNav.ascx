<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

    <ul>              
      <% if (HttpContext.Current.User.Identity.IsAuthenticated)
         { %>
       <li><%= Html.ActionLink("Users", "Users", "Admin")%></li>
       <li><%= Html.ActionLink("New User", "Register", "Account")%></li>
       <li><%= Html.ActionLink("Roles", "EditRoles", "Admin")%></li>
       <li><%= Html.ActionLink("Permissions", "Permissions", "Admin")%></li>
    <%}
         else
         {
      %>
      <li><%= Html.ActionLink("Home", "Index", "Home")%></li>
     <li> <%= Html.ActionLink("Log On", "LogOn", "Account")%></li>
      <%} %>
                </ul>