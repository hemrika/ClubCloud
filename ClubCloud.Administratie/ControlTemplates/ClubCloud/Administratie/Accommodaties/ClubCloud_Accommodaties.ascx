
 
<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Accommodaties.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_AccommodatiesUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Accommodatie_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Accommodaties_View" />
<SharePoint:MenuTemplate ID="AccommodatieMenu" runat="server">
	<SharePoint:MenuItemTemplate ID="Accommodatie_Details" runat="server" Text="Details bekijken van Accommodatie" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Accommodatie.aspx?Id=%Id%', title:'Details van Accommodatie', autoSize:false});" Title="Details van Accommodatie"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Baanblokken" runat="server" Text="Details bekijken van Baanblokken" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Baanblokken.aspx?AccommodatieId=%Id%',title:'Details van Baanblokken', autoSize:false});" Title="Details van Baanblokken"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Banen" runat="server" Text="Details bekijken van Banen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Banen.aspx?AccommodatieId=%Id%',title:'Details van Banen', autoSize:false});" Title="Details van Banen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="BanenSpeciaal" runat="server" Text="Details bekijken van BanenSpeciaal" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'BanenSpeciaal.aspx?AccommodatieId=%Id%',title:'Details van BanenSpeciaal', autoSize:false});" Title="Details van BanenSpeciaal"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Addressen" runat="server" Text="Details bekijken van Addressen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Addressen.aspx?AccommodatieId=%Id%',title:'Details van Addressen', autoSize:false});" Title="Details van Addressen"></SharePoint:MenuItemTemplate>
</SharePoint:MenuTemplate>
<asp:HyperLink ID="Accommodatie_Insert" Text="Toevoegen" NavigateUrl="Accommodatie_Insert.aspx"  runat="server" />
<br/>
<SharePoint:SPGridViewPager ID="spgvpager_top" GridViewId="Accommodaties_Grid" runat="server" />
<br />
<SharePoint:SPGridView 
    ID="Accommodaties_Grid" 
    runat="server"
    AllowPaging="true" 
    AllowSorting="true" 
    AutoGenerateColumns="false" 
    SelectMethod="SelectAccommodaties"
	OnCallingDataMethods="GridAccommodaties_CallingDataMethods"
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
			MenuTemplateId="AccommodatieMenu"
			TokenNameAndValueFields="Id=Id"
			SortExpression="Naam"
			ItemStyle-Width="120px" />
	        <SharePoint:SPBoundField
            DataField="BanenAantal"
            HeaderText="BanenAantal"
            SortExpression="BanenAantal"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="BanenAantalBinnen"
            HeaderText="BanenAantalBinnen"
            SortExpression="BanenAantalBinnen"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="BanenAantalBuiten"
            HeaderText="BanenAantalBuiten"
            SortExpression="BanenAantalBuiten"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Blaashal"
            HeaderText="Blaashal"
            SortExpression="Blaashal"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="BlaashalSoort"
            HeaderText="BlaashalSoort"
            SortExpression="BlaashalSoort"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="BlaashalAantalBanen"
            HeaderText="BlaashalAantalBanen"
            SortExpression="BlaashalAantalBanen"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Playgrounds"
            HeaderText="Playgrounds"
            SortExpression="Playgrounds"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="PlaygroundsAantal"
            HeaderText="PlaygroundsAantal"
            SortExpression="PlaygroundsAantal"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Oefenmuren"
            HeaderText="Oefenmuren"
            SortExpression="Oefenmuren"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="OefenmurenAantal"
            HeaderText="OefenmurenAantal"
            SortExpression="OefenmurenAantal"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Minibanen"
            HeaderText="Minibanen"
            SortExpression="Minibanen"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="MinibanenAantal"
            HeaderText="MinibanenAantal"
            SortExpression="MinibanenAantal"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Overkapping"
            HeaderText="Overkapping"
            SortExpression="Overkapping"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="OverkappingSoort"
            HeaderText="OverkappingSoort"
            SortExpression="OverkappingSoort"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="AantalParkeerplaatsen"
            HeaderText="AantalParkeerplaatsen"
            SortExpression="AantalParkeerplaatsen"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="AantalParkeerplaatsenMindervalide"
            HeaderText="AantalParkeerplaatsenMindervalide"
            SortExpression="AantalParkeerplaatsenMindervalide"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="MetOVBereikbaar"
            HeaderText="MetOVBereikbaar"
            SortExpression="MetOVBereikbaar"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Email"
            HeaderText="Email"
            SortExpression="Email"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Telefoon"
            HeaderText="Telefoon"
            SortExpression="Telefoon"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Website"
            HeaderText="Website"
            SortExpression="Website"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="ClubhuisStatus"
            HeaderText="ClubhuisStatus"
            SortExpression="ClubhuisStatus"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="ClubhuisBouwjaar"
            HeaderText="ClubhuisBouwjaar"
            SortExpression="ClubhuisBouwjaar"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="ClubhuisBouwaard"
            HeaderText="ClubhuisBouwaard"
            SortExpression="ClubhuisBouwaard"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="ClubhuisOppervlakte"
            HeaderText="ClubhuisOppervlakte"
            SortExpression="ClubhuisOppervlakte"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="ClubhuisLigging"
            HeaderText="ClubhuisLigging"
            SortExpression="ClubhuisLigging"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="ClubhuisBeveiliging"
            HeaderText="ClubhuisBeveiliging"
            SortExpression="ClubhuisBeveiliging"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="HalStatus"
            HeaderText="HalStatus"
            SortExpression="HalStatus"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="HalBouwjaar"
            HeaderText="HalBouwjaar"
            SortExpression="HalBouwjaar"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="HalBouwaard"
            HeaderText="HalBouwaard"
            SortExpression="HalBouwaard"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="HalOppervlakte"
            HeaderText="HalOppervlakte"
            SortExpression="HalOppervlakte"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="RolStoeltoegankelijk"
            HeaderText="RolStoeltoegankelijk"
            SortExpression="RolStoeltoegankelijk"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Speeltoestellen"
            HeaderText="Speeltoestellen"
            SortExpression="Speeltoestellen"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="TotaalAantalWasKleedruimte"
            HeaderText="TotaalAantalWasKleedruimte"
            SortExpression="TotaalAantalWasKleedruimte"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="ValideParkeerplaatsen"
            HeaderText="ValideParkeerplaatsen"
            SortExpression="ValideParkeerplaatsen"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="WasruimteClubhuisAanwezig"
            HeaderText="WasruimteClubhuisAanwezig"
            SortExpression="WasruimteClubhuisAanwezig"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Actief"
            HeaderText="Actief"
            SortExpression="Actief"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Gewijzigd"
            HeaderText="Gewijzigd"
            SortExpression="Gewijzigd"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
    
		<asp:TemplateField HeaderText="District" SortExpression="DistrictId">
			<ItemTemplate>
				<asp:Label ID="District" runat="server" Text='<%# Bind("ClubCloud_District.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Regio" SortExpression="RegioId">
			<ItemTemplate>
				<asp:Label ID="Regio" runat="server" Text='<%# Bind("ClubCloud_Regio.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Baanblokken" SortExpression="BaanblokId">
			<ItemTemplate>
				<asp:Label ID="Baanblokken" runat="server" Text='<%# Bind("ClubCloud_Baanblok.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Banen" SortExpression="BaanId">
			<ItemTemplate>
				<asp:Label ID="Banen" runat="server" Text='<%# Bind("ClubCloud_Baan.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="BanenSpeciaal" SortExpression="BaanSpeciaalId">
			<ItemTemplate>
				<asp:Label ID="BanenSpeciaal" runat="server" Text='<%# Bind("ClubCloud_BaanSpeciaal.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Addressen" SortExpression="AddressId">
			<ItemTemplate>
				<asp:Label ID="Addressen" runat="server" Text='<%# Bind("ClubCloud_Address.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
    </Columns>
    <EmptyDataTemplate>
        <HeaderTemplate>
            <asp:HyperLink ID="Accommodatie_Insert" Text="Toevoegen" NavigateUrl="Accommodatie_Insert.aspx"  runat="server" /> <br/>
        </HeaderTemplate>
        <ItemTemplate>Er zijn geen gegevens gevonden.</ItemTemplate>
    </EmptyDataTemplate>        
</SharePoint:SPGridView >
<br />
<SharePoint:SPGridViewPager ID="spgvpager_bottom" GridViewId="Accommodaties_Grid" runat="server"/>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>



