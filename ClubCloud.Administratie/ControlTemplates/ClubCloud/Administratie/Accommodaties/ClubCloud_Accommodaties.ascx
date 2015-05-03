
 
<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Accommodaties.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_AccommodatiesUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Accommodatie_DataSource" runat="server" OnDataBinding="tmr_loader_Accommodaties_Tick" ViewName="ClubCloud_Accommodaties_View" />
<asp:UpdatePanel ID="udp_Accommodaties" runat="server" UpdateMode="Always">
    <contenttemplate>
		<asp:Timer runat="server" ID="tmr_loader_Accommodaties" OnTick="tmr_loader_Accommodaties_Tick" interval="500" />
<SharePoint:MenuTemplate ID="AccommodatieMenu" runat="server" LargeIconMode="true">
	<SharePoint:MenuItemTemplate ID="Accommodatie_Details" runat="server" Text="Details van %Naam%" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Accommodatie.aspx?Id=%Id%', title:'Details van %Naam%', autoSize:true});" Title="Details van %Naam%"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Baanblokken" runat="server" Text="Baanblokken" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Baanblokken.aspx?AccommodatieId=%Id%',title:'Baanblokken', autoSize:true});" Title="Baanblokken"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Banen" runat="server" Text="Banen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Banen.aspx?AccommodatieId=%Id%',title:'Banen', autoSize:true});" Title="Banen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="BanenSpeciaal" runat="server" Text="BanenSpeciaal" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'BanenSpeciaal.aspx?AccommodatieId=%Id%',title:'BanenSpeciaal', autoSize:true});" Title="BanenSpeciaal"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Addressen" runat="server" Text="Addressen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Addressen.aspx?AccommodatieId=%Id%',title:'Addressen', autoSize:true});" Title="Addressen"></SharePoint:MenuItemTemplate>
</SharePoint:MenuTemplate>
<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Accommodatie_Insert.aspx', title:'Toevoegen Accommodatie'});" href="#" target="_self" title="Toevoegen" >Toevoegen Accommodatie</a>
<br/>
<asp:panel runat="server" ID="pnl_Accommodaties" >
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
    ShowHeader="true"
	OnDataBinding="tmr_loader_Accommodaties_Tick" >
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <PagerSettings Mode="NextPreviousFirstLast" Visible="true" Position="TopAndBottom" PreviousPageText="vorige" NextPageText="volgende"  FirstPageText="Eerste" LastPageText="Laatste" PageButtonCount="5" />
    <PagerStyle HorizontalAlign="Center" VerticalAlign="Top" BackColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <Columns>
		<asp:TemplateField>
			<HeaderTemplate>
			    <asp:LinkButton ForeColor="White" ID="Naam_Sort" runat="server" Text="Naam" CommandName="Sort" CommandArgument="Naam"></asp:LinkButton>
			</HeaderTemplate>
			<ItemTemplate>
                <a id="<%# Eval("Naam") %>" title="<%# Eval("Naam") %>" name="<%# Eval("Naam") %>" onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Accommodatie.aspx?Id='+'<%# Eval("Id") %>', title:'Details van '+'<%# Eval("Naam") %>', autoSize:true});" style="white-space:nowrap;" href="#" >
                    <%# Eval("Naam") %>
                </a>
			</ItemTemplate>
		</asp:TemplateField>
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
				<asp:Label ID="ClubCloud_District" runat="server" Text='<%# Bind("ClubCloud_District.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Regio" SortExpression="RegioId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Regio" runat="server" Text='<%# Bind("ClubCloud_Regio.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Baanblokken" SortExpression="BaanblokId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Baanblok" runat="server" Text='<%# Bind("ClubCloud_Baanblok.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Banen" SortExpression="BaanId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Baan" runat="server" Text='<%# Bind("ClubCloud_Baan.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="BanenSpeciaal" SortExpression="BaanSpeciaalId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_BaanSpeciaal" runat="server" Text='<%# Bind("ClubCloud_BaanSpeciaal.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Addressen" SortExpression="AddressId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Address" runat="server" Text='<%# Bind("ClubCloud_Address.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
    </Columns>
    <EmptyDataTemplate>
        <ItemTemplate>Er zijn geen Accommodaties gevonden.</ItemTemplate>
    </EmptyDataTemplate>        
</SharePoint:SPGridView >
<br />
<SharePoint:SPGridViewPager ID="spgvpager_bottom" GridViewId="Accommodaties_Grid" runat="server"/>
</asp:panel>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>
    <triggers>
        <asp:AsyncPostBackTrigger ControlID="tmr_loader_Accommodaties" EventName="Tick" />
    </triggers>
    </contenttemplate>
</asp:UpdatePanel>
<asp:UpdateProgress ID="udp_Accommodaties_progress" runat="server" AssociatedUpdatePanelID="udp_Accommodaties" DisplayAfter="50">
    <progresstemplate>
        <div class="progess" style="position: absolute; background-color: #F9F9F9; top: 0px; left: 0px; width: 100%; height: 100%; opacity: 0.8; -moz-opacity: 0.8; filter: alpha(opacity=80); -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=80)"; z-index: 10000;">
        <div class="bubbles aligncenter" style="top:48%;">laden...</div>
        </div>
</progresstemplate>
</asp:UpdateProgress>



