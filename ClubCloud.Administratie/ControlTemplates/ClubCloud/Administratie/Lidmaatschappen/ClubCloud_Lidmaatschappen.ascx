
 
<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Lidmaatschappen.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_LidmaatschappenUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Lidmaatschap_DataSource" runat="server" OnDataBinding="tmr_loader_Lidmaatschappen_Tick" ViewName="ClubCloud_Lidmaatschappen_View" />
<asp:UpdatePanel ID="udp_Lidmaatschappen" runat="server" UpdateMode="Always">
    <contenttemplate>
		<asp:Timer runat="server" ID="tmr_loader_Lidmaatschappen" OnTick="tmr_loader_Lidmaatschappen_Tick" interval="500" />
<SharePoint:MenuTemplate ID="LidmaatschapMenu" runat="server" LargeIconMode="true">
	<SharePoint:MenuItemTemplate ID="Lidmaatschap_Details" runat="server" Text="Details van %Naam%" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Lidmaatschap.aspx?Id=%Id%', title:'Details van %Naam%', autoSize:true});" Title="Details van %Naam%"></SharePoint:MenuItemTemplate>
</SharePoint:MenuTemplate>
<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Lidmaatschap_Insert.aspx', title:'Toevoegen Lidmaatschap'});" href="#" target="_self" title="Toevoegen" >Toevoegen Lidmaatschap</a>
<br/>
<asp:panel runat="server" ID="pnl_Lidmaatschappen" >
<SharePoint:SPGridViewPager ID="spgvpager_top" GridViewId="Lidmaatschappen_Grid" runat="server" />
<br />
<SharePoint:SPGridView 
    ID="Lidmaatschappen_Grid" 
    runat="server"
    AllowPaging="true" 
    AllowSorting="true" 
    AutoGenerateColumns="false" 
    SelectMethod="SelectLidmaatschappen"
	OnCallingDataMethods="GridLidmaatschappen_CallingDataMethods"
    PageSize="30"
    ShowFooter="true"
    ShowHeader="true"
	OnDataBinding="tmr_loader_Lidmaatschappen_Tick" >
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <PagerSettings Mode="NextPreviousFirstLast" Visible="true" Position="TopAndBottom" PreviousPageText="vorige" NextPageText="volgende"  FirstPageText="Eerste" LastPageText="Laatste" PageButtonCount="5" />
    <PagerStyle HorizontalAlign="Center" VerticalAlign="Top" BackColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <Columns>
		<asp:TemplateField>
			<HeaderTemplate>
			    <asp:LinkButton ForeColor="White" ID="Bondsnummer_Sort" runat="server" Text="Bondsnummer" CommandName="Sort" CommandArgument="Bondsnummer"></asp:LinkButton>
			</HeaderTemplate>
			<ItemTemplate>
                <a id="<%# Eval("Bondsnummer") %>" title="<%# Eval("Bondsnummer") %>" name="<%# Eval("Bondsnummer") %>" onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Lidmaatschap.aspx?Id='+'<%# Eval("Id") %>', title:'Details van '+'<%# Eval("Bondsnummer") %>', autoSize:true});" style="white-space:nowrap;" href="#" >
                    <%# Eval("Bondsnummer") %>
                </a>
			</ItemTemplate>
		</asp:TemplateField>
	        <SharePoint:SPBoundField
            DataField="Begin"
            HeaderText="Begin"
            SortExpression="Begin"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Einde"
            HeaderText="Einde"
            SortExpression="Einde"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Opzegging"
            HeaderText="Opzegging"
            SortExpression="Opzegging"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="InternNummer"
            HeaderText="InternNummer"
            SortExpression="InternNummer"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="PasTypeNaam"
            HeaderText="PasTypeNaam"
            SortExpression="PasTypeNaam"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="PasDatum"
            HeaderText="PasDatum"
            SortExpression="PasDatum"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="PasNoodDatum"
            HeaderText="PasNoodDatum"
            SortExpression="PasNoodDatum"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="PasWedstrijd"
            HeaderText="PasWedstrijd"
            SortExpression="PasWedstrijd"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="PasNieuw"
            HeaderText="PasNieuw"
            SortExpression="PasNieuw"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="PasNood"
            HeaderText="PasNood"
            SortExpression="PasNood"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="PasVolgnummer"
            HeaderText="PasVolgnummer"
            SortExpression="PasVolgnummer"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="SpeelsterkteDubbel"
            HeaderText="SpeelsterkteDubbel"
            SortExpression="SpeelsterkteDubbel"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="SpeelsterkteEnkel"
            HeaderText="SpeelsterkteEnkel"
            SortExpression="SpeelsterkteEnkel"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Autorisatie"
            HeaderText="Autorisatie"
            SortExpression="Autorisatie"
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
    
		<asp:TemplateField HeaderText="Gebruiker" SortExpression="GebruikerId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Gebruiker" runat="server" Text='<%# Bind("ClubCloud_Gebruiker.Volledigenaam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Lidmaatschapsoort" SortExpression="LidmaatschapsoortId">
			<ItemTemplate>
				<asp:Label ID="ClubCloud_Lidmaatschapsoort" runat="server" Text='<%# Bind("ClubCloud_Lidmaatschapsoort.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
    </Columns>
    <EmptyDataTemplate>
        <ItemTemplate>Er zijn geen Lidmaatschappen gevonden.</ItemTemplate>
    </EmptyDataTemplate>        
</SharePoint:SPGridView >
<br />
<SharePoint:SPGridViewPager ID="spgvpager_bottom" GridViewId="Lidmaatschappen_Grid" runat="server"/>
</asp:panel>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>
    <triggers>
        <asp:AsyncPostBackTrigger ControlID="tmr_loader_Lidmaatschappen" EventName="Tick" />
    </triggers>
    </contenttemplate>
</asp:UpdatePanel>
<asp:UpdateProgress ID="udp_Lidmaatschappen_progress" runat="server" AssociatedUpdatePanelID="udp_Lidmaatschappen" DisplayAfter="50">
    <progresstemplate>
        <div class="progess" style="position: absolute; background-color: #F9F9F9; top: 0px; left: 0px; width: 100%; height: 100%; opacity: 0.8; -moz-opacity: 0.8; filter: alpha(opacity=80); -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=80)"; z-index: 10000;">
        <div class="bubbles aligncenter" style="top:48%;">laden...</div>
        </div>
</progresstemplate>
</asp:UpdateProgress>



