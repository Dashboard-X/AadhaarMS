<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Permissions.aspx.cs" MasterPageFile="~/Site.master" Inherits="Superadmin_Permissions" %>

<asp:Content ContentPlaceHolderID="c" runat="server">
<br />
<h2>
    Permissions:</h2>
    <ul>
    <li>You can Configure Exclusive Permissions to website locations here.</li>
    <li>Please create the "Folder/File.aspx" mapping first for the aspx file which you would like to reserve for a specific "Role" or "User" only.</li>
    </ul>
    <div>
<table class="tblAllBorders">
    <tr>
    <th colspan="6">
    Create Role Based Permission
    </th>
    </tr>
    <tr>
        <th>
            Role Name
        </th>
        <th>
            Folder
            -
            File Name
        </th>
        <th>
            PermissionType
        </th>
        <th></th>
        </tr>
        <tr>
        <td>

             <asp:DropDownList ID="ddnRoleNameR" runat="server">
            </asp:DropDownList>
        </td>
            <td><asp:DropDownList 
                    ID="ddnActionNameR" runat="server">
                </asp:DropDownList>
            </td>
    <td>
        <asp:DropDownList ID="ddnPermissionType" runat="server">
        <asp:ListItem Text="--Select--" Value="-1"></asp:ListItem>
        <asp:ListItem Text="ReadOnly" Value="0"></asp:ListItem>
        <asp:ListItem Text="Write" Value="1"></asp:ListItem>
        </asp:DropDownList>
            </td>
        <td>
        
            <asp:Button ID="btnCreateRolePerm" runat="server" Text="Add" 
                onclick="btnCreateRolePerm_Click" />
        </td>
    </tr>
    </table>
    <br />OR<br />
    <table class="tblAllBorders">
    <tr>
    <th colspan="6">
    Create User Permission
    </th>
    </tr>
    <tr>
        <th>
            User Name
        </th>
        <th>
            Folder
            -
            File Name
        </th>
        <th>
            PermissionType
        </th>
        <th>
        
        </th>
    </tr>
    <tr>
    <td><asp:TextBox 
            ID="txtUserId" runat="server"></asp:TextBox>
        </td>
    <td><asp:DropDownList 
            ID="ddnActionIdU" runat="server">
        </asp:DropDownList>
        </td>
    <td><asp:DropDownList 
            ID="ddnPermTypeU" runat="server">
                    <asp:ListItem Text="--Select--" Value="-1"></asp:ListItem>
        <asp:ListItem Text="ReadOnly" Value="0"></asp:ListItem>
        <asp:ListItem Text="Write" Value="1"></asp:ListItem>
        </asp:DropDownList>
        </td>
    <td>
    
        <asp:Button ID="btnCreateUsrPerm" runat="server" Text="Add" 
            onclick="btnCreateUsrPerm_Click" />
    </td>
    </tr>
    </table>
    <br /><br />
    <table class="tblAllBorders">
    <tr><th colspan="7">
    <h3>Existing Permissions</h3></th></tr>
    <tr>
    <th>
            Id
        </th>
        <th>
            Role Name
        </th>
        <th>
            User Name
        </th>
        <th>
            Folder
        </th>
        <th>
            File
        </th>
        <th>
            PermissionType
        </th>
        <th></th>
    </tr>
    <asp:Repeater ID="rptrPermList" runat="server" 
            onitemcommand="rptrPermList_ItemCommand">
        <ItemTemplate>
                 <tr>
                 <td><%# Eval("Id") %></td>
                 <td><%# Eval("Roles") %></td>
                 <td><%# Eval("Users") %></td>
         <td><%# Eval("Controller") %></td>
         <td><%# Eval("Action")%></td>
         <td><%# Eval("PermissionType")%></td>
         <td><asp:LinkButton CssClass="deleteitem" OnClientClick="return confirm('Are you sure to delete this Permission?');"
                            ID="LinkButton2" runat="server" CommandName="deletePerm" CommandArgument='<%# Eval("Id") %>' >Delete</asp:LinkButton></td>
        </tr>
        </ItemTemplate>
        </asp:Repeater>
        </table>
    <br /><br />
     <table class="tblAllBorders" style="background-color:#ffffff">
<tr><th colspan="4">Existing Locations</th></tr>
    <tr>
    <th>
            Id
        </th>
        <th>
            Folder Name
        </th>
        <th>
            File Name
        </th>
        <th></th>
        </tr>
        <asp:Repeater ID="rptrActionList" runat="server" 
             onitemcommand="rptrActionList_ItemCommand">
        <ItemTemplate>
                 <tr>
         <td><%# Eval("Id") %></td>
         <td><%# Eval("ControllerName")%></td>
         <td><%# Eval("ActionName")%></td>
         <td><asp:LinkButton CssClass="deleteitem" OnClientClick="return confirm('Are you sure to delete this Location?');"
                            ID="LinkButton2" runat="server" CommandName="deleteAction" CommandArgument='<%# Eval("Id") %>' >Delete</asp:LinkButton></td>
        </tr>
        </ItemTemplate>
        </asp:Repeater>
 
        </table>
<br /><br />
        <table class="tblAllBorders">
        <tr><th colspan="4">Add New Location for Exclusive Access:</th></tr>
            <tr>
        <th>
            Folder Name
        </th>
        <th>
            File Name
        </th>
        <th></th>
        </tr>
        <tr>
        <td><asp:TextBox ID="txtAddActionController" runat="server"></asp:TextBox>
            </td>
        <td><asp:TextBox ID="txtAddActionAction" runat="server"></asp:TextBox>
            </td>
        <td>
            <asp:Button ID="btnCreateAction" runat="server" Text="Create" 
                onclick="btnCreateAction_Click" />
            </td>
        </tr>
        </table>

    </div>
    
</asp:Content>