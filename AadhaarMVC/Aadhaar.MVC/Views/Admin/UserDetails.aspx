<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	UserDetails
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<%  Aadhaar.MVC.Models.UsersModel model = (Aadhaar.MVC.Models.UsersModel)ViewData["CurrenUser"];
    string[]AllRoles = (string[])ViewData["allRoles"];
     %>
    <h2>UserDetails</h2>
    <%--<script src='<%= Url.Content("~/Scripts/jquery.validate.min.js")%>' type="text/javascript"></script>
<script src='<%="Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js")%>' type="text/javascript"></script>
--%>
<% if (TempData["message"] != null) { %>
    <p style="color:Red"><%= Html.Encode(TempData["message"]) %></p>
  <% } %>
<%using (Html.BeginForm()) {
      Html.ValidationSummary(true);
    %>
    <fieldset>
        <legend>User's Information</legend>
        <table class="tblAllBorders">
                <tr><th><div class="editor-label">
            <%=Html.LabelFor(m => model.id)%>
        </div>
        </th><td><div class="editor-field">
            <%=Html.DisplayFor(m => model.id)%>
            <%=Html.HiddenFor(m => model.id)%>
        </div></td></tr>
                        <tr><th><div class="editor-label">
            <%=Html.LabelFor(m => model.name)%>
        </div>
        </th><td><div class="editor-field">
            <%=Html.DisplayFor(m => model.name)%>
            <%=Html.HiddenFor(m => model.name)%>
        </div></td></tr>
                <tr><th><div class="editor-label">
            <%=Html.LabelFor(m => model.email)%>
        </div>
        </th><td><div class="editor-field">
            <%=Html.DisplayFor(m => model.email)%>
            <%=Html.HiddenFor(m => model.email)%>
        </div></td></tr>


        <tr><th><div class="editor-label">
            <%=Html.LabelFor(m => model.description)%>
        </div>
        </th><td><div class="editor-field">
            <%=Html.EditorFor(m => model.description)%>
            <%=Html.ValidationMessageFor(m => model.description)%>
        </div></td></tr>

        <tr><th><div class="editor-label">
            <%=Html.LabelFor(m => model.loweredEmail)%>
        </div>
        </th><td><div class="editor-field">
            <%=Html.EditorFor(m => model.loweredEmail)%>
            <%=Html.ValidationMessageFor(m => model.loweredEmail)%>
        </div></td></tr>

        <tr><th><div class="editor-label">
            <%=Html.LabelFor(m => model.passwordQuestion)%>
        </div>
        </th><td><div class="editor-field">
            <%=Html.EditorFor(m => model.passwordQuestion)%>
            <%=Html.ValidationMessageFor(m => model.passwordQuestion)%>
        </div></td></tr>

        <tr><th><div class="editor-label">
            <%=Html.LabelFor(m => model.passwordAnswer)%>
        </div>
        </th><td><div class="editor-field">
            <%=Html.EditorFor(m => model.passwordAnswer)%>
            <%=Html.ValidationMessageFor(m => model.passwordAnswer)%>
        </div></td></tr>

        <tr><th><div class="editor-label">
            <%=Html.LabelFor(m => model.comments)%>
        </div>
        </th><td><div class="editor-field">
            <%=Html.EditorFor(m => model.comments)%>
            <%=Html.ValidationMessageFor(m => model.comments)%>
        </div></td></tr>

        <tr><th><div class="editor-label">
            <%=Html.LabelFor(m => model.isApproved)%>
        </div>
        </th><td><div class="editor-field">
            <%=Html.EditorFor(m => model.isApproved)%>
            <%=Html.ValidationMessageFor(m => model.isApproved)%>
        </div></td></tr>

        <tr><th><div class="editor-label">
            <%=Html.LabelFor(m => model.isLockedOut)%>
        </div>
        </th><td><div class="editor-field">
            <%=Html.EditorFor(m => model.isLockedOut)%>
            <%=Html.ValidationMessageFor(m => model.isLockedOut)%>
        </div></td></tr>

        <tr><th><div class="editor-label">
            <%=Html.LabelFor(m => model.lastActivityDate)%>
        </div>
        </th><td><div class="editor-field">
            <%=Html.DisplayFor(m => model.lastActivityDate)%>
            <%=Html.ValidationMessageFor(m => model.lastActivityDate)%>
        </div></td></tr>

        <tr><th><div class="editor-label">
            <%=Html.LabelFor(m => model.lastLoginDate)%>
        </div>
        </th><td><div class="editor-field">
            <%=Html.DisplayFor(m => model.lastLoginDate)%>
            <%=Html.ValidationMessageFor(m => model.lastLoginDate)%>
        </div></td></tr>

        <tr><th><div class="editor-label">
            <%=Html.LabelFor(m => model.lastLockedOutDate)%>
        </div>
        </th><td><div class="editor-field">
            <%=Html.DisplayFor(m => model.lastLockedOutDate)%>
            <%=Html.ValidationMessageFor(m => model.lastLockedOutDate)%>
        </div></td></tr>

        <tr><th><div class="editor-label">
            <%=Html.LabelFor(m => model.lastPasswordChangeDate)%>
        </div>
        </th><td><div class="editor-field">
            <%=Html.DisplayFor(m => model.lastPasswordChangeDate)%>
            <%=Html.ValidationMessageFor(m => model.lastPasswordChangeDate)%>
        </div></td></tr>
        <tr><td colspan="2"><input type="submit" value="Save" /></td></tr>
        </table>
    </fieldset>
<%}%>
<br />
 <% if (!string.IsNullOrEmpty(model.name))
           {%>
<br />
<table class="tblAllBorders">
        <tr><th colspan="4">Change User's Password</th></tr>
            <tr>
        <th>
            New Password
        </th>
        <th></th>
        </tr>
        <% using (Html.BeginForm("ChangeUserPass", "Admin",FormMethod.Post))
        {
            Html.ValidationSummary(true);%>
        <tr>
        <td><%=Html.TextBox("txtNewPass")%></td>
        <td><input type="submit" value="Change" /></td>
        </tr>
       <%} %>
        </table>

        <br /><br />
       
         <table class="tblAllBorders">
<tr><th>User Roles Names</th><th></th></tr>
<%for (int count1 = 0; count1 <= AllRoles.Length - 1; count1++)
  {
      if (System.Web.Security.Roles.IsUserInRole(model.name, AllRoles[count1]))
      {
          using (Html.BeginForm("RemoveUserRole", "Admin", FormMethod.Post))
          {
     
     %><tr><td><%= Html.Hidden("hdnUsrName", model.name)%><%= Html.Hidden("hdnUserKy", model.id)%><%= Html.Hidden("hdnRoleNm", AllRoles[count1])%><%= AllRoles[count1]%></td><td style="background-color:Red"><button name="remove" value="removeRole">Remove</button></td></tr>
    <%}
      }
      else
      {
          using (Html.BeginForm("AddUserRole", "Admin", FormMethod.Post))
          {%>
         <tr><td><%= Html.Hidden("hdnUsrName", model.name)%><%= Html.Hidden("hdnUserKy", model.id)%><%=Html.Hidden("hdnRoleNm", AllRoles[count1])%><%=AllRoles[count1]%></td><td style="background-color:Green"><button name="remove" value="removeRole">Add</button></td></tr>
         <%}
      }
  }
           }
%>
</table>
<div>
    <%= Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
