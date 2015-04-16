<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Gebruiker.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_GebruikerUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Gebruiker_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Gebruikers_View" />
<asp:FormView runat="server" ID="SelectGebruikerform" DefaultMode="ReadOnly" RenderOuterTable="False" OnCallingDataMethods="SelectGebruikerform_CallingDataMethods" SelectMethod="SelectGebruiker" DataKeyNames="Id" >
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Gebruiker gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Gebruiker beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Gebruikers"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <ItemTemplate>
        <fieldset>
            <h1 class="title-regular clearfix">
                <%# ((FormView)Container).CurrentMode == FormViewMode.ReadOnly ? " Gebruiker" : "" %>
            </h1>
			Beschrijving : <asp:Label ID="Beschrijving" runat="server" Text='<%# Eval("Beschrijving") %>' /></br>
			Bondsnummer : <asp:Label ID="Bondsnummer" runat="server" Text='<%# Eval("Bondsnummer") %>' /></br>
			Roepnaam : <asp:Label ID="Roepnaam" runat="server" Text='<%# Eval("Roepnaam") %>' /></br>
			Aanhef : <asp:Label ID="Aanhef" runat="server" Text='<%# Eval("Aanhef") %>' /></br>
			Voornaam : <asp:Label ID="Voornaam" runat="server" Text='<%# Eval("Voornaam") %>' /></br>
			Voornamen : <asp:Label ID="Voornamen" runat="server" Text='<%# Eval("Voornamen") %>' /></br>
			Achtervoegsel : <asp:Label ID="Achtervoegsel" runat="server" Text='<%# Eval("Achtervoegsel") %>' /></br>
			Tussenvoegsel : <asp:Label ID="Tussenvoegsel" runat="server" Text='<%# Eval("Tussenvoegsel") %>' /></br>
			Achternaam : <asp:Label ID="Achternaam" runat="server" Text='<%# Eval("Achternaam") %>' /></br>
			Voorletters : <asp:Label ID="Voorletters" runat="server" Text='<%# Eval("Voorletters") %>' /></br>
			EmailGeheim : <asp:Label ID="EmailGeheim" runat="server" Text='<%# Eval("EmailGeheim") %>' /></br>
			EmailKNLTB : <asp:Label ID="EmailKNLTB" runat="server" Text='<%# Eval("EmailKNLTB") %>' /></br>
			EmailWebSite : <asp:Label ID="EmailWebSite" runat="server" Text='<%# Eval("EmailWebSite") %>' /></br>
			EmailOverig : <asp:Label ID="EmailOverig" runat="server" Text='<%# Eval("EmailOverig") %>' /></br>
			TelefoonGeheim : <asp:Label ID="TelefoonGeheim" runat="server" Text='<%# Eval("TelefoonGeheim") %>' /></br>
			TelefoonAvond : <asp:Label ID="TelefoonAvond" runat="server" Text='<%# Eval("TelefoonAvond") %>' /></br>
			TelefoonOverdag : <asp:Label ID="TelefoonOverdag" runat="server" Text='<%# Eval("TelefoonOverdag") %>' /></br>
			TelefoonOverig : <asp:Label ID="TelefoonOverig" runat="server" Text='<%# Eval("TelefoonOverig") %>' /></br>
			Mobiel : <asp:Label ID="Mobiel" runat="server" Text='<%# Eval("Mobiel") %>' /></br>
			Fax : <asp:Label ID="Fax" runat="server" Text='<%# Eval("Fax") %>' /></br>
			BankNummer : <asp:Label ID="BankNummer" runat="server" Text='<%# Eval("BankNummer") %>' /></br>
			BankIban : <asp:Label ID="BankIban" runat="server" Text='<%# Eval("BankIban") %>' /></br>
			BankPlaats : <asp:Label ID="BankPlaats" runat="server" Text='<%# Eval("BankPlaats") %>' /></br>
			Geboortedatum : <asp:Label ID="Geboortedatum" runat="server" Text='<%# Eval("Geboortedatum") %>' /></br>
			Geboorteplaats : <asp:Label ID="Geboorteplaats" runat="server" Text='<%# Eval("Geboorteplaats") %>' /></br>
			OverlijdensDatum : <asp:Label ID="OverlijdensDatum" runat="server" Text='<%# Eval("OverlijdensDatum") %>' /></br>
			AddressGeheim : <asp:Label ID="AddressGeheim" runat="server" Text='<%# Eval("AddressGeheim") %>' /></br>
			Website : <asp:Label ID="Website" runat="server" Text='<%# Eval("Website") %>' /></br>
			FTPsite : <asp:Label ID="FTPsite" runat="server" Text='<%# Eval("FTPsite") %>' /></br>
			Actief : <asp:Label ID="Actief" runat="server" Text='<%# Eval("Actief") %>' /></br>
			Beroep : <asp:Label ID="Beroep" runat="server" Text='<%# Eval("Beroep") %>' /></br>
			Kinderen : <asp:Label ID="Kinderen" runat="server" Text='<%# Eval("Kinderen") %>' /></br>
			KinderenAantal : <asp:Label ID="KinderenAantal" runat="server" Text='<%# Eval("KinderenAantal") %>' /></br>
			Partner : <asp:Label ID="Partner" runat="server" Text='<%# Eval("Partner") %>' /></br>
			AanhefBrief : <asp:Label ID="AanhefBrief" runat="server" Text='<%# Eval("AanhefBrief") %>' /></br>
			AanhefAttentie : <asp:Label ID="AanhefAttentie" runat="server" Text='<%# Eval("AanhefAttentie") %>' /></br>
			FotoId : <asp:Label ID="FotoId" runat="server" Text='<%# Eval("FotoId") %>' /></br>
			Volledigenaam : <asp:Label ID="Volledigenaam" runat="server" Text='<%# Eval("Volledigenaam") %>' /></br>
			Geslacht : <asp:Label ID="Geslacht" runat="server" Text='<%# Eval("Geslacht") %>' /></br>
			Gewijzigd : <asp:Label ID="Gewijzigd" runat="server" Text='<%# Eval("Gewijzigd") %>' /></br>

			Functionarissen : <a href="Functionarissen.aspx?GebruikerId=<%# Eval("Id") %>" target="_self" title="Functionarissen" >Functionarissen</a></br>
			Lidmaatschappen : <a href="Lidmaatschappen.aspx?GebruikerId=<%# Eval("Id") %>" target="_self" title="Lidmaatschappen" >Lidmaatschappen</a></br>
			<%# Eval("ClubCloud_Address[0].Naam") %> : <a href="Address.aspx?Id=<%# Eval("ClubCloud_Address[0].Id") %>" target="_self" title="<%# Eval("ClubCloud_Address[0].Naam") %>" ><%# Eval("ClubCloud_Address[0].Naam") %></a></br>
			<%# Eval("ClubCloud_Address[1].Naam") %> : <a href="Address.aspx?Id=<%# Eval("ClubCloud_Address[1].Id") %>" target="_self" title="<%# Eval("ClubCloud_Address[1].Naam") %>" ><%# Eval("ClubCloud_Address[1].Naam") %></a></br>
			Vereniging : <a href="Vereniging.aspx?Id=<%# Eval("VerenigingId") %>" target="_self" title="Vereniging" ><%# Eval("ClubCloud_Vereniging.Naam") %></a></br>
			Settings : <a href="Settings.aspx?GebruikerId=<%# Eval("Id") %>" target="_self" title="Settings" >Settings</a></br>
			Nationaliteit : <a href="Nationaliteit.aspx?Id=<%# Eval("NationaliteitId") %>" target="_self" title="Nationaliteit" ><%# Eval("ClubCloud_Nationaliteit.Naam") %></a></br>

		<asp:Button ID="btn_goback" runat="server" Text="Terug naar Gebruikers" CausesValidation="false" OnClick="GoBack"/>
		<asp:Button ID="btn_edit" runat="server" Text="Gebruiker bewerken" CausesValidation="false" OnClick="GoEdit"/>
        </fieldset>
    </ItemTemplate>
</asp:FormView>

