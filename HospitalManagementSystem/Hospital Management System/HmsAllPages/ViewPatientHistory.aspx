<%@ Page Title="" Language="C#" MasterPageFile="~/HmsMasterPage.Master" AutoEventWireup="true" CodeBehind="ViewPatientHistory.aspx.cs" Inherits="Hospital_Management_System.HmsAllPages.ViewPatientHistory" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="menuContent" runat="server">
    <br />
    <br />

    <ul class="list-group">
        <li class="list-group-item "><a href="EnrollPatient.aspx">Add Patient</a></li>
        <li class="list-group-item  active"><a href="ViewPatientHistory.aspx">View Patient Details</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <asp:ScriptManager ID="script" runat="server"></asp:ScriptManager>
    <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
        <ProgressTemplate>
            <div class="">
                <div class="loading">
                    <img src="../Images/load1.gif" />

                </div>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div align="center">
                <table style="width: 100%; margin-top: 20px">
                    <tr>
                        <td>
                            <asp:TextBox ID="txtId" runat="server" Placeholder="Search by id.." CssClass="searchBtn"></asp:TextBox></td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorId" runat="server" ErrorMessage="Invalid Patient Id" ControlToValidate="txtId" ForeColor="Red" ValidationGroup="PatientSearch" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                        <td>
                            <asp:TextBox ID="txtName" runat="server" Placeholder="Search by Name.." CssClass="searchBtn"></asp:TextBox></td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorName" runat="server" ErrorMessage="Invalid Patient Name" ControlToValidate="txtName" ForeColor="Red" ValidationGroup="PatientSearch" ValidationExpression="^[a-zA-Z]+$"></asp:RegularExpressionValidator>
                        <td>
                            <asp:Button ID="btnId" runat="server" Text="Search Id Or Name" OnClick="btnId_Click" CssClass="btnStyle" ValidationGroup="PatientSearch" /></td>

                        <td>
                            <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btnStyle" OnClick="btnReset_Click" />
                        </td>
                    </tr>
                </table>

                <table style="width: 100%; margin-top: 50px" align="center">
                    <tr align="center">
                        <td>

                            <asp:Label ID="lblShow" runat="server" BorderColor="#3399FF" Font-Size="XX-Large"></asp:Label>
                            <asp:Repeater ID="repeterShowPatient" runat="server">
                                <ItemTemplate>
                                    <table align="center">
                                        <tr>
                                            <td colspan="2">
                                                <table style="background-color: #F0E68C; color: black; height: 100px; width: 800px">
                                                    <tr>
                                                        <td style="background-color: black; color: white" colspan="2" align="center">
                                                            <h3>Provided Daigonasis </h3>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Symptoms:</td>
                                                        <td>
                                                            <asp:Label ID="lblSymptoms" runat="server" Text='<%#Eval("Symptoms") %>' Font-Bold="true"></asp:Label></td>
                                                    </tr>
                                                    <tr>
                                                        <td>DiagnosisProvided:</td>
                                                        <td>
                                                            <asp:Label ID="lblDiagnosisProvided" runat="server" Text='<%#Eval("DiagnosisProvided") %>' Font-Bold="true"></asp:Label></td>
                                                    </tr>
                                                    <tr>
                                                        <td>Bill Amount:</td>
                                                        <td>
                                                            <asp:Label ID="lblbill" runat="server" Text='<%#Eval("BillAmount") %>' Font-Bold="true" Font-Size="20px"></asp:Label></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table style="background-color: #F0E68C; color: black; height: 200px; width: 400px; border: 1px solid">
                                                    <tr>
                                                        <td style="background-color: black; color: white" colspan="2" align="center">
                                                            <h3>Patient Inforamtion </h3>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Patient ID:</td>
                                                        <td>
                                                            <asp:Label ID="lblid" runat="server" Text='<%#Eval("PatientId")%>' Font-Bold="true"></asp:Label></td>
                                                    </tr>
                                                    <tr>
                                                        <td>First Name:</td>
                                                        <td>
                                                            <asp:Label ID="lblFName" runat="server" Text='<%#Eval("FirstName")%>' Font-Bold="true"></asp:Label></td>
                                                    </tr>
                                                    <tr>
                                                        <td>Last Name:</td>
                                                        <td>
                                                            <asp:Label ID="lblLname" runat="server" Text='<%#Eval("LastName") %>' Font-Bold="true"></asp:Label></td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td>
                                                <table style="background-color: #F0E68C; color: black; height: 200px; width: 400px; border: 1px solid">
                                                    <tr>
                                                        <td style="background-color: black; color: white" colspan="2" align="center">
                                                            <h3>Physican Information </h3>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Physican Name:</td>
                                                        <td>
                                                            <asp:Label ID="lblPhysican" runat="server" Text='<%#Eval("AdministeredBy") %>' Font-Bold="true"></asp:Label></td>
                                                    </tr>
                                                    <tr>
                                                        <td>Diagnosis Date:</td>
                                                        <td>
                                                            <asp:Label ID="lblDate" runat="server" Text='<%#Eval("DateOfDiagnosis") %>' Font-Bold="true"></asp:Label></td>
                                                    </tr>
                                                    <tr>
                                                        <td>Follow Up Date:</td>
                                                        <td>
                                                            <asp:Label ID="lblRequired" runat="server" Text='<%#Eval("DateOfFollowUp") %>' Font-Bold="true"></asp:Label></td>
                                                    </tr>
                                                </table>
                                            </td>

                                        </tr>

                                    </table>
                                </ItemTemplate>
                            </asp:Repeater>
                        </td>
                    </tr>
                </table>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>






</asp:Content>
