
 
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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Gebruikers.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_GebruikersUserControl" %>
<asp:UpdateProgress ID="udp_Gebruikers_progress" runat="server" AssociatedUpdatePanelID="udp_Gebruikers" DisplayAfter="50">
    <progresstemplate>
        <div class="progess" style="position: absolute; background-color: #F9F9F9; top: 0px; left: 0px; width: 100%; height: 100%; opacity: 0.8; -moz-opacity: 0.8; filter: alpha(opacity=80); -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=80)"; z-index: 10000;">
        <div class="bubbles aligncenter" style="top:48%;">laden...</div>
        </div>
</progresstemplate>
</asp:UpdateProgress>
<!-- <asp:Timer runat="server" ID="tmr_loader_Gebruikers" OnTick="tmr_loader_Gebruikers_Tick" interval="500" /> -->
<Common:ClubCloudDataSource ID="ClubCloud_Gebruiker_DataSource" runat="server" OnDataBinding="tmr_loader_Gebruikers_Tick" ViewName="ClubCloud_Gebruikers_View" />
<asp:UpdatePanel ID="udp_Gebruikers" runat="server" UpdateMode="Conditional" RenderMode="Block" ChildrenAsTriggers="true" >
    <contenttemplate>
		
<SharePoint:MenuTemplate ID="GebruikerMenu" runat="server" LargeIconMode="true">
	<SharePoint:MenuItemTemplate ID="Gebruiker_Details" runat="server" Text="Details van %Naam%" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Gebruiker.aspx?Id=%Id%', title:'Details van %Naam%', autoSize:false});" Title="Details van %Naam%"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Functionarissen" runat="server" Text="Functionarissen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Functionarissen.aspx?GebruikerId=%Id%',title:'Functionarissen', autoSize:false, dialogReturnValueCallback:RefreshOnDialogClose});" Title="Functionarissen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Lidmaatschappen" runat="server" Text="Lidmaatschappen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Lidmaatschappen.aspx?GebruikerId=%Id%',title:'Lidmaatschappen', autoSize:false, dialogReturnValueCallback:RefreshOnDialogClose});" Title="Lidmaatschappen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Addressen" runat="server" Text="Addressen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Addressen.aspx?GebruikerId=%Id%',title:'Addressen', autoSize:false, dialogReturnValueCallback:RefreshOnDialogClose});" Title="Addressen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Profielen" runat="server" Text="Profielen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Profielen.aspx?GebruikerId=%Id%',title:'Profielen', autoSize:false, dialogReturnValueCallback:RefreshOnDialogClose});" Title="Profielen"></SharePoint:MenuItemTemplate>
</SharePoint:MenuTemplate>
<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Gebruiker_Insert.aspx', title:'Toevoegen Gebruiker',allowMaximize:false,showClose:true, autoSize:false, dialogReturnValueCallback:RefreshOnDialogClose});" href="#" target="_self" title="Toevoegen" >Toevoegen Gebruiker</a>
<br/>
<asp:panel runat="server" ID="pnl_Gebruikers" >
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
    ShowHeader="true"
	EnableViewState="false"
	ViewStateMode="Disabled"
	FilteredDataSourcePropertyFormat="{1} like '{0}'"
    FilteredDataSourcePropertyName="FilterExpression"
    FilteringIsCaseSensitive="false" >
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <PagerSettings Mode="NextPreviousFirstLast" Visible="true" Position="TopAndBottom" PreviousPageText="vorige" NextPageText="volgende"  FirstPageText="Eerste" LastPageText="Laatste" PageButtonCount="5" />
    <PagerStyle HorizontalAlign="Center" VerticalAlign="Top" BackColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <Columns>
		<asp:TemplateField>
			<HeaderTemplate>
			    <asp:LinkButton ForeColor="White" ID="Id_Sort" runat="server" Text="Bondsnummer" CommandName="Sort" CommandArgument="Bondsnummer"></asp:LinkButton>
			</HeaderTemplate>
			<ItemTemplate>
                <a id="<%# Eval("Id") %>" title="<%# Eval("Volledigenaam") %>" name="<%# Eval("Volledigenaam") %>" onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Gebruiker.aspx?Id='+'<%# Eval("Id") %>', title:'Details van '+'<%# Eval("Volledigenaam") %>', autoSize:false, dialogReturnValueCallback:RefreshOnDialogClose});" style="white-space:nowrap;" href="#" >
                    <%# Eval("Bondsnummer") %>
                </a>
			</ItemTemplate>
		</asp:TemplateField>
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
				<asp:Label ID="ClubCloud_Functionaris" runat="server" Text='<%# Bind("ClubCloud_Functionaris.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Lidmaatschappen" SortExpression="LidmaatschapId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Lidmaatschap" runat="server" Text='<%# Bind("ClubCloud_Lidmaatschap.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Addressen" SortExpression="AddressId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Address" runat="server" Text='<%# Bind("ClubCloud_Address.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Profielen" SortExpression="ProfielId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Profiel" runat="server" Text='<%# Bind("ClubCloud_Profiel.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Nationaliteit" SortExpression="NationaliteitId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Nationaliteit" runat="server" Text='<%# Bind("ClubCloud_Nationaliteit.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
    </Columns>
    <EmptyDataTemplate>
        <ItemTemplate>Er zijn geen Gebruikers gevonden.</ItemTemplate>
    </EmptyDataTemplate>        
</SharePoint:SPGridView >
<br />
<SharePoint:SPGridViewPager ID="spgvpager_bottom" GridViewId="Gebruikers_Grid" runat="server"/>
</asp:panel>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>
    <triggers>
        <asp:AsyncPostBackTrigger ControlID="tmr_loader_Gebruikers" EventName="Tick" />
    </triggers>
    </contenttemplate>
    <triggers>
        <asp:PostBackTrigger ControlID="spgvpager_top" />
        <asp:PostBackTrigger ControlID="spgvpager_bottom" />
        <asp:PostBackTrigger ControlID="Gebruikers_Grid" />
    </triggers>
</asp:UpdatePanel>



