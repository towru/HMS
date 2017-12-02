<%@ Page Title="" Language="C#" MasterPageFile="~/HmsMasterPage.Master" AutoEventWireup="true" CodeBehind="ViewPhysician.aspx.cs" Inherits="Hospital_Management_System.HmsAllPages.ViewPhysician" %>

<asp:Content ID="Content1" ContentPlaceHolderID="menuContent" runat="server">
    <br />
    <br />

    <ul class="list-group">
        <li class="list-group-item "><a href="AddPhysican.aspx">Add Physican</a></li>
        <li class="list-group-item active"><a href="ViewPhysician.aspx">View Physican Details</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div align="center">

        <table style="height: 150px">
            <tr>
                <td>
                    <asp:Label ID="lblPlan" runat="server" Text="Select Plan"></asp:Label>

                </td>
                <td>
                    <asp:DropDownList ID="DropdownlistPlan" runat="server" CssClass="inputStyle" Height="25px" Width="144px"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblState" runat="server" Text="Select State"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropdownlistState" runat="server" CssClass="inputStyle" Height="25px" Width="144px"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDept" runat="server" Text="Select Department"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownDepart" runat="server" CssClass="inputStyle" Height="25px" Width="144px"></asp:DropDownList>
                </td>
            </tr>
            <tr>

                <td style="padding-right: 10px;">
                    <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btnStyle" OnClick="btnSearch_Click" />
                   

                </td>
                <td>
                    <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btnStyle" OnClick="btnReset_Click" />
                </td>
            </tr>

        </table>

        <table style="width: 100%; margin-top: 50px" align="center">
            <tr align="center">
                <td>
                    <asp:Label ID="lblShow" runat="server" BorderColor="#3399FF" Font-Size="XX-Large"></asp:Label>

                    <asp:Repeater ID="RepeaterPhysican" runat="server">
                        <ItemTemplate>
                            <table>
                                <tr>
                                    <td>
                                        <table style="background-color: #F0E68C; color: black; height: 200px; width: 400px; border: 1px solid">
                                            <tr>
                                                <td>Physician ID</td>
                                                <td>
                                                    <asp:Label ID="lblid" runat="server" Text='<%#Eval("PhysicianId") %>' Font-Bold="true"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>Department ID</td>
                                                <td>
                                                    <asp:Label ID="lbldepid" runat="server" Text='<%#Eval("DepartmentId") %>' Font-Bold="true"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>First Name:</td>
                                                <td>
                                                    <asp:Label ID="lblFname" runat="server" Text='<%#Eval("PhysicianFName") %>' Font-Bold="true"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>Last Name</td>
                                                <td>
                                                    <asp:Label ID="lblLname" runat="server" Text='<%#Eval("PhysicianLName") %>' Font-Bold="true"></asp:Label></td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td>
                                        <table style="background-color: #F0E68C; color: black; height: 200px; width: 400px; border: 1px solid">

                                            <tr>
                                                <td>Educational Qulaification</td>
                                                <td>
                                                    <asp:Label ID="lblEducation" runat="server" Text='<%#Eval("Education") %>' Font-Bold="true"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>Years Of Experience:</td>
                                                <td>
                                                    <asp:Label ID="lblExparience" runat="server" Text='<%#Eval("YearsOfQualification") %>' Font-Bold="true"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>Plan Name</td>
                                                <td>
                                                    <asp:Label ID="lblplan" runat="server" Text='<%#Eval("PlanName") %>' Font-Bold="true"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>State Name</td>
                                                <td>
                                                    <asp:Label ID="lblstate" runat="server" Text='<%#Eval("State") %>' Font-Bold="true"></asp:Label></td>
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
</asp:Content>
