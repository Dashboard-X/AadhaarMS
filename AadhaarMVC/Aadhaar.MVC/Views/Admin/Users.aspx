<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Users
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Users</h2>
    <% if (TempData["message"] != null) { %>
    <p style="color:Red"><%= Html.Encode(TempData["message"]) %></p>
  <% } %>
    <table class="tblAllBorders">
    <tr>
    <th>
    Id
    </th>
        <th>
            E-mail
        </th>
        <th>
            creationDate
        </th>
        <th>
            lastActivityDate
        </th>
        <th>
            lastLoginDate
        </th>
        <th>
            lastLockedOutDate
        </th>
                <th>
            isApproved
        </th>
        <th>
            isLockedOut
        </th>
    </tr>

    <% foreach (var item in (System.Collections.Generic.List<Aadhaar.MVC.Models.UsersModel>)ViewData["userList"])
       { %>
    
        <tr>
            <td>
                <%= Html.ActionLink(item.name, "UserDetails", new { id=item.id }) %>
            </td>
            <td>
                <%= Html.Encode(item.email) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:g}",item.creationDate)) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:g}", item.lastActivityDate)) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:g}",item.lastLoginDate)) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:g}", item.lastLockedOutDate)) %>
            </td>
            <td>
                <%= Html.Encode(item.isApproved) %>
            </td>
            <td>
                <%= Html.Encode(item.isLockedOut) %>
            </td>

        </tr>
    
    <% } %>

    </table>

</asp:Content>

