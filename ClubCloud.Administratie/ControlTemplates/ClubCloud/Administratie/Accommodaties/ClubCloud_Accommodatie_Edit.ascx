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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Accommodatie_Edit.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Accommodatie_EditUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Accommodatie_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Accommodaties_View" />
<asp:CustomValidator ID="Accommodatie_Validator" Display="Dynamic" runat="server" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" ID="Accommodatie_Summary" />
<asp:FormView runat="server" ID="EditAccommodatieform" DefaultMode="Edit" RenderOuterTable="False" OnCallingDataMethods="EditAccommodatieform_CallingDataMethods" SelectMethod="SelectAccommodatie" UpdateMethod="UpdateAccommodatie" DataKeyNames="Id" OnItemUpdated="UpdateAccommodatieform_ItemUpdated">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Accommodatie gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Accommodatie beschikbaar voor dit Id.</div>
        <asp:LinkButton CssClass="button big" ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Accommodaties"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_top" runat="server" Text="Terug naar Accommodatie" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:LinkButton CssClass="button big" ID="btn_update_top" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_bottom" runat="server" Text="Terug naar Accommodatie" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:LinkButton CssClass="button big" ID="btn_update_bottom" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </FooterTemplate>
    <EditItemTemplate>
        <fieldset>
			<asp:HiddenField ID="Id" Value='<%# Bind("Id") %>' runat="server" />
			Naam : <asp:TextBox ID="Naam" runat="server" Text='<%# Bind("Naam") %>' TextMode="SingleLine"/></br>
			BanenAantal : <asp:TextBox ID="BanenAantal" runat="server" Text='<%# Bind("BanenAantal") %>' TextMode="Number" /></br>
			BanenAantalBinnen : <asp:TextBox ID="BanenAantalBinnen" runat="server" Text='<%# Bind("BanenAantalBinnen") %>' TextMode="Number" /></br>
			BanenAantalBuiten : <asp:TextBox ID="BanenAantalBuiten" runat="server" Text='<%# Bind("BanenAantalBuiten") %>' TextMode="Number" /></br>
			BlaashalSoort : <asp:TextBox ID="BlaashalSoort" runat="server" Text='<%# Bind("BlaashalSoort") %>' TextMode="SingleLine"/></br>
			Playgrounds : <asp:Checkbox ID="Playgrounds" runat="server" Checked='<%# Bind("Playgrounds") %>' /></br>
			PlaygroundsAantal : <asp:TextBox ID="PlaygroundsAantal" runat="server" Text='<%# Bind("PlaygroundsAantal") %>' TextMode="Number" /></br>
			Oefenmuren : <asp:Checkbox ID="Oefenmuren" runat="server" Checked='<%# Bind("Oefenmuren") %>' /></br>
			OefenmurenAantal : <asp:TextBox ID="OefenmurenAantal" runat="server" Text='<%# Bind("OefenmurenAantal") %>' TextMode="Number" /></br>
			Minibanen : <asp:Checkbox ID="Minibanen" runat="server" Checked='<%# Bind("Minibanen") %>' /></br>
			MinibanenAantal : <asp:TextBox ID="MinibanenAantal" runat="server" Text='<%# Bind("MinibanenAantal") %>' TextMode="Number" /></br>
			OverkappingSoort : <asp:TextBox ID="OverkappingSoort" runat="server" Text='<%# Bind("OverkappingSoort") %>' TextMode="SingleLine"/></br>
			AantalParkeerplaatsen : <asp:TextBox ID="AantalParkeerplaatsen" runat="server" Text='<%# Bind("AantalParkeerplaatsen") %>' TextMode="Number" /></br>
			AantalParkeerplaatsenMindervalide : <asp:TextBox ID="AantalParkeerplaatsenMindervalide" runat="server" Text='<%# Bind("AantalParkeerplaatsenMindervalide") %>' TextMode="Number" /></br>
			MetOVBereikbaar : <asp:Checkbox ID="MetOVBereikbaar" runat="server" Checked='<%# Bind("MetOVBereikbaar") %>' /></br>
			Email : <asp:TextBox ID="Email" runat="server" Text='<%# Bind("Email") %>' TextMode="Email" /></br>
			Telefoon : <asp:TextBox ID="Telefoon" runat="server" Text='<%# Bind("Telefoon") %>' TextMode="Phone" /></br>
			Website : <asp:TextBox ID="Website" runat="server" Text='<%# Bind("Website") %>' TextMode="SingleLine"/></br>
			ClubhuisStatus : <asp:TextBox ID="ClubhuisStatus" runat="server" Text='<%# Bind("ClubhuisStatus") %>' TextMode="SingleLine"/></br>
			ClubhuisBouwjaar : <asp:TextBox ID="ClubhuisBouwjaar" runat="server" Text='<%# Bind("ClubhuisBouwjaar") %>' TextMode="SingleLine"/></br>
			ClubhuisBouwaard : <asp:TextBox ID="ClubhuisBouwaard" runat="server" Text='<%# Bind("ClubhuisBouwaard") %>' TextMode="SingleLine"/></br>
			ClubhuisLigging : <asp:TextBox ID="ClubhuisLigging" runat="server" Text='<%# Bind("ClubhuisLigging") %>' TextMode="SingleLine"/></br>
			ClubhuisBeveiliging : <asp:TextBox ID="ClubhuisBeveiliging" runat="server" Text='<%# Bind("ClubhuisBeveiliging") %>' TextMode="SingleLine"/></br>
			HalStatus : <asp:TextBox ID="HalStatus" runat="server" Text='<%# Bind("HalStatus") %>' TextMode="SingleLine"/></br>
			HalBouwjaar : <asp:TextBox ID="HalBouwjaar" runat="server" Text='<%# Bind("HalBouwjaar") %>' TextMode="SingleLine"/></br>
			HalBouwaard : <asp:TextBox ID="HalBouwaard" runat="server" Text='<%# Bind("HalBouwaard") %>' TextMode="SingleLine"/></br>
			RolStoeltoegankelijk : <asp:Checkbox ID="RolStoeltoegankelijk" runat="server" Checked='<%# Bind("RolStoeltoegankelijk") %>' /></br>
			Speeltoestellen : <asp:TextBox ID="Speeltoestellen" runat="server" Text='<%# Bind("Speeltoestellen") %>' TextMode="SingleLine"/></br>
			WasruimteClubhuisAanwezig : <asp:Checkbox ID="WasruimteClubhuisAanwezig" runat="server" Checked='<%# Bind("WasruimteClubhuisAanwezig") %>' /></br>
			<asp:HiddenField ID="DistrictId" Value='<%# Bind("DistrictId") %>' runat="server" />
			<asp:HiddenField ID="RegioId" Value='<%# Bind("RegioId") %>' runat="server" />
			Actief : <asp:TextBox ID="Actief" runat="server" Text='<%# Bind("Actief") %>' TextMode="SingleLine"/></br>
			Gewijzigd : <asp:TextBox ID="Gewijzigd" runat="server" Text='<%# Bind("Gewijzigd") %>' TextMode="Date" /></br>
        </fieldset>
    </EditItemTemplate>
</asp:FormView>
