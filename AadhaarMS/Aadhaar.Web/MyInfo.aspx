<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MyInfo.aspx.cs" Inherits="MyInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c" Runat="Server">
<table class="tblAllBorders" border="0" cellpadding="0">
							<tr>
								<td align="left" colspan="2">
									<p><strong>Information about you which you would like your friends to know about 
                                        you.</strong></p>
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
									<asp:DropDownList runat="server" ID="ddnTimeZone">
    <asp:ListItem Value="AF">Afghanistan</asp:ListItem>
    <asp:ListItem Value="AL">Albania</asp:ListItem>
    <asp:ListItem Value="DZ">Algeria</asp:ListItem>
    <asp:ListItem Value="AS">American Samoa</asp:ListItem>
    <asp:ListItem Value="AD">Andorra</asp:ListItem>
    <asp:ListItem Value="AO">Angola</asp:ListItem>
    <asp:ListItem Value="AI">Anguilla</asp:ListItem>
    <asp:ListItem Value="AQ">Antarctica</asp:ListItem>
    <asp:ListItem Value="AG">Antigua And Barbuda</asp:ListItem>
    <asp:ListItem Value="AR">Argentina</asp:ListItem>
    <asp:ListItem Value="AM">Armenia</asp:ListItem>
    <asp:ListItem Value="AW">Aruba</asp:ListItem>
    <asp:ListItem Value="AU">Australia</asp:ListItem>
    <asp:ListItem Value="AT">Austria</asp:ListItem>
    <asp:ListItem Value="AZ">Azerbaijan</asp:ListItem>
    <asp:ListItem Value="BS">Bahamas</asp:ListItem>
    <asp:ListItem Value="BH">Bahrain</asp:ListItem>
    <asp:ListItem Value="BD">Bangladesh</asp:ListItem>
    <asp:ListItem Value="BB">Barbados</asp:ListItem>
    <asp:ListItem Value="BY">Belarus</asp:ListItem>
    <asp:ListItem Value="BE">Belgium</asp:ListItem>
    <asp:ListItem Value="BZ">Belize</asp:ListItem>
    <asp:ListItem Value="BJ">Benin</asp:ListItem>
    <asp:ListItem Value="BM">Bermuda</asp:ListItem>
    <asp:ListItem Value="BT">Bhutan</asp:ListItem>
    <asp:ListItem Value="BO">Bolivia</asp:ListItem>
    <asp:ListItem Value="BA">Bosnia And Herzegowina</asp:ListItem>
    <asp:ListItem Value="BW">Botswana</asp:ListItem>
    <asp:ListItem Value="BV">Bouvet Island</asp:ListItem>
    <asp:ListItem Value="BR">Brazil</asp:ListItem>
    <asp:ListItem Value="IO">British Indian Ocean Territory</asp:ListItem>
    <asp:ListItem Value="BN">Brunei Darussalam</asp:ListItem>
    <asp:ListItem Value="BG">Bulgaria</asp:ListItem>
    <asp:ListItem Value="BF">Burkina Faso</asp:ListItem>
    <asp:ListItem Value="BI">Burundi</asp:ListItem>
    <asp:ListItem Value="KH">Cambodia</asp:ListItem>
    <asp:ListItem Value="CM">Cameroon</asp:ListItem>
    <asp:ListItem Value="CA">Canada</asp:ListItem>
    <asp:ListItem Value="CV">Cape Verde</asp:ListItem>
    <asp:ListItem Value="KY">Cayman Islands</asp:ListItem>
    <asp:ListItem Value="CF">Central African Republic</asp:ListItem>
    <asp:ListItem Value="TD">Chad</asp:ListItem>
    <asp:ListItem Value="CL">Chile</asp:ListItem>
    <asp:ListItem Value="CN">China</asp:ListItem>
    <asp:ListItem Value="CX">Christmas Island</asp:ListItem>
    <asp:ListItem Value="CC">Cocos (Keeling) Islands</asp:ListItem>
    <asp:ListItem Value="CO">Colombia</asp:ListItem>
    <asp:ListItem Value="KM">Comoros</asp:ListItem>
    <asp:ListItem Value="CG">Congo</asp:ListItem>
    <asp:ListItem Value="CK">Cook Islands</asp:ListItem>
    <asp:ListItem Value="CR">Costa Rica</asp:ListItem>
    <asp:ListItem Value="CI">Cote D'Ivoire</asp:ListItem>
    <asp:ListItem Value="HR">Croatia (Local Name: Hrvatska)</asp:ListItem>
    <asp:ListItem Value="CU">Cuba</asp:ListItem>
    <asp:ListItem Value="CY">Cyprus</asp:ListItem>
    <asp:ListItem Value="CZ">Czech Republic</asp:ListItem>
    <asp:ListItem Value="DK">Denmark</asp:ListItem>
    <asp:ListItem Value="DJ">Djibouti</asp:ListItem>
    <asp:ListItem Value="DM">Dominica</asp:ListItem>
    <asp:ListItem Value="DO">Dominican Republic</asp:ListItem>
    <asp:ListItem Value="TP">East Timor</asp:ListItem>
    <asp:ListItem Value="EC">Ecuador</asp:ListItem>
    <asp:ListItem Value="EG">Egypt</asp:ListItem>
    <asp:ListItem Value="SV">El Salvador</asp:ListItem>
    <asp:ListItem Value="GQ">Equatorial Guinea</asp:ListItem>
    <asp:ListItem Value="ER">Eritrea</asp:ListItem>
    <asp:ListItem Value="EE">Estonia</asp:ListItem>
    <asp:ListItem Value="ET">Ethiopia</asp:ListItem>
    <asp:ListItem Value="FK">Falkland Islands (Malvinas)</asp:ListItem>
    <asp:ListItem Value="FO">Faroe Islands</asp:ListItem>
    <asp:ListItem Value="FJ">Fiji</asp:ListItem>
    <asp:ListItem Value="FI">Finland</asp:ListItem>
    <asp:ListItem Value="FR">France</asp:ListItem>
    <asp:ListItem Value="GF">French Guiana</asp:ListItem>
    <asp:ListItem Value="PF">French Polynesia</asp:ListItem>
    <asp:ListItem Value="TF">French Southern Territories</asp:ListItem>
    <asp:ListItem Value="GA">Gabon</asp:ListItem>
    <asp:ListItem Value="GM">Gambia</asp:ListItem>
    <asp:ListItem Value="GE">Georgia</asp:ListItem>
    <asp:ListItem Value="DE">Germany</asp:ListItem>
    <asp:ListItem Value="GH">Ghana</asp:ListItem>
    <asp:ListItem Value="GI">Gibraltar</asp:ListItem>
    <asp:ListItem Value="GR">Greece</asp:ListItem>
    <asp:ListItem Value="GL">Greenland</asp:ListItem>
    <asp:ListItem Value="GD">Grenada</asp:ListItem>
    <asp:ListItem Value="GP">Guadeloupe</asp:ListItem>
    <asp:ListItem Value="GU">Guam</asp:ListItem>
    <asp:ListItem Value="GT">Guatemala</asp:ListItem>
    <asp:ListItem Value="GN">Guinea</asp:ListItem>
    <asp:ListItem Value="GW">Guinea-Bissau</asp:ListItem>
    <asp:ListItem Value="GY">Guyana</asp:ListItem>
    <asp:ListItem Value="HT">Haiti</asp:ListItem>
    <asp:ListItem Value="HM">Heard And Mc Donald Islands</asp:ListItem>
    <asp:ListItem Value="VA">Holy See (Vatican City State)</asp:ListItem>
    <asp:ListItem Value="HN">Honduras</asp:ListItem>
    <asp:ListItem Value="HK">Hong Kong</asp:ListItem>
    <asp:ListItem Value="HU">Hungary</asp:ListItem>
    <asp:ListItem Value="IS">Icel And</asp:ListItem>
    <asp:ListItem Value="IN">India</asp:ListItem>
    <asp:ListItem Value="ID">Indonesia</asp:ListItem>
    <asp:ListItem Value="IR">Iran (Islamic Republic Of)</asp:ListItem>
    <asp:ListItem Value="IQ">Iraq</asp:ListItem>
    <asp:ListItem Value="IE">Ireland</asp:ListItem>
    <asp:ListItem Value="IL">Israel</asp:ListItem>
    <asp:ListItem Value="IT">Italy</asp:ListItem>
    <asp:ListItem Value="JM">Jamaica</asp:ListItem>
    <asp:ListItem Value="JP">Japan</asp:ListItem>
    <asp:ListItem Value="JO">Jordan</asp:ListItem>
    <asp:ListItem Value="KZ">Kazakhstan</asp:ListItem>
    <asp:ListItem Value="KE">Kenya</asp:ListItem>
    <asp:ListItem Value="KI">Kiribati</asp:ListItem>
    <asp:ListItem Value="KP">Korea, Dem People'S Republic</asp:ListItem>
    <asp:ListItem Value="KR">Korea, Republic Of</asp:ListItem>
    <asp:ListItem Value="KW">Kuwait</asp:ListItem>
    <asp:ListItem Value="KG">Kyrgyzstan</asp:ListItem>
    <asp:ListItem Value="LA">Lao People'S Dem Republic</asp:ListItem>
    <asp:ListItem Value="LV">Latvia</asp:ListItem>
    <asp:ListItem Value="LB">Lebanon</asp:ListItem>
    <asp:ListItem Value="LS">Lesotho</asp:ListItem>
    <asp:ListItem Value="LR">Liberia</asp:ListItem>
    <asp:ListItem Value="LY">Libyan Arab Jamahiriya</asp:ListItem>
    <asp:ListItem Value="LI">Liechtenstein</asp:ListItem>
    <asp:ListItem Value="LT">Lithuania</asp:ListItem>
    <asp:ListItem Value="LU">Luxembourg</asp:ListItem>
    <asp:ListItem Value="MO">Macau</asp:ListItem>
    <asp:ListItem Value="MK">Macedonia</asp:ListItem>
    <asp:ListItem Value="MG">Madagascar</asp:ListItem>
    <asp:ListItem Value="MW">Malawi</asp:ListItem>
    <asp:ListItem Value="MY">Malaysia</asp:ListItem>
    <asp:ListItem Value="MV">Maldives</asp:ListItem>
    <asp:ListItem Value="ML">Mali</asp:ListItem>
    <asp:ListItem Value="MT">Malta</asp:ListItem>
    <asp:ListItem Value="MH">Marshall Islands</asp:ListItem>
    <asp:ListItem Value="MQ">Martinique</asp:ListItem>
    <asp:ListItem Value="MR">Mauritania</asp:ListItem>
    <asp:ListItem Value="MU">Mauritius</asp:ListItem>
    <asp:ListItem Value="YT">Mayotte</asp:ListItem>
    <asp:ListItem Value="MX">Mexico</asp:ListItem>
    <asp:ListItem Value="FM">Micronesia, Federated States</asp:ListItem>
    <asp:ListItem Value="MD">Moldova, Republic Of</asp:ListItem>
    <asp:ListItem Value="MC">Monaco</asp:ListItem>
    <asp:ListItem Value="MN">Mongolia</asp:ListItem>
    <asp:ListItem Value="MS">Montserrat</asp:ListItem>
    <asp:ListItem Value="MA">Morocco</asp:ListItem>
    <asp:ListItem Value="MZ">Mozambique</asp:ListItem>
    <asp:ListItem Value="MM">Myanmar</asp:ListItem>
    <asp:ListItem Value="NA">Namibia</asp:ListItem>
    <asp:ListItem Value="NR">Nauru</asp:ListItem>
    <asp:ListItem Value="NP">Nepal</asp:ListItem>
    <asp:ListItem Value="NL">Netherlands</asp:ListItem>
    <asp:ListItem Value="AN">Netherlands Ant Illes</asp:ListItem>
    <asp:ListItem Value="NC">New Caledonia</asp:ListItem>
    <asp:ListItem Value="NZ" Selected="True">New Zealand</asp:ListItem>
    <asp:ListItem Value="NI">Nicaragua</asp:ListItem>
    <asp:ListItem Value="NE">Niger</asp:ListItem>
    <asp:ListItem Value="NG">Nigeria</asp:ListItem>
    <asp:ListItem Value="NU">Niue</asp:ListItem>
    <asp:ListItem Value="NF">Norfolk Island</asp:ListItem>
    <asp:ListItem Value="MP">Northern Mariana Islands</asp:ListItem>
    <asp:ListItem Value="NO">Norway</asp:ListItem>
    <asp:ListItem Value="OM">Oman</asp:ListItem>
    <asp:ListItem Value="PK">Pakistan</asp:ListItem>
    <asp:ListItem Value="PW">Palau</asp:ListItem>
    <asp:ListItem Value="PA">Panama</asp:ListItem>
    <asp:ListItem Value="PG">Papua New Guinea</asp:ListItem>
    <asp:ListItem Value="PY">Paraguay</asp:ListItem>
    <asp:ListItem Value="PE">Peru</asp:ListItem>
    <asp:ListItem Value="PH">Philippines</asp:ListItem>
    <asp:ListItem Value="PN">Pitcairn</asp:ListItem>
    <asp:ListItem Value="PL">Poland</asp:ListItem>
    <asp:ListItem Value="PT">Portugal</asp:ListItem>
    <asp:ListItem Value="PR">Puerto Rico</asp:ListItem>
    <asp:ListItem Value="QA">Qatar</asp:ListItem>
    <asp:ListItem Value="RE">Reunion</asp:ListItem>
    <asp:ListItem Value="RO">Romania</asp:ListItem>
    <asp:ListItem Value="RU">Russian Federation</asp:ListItem>
    <asp:ListItem Value="RW">Rwanda</asp:ListItem>
    <asp:ListItem Value="KN">Saint K Itts And Nevis</asp:ListItem>
    <asp:ListItem Value="LC">Saint Lucia</asp:ListItem>
    <asp:ListItem Value="VC">Saint Vincent, The Grenadines</asp:ListItem>
    <asp:ListItem Value="WS">Samoa</asp:ListItem>
    <asp:ListItem Value="SM">San Marino</asp:ListItem>
    <asp:ListItem Value="ST">Sao Tome And Principe</asp:ListItem>
    <asp:ListItem Value="SA">Saudi Arabia</asp:ListItem>
    <asp:ListItem Value="SN">Senegal</asp:ListItem>
    <asp:ListItem Value="SC">Seychelles</asp:ListItem>
    <asp:ListItem Value="SL">Sierra Leone</asp:ListItem>
    <asp:ListItem Value="SG">Singapore</asp:ListItem>
    <asp:ListItem Value="SK">Slovakia (Slovak Republic)</asp:ListItem>
    <asp:ListItem Value="SI">Slovenia</asp:ListItem>
    <asp:ListItem Value="SB">Solomon Islands</asp:ListItem>
    <asp:ListItem Value="SO">Somalia</asp:ListItem>
    <asp:ListItem Value="ZA">South Africa</asp:ListItem>
    <asp:ListItem Value="GS">South Georgia , S Sandwich Is.</asp:ListItem>
    <asp:ListItem Value="ES">Spain</asp:ListItem>
    <asp:ListItem Value="LK">Sri Lanka</asp:ListItem>
    <asp:ListItem Value="SH">St. Helena</asp:ListItem>
    <asp:ListItem Value="PM">St. Pierre And Miquelon</asp:ListItem>
    <asp:ListItem Value="SD">Sudan</asp:ListItem>
    <asp:ListItem Value="SR">Suriname</asp:ListItem>
    <asp:ListItem Value="SJ">Svalbard, Jan Mayen Islands</asp:ListItem>
    <asp:ListItem Value="SZ">Sw Aziland</asp:ListItem>
    <asp:ListItem Value="SE">Sweden</asp:ListItem>
    <asp:ListItem Value="CH">Switzerland</asp:ListItem>
    <asp:ListItem Value="SY">Syrian Arab Republic</asp:ListItem>
    <asp:ListItem Value="TW">Taiwan</asp:ListItem>
    <asp:ListItem Value="TJ">Tajikistan</asp:ListItem>
    <asp:ListItem Value="TZ">Tanzania, United Republic Of</asp:ListItem>
    <asp:ListItem Value="TH">Thailand</asp:ListItem>
    <asp:ListItem Value="TG">Togo</asp:ListItem>
    <asp:ListItem Value="TK">Tokelau</asp:ListItem>
    <asp:ListItem Value="TO">Tonga</asp:ListItem>
    <asp:ListItem Value="TT">Trinidad And Tobago</asp:ListItem>
    <asp:ListItem Value="TN">Tunisia</asp:ListItem>
    <asp:ListItem Value="TR">Turkey</asp:ListItem>
    <asp:ListItem Value="TM">Turkmenistan</asp:ListItem>
    <asp:ListItem Value="TC">Turks And Caicos Islands</asp:ListItem>
    <asp:ListItem Value="TV">Tuvalu</asp:ListItem>
    <asp:ListItem Value="UG">Uganda</asp:ListItem>
    <asp:ListItem Value="UA">Ukraine</asp:ListItem>
    <asp:ListItem Value="AE">United Arab Emirates</asp:ListItem>
    <asp:ListItem Value="GB">United Kingdom</asp:ListItem>
    <asp:ListItem Value="US">United States</asp:ListItem>
    <asp:ListItem Value="UM">United States Minor Is.</asp:ListItem>
    <asp:ListItem Value="UY">Uruguay</asp:ListItem>
    <asp:ListItem Value="UZ">Uzbekistan</asp:ListItem>
    <asp:ListItem Value="VU">Vanuatu</asp:ListItem>
    <asp:ListItem Value="VE">Venezuela</asp:ListItem>
    <asp:ListItem Value="VN">Viet Nam</asp:ListItem>
    <asp:ListItem Value="VG">Virgin Islands (British)</asp:ListItem>
    <asp:ListItem Value="VI">Virgin Islands (U.S.)</asp:ListItem>
    <asp:ListItem Value="WF">Wallis And Futuna Islands</asp:ListItem>
    <asp:ListItem Value="EH">Western Sahara</asp:ListItem>
    <asp:ListItem Value="YE">Yemen</asp:ListItem>
    <asp:ListItem Value="YU">Yugoslavia</asp:ListItem>
    <asp:ListItem Value="ZR">Zaire</asp:ListItem>
    <asp:ListItem Value="ZM">Zambia</asp:ListItem>
    <asp:ListItem Value="ZW">Zimbabwe</asp:ListItem>
</asp:DropDownList>
								</td>
							</tr>
							<tr>
								<td class="field">
									<asp:Label ID="PostalCodeLabel" runat="server" AssociatedControlID="PostalCode">Postal Code:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="PostalCode" runat="server"></asp:TextBox>
								</td>
							</tr>
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
						
							<tr>
								<td>
								    &nbsp;</td>
								<td style="color: red" align="left">
									<asp:Button ID="btnUpdateProfile" runat="server" 
                                        onclick="btnUpdateProfile_Click" Text="Update" />
								</td>
							</tr>
						
					</table>
<br />
<table class="tblAllBorders" border="0" cellpadding="0">
						
							<tr>
								<td align="left" colspan="2">
									<p>Update your Account Information:</p>
								</td>
							</tr>
							<tr>
								<td align="left" colspan="2">
									<p><strong>Please update your profile information.</strong></p>
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
									<span class="red">*</span><asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">E-mail:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="Email" runat="server"></asp:TextBox>
									<asp:RequiredFieldValidator ID="EmailRequired" runat="server" ValidationGroup="CreateUserExWizard1" ControlToValidate="Email" ErrorMessage="E-mail is required." Display="Dynamic"></asp:RequiredFieldValidator>
									<asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server" ValidationGroup="CreateUserExWizard1" ControlToValidate="Email" ErrorMessage="Invalid Email." Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
								</td>
							</tr>
                            </table><br />
                            <table class="tblAllBorders" border="0" cellpadding="0">
							<tr>
								<td class="field">
									<span class="red">*</span><asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="Password" runat="server" TextMode="Password">
									</asp:TextBox>
									<asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ValidationGroup="chngPass" ControlToValidate="Password" ErrorMessage="Password is required." Display="Dynamic"></asp:RequiredFieldValidator>
								</td>
							</tr>
							<tr>
								<td class="field">
									<span class="red">*</span><asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirm Password:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password">
									</asp:TextBox>
									<asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ValidationGroup="chngPass" ControlToValidate="ConfirmPassword" ErrorMessage="Confirm Password is required." Display="Dynamic"></asp:RequiredFieldValidator>
								</td>
							</tr>
							<tr>
								<td class="field">
									*Old Password</td>
								<td class="formTextBox">
									<asp:TextBox ID="txtOldPass" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                        ControlToValidate="txtOldPass" 
                                        ErrorMessage="Old Password is Required to change the current password." 
                                        ValidationGroup="chngPass"></asp:RequiredFieldValidator>
								</td>
							</tr>
							<tr>
								<td class="field">
									Change Password:</td>
								<td class="formTextBox">
									<asp:Button ID="btnChangePass" runat="server" Text="Update" 
                                        onclick="btnChangePass_Click" />
								</td>
							</tr>
							</table><br />
                            <table class="tblAllBorders" border="0" cellpadding="0">
							<tr>
								<td class="field">
									<span class="red">*</span><asp:Label ID="QuestionLabel" runat="server" AssociatedControlID="Question">Password Question:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="Question" runat="server"></asp:TextBox>
									<asp:RequiredFieldValidator ID="QuestionRequired" runat="server" 
                                        ValidationGroup="passwrdQnA" ControlToValidate="Question" 
                                        ErrorMessage="Password Question is required." Display="Dynamic"></asp:RequiredFieldValidator>
								</td>
							</tr>	
							<tr>
								<td class="field">
									<span class="red">*</span><asp:Label ID="PasswordAnswerLabel" runat="server" AssociatedControlID="Answer">Password Answer:</asp:Label>
								</td>
								<td class="formTextBox">
									<asp:TextBox ID="Answer" runat="server" TextMode="Password"></asp:TextBox>
									<asp:RequiredFieldValidator ID="AnswerRequired" runat="server" 
                                        ValidationGroup="passwrdQnA" ControlToValidate="Answer" 
                                        ErrorMessage="Password Answer is required." Display="Dynamic"></asp:RequiredFieldValidator>
								</td>
							</tr>
							<tr>
								<td class="field">
									*Old Password:</td>
								<td class="formTextBox">
									<asp:TextBox ID="txtOldPassQnA" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                        ControlToValidate="txtOldPassQnA" 
                                        ErrorMessage="Old Password is Required to change the Security Question and Answer." 
                                        ValidationGroup="passwrdQnA"></asp:RequiredFieldValidator>
								</td>
							</tr>
							<tr>
								<td class="field">
									Change Password Question &amp; Answer: </td>
								<td class="formTextBox">
									<asp:Button ID="btnChangeQnA" runat="server" Text="Update" 
                                        onclick="btnChangeQnA_Click" />
								</td>
							</tr>
                            </table><br />
      
</asp:Content>

