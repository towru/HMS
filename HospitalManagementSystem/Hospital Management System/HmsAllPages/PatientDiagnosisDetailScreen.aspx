<%@ Page Title="" Language="C#" MasterPageFile="~/HmsMasterPage.Master" AutoEventWireup="true" CodeBehind="PatientDiagnosisDetailScreen.aspx.cs" Inherits="Hospital_Management_System.HmsAllPages.PatientDiagnosisDetailScreen" %>

<%@ Register Src="~/calenderControl.ascx" TagPrefix="uc1" TagName="calenderControl" %>

<asp:Content ID="menu" runat="server" ContentPlaceHolderID="menuContent">
    <br />
    <br />

    <ul class="list-group">
        <li class="list-group-item "><a href="EnrollPatient.aspx">Add Patient</a></li>
        <li class="list-group-item active"><a href="PatientDiagnosisDetailScreen.aspx">Diagnosis Information</a></li>
        <li class="list-group-item"><a href="ViewPatientHistory.aspx">View Patient Details</a></li>
    </ul>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <asp:Panel ID="PatienDeatils" runat="server">
        <fieldset style="height: 250px">
            <legend>Patient Diagnosis Information:</legend>
            <div class="row">
                <div class="col-lg-6">
                    <table style="height: 100px">
                        <tr>
                            <td>Symptoms:</td>
                            <td>
                                <asp:TextBox ID="txtSymptome" runat="server" cols="20" rows="2" class="inputStyle" TextMode="MultiLine"></asp:TextBox>
                              
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorSymptome" runat="server" ErrorMessage="Need Symptome Details" ForeColor="Red" ControlToValidate="txtSymptome" ValidationGroup="diagonis">?</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>Diagnosis Provided:</td>
                            <td>
                                 <asp:TextBox ID="txtDiagnosis" runat="server" cols="20" rows="2" class="inputStyle" TextMode="MultiLine"></asp:TextBox>
                              
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorDiagonacis" runat="server" ErrorMessage="Enter Diagnosis Details" ControlToValidate="txtDiagnosis" ForeColor="red" ValidationGroup="diagonis">?</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="col-lg-6">
                    <table style="height: 200px">
                        <tr>
                            <td>Physician:</td>
                            <td>
                                <asp:DropDownList ID="DropDownListPhysican" runat="server" Height="25px" Width="120px" CssClass="inputStyle"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Date Of Diagnosis:</td>
                            <td>
                                <uc1:calenderControl runat="server" ID="calenderControDateDiagnosis" CssClass="inputStyle" />
                               
                            </td>
                        </tr>
                        <tr>
                            <td>Follow-up Required:</td>
                            <td>
                                <asp:CheckBox ID="CheckBoxFollow" runat="server" OnCheckedChanged="CheckBoxFollow_CheckedChanged" AutoPostBack="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblFollow" runat="server" Text="Date of Follow-up:"></asp:Label></td>
                            <td>
                                <uc1:calenderControl runat="server" ID="calenderControlDateFollow" CssClass="inputStyle" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="center">
                                <asp:Button ID="btnSubmit" runat="server" CssClass="btnStyle" Text="Submit" OnClick="btnSubmit_Click" ValidationGroup="diagonis" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </fieldset>
    </asp:Panel>
    <asp:Panel ID="billInfo" runat="server">
        <fieldset style="height: 300px">
            <legend>Bill Info:</legend>
            <table style="height: 200px">
                <tr>
                    <td>Bill ID:
                    </td>
                    <td>
                        <asp:Label ID="LblBillId" runat="server" ForeColor="blue"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Bill Amount:</td>
                    <td>
                        <asp:TextBox ID="txtBillAmount" runat="server" CssClass="inputStyle"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorBillAmount" runat="server" ErrorMessage="Enter Amount" ForeColor="Red" ControlToValidate="txtBillAmount" ValidationGroup="bill"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Mode of Payment:</td>
                    <td>
                        <asp:DropDownList ID="DropDownListModeOfPayment" runat="server" Height="25px" Width="144px" OnSelectedIndexChanged="DropDownListModeOfPayment_SelectedIndexChanged" AutoPostBack="true" CssClass="inputStyle">
                            <asp:ListItem>Cash</asp:ListItem>
                            <asp:ListItem>Card</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCard" runat="server" Text="Card Number:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtCardNumber" runat="server" CssClass="inputStyle"></asp:TextBox>
                       
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnSubmitBill" runat="server" Text="Submit Details" CssClass="btnStyle"  ValidationGroup="bill" OnClick="btnSubmitBill_Click"/>
                    </td>
                </tr>
            </table>
        </fieldset>
    </asp:Panel>
</asp:Content>
