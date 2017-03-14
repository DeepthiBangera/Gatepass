<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Gatepass._Default" %>


        <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent" >
            
    <%-- <asp:Table ID="MenuTable" runat="server" Width="500">
    <asp:TableRow Height="60" BackColor="Red" Width="500" ForeColor="Black">
    <asp:TableCell runat="server">
    <asp:Label runat="server" ID="lblFromDate" Text="From Date" Width="60"/>
    </asp:TableCell>
    </asp:TableRow>
    </asp:Table>--%>

     <div class="hideSkiplink">
     <asp:Panel ID="panFooter" runat="server" DefaultButton="BtnSearch"
       Width="100%">

             <asp:Table ID="MenuTable" runat="server" Width="100%" BackColor="BurlyWood">
    <asp:TableRow BackColor="BurlyWood" >

    <asp:TableCell ID="TableCell1" runat="server" Width="70">
    <asp:Label runat="server" ID="lblFromDate" Text="From Date" Font-Bold="true" Width="70"/>
    </asp:TableCell><asp:TableCell ID="TableCell2" runat="server" Width="70">
     <asp:TextBox  runat="server" ID="txtFromDate" Width="100"/>
     </asp:TableCell><asp:TableCell ID="TableCell3" runat="server" Width="70">
    <asp:Label runat="server" ID="lblToDate" Text="To Date" Font-Bold="true" Width="70"/>
    </asp:TableCell><asp:TableCell ID="TableCell4" runat="server" Width="70">
     <asp:TextBox  runat="server" ID="txtToDate" Width="100"/>
     </asp:TableCell><asp:TableCell ID="TableCell8" runat="server" HorizontalAlign="Center">
    <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="OnSubmitclick" Font-Bold="true" Width="70"/>
    </asp:TableCell><asp:TableCell ID="TableCell5" runat="server" Width="70">
     <asp:Label runat="server" ID="search" Text="Search FS" Font-Bold="true" Width="70"/>


    </asp:TableCell><asp:TableCell ID="TableCell6" runat="server" Width="70">
     <asp:TextBox  runat="server" ID="TxtSearch" Width="100" onkeyDown="Search_Click1" />
    <asp:Button ID="BtnSearch" runat="server" OnClick="Search_Click1" Style="display: none" />


     </asp:TableCell><asp:TableCell ID="TableCell9" runat="server" HorizontalAlign="Center">
    <asp:Button runat="server" ID="Button1" Text="Clear All" Font-Bold="true" OnClick="ClearAll_Click" Width="70"/>
    </asp:TableCell><asp:TableCell ID="TableCell7" runat="server" HorizontalAlign="Right">
    <asp:Button runat="server" ID="btnSettings" Text="Settings" Font-Bold="true" Width="70" OnClick="Onsettingclick"/>
    </asp:TableCell></asp:TableRow></asp:Table></asp:Panel></div><%--<asp:DataGrid ID="grdTable" runat="server" Width="100%" Height="100%" AutoGenerateColumns="false"  AllowPaging="True"
            PageSize="5"   OnPageIndexChanged="OnPaging_changed"  
            ShowFooter="true">
    <Columns> 
    <asp:BoundColumn HeaderText="Date"  DataField="Date" HeaderStyle-Font-Bold="true"/>
    <asp:BoundColumn HeaderText="Job Number"  DataField="JobNumber" HeaderStyle-Font-Bold="true"/>
    <asp:BoundColumn HeaderText="Customer Name"  DataField="CustomerName" HeaderStyle-Font-Bold="true"/>
    <asp:BoundColumn HeaderText="Customer Address"  DataField="CustomerAddress" HeaderStyle-Font-Bold="true"/>
    <asp:BoundColumn HeaderText="PO Number"  DataField="PONumber" HeaderStyle-Font-Bold="true"/>
    <asp:BoundColumn HeaderText="Design"  DataField="Design" HeaderStyle-Font-Bold="true"/>
    <asp:BoundColumn HeaderText="Quantity"  DataField="Quantity" HeaderStyle-Font-Bold="true"/>
    <asp:BoundColumn HeaderText="A1"  DataField="A1" HeaderStyle-Font-Bold="true"/>
    <asp:BoundColumn HeaderText="B1"  DataField="B1" HeaderStyle-Font-Bold="true" ReadOnly="false"/>
    <asp:BoundColumn HeaderText="Item"  DataField="Item" HeaderStyle-Font-Bold="true"/>
    <asp:BoundColumn HeaderText="Printer"  DataField="Printer" HeaderStyle-Font-Bold="true"/>
    <asp:BoundColumn HeaderText="Part"  DataField="Part" HeaderStyle-Font-Bold="true"/>
    <asp:BoundColumn HeaderText="SalOrdNo"  DataField="SalOrdNo" HeaderStyle-Font-Bold="true"/>
    <asp:BoundColumn HeaderText="ItemCode"  DataField="ItemCode" HeaderStyle-Font-Bold="true"/>
    </Columns>
    </asp:DataGrid>
--%><asp:Table ID="Table1" runat="server" Visible="false" Width="100%"   BorderWidth="1px" >
        <asp:TableHeaderRow>
        <asp:TableHeaderCell BorderWidth="1px">Date</asp:TableHeaderCell><asp:TableHeaderCell BorderWidth="1px">Job Number</asp:TableHeaderCell><asp:TableHeaderCell BorderWidth="1px">Customer Name</asp:TableHeaderCell><asp:TableHeaderCell BorderWidth="1px">Customer Address</asp:TableHeaderCell><asp:TableHeaderCell BorderWidth="1px">PO Number</asp:TableHeaderCell><asp:TableHeaderCell BorderWidth="1px">Design</asp:TableHeaderCell><asp:TableHeaderCell BorderWidth="1px">Quantity</asp:TableHeaderCell><asp:TableHeaderCell BorderWidth="1px">A1</asp:TableHeaderCell><asp:TableHeaderCell BorderWidth="1px">B1</asp:TableHeaderCell><asp:TableHeaderCell BorderWidth="1px">Item</asp:TableHeaderCell><asp:TableHeaderCell BorderWidth="1px">Printer</asp:TableHeaderCell><asp:TableHeaderCell BorderWidth="1px">Part</asp:TableHeaderCell><asp:TableHeaderCell BorderWidth="1px">SalOrdNo</asp:TableHeaderCell><asp:TableHeaderCell BorderWidth="1px">ItemCode</asp:TableHeaderCell></asp:TableHeaderRow></asp:Table>
                 <div id="grid-view-container" style="height: 500px; overflow: auto">
                 <asp:GridView 
        runat="server" ID="grdTable" Width="100%" 
        AutoGenerateColumns="false" BorderWidth="1px" AllowPaging="true" 
            PageSize="10"  OnPageIndexChanging ="OnPaging_changed"  OnSelectedIndexChanged="OnSelectedIndexChanged"
       RowStyle-Wrap="True" RowStyle-Height="12">
             
    <Columns>
        <asp:TemplateField ItemStyle-Wrap="true">
        <%--<HeaderTemplate>
            <asp:CheckBox ID="chkAll" runat="server"
             onclick = "checkAll(this);" />
        </HeaderTemplate>--%>
        <ItemTemplate>
            <asp:CheckBox ID="chk"  runat="server" OnCheckedChanged="CheckboxSelected"/>
        </ItemTemplate>
    </asp:TemplateField>
    <asp:BoundField ItemStyle-Wrap="true" HeaderText="Date"  DataField="Date" HeaderStyle-Font-Bold="true"/>
    <asp:BoundField ItemStyle-Wrap="true" HeaderText="Job Number"  DataField="JobNumber" HeaderStyle-Font-Bold="true"/>
    <asp:BoundField ItemStyle-Wrap="true" HeaderText="Customer Name"  DataField="CustomerName" HeaderStyle-Font-Bold="true"/>
    <asp:BoundField ItemStyle-Wrap="true" HeaderText="Customer Address"  DataField="CustomerAddress" HeaderStyle-Font-Bold="true"/>
    <asp:BoundField ItemStyle-Wrap="true" HeaderText="PO Number"  DataField="PONumber" HeaderStyle-Font-Bold="true"/>
    <asp:BoundField ItemStyle-Wrap="true" HeaderText="Design"  DataField="Design" HeaderStyle-Font-Bold="true"/>
    <asp:BoundField ItemStyle-Wrap="true" HeaderText="Quantity"  DataField="Quantity" HeaderStyle-Font-Bold="true"/>
    <asp:BoundField ItemStyle-Wrap="true" HeaderText="A1"  DataField="A1" HeaderStyle-Font-Bold="true"/>
    <asp:BoundField ItemStyle-Wrap="true" HeaderText="B1"  DataField="B1" HeaderStyle-Font-Bold="true" ReadOnly="false" />
    <asp:BoundField ItemStyle-Wrap="true" HeaderText="Item"  DataField="Item" HeaderStyle-Font-Bold="true"/>
    <asp:BoundField ItemStyle-Wrap="true" HeaderText="Printer"  DataField="Printer" HeaderStyle-Font-Bold="true"/>
    <asp:BoundField ItemStyle-Wrap="true" HeaderText="Part"  DataField="Part" HeaderStyle-Font-Bold="true"/>
    <asp:BoundField ItemStyle-Wrap="true" HeaderText="SalOrdNo"  DataField="SalOrdNo" HeaderStyle-Font-Bold="true"/>
    <asp:BoundField ItemStyle-Wrap="true" HeaderText="ItemCode"  DataField="ItemCode" HeaderStyle-Font-Bold="true"/>
    </Columns>
        
    </asp:GridView>
         

    <asp:Table ID="FooterTable" runat="server" Width="100%" BackColor="BurlyWood">
    <asp:TableRow BackColor="BurlyWood" >

    <asp:TableCell ID="TableCell10" runat="server" Width="70" HorizontalAlign="Center">
    <asp:Button runat="server" ID="btnReport" Text="Report" OnClick="Onsettingclick" Font-Bold="true" Width="70"/>

         </asp:TableCell><asp:TableCell ID="TableCell14" runat="server" Width="70" HorizontalAlign="Right">
     <asp:TextBox  runat="server" ID="txtSelectedJob" Width="100" Enabled="false"/>

          </asp:TableCell><asp:TableCell ID="TableCell16" runat="server" Width="70" HorizontalAlign="Right">
     <asp:Label  runat="server" ID="lblB1" Width="100" Font-Bold="true"   Text="Enter B1 :"/>

     </asp:TableCell><asp:TableCell ID="TableCell15" runat="server" Width="70" HorizontalAlign="Left">
     <asp:TextBox  runat="server" ID="txtB1" Width="40" Enabled="false" Font-Bold="true"/>

    </asp:TableCell><asp:TableCell ID="TableCell11" runat="server" Width="70" HorizontalAlign="Center">
     <asp:Button  runat="server" ID="btnReplicate" Width="100" Text="Replicate" Enabled="false" UseSubmitBehavior="false" Font-Bold="true" OnClick="onReplicateClick"/>

     </asp:TableCell><asp:TableCell ID="TableCell12" runat="server" Width="70" HorizontalAlign="Right">
    <asp:Button runat="server" ID="btnPrint" Text="Print" OnClick="Onsettingclick" Font-Bold="true" Width="70" />
    </asp:TableCell><asp:TableCell ID="TableCell13" runat="server" Width="100" HorizontalAlign="Center">
     <asp:Button  runat="server" ID="btnBarcode" Width="150" Text="Genarate Barcode" OnClick="Onsettingclick" Font-Bold="true"/>

     </asp:TableCell></asp:TableRow></asp:Table><%--<script type="text/javascript">
         function FireOnClickButton() {
             document.getElementByID("BtnSearch").click();

         }
</script>--%>
                      </div>            
</asp:Content>