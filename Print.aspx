<%@ Page Title="Print" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Print.aspx.cs" Inherits="Gatepass.Account.Login" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

    <div class="hideSkiplink">
     <asp:Panel ID="panF" runat="server"
       Width="100%">

    <asp:Table ID="MenuTable" runat="server" Width="100%" Height="35" BackColor="BurlyWood">
    <asp:TableRow Width="120">
    <asp:TableCell ID="TableCell1" runat="server" Width="100">
    <asp:Label runat="server" ID="lblFSnumber" Text="FS Number:" Font-Bold="true" Width="100"/></asp:TableCell>
    <asp:TableCell ID="TableCell2" runat="server" Width="100" >
    <asp:TextBox  runat="server" ID="txtFSNumber" Width="100"/></asp:TableCell>
    <asp:TableCell ID="TableCell3" runat="server" Width="70"></asp:TableCell>
    <asp:TableCell ID="TableCell4" runat="server" Width="70"></asp:TableCell>
    <asp:TableCell ID="TableCell5" runat="server" Width="70"></asp:TableCell>
    <asp:TableCell ID="TableCell6" runat="server" Width="70"></asp:TableCell>
    <asp:TableCell ID="TableCell7" runat="server" Width="70"></asp:TableCell>
    <asp:TableCell ID="TableCell8" runat="server" Width="70"></asp:TableCell>
    <asp:TableCell ID="TableCell9" runat="server" Width="70"></asp:TableCell>
    <asp:TableCell ID="TableCell10" runat="server" Width="70"></asp:TableCell>
    <asp:TableCell ID="TableCell11" runat="server" Width="70"></asp:TableCell>
    <asp:TableCell ID="TableCell12" runat="server" Width="70"></asp:TableCell>
    </asp:TableRow></asp:Table>

     </asp:Panel></div></asp:Content>