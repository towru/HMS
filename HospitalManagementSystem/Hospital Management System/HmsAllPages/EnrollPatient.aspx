<%@ Page Title="" Language="C#" MasterPageFile="~/HmsMasterPage.Master" AutoEventWireup="true" CodeBehind="EnrollPatient.aspx.cs" Inherits="Hospital_Management_System.HmsAllPages.EnrollPatient" %>

<%@ Register Src="~/calenderControl.ascx" TagPrefix="uc1" TagName="calenderControl" %>
<asp:Content ID="menu" runat="server" ContentPlaceHolderID="menuContent">
    <br />
    <br />

    <ul class="list-group">
        <li class="list-group-item active"><a href="EnrollPatient.aspx">Add Patient</a></li>
        <li class="list-group-item"><a href="ViewPatientHistory.aspx">View Patient Details</a></li>
    </ul>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <h4>PATIENT ID:
        <asp:Label ID="lblPatientID" runat="server" Text="" ForeColor="Blue"></asp:Label>

    </h4>
    <fieldset>
        <legend>Personal Information:</legend>
        <table style="height: 120px">
            <tr>
                <td><sup>*</sup>First Name:</td>
                <td>
                    <asp:TextBox ID="txtFname" runat="server" CssClass="inputStyle"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorFname" runat="server" ErrorMessage="Input First Name" ControlToValidate="txtFname" ValidationGroup="enroll" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorFname" runat="server" ErrorMessage="Invalid First Name" ControlToValidate="txtFname" ValidationExpression="^[a-zA-Z]+$" ForeColor="Red" ValidationGroup="enroll"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td><sup>*</sup>Last Name:</td>
                <td>
                    <asp:TextBox ID="txtLname" runat="server" CssClass="inputStyle"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorLname" runat="server" ErrorMessage="Input Last Name" ControlToValidate="txtLname" ValidationGroup="enroll" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorLname" runat="server" ErrorMessage="Invalid Last Name" ControlToValidate="txtLname" ValidationExpression="^[a-zA-Z]*$" ForeColor="Red" ValidationGroup="enroll"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Date of birth:</td>
                <td>
                    <uc1:calenderControl runat="server" ID="calenderControl" />

                </td>
            </tr>
        </table>
    </fieldset>

    <fieldset>
        <legend>Contact Information:</legend>
        <table style="height: 80px">
            <tr>
                <td><sup>*</sup>Email ID:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="inputStyle"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="Input Email Address" ControlToValidate="txtEmail" ValidationGroup="enroll" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Email Address" ControlToValidate="txtEmail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td><sup>*</sup>Phone Number:</td>
                <td>
                    <asp:TextBox ID="txtPhone" runat="server" CssClass="inputStyle"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhone" runat="server" ErrorMessage="Input Phone Number" ControlToValidate="txtPhone" ValidationGroup="enroll" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid Phone Number" ControlToValidate="txtPhone" ForeColor="Red" ValidationExpression="^\d{11}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
        </table>
    </fieldset>

    <fieldset>
        <legend>Address Information:</legend>
        <table style="height: 80px">
            <tr>
                <td>State:</td>
                <td>
                    <asp:DropDownList ID="DropDownListState" runat="server" CssClass="inputStyle" Height="25px" Width="144px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Plan:</td>
                <td>
                    <asp:DropDownList ID="DropDownListPlan" runat="server" CssClass="inputStyle" Height="25px" Width="144px"></asp:DropDownList>
                </td>
            </tr>
        </table>
    </fieldset>

    <table style="width: 600px">
        <tr>
            <td>
                <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btnStyle" OnClick="btnReset_Click" />

            </td>
            <td>
                <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btnStyle" ValidationGroup="enroll" OnClick="btnRegister_Click" />

            </td>
        </tr>
    </table>

</asp:Content>
