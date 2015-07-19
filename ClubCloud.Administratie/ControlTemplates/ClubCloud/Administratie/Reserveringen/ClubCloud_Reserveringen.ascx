
 
<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="AjaxControlToolkit" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit, Version=15.1.1.100, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Reserveringen.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_ReserveringenUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Reservering_DataSource" runat="server" OnDataBinding="tmr_loader_Reserveringen_Tick" ViewName="ClubCloud_Reserveringen_View" />
<asp:UpdatePanel ID="udp_Reserveringen" runat="server" UpdateMode="Always">
    <contenttemplate>
		<asp:Timer runat="server" ID="tmr_loader_Reserveringen" OnTick="tmr_loader_Reserveringen_Tick" interval="500" />
<SharePoint:MenuTemplate ID="ReserveringMenu" runat="server" LargeIconMode="true">
	<SharePoint:MenuItemTemplate ID="Reservering_Details" runat="server" Text="Details van %Naam%" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Reservering.aspx?Id=%Id%', title:'Details van %Naam%', autoSize:true});" Title="Details van %Naam%"></SharePoint:MenuItemTemplate>
</SharePoint:MenuTemplate>
<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Reservering_Insert.aspx', title:'Toevoegen Reservering', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" href="#" target="_self" title="Toevoegen" >Toevoegen Reservering</a>
<br/>
<asp:panel runat="server" ID="pnl_Reserveringen" >
<SharePoint:SPGridViewPager ID="spgvpager_top" GridViewId="Reserveringen_Grid" runat="server" />
<br />
<SharePoint:SPGridView 
    ID="Reserveringen_Grid" 
    runat="server"
    AllowPaging="true" 
    AllowSorting="true" 
    AutoGenerateColumns="false" 
    SelectMethod="SelectReserveringen"
	OnCallingDataMethods="GridReserveringen_CallingDataMethods"
    PageSize="30"
    ShowFooter="true"
    ShowHeader="true"
	EnableViewState="false"
	ViewStateMode="Disabled"
	OnDataBinding="tmr_loader_Reserveringen_Tick" >
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <PagerSettings Mode="NextPreviousFirstLast" Visible="true" Position="TopAndBottom" PreviousPageText="vorige" NextPageText="volgende"  FirstPageText="Eerste" LastPageText="Laatste" PageButtonCount="5" />
    <PagerStyle HorizontalAlign="Center" VerticalAlign="Top" BackColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <Columns>
		<asp:TemplateField>
			<HeaderTemplate>
			    <asp:LinkButton ForeColor="White" ID="Id_Sort" runat="server" Text="Id" CommandName="Sort" CommandArgument="Id"></asp:LinkButton>
			</HeaderTemplate>
			<ItemTemplate>
                <a id="<%# Eval("Id") %>" title="<%# Eval("Id") %>" name="<%# Eval("Id") %>" onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Reservering.aspx?Id='+'<%# Eval("Id") %>', title:'Details van '+'<%# Eval("Id") %>', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" style="white-space:nowrap;" href="#" >
                    <%# Eval("Id") %>
                </a>
			</ItemTemplate>
		</asp:TemplateField>
        <SharePoint:SPBoundField
            DataField="Datum"
            HeaderText="Datum"
            SortExpression="Datum"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Tijd"
            HeaderText="Tijd"
            SortExpression="Tijd"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Duur"
            HeaderText="Duur"
            SortExpression="Duur"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="ReserveringSoort"
            HeaderText="ReserveringSoort"
            SortExpression="ReserveringSoort"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Beschrijving"
            HeaderText="Beschrijving"
            SortExpression="Beschrijving"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Final"
            HeaderText="Final"
            SortExpression="Final"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
    
		<asp:TemplateField HeaderText="Baan" SortExpression="BaanId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Baan" runat="server" Text='<%# Bind("ClubCloud_Baan.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Gebruiker" SortExpression="GebruikerId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Gebruiker_Een" runat="server" Text='<%# Bind("ClubCloud_Gebruiker_Een.Volledigenaam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Gebruiker" SortExpression="GebruikerId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Gebruiker_Twee" runat="server" Text='<%# Bind("ClubCloud_Gebruiker_Twee.Volledigenaam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Gebruiker" SortExpression="GebruikerId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Gebruiker_Drie" runat="server" Text='<%# Bind("ClubCloud_Gebruiker_Drie.Volledigenaam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Gebruiker" SortExpression="GebruikerId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Gebruiker_Vier" runat="server" Text='<%# Bind("ClubCloud_Gebruiker_Vier.Volledigenaam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
    </Columns>
    <EmptyDataTemplate>
        <ItemTemplate>Er zijn geen Reserveringen gevonden.</ItemTemplate>
    </EmptyDataTemplate>        
</SharePoint:SPGridView >
<br />
<SharePoint:SPGridViewPager ID="spgvpager_bottom" GridViewId="Reserveringen_Grid" runat="server"/>
</asp:panel>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>
    <triggers>
        <asp:AsyncPostBackTrigger ControlID="tmr_loader_Reserveringen" EventName="Tick" />
    </triggers>
    </contenttemplate>
</asp:UpdatePanel>
<asp:UpdateProgress ID="udp_Reserveringen_progress" runat="server" AssociatedUpdatePanelID="udp_Reserveringen" DisplayAfter="50">
    <progresstemplate>
        <div class="progess" style="position: absolute; background-color: #F9F9F9; top: 0px; left: 0px; width: 100%; height: 100%; opacity: 0.8; -moz-opacity: 0.8; filter: alpha(opacity=80); -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=80)"; z-index: 10000;">
        <div class="bubbles aligncenter" style="top:48%;">laden...</div>
        </div>
</progresstemplate>
</asp:UpdateProgress>



