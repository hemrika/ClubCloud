
 
<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Verenigingen.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_VerenigingenUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Vereniging_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Verenigingen_View" />
<SharePoint:MenuTemplate ID="VerenigingMenu" runat="server">
	<SharePoint:MenuItemTemplate ID="Vereniging_Details" runat="server" Text="Details bekijken van Vereniging" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Vereniging.aspx?Id=%Id%', title:'Details van Vereniging', autoSize:false});" Title="Details van Vereniging"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Functionarissen" runat="server" Text="Details bekijken van Functionarissen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Functionarissen.aspx?VerenigingId=%Id%',title:'Details van Functionarissen', autoSize:false});" Title="Details van Functionarissen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Lidmaatschappen" runat="server" Text="Details bekijken van Lidmaatschappen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Lidmaatschappen.aspx?VerenigingId=%Id%',title:'Details van Lidmaatschappen', autoSize:false});" Title="Details van Lidmaatschappen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Bestuursorganen" runat="server" Text="Details bekijken van Bestuursorganen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Bestuursorganen.aspx?VerenigingId=%Id%',title:'Details van Bestuursorganen', autoSize:false});" Title="Details van Bestuursorganen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Addressen" runat="server" Text="Details bekijken van Addressen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Addressen.aspx?VerenigingId=%Id%',title:'Details van Addressen', autoSize:false});" Title="Details van Addressen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Afhangen" runat="server" Text="Details bekijken van Afhangen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Afhangen.aspx?VerenigingId=%Id%',title:'Details van Afhangen', autoSize:false});" Title="Details van Afhangen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Sponsoren" runat="server" Text="Details bekijken van Sponsoren" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Sponsoren.aspx?VerenigingId=%Id%',title:'Details van Sponsoren', autoSize:false});" Title="Details van Sponsoren"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Baanschemas" runat="server" Text="Details bekijken van Baanschemas" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Baanschemas.aspx?VerenigingId=%Id%',title:'Details van Baanschemas', autoSize:false});" Title="Details van Baanschemas"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Lidmaatschapsoorten" runat="server" Text="Details bekijken van Lidmaatschapsoorten" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Lidmaatschapsoorten.aspx?VerenigingId=%Id%',title:'Details van Lidmaatschapsoorten', autoSize:false});" Title="Details van Lidmaatschapsoorten"></SharePoint:MenuItemTemplate>
</SharePoint:MenuTemplate>
<asp:HyperLink ID="Vereniging_Insert" Text="Toevoegen" NavigateUrl="Vereniging_Insert.aspx"  runat="server" />
<br/>
<SharePoint:SPGridViewPager ID="spgvpager_top" GridViewId="Verenigingen_Grid" runat="server" />
<br />
<SharePoint:SPGridView 
    ID="Verenigingen_Grid" 
    runat="server"
    AllowPaging="true" 
    AllowSorting="true" 
    AutoGenerateColumns="false" 
    SelectMethod="SelectVerenigingen"
	OnCallingDataMethods="GridVerenigingen_CallingDataMethods"
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
			MenuTemplateId="VerenigingMenu"
			TokenNameAndValueFields="Id=Id"
			SortExpression="Naam"
			ItemStyle-Width="120px" />
	        <SharePoint:SPBoundField
            DataField="Beschrijving"
            HeaderText="Beschrijving"
            SortExpression="Beschrijving"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="BankNummer"
            HeaderText="BankNummer"
            SortExpression="BankNummer"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="BankIban"
            HeaderText="BankIban"
            SortExpression="BankIban"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="BankPlaats"
            HeaderText="BankPlaats"
            SortExpression="BankPlaats"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="KvKnummer"
            HeaderText="KvKnummer"
            SortExpression="KvKnummer"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="KvKplaats"
            HeaderText="KvKplaats"
            SortExpression="KvKplaats"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="EmailKNLTB"
            HeaderText="EmailKNLTB"
            SortExpression="EmailKNLTB"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="EmailWebSite"
            HeaderText="EmailWebSite"
            SortExpression="EmailWebSite"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="EmailOverig"
            HeaderText="EmailOverig"
            SortExpression="EmailOverig"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Fax"
            HeaderText="Fax"
            SortExpression="Fax"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="TelefoonAvond"
            HeaderText="TelefoonAvond"
            SortExpression="TelefoonAvond"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="TelefoonOverdag"
            HeaderText="TelefoonOverdag"
            SortExpression="TelefoonOverdag"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="TelefoonOverig"
            HeaderText="TelefoonOverig"
            SortExpression="TelefoonOverig"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Website"
            HeaderText="Website"
            SortExpression="Website"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="FTPsite"
            HeaderText="FTPsite"
            SortExpression="FTPsite"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Actief"
            HeaderText="Actief"
            SortExpression="Actief"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Oprichting"
            HeaderText="Oprichting"
            SortExpression="Oprichting"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Erkenning"
            HeaderText="Erkenning"
            SortExpression="Erkenning"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Gestopt"
            HeaderText="Gestopt"
            SortExpression="Gestopt"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Maanden"
            HeaderText="Maanden"
            SortExpression="Maanden"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Gewijzigd"
            HeaderText="Gewijzigd"
            SortExpression="Gewijzigd"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
    
		<asp:TemplateField HeaderText="Functionarissen" SortExpression="FunctionarisId">
			<ItemTemplate>
				<asp:Label ID="Functionarissen" runat="server" Text='<%# Bind("ClubCloud_Functionaris.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Lidmaatschappen" SortExpression="LidmaatschapId">
			<ItemTemplate>
				<asp:Label ID="Lidmaatschappen" runat="server" Text='<%# Bind("ClubCloud_Lidmaatschap.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Bestuursorganen" SortExpression="BestuursorgaanId">
			<ItemTemplate>
				<asp:Label ID="Bestuursorganen" runat="server" Text='<%# Bind("ClubCloud_Bestuursorgaan.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="District" SortExpression="DistrictId">
			<ItemTemplate>
				<asp:Label ID="District" runat="server" Text='<%# Bind("ClubCloud_District.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Rechtsvorm" SortExpression="RechtsvormId">
			<ItemTemplate>
				<asp:Label ID="Rechtsvorm" runat="server" Text='<%# Bind("ClubCloud_Rechtsvorm.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Addressen" SortExpression="AddressId">
			<ItemTemplate>
				<asp:Label ID="Addressen" runat="server" Text='<%# Bind("ClubCloud_Address.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Regio" SortExpression="RegioId">
			<ItemTemplate>
				<asp:Label ID="Regio" runat="server" Text='<%# Bind("ClubCloud_Regio.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Afhangen" SortExpression="AfhangId">
			<ItemTemplate>
				<asp:Label ID="Afhangen" runat="server" Text='<%# Bind("ClubCloud_Afhang.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Sponsoren" SortExpression="SponsorId">
			<ItemTemplate>
				<asp:Label ID="Sponsoren" runat="server" Text='<%# Bind("ClubCloud_Sponsor.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Baanschemas" SortExpression="BaanschemaId">
			<ItemTemplate>
				<asp:Label ID="Baanschemas" runat="server" Text='<%# Bind("ClubCloud_Baanschema.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Lidmaatschapsoorten" SortExpression="LidmaatschapsoortId">
			<ItemTemplate>
				<asp:Label ID="Lidmaatschapsoorten" runat="server" Text='<%# Bind("ClubCloud_Lidmaatschapsoort.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
    </Columns>
    <EmptyDataTemplate>
        <HeaderTemplate>
            <asp:HyperLink ID="Vereniging_Insert" Text="Toevoegen" NavigateUrl="Vereniging_Insert.aspx"  runat="server" /> <br/>
        </HeaderTemplate>
        <ItemTemplate>Er zijn geen gegevens gevonden.</ItemTemplate>
    </EmptyDataTemplate>        
</SharePoint:SPGridView >
<br />
<SharePoint:SPGridViewPager ID="spgvpager_bottom" GridViewId="Verenigingen_Grid" runat="server"/>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>



