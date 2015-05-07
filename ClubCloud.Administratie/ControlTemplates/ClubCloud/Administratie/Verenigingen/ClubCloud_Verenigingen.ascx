
 
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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Verenigingen.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_VerenigingenUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Vereniging_DataSource" runat="server" OnDataBinding="tmr_loader_Verenigingen_Tick" ViewName="ClubCloud_Verenigingen_View" />
<asp:UpdatePanel ID="udp_Verenigingen" runat="server" UpdateMode="Always">
    <contenttemplate>
		<asp:Timer runat="server" ID="tmr_loader_Verenigingen" OnTick="tmr_loader_Verenigingen_Tick" interval="500" />
<SharePoint:MenuTemplate ID="VerenigingMenu" runat="server" LargeIconMode="true">
	<SharePoint:MenuItemTemplate ID="Vereniging_Details" runat="server" Text="Details van %Naam%" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Vereniging.aspx?Id=%Id%', title:'Details van %Naam%', autoSize:true});" Title="Details van %Naam%"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Functionarissen" runat="server" Text="Functionarissen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Functionarissen.aspx?VerenigingId=%Id%',title:'Functionarissen', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" Title="Functionarissen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Lidmaatschappen" runat="server" Text="Lidmaatschappen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Lidmaatschappen.aspx?VerenigingId=%Id%',title:'Lidmaatschappen', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" Title="Lidmaatschappen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Bestuursorganen" runat="server" Text="Bestuursorganen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Bestuursorganen.aspx?VerenigingId=%Id%',title:'Bestuursorganen', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" Title="Bestuursorganen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Addressen" runat="server" Text="Addressen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Addressen.aspx?VerenigingId=%Id%',title:'Addressen', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" Title="Addressen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Afhangen" runat="server" Text="Afhangen" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Afhangen.aspx?VerenigingId=%Id%',title:'Afhangen', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" Title="Afhangen"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Sponsoren" runat="server" Text="Sponsoren" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Sponsoren.aspx?VerenigingId=%Id%',title:'Sponsoren', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" Title="Sponsoren"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Baanschemas" runat="server" Text="Baanschemas" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Baanschemas.aspx?VerenigingId=%Id%',title:'Baanschemas', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" Title="Baanschemas"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Lidmaatschapsoorten" runat="server" Text="Lidmaatschapsoorten" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Lidmaatschapsoorten.aspx?VerenigingId=%Id%',title:'Lidmaatschapsoorten', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" Title="Lidmaatschapsoorten"></SharePoint:MenuItemTemplate>
</SharePoint:MenuTemplate>
<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Vereniging_Insert.aspx', title:'Toevoegen Vereniging', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" href="#" target="_self" title="Toevoegen" >Toevoegen Vereniging</a>
<br/>
<asp:panel runat="server" ID="pnl_Verenigingen" >
<SharePoint:SPGridViewPager ID="spgvpager_top" GridViewId="Verenigingen_Grid" runat="server" />
<br />
<SharePoint:SPGridView 
    ID="Verenigingen_Grid" 
    runat="server"
    AllowPaging="true" 
    AllowSorting="true" 
    AutoGenerateColumns="false" 
    SelectMethod="SelectVerenigingen"
	OnCallingDataMethods="GridVerenigingen_CallingDataMethods"
    PageSize="30"
    ShowFooter="true"
    ShowHeader="true"
	EnableViewState="false"
	ViewStateMode="Disabled"
	OnDataBinding="tmr_loader_Verenigingen_Tick" >
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
                <a id="<%# Eval("Naam") %>" title="<%# Eval("Naam") %>" name="<%# Eval("Naam") %>" onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Vereniging.aspx?Id='+'<%# Eval("Id") %>', title:'Details van '+'<%# Eval("Naam") %>', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" style="white-space:nowrap;" href="#" >
                    <%# Eval("Naam") %>
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
            DataField="KvKnummer"
            HeaderText="KvKnummer"
            SortExpression="KvKnummer"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="KvKplaats"
            HeaderText="KvKplaats"
            SortExpression="KvKplaats"
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
            DataField="Fax"
            HeaderText="Fax"
            SortExpression="Fax"
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
            DataField="Oprichting"
            HeaderText="Oprichting"
            SortExpression="Oprichting"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Erkenning"
            HeaderText="Erkenning"
            SortExpression="Erkenning"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Gestopt"
            HeaderText="Gestopt"
            SortExpression="Gestopt"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Maanden"
            HeaderText="Maanden"
            SortExpression="Maanden"
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
		<asp:TemplateField HeaderText="Bestuursorganen" SortExpression="BestuursorgaanId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Bestuursorgaan" runat="server" Text='<%# Bind("ClubCloud_Bestuursorgaan.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="District" SortExpression="DistrictId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_District" runat="server" Text='<%# Bind("ClubCloud_District.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Rechtsvorm" SortExpression="RechtsvormId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Rechtsvorm" runat="server" Text='<%# Bind("ClubCloud_Rechtsvorm.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Addressen" SortExpression="AddressId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Address" runat="server" Text='<%# Bind("ClubCloud_Address.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Regio" SortExpression="RegioId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Regio" runat="server" Text='<%# Bind("ClubCloud_Regio.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Afhangen" SortExpression="AfhangId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Afhang" runat="server" Text='<%# Bind("ClubCloud_Afhang.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Sponsoren" SortExpression="SponsorId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Sponsor" runat="server" Text='<%# Bind("ClubCloud_Sponsor.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Baanschemas" SortExpression="BaanschemaId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Baanschema" runat="server" Text='<%# Bind("ClubCloud_Baanschema.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Lidmaatschapsoorten" SortExpression="LidmaatschapsoortId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Lidmaatschapsoort" runat="server" Text='<%# Bind("ClubCloud_Lidmaatschapsoort.Count") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
    </Columns>
    <EmptyDataTemplate>
        <ItemTemplate>Er zijn geen Verenigingen gevonden.</ItemTemplate>
    </EmptyDataTemplate>        
</SharePoint:SPGridView >
<br />
<SharePoint:SPGridViewPager ID="spgvpager_bottom" GridViewId="Verenigingen_Grid" runat="server"/>
</asp:panel>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>
    <triggers>
        <asp:AsyncPostBackTrigger ControlID="tmr_loader_Verenigingen" EventName="Tick" />
    </triggers>
    </contenttemplate>
</asp:UpdatePanel>
<asp:UpdateProgress ID="udp_Verenigingen_progress" runat="server" AssociatedUpdatePanelID="udp_Verenigingen" DisplayAfter="50">
    <progresstemplate>
        <div class="progess" style="position: absolute; background-color: #F9F9F9; top: 0px; left: 0px; width: 100%; height: 100%; opacity: 0.8; -moz-opacity: 0.8; filter: alpha(opacity=80); -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=80)"; z-index: 10000;">
        <div class="bubbles aligncenter" style="top:48%;">laden...</div>
        </div>
</progresstemplate>
</asp:UpdateProgress>



