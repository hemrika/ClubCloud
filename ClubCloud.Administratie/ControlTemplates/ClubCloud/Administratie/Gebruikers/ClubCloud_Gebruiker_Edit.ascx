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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Gebruiker_Edit.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Gebruiker_EditUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Gebruiker_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Gebruikers_View" />
<asp:CustomValidator ID="Gebruiker_Validator" Display="Dynamic" runat="server" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" ID="Gebruiker_Summary" />
<asp:FormView runat="server" ID="EditGebruikerform" DefaultMode="Edit" RenderOuterTable="False" OnCallingDataMethods="EditGebruikerform_CallingDataMethods" SelectMethod="SelectGebruiker" UpdateMethod="UpdateGebruiker" DataKeyNames="Id" OnItemUpdated="UpdateGebruikerform_ItemUpdated">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Gebruiker gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Gebruiker beschikbaar voor dit Id.</div>
        <asp:LinkButton CssClass="button big" ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Gebruikers"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_top" runat="server" Text="Terug naar Gebruiker" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:LinkButton CssClass="button big" ID="btn_update_top" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_bottom" runat="server" Text="Terug naar Gebruiker" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:LinkButton CssClass="button big" ID="btn_update_bottom" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </FooterTemplate>
    <EditItemTemplate>
        <fieldset>
			<asp:HiddenField ID="Id" Value='<%# Bind("Id") %>' runat="server" />
			Beschrijving : <asp:TextBox ID="Beschrijving" runat="server" Text='<%# Bind("Beschrijving") %>' TextMode="MultiLine" /></br>
			Bondsnummer : <asp:TextBox ID="Bondsnummer" runat="server" Text='<%# Bind("Bondsnummer") %>' TextMode="Number" Enabled="false" /></br>
			Roepnaam : <asp:TextBox ID="Roepnaam" runat="server" Text='<%# Bind("Roepnaam") %>' TextMode="SingleLine"/></br>
			Aanhef : <asp:TextBox ID="Aanhef" runat="server" Text='<%# Bind("Aanhef") %>' TextMode="SingleLine"/></br>
			Voornaam : <asp:TextBox ID="Voornaam" runat="server" Text='<%# Bind("Voornaam") %>' TextMode="SingleLine"/></br>
			Voornamen : <asp:TextBox ID="Voornamen" runat="server" Text='<%# Bind("Voornamen") %>' TextMode="SingleLine"/></br>
			Achtervoegsel : <asp:TextBox ID="Achtervoegsel" runat="server" Text='<%# Bind("Achtervoegsel") %>' TextMode="SingleLine"/></br>
			Tussenvoegsel : <asp:TextBox ID="Tussenvoegsel" runat="server" Text='<%# Bind("Tussenvoegsel") %>' TextMode="SingleLine"/></br>
			Achternaam : <asp:TextBox ID="Achternaam" runat="server" Text='<%# Bind("Achternaam") %>' TextMode="SingleLine"/></br>
			Voorletters : <asp:TextBox ID="Voorletters" runat="server" Text='<%# Bind("Voorletters") %>' TextMode="SingleLine"/></br>
			EmailGeheim : <asp:Checkbox ID="EmailGeheim" runat="server" Checked='<%# Bind("EmailGeheim") %>' /></br>
			EmailKNLTB : <asp:TextBox ID="EmailKNLTB" runat="server" Text='<%# Bind("EmailKNLTB") %>' TextMode="Email" /></br>
			EmailWebSite : <asp:TextBox ID="EmailWebSite" runat="server" Text='<%# Bind("EmailWebSite") %>' TextMode="Email" /></br>
			EmailOverig : <asp:TextBox ID="EmailOverig" runat="server" Text='<%# Bind("EmailOverig") %>' TextMode="Email" /></br>
			TelefoonGeheim : <asp:Checkbox ID="TelefoonGeheim" runat="server" Checked='<%# Bind("TelefoonGeheim") %>' /></br>
			TelefoonAvond : <asp:TextBox ID="TelefoonAvond" runat="server" Text='<%# Bind("TelefoonAvond") %>' TextMode="Phone" /></br>
			TelefoonOverdag : <asp:TextBox ID="TelefoonOverdag" runat="server" Text='<%# Bind("TelefoonOverdag") %>' TextMode="Phone" /></br>
			TelefoonOverig : <asp:TextBox ID="TelefoonOverig" runat="server" Text='<%# Bind("TelefoonOverig") %>' TextMode="Phone" /></br>
			Mobiel : <asp:TextBox ID="Mobiel" runat="server" Text='<%# Bind("Mobiel") %>' TextMode="Phone" /></br>
			Fax : <asp:TextBox ID="Fax" runat="server" Text='<%# Bind("Fax") %>' TextMode="Phone" /></br>
			BankNummer : <asp:TextBox ID="BankNummer" runat="server" Text='<%# Bind("BankNummer") %>' TextMode="Number" Enabled="false" /></br>
			BankIban : <asp:TextBox ID="BankIban" runat="server" Text='<%# Bind("BankIban") %>' TextMode="SingleLine"/></br>
			BankPlaats : <asp:TextBox ID="BankPlaats" runat="server" Text='<%# Bind("BankPlaats") %>' TextMode="SingleLine"/></br>
			Geboortedatum : <asp:TextBox ID="Geboortedatum" runat="server" Text='<%# Bind("Geboortedatum") %>' TextMode="Date" /></br>
			Geboorteplaats : <asp:TextBox ID="Geboorteplaats" runat="server" Text='<%# Bind("Geboorteplaats") %>' TextMode="SingleLine"/></br>
			OverlijdensDatum : <asp:TextBox ID="OverlijdensDatum" runat="server" Text='<%# Bind("OverlijdensDatum") %>' TextMode="Date" /></br>
			AddressGeheim : <asp:Checkbox ID="AddressGeheim" runat="server" Checked='<%# Bind("AddressGeheim") %>' /></br>
            Nationaliteit : <asp:DropDownList ID="NationaliteitId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("NationaliteitId") %>' SelectMethod="SelectNationaliteit" OnCallingDataMethods="EditGebruikerform_CallingDataMethods" /></br>
			Website : <asp:TextBox ID="Website" runat="server" Text='<%# Bind("Website") %>' TextMode="SingleLine"/></br>
			FTPsite : <asp:TextBox ID="FTPsite" runat="server" Text='<%# Bind("FTPsite") %>' TextMode="SingleLine"/></br>
			Actief : <asp:DropDownList ID="Actief" runat="server" DataTextField="Value" DataValueField="Value" SelectedValue='<%# Bind("Actief") %>' SelectMethod="SelectActief" OnCallingDataMethods="EditGebruikerform_CallingDataMethods" /></br>
			Beroep : <asp:TextBox ID="Beroep" runat="server" Text='<%# Bind("Beroep") %>' TextMode="SingleLine"/></br>
			Kinderen : <asp:Checkbox ID="Kinderen" runat="server" Checked='<%# Bind("Kinderen") %>' /></br>
			KinderenAantal : <asp:TextBox ID="KinderenAantal" runat="server" Text='<%# Bind("KinderenAantal") %>' TextMode="Number" /></br>
			Partner : <asp:TextBox ID="Partner" runat="server" Text='<%# Bind("Partner") %>' TextMode="SingleLine"/></br>
			AanhefBrief : <asp:TextBox ID="AanhefBrief" runat="server" Text='<%# Bind("AanhefBrief") %>' TextMode="SingleLine"/></br>
			AanhefAttentie : <asp:TextBox ID="AanhefAttentie" runat="server" Text='<%# Bind("AanhefAttentie") %>' TextMode="SingleLine"/></br>
			FotoId : <asp:TextBox ID="FotoId" runat="server" Text='<%# Bind("FotoId") %>' TextMode="Number" /></br>
			<asp:HiddenField ID="VerenigingId" Value='<%# Bind("VerenigingId") %>' runat="server" />
			Volledigenaam : <asp:TextBox ID="Volledigenaam" runat="server" Text='<%# Bind("Volledigenaam") %>' TextMode="SingleLine"/></br>
			Geslacht : <asp:DropDownList ID="Geslacht" runat="server" DataTextField="Value" DataValueField="Value" SelectedValue='<%# Bind("Geslacht") %>' SelectMethod="SelectGeslacht" OnCallingDataMethods="EditGebruikerform_CallingDataMethods" /></br>
			Gewijzigd : <asp:TextBox ID="Gewijzigd" runat="server" Text='<%# Bind("Gewijzigd") %>' TextMode="Date" /></br>
        </fieldset>
    </EditItemTemplate>
</asp:FormView>
