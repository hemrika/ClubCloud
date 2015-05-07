
 
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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Addressen.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_AddressenUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Address_DataSource" runat="server" OnDataBinding="tmr_loader_Addressen_Tick" ViewName="ClubCloud_Addressen_View" />
<asp:UpdatePanel ID="udp_Addressen" runat="server" UpdateMode="Always">
    <contenttemplate>
		<asp:Timer runat="server" ID="tmr_loader_Addressen" OnTick="tmr_loader_Addressen_Tick" interval="500" />
<SharePoint:MenuTemplate ID="AddressMenu" runat="server" LargeIconMode="true">
	<SharePoint:MenuItemTemplate ID="Address_Details" runat="server" Text="Details van %Naam%" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Address.aspx?Id=%Id%', title:'Details van %Naam%', autoSize:true});" Title="Details van %Naam%"></SharePoint:MenuItemTemplate>
</SharePoint:MenuTemplate>
<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Address_Insert.aspx', title:'Toevoegen Address', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" href="#" target="_self" title="Toevoegen" >Toevoegen Address</a>
<br/>
<asp:panel runat="server" ID="pnl_Addressen" >
<SharePoint:SPGridViewPager ID="spgvpager_top" GridViewId="Addressen_Grid" runat="server" />
<br />
<SharePoint:SPGridView 
    ID="Addressen_Grid" 
    runat="server"
    AllowPaging="true" 
    AllowSorting="true" 
    AutoGenerateColumns="false" 
    SelectMethod="SelectAddressen"
	OnCallingDataMethods="GridAddressen_CallingDataMethods"
    PageSize="30"
    ShowFooter="true"
    ShowHeader="true"
	EnableViewState="false"
	ViewStateMode="Disabled"
	OnDataBinding="tmr_loader_Addressen_Tick" >
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <PagerSettings Mode="NextPreviousFirstLast" Visible="true" Position="TopAndBottom" PreviousPageText="vorige" NextPageText="volgende"  FirstPageText="Eerste" LastPageText="Laatste" PageButtonCount="5" />
    <PagerStyle HorizontalAlign="Center" VerticalAlign="Top" BackColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <Columns>
		<asp:TemplateField>
			<HeaderTemplate>
			    <asp:LinkButton ForeColor="White" ID="Naam_Sort" runat="server" Text="Naam" CommandName="Sort" CommandArgument="Naam"></asp:LinkButton>
			</HeaderTemplate>
			<ItemTemplate>
                <a id="<%# Eval("Naam") %>" title="<%# Eval("Naam") %>" name="<%# Eval("Naam") %>" onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Address.aspx?Id='+'<%# Eval("Id") %>', title:'Details van '+'<%# Eval("Naam") %>', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" style="white-space:nowrap;" href="#" >
                    <%# Eval("Naam") %>
                </a>
			</ItemTemplate>
		</asp:TemplateField>
	        <SharePoint:SPBoundField
            DataField="Stad"
            HeaderText="Stad"
            SortExpression="Stad"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Provincie"
            HeaderText="Provincie"
            SortExpression="Provincie"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Latitude"
            HeaderText="Latitude"
            SortExpression="Latitude"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Longitude"
            HeaderText="Longitude"
            SortExpression="Longitude"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Postcode"
            HeaderText="Postcode"
            SortExpression="Postcode"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Straat"
            HeaderText="Straat"
            SortExpression="Straat"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Actief"
            HeaderText="Actief"
            SortExpression="Actief"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Fax"
            HeaderText="Fax"
            SortExpression="Fax"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Toevoeging"
            HeaderText="Toevoeging"
            SortExpression="Toevoeging"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Postbus"
            HeaderText="Postbus"
            SortExpression="Postbus"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="TelefoonPrimair"
            HeaderText="TelefoonPrimair"
            SortExpression="TelefoonPrimair"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="TelefoonSecundair"
            HeaderText="TelefoonSecundair"
            SortExpression="TelefoonSecundair"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="TelefoonTertiair"
            HeaderText="TelefoonTertiair"
            SortExpression="TelefoonTertiair"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="GeoLocation"
            HeaderText="GeoLocation"
            SortExpression="GeoLocation"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Gewijzigd"
            HeaderText="Gewijzigd"
            SortExpression="Gewijzigd"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Gemeente"
            HeaderText="Gemeente"
            SortExpression="Gemeente"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="AddressGeheim"
            HeaderText="AddressGeheim"
            SortExpression="AddressGeheim"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
    
		<asp:TemplateField HeaderText="Gebruiker" SortExpression="GebruikerId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Gebruiker" runat="server" Text='<%# Bind("ClubCloud_Gebruiker.Volledigenaam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Regio" SortExpression="RegioId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Regio" runat="server" Text='<%# Bind("ClubCloud_Regio.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Land" SortExpression="LandId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Land" runat="server" Text='<%# Bind("ClubCloud_Land.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
    </Columns>
    <EmptyDataTemplate>
        <ItemTemplate>Er zijn geen Addressen gevonden.</ItemTemplate>
    </EmptyDataTemplate>        
</SharePoint:SPGridView >
<br />
<SharePoint:SPGridViewPager ID="spgvpager_bottom" GridViewId="Addressen_Grid" runat="server"/>
</asp:panel>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>
    <triggers>
        <asp:AsyncPostBackTrigger ControlID="tmr_loader_Addressen" EventName="Tick" />
    </triggers>
    </contenttemplate>
</asp:UpdatePanel>
<asp:UpdateProgress ID="udp_Addressen_progress" runat="server" AssociatedUpdatePanelID="udp_Addressen" DisplayAfter="50">
    <progresstemplate>
        <div class="progess" style="position: absolute; background-color: #F9F9F9; top: 0px; left: 0px; width: 100%; height: 100%; opacity: 0.8; -moz-opacity: 0.8; filter: alpha(opacity=80); -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=80)"; z-index: 10000;">
        <div class="bubbles aligncenter" style="top:48%;">laden...</div>
        </div>
</progresstemplate>
</asp:UpdateProgress>



