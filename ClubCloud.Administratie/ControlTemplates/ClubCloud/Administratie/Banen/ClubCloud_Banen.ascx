
 
<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Banen.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_BanenUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Baan_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Banen_View" />
<SharePoint:MenuTemplate ID="BaanMenu" runat="server">
	<SharePoint:MenuItemTemplate ID="Baan_Details" runat="server" Text="Details bekijken van Baan" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Baan.aspx?Id=%Id%', title:'Details van Baan', autoSize:false});" Title="Details van Baan"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Baanschemas" runat="server" Text="Details bekijken van Baanschemas" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Baanschemas.aspx?BaanId=%Id%',title:'Details van Baanschemas', autoSize:false});" Title="Details van Baanschemas"></SharePoint:MenuItemTemplate>
</SharePoint:MenuTemplate>
<asp:HyperLink ID="Baan_Insert" Text="Toevoegen" NavigateUrl="Baan_Insert.aspx"  runat="server" />
<br/>
<SharePoint:SPGridViewPager ID="spgvpager_top" GridViewId="Banen_Grid" runat="server" />
<br />
<SharePoint:SPGridView 
    ID="Banen_Grid" 
    runat="server"
    AllowPaging="true" 
    AllowSorting="true" 
    AutoGenerateColumns="false" 
    SelectMethod="SelectBanen"
	OnCallingDataMethods="GridBanen_CallingDataMethods"
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
			MenuTemplateId="BaanMenu"
			TokenNameAndValueFields="Id=Id"
			SortExpression="Naam"
			ItemStyle-Width="120px" />
	        <SharePoint:SPBoundField
            DataField="Status"
            HeaderText="Status"
            SortExpression="Status"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Keuring"
            HeaderText="Keuring"
            SortExpression="Keuring"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Actief"
            HeaderText="Actief"
            SortExpression="Actief"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
    
		<asp:TemplateField HeaderText="Baanblok" SortExpression="BaanblokId">
			<ItemTemplate>
				<asp:Label ID="Baanblok" runat="server" Text='<%# Bind("ClubCloud_Baanblok.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Baanschemas" SortExpression="BaanschemaId">
			<ItemTemplate>
				<asp:Label ID="Baanschemas" runat="server" Text='<%# Bind("ClubCloud_Baanschema.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
    </Columns>
    <EmptyDataTemplate>
        <HeaderTemplate>
            <asp:HyperLink ID="Baan_Insert" Text="Toevoegen" NavigateUrl="Baan_Insert.aspx"  runat="server" /> <br/>
        </HeaderTemplate>
        <ItemTemplate>Er zijn geen gegevens gevonden.</ItemTemplate>
    </EmptyDataTemplate>        
</SharePoint:SPGridView >
<br />
<SharePoint:SPGridViewPager ID="spgvpager_bottom" GridViewId="Banen_Grid" runat="server"/>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>



