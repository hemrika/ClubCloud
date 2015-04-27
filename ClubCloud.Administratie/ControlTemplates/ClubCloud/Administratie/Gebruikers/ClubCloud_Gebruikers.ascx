
 
<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Gebruikers.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_GebruikersUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Gebruiker_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Gebruikers_View" />
<SharePoint:MenuTemplate ID="GebruikerMenu" runat="server">
	<SharePoint:MenuItemTemplate ID="Gebruiker_Details" runat="server" Text="Details bekijken van Gebruiker" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Gebruiker.aspx?Id=%Id%', title:'Details van Gebruiker', autoSize:false});" Title="Details van Gebruiker"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Functionarissen" runat="server" Text="Details bekijken van Functionarissen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Functionarissen.aspx?GebruikerId=%Id%',title:'Details van Functionarissen', autoSize:false});" Title="Details van Functionarissen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Lidmaatschappen" runat="server" Text="Details bekijken van Lidmaatschappen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Lidmaatschappen.aspx?GebruikerId=%Id%',title:'Details van Lidmaatschappen', autoSize:false});" Title="Details van Lidmaatschappen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Addressen" runat="server" Text="Details bekijken van Addressen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Addressen.aspx?GebruikerId=%Id%',title:'Details van Addressen', autoSize:false});" Title="Details van Addressen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Profielen" runat="server" Text="Details bekijken van Profielen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Profielen.aspx?GebruikerId=%Id%',title:'Details van Profielen', autoSize:false});" Title="Details van Profielen"></SharePoint:MenuItemTemplate>
</SharePoint:MenuTemplate>
<asp:HyperLink ID="Gebruiker_Insert" Text="Toevoegen" NavigateUrl="Gebruiker_Insert.aspx"  runat="server" />
<br/>
<SharePoint:SPGridViewPager ID="spgvpager_top" GridViewId="Gebruikers_Grid" runat="server" />
<br />
<SharePoint:SPGridView 
    ID="Gebruikers_Grid" 
    runat="server"
    AllowPaging="true" 
    AllowSorting="true" 
    AutoGenerateColumns="false" 
    SelectMethod="SelectGebruikers"
	OnCallingDataMethods="GridGebruikers_CallingDataMethods"
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
			HeaderText="Bondsnummer"
			TextFields="Bondsnummer"
			MenuTemplateId="GebruikerMenu"
			TokenNameAndValueFields="Id=Id"
			SortExpression="Bondsnummer"
			ItemStyle-Width="120px" />
	        <SharePoint:SPBoundField
            DataField="Beschrijving"
            HeaderText="Beschrijving"
            SortExpression="Beschrijving"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Roepnaam"
            HeaderText="Roepnaam"
            SortExpression="Roepnaam"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Aanhef"
            HeaderText="Aanhef"
            SortExpression="Aanhef"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Voornaam"
            HeaderText="Voornaam"
            SortExpression="Voornaam"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Voornamen"
            HeaderText="Voornamen"
            SortExpression="Voornamen"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Achtervoegsel"
            HeaderText="Achtervoegsel"
            SortExpression="Achtervoegsel"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Tussenvoegsel"
            HeaderText="Tussenvoegsel"
            SortExpression="Tussenvoegsel"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Achternaam"
            HeaderText="Achternaam"
            SortExpression="Achternaam"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Voorletters"
            HeaderText="Voorletters"
            SortExpression="Voorletters"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="EmailGeheim"
            HeaderText="EmailGeheim"
            SortExpression="EmailGeheim"
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
            DataField="TelefoonGeheim"
            HeaderText="TelefoonGeheim"
            SortExpression="TelefoonGeheim"
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
            DataField="Mobiel"
            HeaderText="Mobiel"
            SortExpression="Mobiel"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Fax"
            HeaderText="Fax"
            SortExpression="Fax"
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
            DataField="Geboortedatum"
            HeaderText="Geboortedatum"
            SortExpression="Geboortedatum"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Geboorteplaats"
            HeaderText="Geboorteplaats"
            SortExpression="Geboorteplaats"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="OverlijdensDatum"
            HeaderText="OverlijdensDatum"
            SortExpression="OverlijdensDatum"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="AddressGeheim"
            HeaderText="AddressGeheim"
            SortExpression="AddressGeheim"
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
            DataField="Beroep"
            HeaderText="Beroep"
            SortExpression="Beroep"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Kinderen"
            HeaderText="Kinderen"
            SortExpression="Kinderen"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="KinderenAantal"
            HeaderText="KinderenAantal"
            SortExpression="KinderenAantal"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Partner"
            HeaderText="Partner"
            SortExpression="Partner"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="AanhefBrief"
            HeaderText="AanhefBrief"
            SortExpression="AanhefBrief"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="AanhefAttentie"
            HeaderText="AanhefAttentie"
            SortExpression="AanhefAttentie"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="FotoId"
            HeaderText="FotoId"
            SortExpression="FotoId"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Volledigenaam"
            HeaderText="Volledigenaam"
            SortExpression="Volledigenaam"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Geslacht"
            HeaderText="Geslacht"
            SortExpression="Geslacht"
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
		<asp:TemplateField HeaderText="Addressen" SortExpression="AddressId">
			<ItemTemplate>
				<asp:Label ID="Addressen" runat="server" Text='<%# Bind("ClubCloud_Address.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Profielen" SortExpression="ProfielId">
			<ItemTemplate>
				<asp:Label ID="Profielen" runat="server" Text='<%# Bind("ClubCloud_Profiel.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Nationaliteit" SortExpression="NationaliteitId">
			<ItemTemplate>
				<asp:Label ID="Nationaliteit" runat="server" Text='<%# Bind("ClubCloud_Nationaliteit.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
    </Columns>
    <EmptyDataTemplate>
        <HeaderTemplate>
            <asp:HyperLink ID="Gebruiker_Insert" Text="Toevoegen" NavigateUrl="Gebruiker_Insert.aspx"  runat="server" /> <br/>
        </HeaderTemplate>
        <ItemTemplate>Er zijn geen gegevens gevonden.</ItemTemplate>
    </EmptyDataTemplate>        
</SharePoint:SPGridView >
<br />
<SharePoint:SPGridViewPager ID="spgvpager_bottom" GridViewId="Gebruikers_Grid" runat="server"/>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>



