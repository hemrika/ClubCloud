<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
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
		<asp:LinkButton ID="btn_goback_top" runat="server" Text="Terug" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
        <asp:LinkButton ID="btn_edit_top" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/>
		<a onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Baanblokken.aspx?AccommodatieId=<%# Eval("Id") %>'});" href="#" target="_self" title="Baanblokken" >Baanblokken</a>
		<a onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Banen.aspx?AccommodatieId=<%# Eval("Id") %>'});" href="#" target="_self" title="Banen" >Banen</a>
		<a onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'BanenSpeciaal.aspx?AccommodatieId=<%# Eval("Id") %>'});" href="#" target="_self" title="BanenSpeciaal" >BanenSpeciaal</a>
		<a onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Addressen.aspx?AccommodatieId=<%# Eval("Id") %>'});" href="#" target="_self" title="Addressen" >Addressen</a>
    </HeaderTemplate>
    <FooterTemplate>
		<asp:LinkButton ID="btn_goback_bottom" runat="server" Text="Terug " CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
		<asp:LinkButton ID="btn_edit_bottom" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/>
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
			District : <a href="District.aspx?Id=<%# Eval("DistrictId") %>" target="_self" title="District" ><%# Eval("ClubCloud_District.Naam") %></a></br>
			Regio : <a href="Regio.aspx?Id=<%# Eval("RegioId") %>" target="_self" title="Regio" ><%# Eval("ClubCloud_Regio.Naam") %></a></br>
		Baanblokken : <a onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Baanblokken.aspx?AccommodatieId=<%# Eval("Id") %>'});" href="#" target="_self" title="Baanblokken" >Baanblokken</a></br>			
		Banen : <a onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Banen.aspx?AccommodatieId=<%# Eval("Id") %>'});" href="#" target="_self" title="Banen" >Banen</a></br>			
		BanenSpeciaal : <a onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'BanenSpeciaal.aspx?AccommodatieId=<%# Eval("Id") %>'});" href="#" target="_self" title="BanenSpeciaal" >BanenSpeciaal</a></br>			
		Addressen : <a onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Addressen.aspx?AccommodatieId=<%# Eval("Id") %>'});" href="#" target="_self" title="Addressen" >Addressen</a></br>			
        </fieldset>
    </ItemTemplate>
</asp:FormView>
