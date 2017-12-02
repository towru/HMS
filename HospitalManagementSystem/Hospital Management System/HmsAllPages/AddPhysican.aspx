<%@ Page Title="" Language="C#" MasterPageFile="~/HmsMasterPage.Master" AutoEventWireup="true" CodeBehind="AddPhysican.aspx.cs" Inherits="Hospital_Management_System.HmsAllPages.AddPhysican" %>

<asp:Content ID="Content1" ContentPlaceHolderID="menuContent" runat="server">
    <br />
    <br />

    <ul class="list-group">
        <li class="list-group-item active"><a href="AddPhysican.aspx">Add Physican</a></li>
        <li class="list-group-item"><a href="ViewPhysician.aspx">View Physican Details</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <fieldset>
        <legend>Personal Information:</legend>
        <table style="height:100px">
            <tr>
                <td>Physician ID:</td>
                <td>
                 <asp:Label ID="lblPatientID" runat="server" Text="" ForeColor="Blue" Font-Size="20px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td><sup>*</sup> First Name:</td>
                <td>
                    <asp:Textbox id="txtFirstName" runat="server" CssClass="inputStyle"></asp:Textbox>
                    <asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" errormessage="First Name Must be enter" controltovalidate="txtFirstName" forecolor="Red" ValidationGroup="addPhy"></asp:requiredfieldvalidator>
                </td>

            </tr>

            <tr>
                <td><sup>*</sup> Last Name:</td>
                <td>
                    <asp:Textbox id="txtLastName" runat="server" CssClass="inputStyle"></asp:Textbox>
                    <asp:requiredfieldvalidator id="RequiredFieldValidator3" runat="server" errormessage="Last Name Must be enter" controltovalidate="txtLastName" forecolor="Red" ValidationGroup="addPhy"></asp:requiredfieldvalidator>
                </td>
            </tr>
        </table>
    </fieldset>

    <fieldset>
        <legend>Other Information:</legend>
        <table style="height:180px">
            <tr>
                <td><sup>*</sup> Depertment:</td>
                <td>

                    <asp:Dropdownlist id="DropdownlistDepartment" runat="server" CssClass="inputStyle" Height="25px" Width="144px">
                        <asp:ListItem>D001</asp:ListItem>
                        <asp:ListItem>D002</asp:ListItem>
                        <asp:ListItem>D003</asp:ListItem>
                    </asp:Dropdownlist>

                </td>

            </tr>


            <tr>
                <td><sup>*</sup>Educational qualification:</td>
                <td>
                    <asp:Textbox id="txtEducational" runat="server" CssClass="inputStyle"></asp:Textbox>
                    <asp:requiredfieldvalidator id="RequiredFieldValidator4" runat="server" errormessage="Education Qualification Must be Enter" controltovalidate="txtEducational" forecolor="Red" ValidationGroup="addPhy"></asp:requiredfieldvalidator>
                </td>
            </tr>

            <tr>
                <td><sup>*</sup>Years of experience:</td>
                <td>
                    <asp:Textbox id="txtYearOfEx" runat="server" CssClass="inputStyle"></asp:Textbox>
                    <asp:requiredfieldvalidator id="RequiredFieldValidator5" runat="server" errormessage="Year of Eperience Must be Enter" controltovalidate="txtYearOfEx" forecolor="Red" ValidationGroup="addPhy"></asp:requiredfieldvalidator>
                </td>
            </tr>


            <tr>
                <td><sup>*</sup>State:</td>
                <td>

                    <asp:Dropdownlist id="DropDownState" runat="server" CssClass="inputStyle" Height="25px" Width="144px"></asp:Dropdownlist>
              
                </td>

            </tr>

            <tr>
                <td><sup>*</sup>Plan:</td>
                <td>

                    <asp:Dropdownlist id="DropDownPlan" runat="server" CssClass="inputStyle" Height="25px" Width="144px"></asp:Dropdownlist>
                </td>

            </tr>
        </table>
    </fieldset>

    <table style="width:600px">
        <tr>
            <td>
                <asp:Button id="btnReg" runat="server" text="Regester" CssClass="btnStyle" OnClick="btnReg_Click" ValidationGroup="addPhy"/>
            </td>
            <td>
                <asp:Button id="btnReset" runat="server" text="Reset"  CssClass="btnStyle" OnClick="btnReset_Click"/>
            </td>
        </tr>
    </table>

</asp:Content>
