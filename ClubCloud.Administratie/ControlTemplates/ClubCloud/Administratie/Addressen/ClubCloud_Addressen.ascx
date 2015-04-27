
 
<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Addressen.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_AddressenUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Address_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Addressen_View" />
<SharePoint:MenuTemplate ID="AddressMenu" runat="server">
	<SharePoint:MenuItemTemplate ID="Address_Details" runat="server" Text="Details bekijken van Address" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Address.aspx?Id=%Id%', title:'Details van Address', autoSize:false});" Title="Details van Address"></SharePoint:MenuItemTemplate>
</SharePoint:MenuTemplate>
<asp:HyperLink ID="Address_Insert" Text="Toevoegen" NavigateUrl="Address_Insert.aspx"  runat="server" />
<br/>
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
    ShowHeader="true" >
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <PagerSettings Mode="NextPreviousFirstLast" Visible="true" Position="TopAndBottom" PreviousPageText="vorige" NextPageText="volgende"  FirstPageText="Eerste" LastPageText="Laatste" PageButtonCount="5" />
    <PagerStyle HorizontalAlign="Center" VerticalAlign="Top" BackColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <Columns>
			<SharePoint:SPMenuField
			HeaderText="Naam"
			TextFields="Naam"
			MenuTemplateId="AddressMenu"
			TokenNameAndValueFields="Id=Id"
			SortExpression="Naam"
			ItemStyle-Width="120px" />
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
    
		<asp:TemplateField HeaderText="Regio" SortExpression="RegioId">
			<ItemTemplate>
				<asp:Label ID="Regio" runat="server" Text='<%# Bind("ClubCloud_Regio.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Land" SortExpression="LandId">
			<ItemTemplate>
				<asp:Label ID="Land" runat="server" Text='<%# Bind("ClubCloud_Land.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
    </Columns>
    <EmptyDataTemplate>
        <HeaderTemplate>
            <asp:HyperLink ID="Address_Insert" Text="Toevoegen" NavigateUrl="Address_Insert.aspx"  runat="server" /> <br/>
        </HeaderTemplate>
        <ItemTemplate>Er zijn geen gegevens gevonden.</ItemTemplate>
    </EmptyDataTemplate>        
</SharePoint:SPGridView >
<br />
<SharePoint:SPGridViewPager ID="spgvpager_bottom" GridViewId="Addressen_Grid" runat="server"/>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>



