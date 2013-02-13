<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="UserList.aspx.cs" Inherits="UserList" Title="Users List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c" runat="Server">
    <h1>
        Users list</h1>
    <div>
        <p>
            <a class="newitem" id="linkNewItem" runat="server" >New login</a>
        </p>
        <asp:Repeater ID="listRepeater" runat="server" OnItemCommand="listRepeater_ItemCommand">
            <HeaderTemplate>
                <table class="tblAllBorders">
                    <thead>
                        <tr>
                            <th>
                                Name</th>
                            <th>
                                EMail</th>
                            <th>Creation Date</th>
                            <th>Last Activity Date</th>
                            <th>
                                Status</th>
                            <th>
                            </th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <%# Eval("UserName") %>
                    </td>
                    <td>
                        <%# Eval("Email") %>
                    </td>
                    <td>
                        <%# Eval("CreationDate")%>
                    </td>
                    <td>
                        <%# Eval("LastActivityDate")%>
                    </td>
                    <td>
                        <%# Server.HtmlEncode(GetUserStatus((MembershipUser)Container.DataItem)) %>
                    </td>
                    <td>
                        <asp:LinkButton CssClass="edititem" ID="LinkButton1" runat="server"
                            CommandName="edit" CommandArgument='<%# Eval("UserName") %>' >Edit</asp:LinkButton>
                        
                        <asp:LinkButton CssClass="deleteitem" OnClientClick="return confirm('Are you sure to delete the user?');"
                            ID="LinkButton2" runat="server" CommandName="delete" CommandArgument='<%# Eval("UserName") %>' >Delete</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody> </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
