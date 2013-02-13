<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c" Runat="Server">

    A custom create user wizard.
	<asp:CreateUserWizard ID="CreateUserExWizard1" runat="server" DisableCreatedUser="false" 
		LoginCreatedUser="false" ContinueDestinationPageUrl="~/Default.aspx">
		<WizardSteps>
			<asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
				<ContentTemplate>
					<table class="form" border="0" cellpadding="0">
						<tbody>
							<tr>
								<td align="left" colspan="2">
									<p>Sign Up for a New User Account</p>
								</td>
							</tr>
							<tr>
								<td align="left" colspan="2">
									<p><strong>The following fields are needed for the membership provider</strong></p>
								</td>
							</tr>
							<tr>
								<td class="field">
									<span class="red">*</span><asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="UserName" runat="server"></asp:TextBox>
									<asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ValidationGroup="CreateUserExWizard1" ControlToValidate="UserName" ErrorMessage="User Name is required." Display="Dynamic"></asp:RequiredFieldValidator>
								</td>
							</tr>
							<tr>
								<td class="field">
									<span class="red">*</span><asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="Password" runat="server" TextMode="Password">
									</asp:TextBox>
									<asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ValidationGroup="CreateUserExWizard1" ControlToValidate="Password" ErrorMessage="Password is required." Display="Dynamic"></asp:RequiredFieldValidator>
								</td>
							</tr>
							<tr>
								<td class="field">
									<span class="red">*</span><asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirm Password:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password">
									</asp:TextBox>
									<asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ValidationGroup="CreateUserExWizard1" ControlToValidate="ConfirmPassword" ErrorMessage="Confirm Password is required." Display="Dynamic"></asp:RequiredFieldValidator>
								</td>
							</tr>
							<tr>
								<td class="field">
									<span class="red">*</span><asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">E-mail:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="Email" runat="server"></asp:TextBox>
									<asp:RequiredFieldValidator ID="EmailRequired" runat="server" ValidationGroup="CreateUserExWizard1" ControlToValidate="Email" ErrorMessage="E-mail is required." Display="Dynamic"></asp:RequiredFieldValidator>
									<asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server" ValidationGroup="CreateUserExWizard1" ControlToValidate="Email" ErrorMessage="Invalid Email." Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td class="field">
									<span class="red">*</span><asp:Label ID="QuestionLabel" runat="server" AssociatedControlID="Question">Password Question:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="Question" runat="server"></asp:TextBox>
									<asp:RequiredFieldValidator ID="QuestionRequired" runat="server" ValidationGroup="CreateUserExWizard1" ControlToValidate="Question" ErrorMessage="Password Question is required." Display="Dynamic"></asp:RequiredFieldValidator>
								</td>
							</tr>	
							<tr>
								<td class="field">
									<span class="red">*</span><asp:Label ID="PasswordAnswerLabel" runat="server" AssociatedControlID="Answer">Password Answer:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="Answer" runat="server"></asp:TextBox>
									<asp:RequiredFieldValidator ID="AnswerRequired" runat="server" ValidationGroup="CreateUserExWizard1" ControlToValidate="Answer" ErrorMessage="Password Answer is required." Display="Dynamic"></asp:RequiredFieldValidator>
								</td>
							</tr>
							<%--<tr>
								<td align="left" colspan="2">
									<p><strong>The following fields are extra information not present in the MembershipUserInfo class</strong></p>
								</td>
							</tr>
							<tr>
								<td class="field">
									<span class="red">*</span><asp:Label ID="NameLabel" runat="server" AssociatedControlID="Name">Name:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="Name" runat="server"></asp:TextBox>
									<asp:RequiredFieldValidator ID="NameRequired" runat="server" ValidationGroup="CreateUserExWizard1" ControlToValidate="Name" ErrorMessage="Name is required." Display="Dynamic"></asp:RequiredFieldValidator>
								</td>
							</tr>
							<tr>
								<td class="field">
									<span class="red">*</span><asp:Label ID="SurnameLabel" runat="server" AssociatedControlID="Surname">Surname:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="Surname" runat="server"></asp:TextBox>
									<asp:RequiredFieldValidator ID="SurnameRequired" runat="server" ValidationGroup="CreateUserExWizard1" ControlToValidate="Surname" ErrorMessage="Surname is required." Display="Dynamic"></asp:RequiredFieldValidator>
								</td>
							</tr>
							<tr>
								<td class="field">
									<span class="red">*</span><asp:Label ID="CompanyLabel" runat="server" AssociatedControlID="Company">Company:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="Company" runat="server"></asp:TextBox>
									<asp:RequiredFieldValidator ID="CompanyRequired" runat="server" ValidationGroup="CreateUserExWizard1" ControlToValidate="Company" ErrorMessage="Company is required." Display="Dynamic"></asp:RequiredFieldValidator>
								</td>
							</tr>
							<tr>
								<td class="field">
									<asp:Label ID="PhoneLabel" runat="server" AssociatedControlID="Phone">Phone:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="Phone" runat="server"></asp:TextBox>
								</td>
							</tr>
                            <tr>
								<td class="field">
									<asp:Label ID="TimeZone" runat="server" AssociatedControlID="TimeZone">Time Zone:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:DropDownList runat="server" ID="ddnTimeZone"></asp:DropDownList>
								</td>
							</tr>
							<tr>
								<td class="field">
									<asp:Label ID="PostalCodeLabel" runat="server" AssociatedControlID="PostalCode">Postal Code:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="PostalCode" runat="server"></asp:TextBox>
								</td>
							</tr>--%>
							<tr>
								<td align="left" colspan="2">
									<span class="red">*</span>Denotes required field
								</td>
							</tr>
							<tr>
								<td class="field" colspan="2">
									<asp:CompareValidator ID="PasswordCompare" runat="server" ValidationGroup="CreateUserExWizard1" ControlToValidate="ConfirmPassword" ErrorMessage="The Password and Confirmation Password must match." Display="Dynamic" ControlToCompare="Password"></asp:CompareValidator>
								</td>
							</tr>
							<tr>
								<td>
								</td>
								<td style="color: red" align="left">
									<asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
								</td>
							</tr>
						</tbody>
					</table>
				</ContentTemplate>
				<CustomNavigationTemplate>
					<table class="form" border="0" cellpadding="0">
						<tbody>
							<tr>
								<td class="field">
								</td>
								<td style="text-align: left; width: 640px">
									<asp:Button ID="StepNextButton" runat="server" CssClass="button" ValidationGroup="CreateUserExWizard1" CommandName="MoveNext" Text="Create User"></asp:Button>
								</td>
							</tr>
						</tbody>
					</table>
				</CustomNavigationTemplate>
			</asp:CreateUserWizardStep>
			<asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
				<ContentTemplate>
					<table border="0">
						<tbody>
							<tr>
								<td align="center" colspan="2">
									<p>
										Your account has been successfully created.
									</p>
								</td>
							</tr>
							<tr>
								<td align="center" colspan="2">
									<asp:Button ID="ContinueButton" runat="server" CssClass="button" CausesValidation="False" CommandName="Continue" Text="Continue" ValidationGroup="CreateUserExWizard1"></asp:Button>
								</td>
							</tr>
						</tbody>
					</table>
				</ContentTemplate>
			</asp:CompleteWizardStep>
		</WizardSteps>
		<NavigationStyle HorizontalAlign="Left" />
	</asp:CreateUserWizard>
</asp:Content>

