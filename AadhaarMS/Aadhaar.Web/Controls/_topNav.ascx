<%@ Control Language="C#" AutoEventWireup="true" CodeFile="_topNav.ascx.cs" Inherits="Controls_topNav" %>

<ul>
    <li><a href="<%= appPath %>">Home</a></li>
    <% if (HttpContext.Current.User.Identity.IsAuthenticated)
       { %>
    <li><a href="<%= appPath %>SUPERAdmin/UserList.aspx">Users</a></li>
    <li><a href="<%= appPath %>SUPERAdmin/UserDetails.aspx">Create User</a></li>
    <li><a href="<%= appPath %>SUPERAdmin/RoleList.aspx">Roles</a></li>
    <li><a href="<%= appPath %>SUPERAdmin/Permissions.aspx">Permissions</a></li>
    <%} %>
    </ul>