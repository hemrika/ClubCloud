<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Gebruiker.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_GebruikerUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Gebruiker_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Gebruikers_View" />
<asp:UpdatePanel ID="udp_profiel" runat="server" UpdateMode="Always">
    <contenttemplate>
<asp:FormView runat="server" ID="SelectGebruikerform" DefaultMode="ReadOnly" RenderOuterTable="False" OnCallingDataMethods="SelectGebruikerform_CallingDataMethods" SelectMethod="SelectGebruiker" DataKeyNames="Id" >
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Gebruiker gevonden
		</h1>
        <div class="notice">
            Sorry, er is geen  Gebruiker beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Gebruikers" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center"/>
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <HeaderTemplate>
	<span style="display:inline-block;" >
		<asp:LinkButton CssClass="button big"  ID="btn_goback_top" runat="server" Text="Terug" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
        <asp:LinkButton CssClass="button big"  ID="btn_edit_top" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/></br>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Functionarissen.aspx?GebruikerId=<%# Eval("Id") %>', title:'Functionarissen van <%# Eval("Volledigenaam") %>', autoSize:true});" href="#" target="_self" title="Functionarissen" >Functionarissen</a>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Lidmaatschappen.aspx?GebruikerId=<%# Eval("Id") %>', title:'Lidmaatschappen van <%# Eval("Volledigenaam") %>', autoSize:true});" href="#" target="_self" title="Lidmaatschappen" >Lidmaatschappen</a>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Addressen.aspx?GebruikerId=<%# Eval("Id") %>', title:'Addressen van <%# Eval("Volledigenaam") %>', autoSize:true});" href="#" target="_self" title="Addressen" >Addressen</a>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Profielen.aspx?GebruikerId=<%# Eval("Id") %>', title:'Profielen van <%# Eval("Volledigenaam") %>', autoSize:true});" href="#" target="_self" title="Profielen" >Profielen</a>
	</span>
    </HeaderTemplate>
    <FooterTemplate>
		<asp:LinkButton CssClass="button big"  ID="btn_goback_bottom" runat="server" Text="Terug " CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
		<asp:LinkButton CssClass="button big"  ID="btn_edit_bottom" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/>
    </FooterTemplate>
    <ItemTemplate>
        <fieldset>
			Aanhef : <asp:Label ID="Aanhef" runat="server" Text='<%# Eval("Aanhef") %>' /></br>
			AanhefAttentie : <asp:Label ID="AanhefAttentie" runat="server" Text='<%# Eval("AanhefAttentie") %>' /></br>
			AanhefBrief : <asp:Label ID="AanhefBrief" runat="server" Text='<%# Eval("AanhefBrief") %>' /></br>
			Achternaam : <asp:Label ID="Achternaam" runat="server" Text='<%# Eval("Achternaam") %>' /></br>
			Achtervoegsel : <asp:Label ID="Achtervoegsel" runat="server" Text='<%# Eval("Achtervoegsel") %>' /></br>
			Actief : <asp:Label ID="Actief" runat="server" Text='<%# Eval("Actief") %>' /></br>
			AddressGeheim : <asp:Label ID="AddressGeheim" runat="server" Text='<%# Eval("AddressGeheim") %>' /></br>
			BankIban : <asp:Label ID="BankIban" runat="server" Text='<%# Eval("BankIban") %>' /></br>
			BankNummer : <asp:Label ID="BankNummer" runat="server" Text='<%# Eval("BankNummer") %>' /></br>
			BankPlaats : <asp:Label ID="BankPlaats" runat="server" Text='<%# Eval("BankPlaats") %>' /></br>
			Beroep : <asp:Label ID="Beroep" runat="server" Text='<%# Eval("Beroep") %>' /></br>
			Beschrijving : <asp:Label ID="Beschrijving" runat="server" Text='<%# Eval("Beschrijving") %>' /></br>
			Bondsnummer : <asp:Label ID="Bondsnummer" runat="server" Text='<%# Eval("Bondsnummer") %>' /></br>
			EmailGeheim : <asp:Label ID="EmailGeheim" runat="server" Text='<%# Eval("EmailGeheim") %>' /></br>
			EmailKNLTB : <asp:Label ID="EmailKNLTB" runat="server" Text='<%# Eval("EmailKNLTB") %>' /></br>
			EmailOverig : <asp:Label ID="EmailOverig" runat="server" Text='<%# Eval("EmailOverig") %>' /></br>
			EmailWebSite : <asp:Label ID="EmailWebSite" runat="server" Text='<%# Eval("EmailWebSite") %>' /></br>
			Fax : <asp:Label ID="Fax" runat="server" Text='<%# Eval("Fax") %>' /></br>
			FotoId : <asp:Label ID="FotoId" runat="server" Text='<%# Eval("FotoId") %>' /></br>
			FTPsite : <asp:Label ID="FTPsite" runat="server" Text='<%# Eval("FTPsite") %>' /></br>
			Geboortedatum : <asp:Label ID="Geboortedatum" runat="server" Text='<%# Eval("Geboortedatum") %>' /></br>
			Geboorteplaats : <asp:Label ID="Geboorteplaats" runat="server" Text='<%# Eval("Geboorteplaats") %>' /></br>
			Geslacht : <asp:Label ID="Geslacht" runat="server" Text='<%# Eval("Geslacht") %>' /></br>
			Gewijzigd : <asp:Label ID="Gewijzigd" runat="server" Text='<%# Eval("Gewijzigd") %>' /></br>
			Kinderen : <asp:Label ID="Kinderen" runat="server" Text='<%# Eval("Kinderen") %>' /></br>
			KinderenAantal : <asp:Label ID="KinderenAantal" runat="server" Text='<%# Eval("KinderenAantal") %>' /></br>
			Mobiel : <asp:Label ID="Mobiel" runat="server" Text='<%# Eval("Mobiel") %>' /></br>
			OverlijdensDatum : <asp:Label ID="OverlijdensDatum" runat="server" Text='<%# Eval("OverlijdensDatum") %>' /></br>
			Partner : <asp:Label ID="Partner" runat="server" Text='<%# Eval("Partner") %>' /></br>
			Roepnaam : <asp:Label ID="Roepnaam" runat="server" Text='<%# Eval("Roepnaam") %>' /></br>
			TelefoonAvond : <asp:Label ID="TelefoonAvond" runat="server" Text='<%# Eval("TelefoonAvond") %>' /></br>
			TelefoonGeheim : <asp:Label ID="TelefoonGeheim" runat="server" Text='<%# Eval("TelefoonGeheim") %>' /></br>
			TelefoonOverdag : <asp:Label ID="TelefoonOverdag" runat="server" Text='<%# Eval("TelefoonOverdag") %>' /></br>
			TelefoonOverig : <asp:Label ID="TelefoonOverig" runat="server" Text='<%# Eval("TelefoonOverig") %>' /></br>
			Tussenvoegsel : <asp:Label ID="Tussenvoegsel" runat="server" Text='<%# Eval("Tussenvoegsel") %>' /></br>
			Volledigenaam : <asp:Label ID="Volledigenaam" runat="server" Text='<%# Eval("Volledigenaam") %>' /></br>
			Voorletters : <asp:Label ID="Voorletters" runat="server" Text='<%# Eval("Voorletters") %>' /></br>
			Voornaam : <asp:Label ID="Voornaam" runat="server" Text='<%# Eval("Voornaam") %>' /></br>
			Voornamen : <asp:Label ID="Voornamen" runat="server" Text='<%# Eval("Voornamen") %>' /></br>
			Website : <asp:Label ID="Website" runat="server" Text='<%# Eval("Website") %>' /></br>
			Functionarissen : <asp:Label runat="server" ID="Functionaris" Text='<%# Eval("ClubCloud_Functionaris.Count") %>' /></br>		
			Lidmaatschappen : <asp:Label runat="server" ID="Lidmaatschap" Text='<%# Eval("ClubCloud_Lidmaatschap.Count") %>' /></br>		
			Addressen : <asp:Label runat="server" ID="Address" Text='<%# Eval("ClubCloud_Address.Count") %>' /></br>		
			Vereniging : <asp:Label runat="server" ID="Vereniging" Text='<%# Eval("ClubCloud_Vereniging.Naam") %>' /></br>
			Profielen : <asp:Label runat="server" ID="Profiel" Text='<%# Eval("ClubCloud_Profiel.Count") %>' /></br>		
			Nationaliteit : <asp:Label runat="server" ID="Nationaliteit" Text='<%# Eval("ClubCloud_Nationaliteit.Naam") %>' /></br>
        </fieldset>
    </ItemTemplate>
</asp:FormView>
    </contenttemplate>
</asp:UpdatePanel>
