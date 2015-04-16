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
            Geen Accommodatie gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Accommodatie beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Accommodaties"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <ItemTemplate>
        <fieldset>
            <h1 class="title-regular clearfix">
                <%# ((FormView)Container).CurrentMode == FormViewMode.ReadOnly ? " Accommodatie" : "" %>
            </h1>
			Naam : <asp:Label ID="Naam" runat="server" Text='<%# Eval("Naam") %>' /></br>
			BanenAantal : <asp:Label ID="BanenAantal" runat="server" Text='<%# Eval("BanenAantal") %>' /></br>
			BanenAantalBinnen : <asp:Label ID="BanenAantalBinnen" runat="server" Text='<%# Eval("BanenAantalBinnen") %>' /></br>
			BanenAantalBuiten : <asp:Label ID="BanenAantalBuiten" runat="server" Text='<%# Eval("BanenAantalBuiten") %>' /></br>
			Blaashal : <asp:Label ID="Blaashal" runat="server" Text='<%# Eval("Blaashal") %>' /></br>
			BlaashalSoort : <asp:Label ID="BlaashalSoort" runat="server" Text='<%# Eval("BlaashalSoort") %>' /></br>
			BlaashalAantalBanen : <asp:Label ID="BlaashalAantalBanen" runat="server" Text='<%# Eval("BlaashalAantalBanen") %>' /></br>
			Playgrounds : <asp:Label ID="Playgrounds" runat="server" Text='<%# Eval("Playgrounds") %>' /></br>
			PlaygroundsAantal : <asp:Label ID="PlaygroundsAantal" runat="server" Text='<%# Eval("PlaygroundsAantal") %>' /></br>
			Oefenmuren : <asp:Label ID="Oefenmuren" runat="server" Text='<%# Eval("Oefenmuren") %>' /></br>
			OefenmurenAantal : <asp:Label ID="OefenmurenAantal" runat="server" Text='<%# Eval("OefenmurenAantal") %>' /></br>
			Minibanen : <asp:Label ID="Minibanen" runat="server" Text='<%# Eval("Minibanen") %>' /></br>
			MinibanenAantal : <asp:Label ID="MinibanenAantal" runat="server" Text='<%# Eval("MinibanenAantal") %>' /></br>
			Overkapping : <asp:Label ID="Overkapping" runat="server" Text='<%# Eval("Overkapping") %>' /></br>
			OverkappingSoort : <asp:Label ID="OverkappingSoort" runat="server" Text='<%# Eval("OverkappingSoort") %>' /></br>
			AantalParkeerplaatsen : <asp:Label ID="AantalParkeerplaatsen" runat="server" Text='<%# Eval("AantalParkeerplaatsen") %>' /></br>
			AantalParkeerplaatsenMindervalide : <asp:Label ID="AantalParkeerplaatsenMindervalide" runat="server" Text='<%# Eval("AantalParkeerplaatsenMindervalide") %>' /></br>
			MetOVBereikbaar : <asp:Label ID="MetOVBereikbaar" runat="server" Text='<%# Eval("MetOVBereikbaar") %>' /></br>
			Email : <asp:Label ID="Email" runat="server" Text='<%# Eval("Email") %>' /></br>
			Telefoon : <asp:Label ID="Telefoon" runat="server" Text='<%# Eval("Telefoon") %>' /></br>
			Website : <asp:Label ID="Website" runat="server" Text='<%# Eval("Website") %>' /></br>
			ClubhuisStatus : <asp:Label ID="ClubhuisStatus" runat="server" Text='<%# Eval("ClubhuisStatus") %>' /></br>
			ClubhuisBouwjaar : <asp:Label ID="ClubhuisBouwjaar" runat="server" Text='<%# Eval("ClubhuisBouwjaar") %>' /></br>
			ClubhuisBouwaard : <asp:Label ID="ClubhuisBouwaard" runat="server" Text='<%# Eval("ClubhuisBouwaard") %>' /></br>
			ClubhuisOppervlakte : <asp:Label ID="ClubhuisOppervlakte" runat="server" Text='<%# Eval("ClubhuisOppervlakte") %>' /></br>
			ClubhuisLigging : <asp:Label ID="ClubhuisLigging" runat="server" Text='<%# Eval("ClubhuisLigging") %>' /></br>
			ClubhuisBeveiliging : <asp:Label ID="ClubhuisBeveiliging" runat="server" Text='<%# Eval("ClubhuisBeveiliging") %>' /></br>
			HalStatus : <asp:Label ID="HalStatus" runat="server" Text='<%# Eval("HalStatus") %>' /></br>
			HalBouwjaar : <asp:Label ID="HalBouwjaar" runat="server" Text='<%# Eval("HalBouwjaar") %>' /></br>
			HalBouwaard : <asp:Label ID="HalBouwaard" runat="server" Text='<%# Eval("HalBouwaard") %>' /></br>
			HalOppervlakte : <asp:Label ID="HalOppervlakte" runat="server" Text='<%# Eval("HalOppervlakte") %>' /></br>
			RolStoeltoegankelijk : <asp:Label ID="RolStoeltoegankelijk" runat="server" Text='<%# Eval("RolStoeltoegankelijk") %>' /></br>
			Speeltoestellen : <asp:Label ID="Speeltoestellen" runat="server" Text='<%# Eval("Speeltoestellen") %>' /></br>
			TotaalAantalWasKleedruimte : <asp:Label ID="TotaalAantalWasKleedruimte" runat="server" Text='<%# Eval("TotaalAantalWasKleedruimte") %>' /></br>
			ValideParkeerplaatsen : <asp:Label ID="ValideParkeerplaatsen" runat="server" Text='<%# Eval("ValideParkeerplaatsen") %>' /></br>
			WasruimteClubhuisAanwezig : <asp:Label ID="WasruimteClubhuisAanwezig" runat="server" Text='<%# Eval("WasruimteClubhuisAanwezig") %>' /></br>
			Actief : <asp:Label ID="Actief" runat="server" Text='<%# Eval("Actief") %>' /></br>
			Gewijzigd : <asp:Label ID="Gewijzigd" runat="server" Text='<%# Eval("Gewijzigd") %>' /></br>

			Verenigingen : <a href="Verenigingen.aspx?AccommodatieId=<%# Eval("Id") %>" target="_self" title="Verenigingen" >Verenigingen</a></br>
			District : <a href="District.aspx?Id=<%# Eval("DistrictId") %>" target="_self" title="District" ><%# Eval("ClubCloud_District.Naam") %></a></br>
			Regio : <a href="Regio.aspx?Id=<%# Eval("RegioId") %>" target="_self" title="Regio" ><%# Eval("ClubCloud_Regio.Naam") %></a></br>
			Baanblokken : <a href="Baanblokken.aspx?AccommodatieId=<%# Eval("Id") %>" target="_self" title="Baanblokken" >Baanblokken</a></br>
			Banen : <a href="Banen.aspx?AccommodatieId=<%# Eval("Id") %>" target="_self" title="Banen" >Banen</a></br>
			BanenSpeciaal : <a href="BanenSpeciaal.aspx?AccommodatieId=<%# Eval("Id") %>" target="_self" title="BanenSpeciaal" >BanenSpeciaal</a></br>
			<%# Eval("ClubCloud_Address[0].Naam") %> : <a href="Address.aspx?Id=<%# Eval("ClubCloud_Address[0].Id") %>" target="_self" title="<%# Eval("ClubCloud_Address[0].Naam") %>" ><%# Eval("ClubCloud_Address[0].Naam") %></a></br>
			<%# Eval("ClubCloud_Address[1].Naam") %> : <a href="Address.aspx?Id=<%# Eval("ClubCloud_Address[1].Id") %>" target="_self" title="<%# Eval("ClubCloud_Address[1].Naam") %>" ><%# Eval("ClubCloud_Address[1].Naam") %></a></br>

		<asp:Button ID="btn_goback" runat="server" Text="Terug naar Accommodaties" CausesValidation="false" OnClick="GoBack"/>
		<asp:Button ID="btn_edit" runat="server" Text="Accommodatie bewerken" CausesValidation="false" OnClick="GoEdit"/>
        </fieldset>
    </ItemTemplate>
</asp:FormView>

