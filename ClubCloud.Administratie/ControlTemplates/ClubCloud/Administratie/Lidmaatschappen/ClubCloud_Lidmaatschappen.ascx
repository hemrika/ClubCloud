
 
<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Lidmaatschappen.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_LidmaatschappenUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Lidmaatschap_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Lidmaatschappen_View" />
<SharePoint:MenuTemplate ID="LidmaatschapMenu" runat="server">
	<SharePoint:MenuItemTemplate ID="Lidmaatschap_Details" runat="server" Text="Details bekijken van Lidmaatschap" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'Lidmaatschap.aspx?Id=%Id%', title:'Details van Lidmaatschap', autoSize:false});" Title="Details van Lidmaatschap"></SharePoint:MenuItemTemplate>
</SharePoint:MenuTemplate>
<asp:HyperLink ID="Lidmaatschap_Insert" Text="Toevoegen" NavigateUrl="Lidmaatschap_Insert.aspx"  runat="server" />
<br/>
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
    ShowHeader="true" >
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <PagerSettings Mode="NextPreviousFirstLast" Visible="true" Position="TopAndBottom" PreviousPageText="vorige" NextPageText="volgende"  FirstPageText="Eerste" LastPageText="Laatste" PageButtonCount="5" />
    <PagerStyle HorizontalAlign="Center" VerticalAlign="Top" BackColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <Columns>
			<SharePoint:SPMenuField
			HeaderText="Bondsnummer"
			TextFields="Bondsnummer"
			MenuTemplateId="LidmaatschapMenu"
			TokenNameAndValueFields="Id=Id"
			SortExpression="Bondsnummer"
			ItemStyle-Width="120px" />
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
    
		<asp:TemplateField HeaderText="Lidmaatschapsoort" SortExpression="LidmaatschapsoortId">
			<ItemTemplate>
				<asp:Label ID="Lidmaatschapsoort" runat="server" Text='<%# Bind("ClubCloud_Lidmaatschapsoort.Naam") %>'></asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
    </Columns>
    <EmptyDataTemplate>
        <HeaderTemplate>
            <asp:HyperLink ID="Lidmaatschap_Insert" Text="Toevoegen" NavigateUrl="Lidmaatschap_Insert.aspx"  runat="server" /> <br/>
        </HeaderTemplate>
        <ItemTemplate>Er zijn geen gegevens gevonden.</ItemTemplate>
    </EmptyDataTemplate>        
</SharePoint:SPGridView >
<br />
<SharePoint:SPGridViewPager ID="spgvpager_bottom" GridViewId="Lidmaatschappen_Grid" runat="server"/>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>



