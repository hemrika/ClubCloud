
 
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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Functionarissen.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_FunctionarissenUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Functionaris_DataSource" runat="server" OnDataBinding="tmr_loader_Functionarissen_Tick" ViewName="ClubCloud_Functionarissen_View" />
<asp:UpdatePanel ID="udp_Functionarissen" runat="server" UpdateMode="Always">
    <contenttemplate>
		<asp:Timer runat="server" ID="tmr_loader_Functionarissen" OnTick="tmr_loader_Functionarissen_Tick" interval="500" />
<SharePoint:MenuTemplate ID="FunctionarisMenu" runat="server" LargeIconMode="true">
	<SharePoint:MenuItemTemplate ID="Functionaris_Details" runat="server" Text="Details van %Naam%" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Functionaris.aspx?Id=%Id%', title:'Details van %Naam%', autoSize:true});" Title="Details van %Naam%"></SharePoint:MenuItemTemplate>
</SharePoint:MenuTemplate>
<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Functionaris_Insert.aspx', title:'Toevoegen Functionaris', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" href="#" target="_self" title="Toevoegen" >Toevoegen Functionaris</a>
<br/>
<asp:panel runat="server" ID="pnl_Functionarissen" >
<SharePoint:SPGridViewPager ID="spgvpager_top" GridViewId="Functionarissen_Grid" runat="server" />
<br />
<SharePoint:SPGridView 
    ID="Functionarissen_Grid" 
    runat="server"
    AllowPaging="true" 
    AllowSorting="true" 
    AutoGenerateColumns="false" 
    SelectMethod="SelectFunctionarissen"
	OnCallingDataMethods="GridFunctionarissen_CallingDataMethods"
    PageSize="30"
    ShowFooter="true"
    ShowHeader="true"
	EnableViewState="false"
	ViewStateMode="Disabled"
    GroupField="ClubCloud_Functie_Naam"
    GroupDisplayTextField="ClubCloud_Functie_Naam"
    GroupFieldDisplayName="Functie"
    AllowGrouping="true"
    AllowGroupCollapse="true"
    DisplayGroupFieldName="true"
	OnDataBinding="tmr_loader_Functionarissen_Tick" >
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <PagerSettings Mode="NextPreviousFirstLast" Visible="true" Position="TopAndBottom" PreviousPageText="vorige" NextPageText="volgende"  FirstPageText="Eerste" LastPageText="Laatste" PageButtonCount="5" />
    <PagerStyle HorizontalAlign="Center" VerticalAlign="Top" BackColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <Columns>
		<asp:TemplateField>
			<HeaderTemplate>
			    <asp:LinkButton ForeColor="White" ID="Id_Sort" runat="server" Text="Naam" CommandName="Sort" CommandArgument="Id"></asp:LinkButton>
			</HeaderTemplate>
			<ItemTemplate>
                <a id="<%# Eval("Id") %>" title="<%# Eval("ClubCloud_Gebruiker_Volledigenaam") %>" name="<%# Eval("ClubCloud_Gebruiker_Volledigenaam") %>" onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Functionaris.aspx?Id='+'<%# Eval("Id") %>', title:'Details van '+'<%# Eval("ClubCloud_Gebruiker_Volledigenaam") %>', autoSize:true, dialogReturnValueCallback:RefreshOnDialogClose});" style="white-space:nowrap;" href="#" >
                    <%# Eval("ClubCloud_Gebruiker_Volledigenaam") %>
                </a>
			</ItemTemplate>
		</asp:TemplateField>
        <SharePoint:SPBoundField
            DataField="TermijnBegin"
            HeaderText="TermijnBegin"
            SortExpression="TermijnBegin"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="TermijnEinde"
            HeaderText="TermijnEinde"
            SortExpression="TermijnEinde"
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
    
    </Columns>
    <EmptyDataTemplate>
        <ItemTemplate>Er zijn geen Functionarissen gevonden.</ItemTemplate>
    </EmptyDataTemplate>        
</SharePoint:SPGridView >
<br />
<SharePoint:SPGridViewPager ID="spgvpager_bottom" GridViewId="Functionarissen_Grid" runat="server"/>
</asp:panel>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>
    <triggers>
        <asp:AsyncPostBackTrigger ControlID="tmr_loader_Functionarissen" EventName="Tick" />
    </triggers>
    </contenttemplate>
</asp:UpdatePanel>
<asp:UpdateProgress ID="udp_Functionarissen_progress" runat="server" AssociatedUpdatePanelID="udp_Functionarissen" DisplayAfter="50">
    <progresstemplate>
        <div class="progess" style="position: absolute; background-color: #F9F9F9; top: 0px; left: 0px; width: 100%; height: 100%; opacity: 0.8; -moz-opacity: 0.8; filter: alpha(opacity=80); -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=80)"; z-index: 10000;">
        <div class="bubbles aligncenter" style="top:48%;">laden...</div>
        </div>
</progresstemplate>
</asp:UpdateProgress>



