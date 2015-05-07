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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Accommodatie.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_AccommodatieUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Accommodatie_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Accommodaties_View" />
<asp:FormView runat="server" ID="SelectAccommodatieform" DefaultMode="ReadOnly" RenderOuterTable="False" OnCallingDataMethods="SelectAccommodatieform_CallingDataMethods" SelectMethod="SelectAccommodatie" DataKeyNames="Id" >
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Accommodatie gevonden
		</h1>
        <div class="notice">
            Sorry, er is geen  Accommodatie beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Accommodaties" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center"/>
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <HeaderTemplate>
	<span style="display:inline-block;" >
		<asp:LinkButton CssClass="button big"  ID="btn_goback_top" runat="server" Text="Terug naar Accommodaties" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
        <asp:LinkButton CssClass="button big"  ID="btn_edit_top" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/></br>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Baanblokken.aspx?AccommodatieId=<%# Eval("Id") %>', title:'Baanblokken van <%# Eval("Naam") %>', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" href="#" target="_self" title="Baanblokken" >Baanblokken</a>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Banen.aspx?AccommodatieId=<%# Eval("Id") %>', title:'Banen van <%# Eval("Naam") %>', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" href="#" target="_self" title="Banen" >Banen</a>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'BanenSpeciaal.aspx?AccommodatieId=<%# Eval("Id") %>', title:'BanenSpeciaal van <%# Eval("Naam") %>', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" href="#" target="_self" title="BanenSpeciaal" >BanenSpeciaal</a>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Addressen.aspx?AccommodatieId=<%# Eval("Id") %>', title:'Addressen van <%# Eval("Naam") %>', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" href="#" target="_self" title="Addressen" >Addressen</a>
	</span>
    </HeaderTemplate>
    <FooterTemplate>
		<asp:LinkButton CssClass="button big"  ID="btn_goback_bottom" runat="server" Text="Terug naar Accommodaties" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
		<asp:LinkButton CssClass="button big"  ID="btn_edit_bottom" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/>
    </FooterTemplate>
    <ItemTemplate>
        <fieldset>
			AantalParkeerplaatsen : <asp:Label ID="AantalParkeerplaatsen" runat="server" Text='<%# Eval("AantalParkeerplaatsen") %>' /></br>
			AantalParkeerplaatsenMindervalide : <asp:Label ID="AantalParkeerplaatsenMindervalide" runat="server" Text='<%# Eval("AantalParkeerplaatsenMindervalide") %>' /></br>
			Actief : <asp:Label ID="Actief" runat="server" Text='<%# Eval("Actief") %>' /></br>
			BanenAantal : <asp:Label ID="BanenAantal" runat="server" Text='<%# Eval("BanenAantal") %>' /></br>
			BanenAantalBinnen : <asp:Label ID="BanenAantalBinnen" runat="server" Text='<%# Eval("BanenAantalBinnen") %>' /></br>
			BanenAantalBuiten : <asp:Label ID="BanenAantalBuiten" runat="server" Text='<%# Eval("BanenAantalBuiten") %>' /></br>
			Blaashal : <asp:Label ID="Blaashal" runat="server" Text='<%# Eval("Blaashal") %>' /></br>
			BlaashalAantalBanen : <asp:Label ID="BlaashalAantalBanen" runat="server" Text='<%# Eval("BlaashalAantalBanen") %>' /></br>
			BlaashalSoort : <asp:Label ID="BlaashalSoort" runat="server" Text='<%# Eval("BlaashalSoort") %>' /></br>
			ClubhuisBeveiliging : <asp:Label ID="ClubhuisBeveiliging" runat="server" Text='<%# Eval("ClubhuisBeveiliging") %>' /></br>
			ClubhuisBouwaard : <asp:Label ID="ClubhuisBouwaard" runat="server" Text='<%# Eval("ClubhuisBouwaard") %>' /></br>
			ClubhuisBouwjaar : <asp:Label ID="ClubhuisBouwjaar" runat="server" Text='<%# Eval("ClubhuisBouwjaar") %>' /></br>
			ClubhuisLigging : <asp:Label ID="ClubhuisLigging" runat="server" Text='<%# Eval("ClubhuisLigging") %>' /></br>
			ClubhuisOppervlakte : <asp:Label ID="ClubhuisOppervlakte" runat="server" Text='<%# Eval("ClubhuisOppervlakte") %>' /></br>
			ClubhuisStatus : <asp:Label ID="ClubhuisStatus" runat="server" Text='<%# Eval("ClubhuisStatus") %>' /></br>
			Email : <asp:Label ID="Email" runat="server" Text='<%# Eval("Email") %>' /></br>
			Gewijzigd : <asp:Label ID="Gewijzigd" runat="server" Text='<%# Eval("Gewijzigd") %>' /></br>
			HalBouwaard : <asp:Label ID="HalBouwaard" runat="server" Text='<%# Eval("HalBouwaard") %>' /></br>
			HalBouwjaar : <asp:Label ID="HalBouwjaar" runat="server" Text='<%# Eval("HalBouwjaar") %>' /></br>
			HalOppervlakte : <asp:Label ID="HalOppervlakte" runat="server" Text='<%# Eval("HalOppervlakte") %>' /></br>
			HalStatus : <asp:Label ID="HalStatus" runat="server" Text='<%# Eval("HalStatus") %>' /></br>
			<asp:HiddenField ID="Id" Value='<%# Eval("Id") %>' runat="server" />
			MetOVBereikbaar : <asp:Label ID="MetOVBereikbaar" runat="server" Text='<%# Eval("MetOVBereikbaar") %>' /></br>
			Minibanen : <asp:Label ID="Minibanen" runat="server" Text='<%# Eval("Minibanen") %>' /></br>
			MinibanenAantal : <asp:Label ID="MinibanenAantal" runat="server" Text='<%# Eval("MinibanenAantal") %>' /></br>
			Naam : <asp:Label ID="Naam" runat="server" Text='<%# Eval("Naam") %>' /></br>
			Oefenmuren : <asp:Label ID="Oefenmuren" runat="server" Text='<%# Eval("Oefenmuren") %>' /></br>
			OefenmurenAantal : <asp:Label ID="OefenmurenAantal" runat="server" Text='<%# Eval("OefenmurenAantal") %>' /></br>
			Overkapping : <asp:Label ID="Overkapping" runat="server" Text='<%# Eval("Overkapping") %>' /></br>
			OverkappingSoort : <asp:Label ID="OverkappingSoort" runat="server" Text='<%# Eval("OverkappingSoort") %>' /></br>
			Playgrounds : <asp:Label ID="Playgrounds" runat="server" Text='<%# Eval("Playgrounds") %>' /></br>
			PlaygroundsAantal : <asp:Label ID="PlaygroundsAantal" runat="server" Text='<%# Eval("PlaygroundsAantal") %>' /></br>
			RolStoeltoegankelijk : <asp:Label ID="RolStoeltoegankelijk" runat="server" Text='<%# Eval("RolStoeltoegankelijk") %>' /></br>
			Speeltoestellen : <asp:Label ID="Speeltoestellen" runat="server" Text='<%# Eval("Speeltoestellen") %>' /></br>
			Telefoon : <asp:Label ID="Telefoon" runat="server" Text='<%# Eval("Telefoon") %>' /></br>
			TotaalAantalWasKleedruimte : <asp:Label ID="TotaalAantalWasKleedruimte" runat="server" Text='<%# Eval("TotaalAantalWasKleedruimte") %>' /></br>
			ValideParkeerplaatsen : <asp:Label ID="ValideParkeerplaatsen" runat="server" Text='<%# Eval("ValideParkeerplaatsen") %>' /></br>
			WasruimteClubhuisAanwezig : <asp:Label ID="WasruimteClubhuisAanwezig" runat="server" Text='<%# Eval("WasruimteClubhuisAanwezig") %>' /></br>
			Website : <asp:Label ID="Website" runat="server" Text='<%# Eval("Website") %>' /></br>
			District : <asp:Label runat="server" ID="District" Text='<%# Eval("ClubCloud_District.Naam") %>' /></br>
			Regio : <asp:Label runat="server" ID="Regio" Text='<%# Eval("ClubCloud_Regio.Naam") %>' /></br>
			Baanblokken : <asp:Label runat="server" ID="Baanblok" Text='<%# Eval("ClubCloud_Baanblok.Count") %>' /></br>		
			Banen : <asp:Label runat="server" ID="Baan" Text='<%# Eval("ClubCloud_Baan.Count") %>' /></br>		
			BanenSpeciaal : <asp:Label runat="server" ID="BaanSpeciaal" Text='<%# Eval("ClubCloud_BaanSpeciaal.Count") %>' /></br>		
			Addressen : <asp:Label runat="server" ID="Address" Text='<%# Eval("ClubCloud_Address.Count") %>' /></br>		
        </fieldset>
    </ItemTemplate>
</asp:FormView>
