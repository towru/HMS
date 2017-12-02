<%@ Page Title="" Language="C#" MasterPageFile="~/HmsMasterPage.Master" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Hospital_Management_System.Welcome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="menuContent" runat="server">
    <br />
    <br />

    <ul class="list-group">
        <li class="list-group-item "><a href="EnrollPatient.aspx">Add Patient</a></li>
        <li class="list-group-item "><a href="ViewPatientHistory.aspx">View Patient Details</a></li>
        <li class="list-group-item "><a href="AddPhysican.aspx">Add Physican</a></li>
        <li class="list-group-item"><a href="ViewPhysician.aspx">View Physican Details</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div>
         <asp:ScriptManager runat="server"></asp:ScriptManager>
        <asp:Timer ID="timerOne" runat="server" Interval="1000"></asp:Timer>
        <asp:UpdatePanel ID="updatePanel" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="timerOne" EventName="tick"/>
            </Triggers>
            <ContentTemplate>
                <center>
                    <asp:AdRotator runat="server" ID="adRotat" Height="250px" width="1000px" BorderColor="blue" AdvertisementFile="~/image.xml" >
                       
                    </asp:AdRotator>
                </center>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
   <hr />
  <div style="width:100% auto" align="center">
      <h1> WELCOME OUR SYSTEM</h1>
  </div>
</asp:Content>
