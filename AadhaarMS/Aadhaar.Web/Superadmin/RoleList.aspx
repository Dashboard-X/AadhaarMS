<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="RoleList.aspx.cs" Inherits="RoleList" Title="Roles List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c" runat="Server">
    <h1>
        Roles list</h1>
    <div>
        <table class="tblAllBorders">
            <tr>
                <td>
                    <label for="txtName">Role:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" MaxLength="20"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validatorName" runat="server" ControlToValidate="txtName"
                        Display="Static" ErrorMessage="Name field is required" ValidationGroup="RoleAdd"></asp:RequiredFieldValidator>
                </td>
                <td><asp:Button ID="btAdd" runat="server" Text="Add" OnClick="btAdd_Click" ValidationGroup="RoleAdd" /></td>
            </tr>
        </table>
        <p>
            
        </p>


        <asp:Repeater ID="listRepeater" runat="server" OnItemCommand="listRepeater_ItemCommand">
            <HeaderTemplate>
                <table class="tblAllBorders">
                    <thead>
                        <tr>
                            <th>
                                Name</th>
                            <th>
                            </th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <%# Container.DataItem %>
                    </td>
                    <td>
                        <asp:LinkButton CssClass="deleteitem" OnClientClick="return confirm('Are you sure to delete role?');"
                            ID="LinkButton2" runat="server" CommandName="delete" CommandArgument='<%# Container.DataItem %>' >Delete</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody> </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
