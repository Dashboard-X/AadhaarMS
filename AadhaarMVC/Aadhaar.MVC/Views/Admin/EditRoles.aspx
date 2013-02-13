<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	EditRoles
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<% string[] roleList = (string[])ViewData["roleList"]; %>
    <h2>EditRoles</h2>
    <% if (TempData["message"] != null) { %>
    <p style="color:Red"><%= Html.Encode(TempData["message"]) %></p>
  <% } %>
<p><%= Html.ValidationSummary(true) %></p>

<table class="tblAllBorders">
<tr><th>Role Names</th><th></th></tr>
<% if(roleList.Length!=0)
       for(int count1 = 0; count1 <= (roleList).Length - 1; count1++)
{ %>
    <tr><td><%=roleList[count1]%></td><td><%= Html.ActionLink("Delete", "DeleteRole", new { roleName = roleList[count1] })%> </td></tr>
<% } %>
</table>
<br />
<br />
<table class="tblAllBorders">
        <tr><th colspan="4">Add New Role</th></tr>
            <tr>
        <th>
            Role Name
        </th>
        <th>
            
        </th>
        </tr>
        <% using(Html.BeginForm("AddRole", "Admin", FormMethod.Post))
        {%>
        <tr>
        <td><%=Html.TextBox("txtAddRoleName")%></td>
        <td><input type="submit" value="Add New" /></td>
        </tr>
      <%  } %>
        </table>
</asp:Content>
