
 
<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Banen.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_BanenUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Baan_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Banen_View" />
<SharePoint:SPGridViewPager ID="spgvpager_top" GridViewId="ClubCloud_Baan_Grid" runat="server" />
<br />
<SharePoint:SPGridView
    ID="ClubCloud_Baan_Grid"
    runat="server"
    DataSourceID="ClubCloud_Baan_DataSource"
    AutoGenerateColumns="false"     
    AllowPaging="true"
    PageSize="30"
    AllowSorting="true" 
    ShowFooter="True" OnDataBinding="Page_Load">
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <PagerSettings Mode="NextPreviousFirstLast" Visible="true" Position="TopAndBottom" PreviousPageText="vorige" NextPageText="volgende"  FirstPageText="Eerste" LastPageText="Laatste" PageButtonCount="5" />
    <PagerStyle HorizontalAlign="Center" VerticalAlign="Top" BackColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <Columns>
        <SharePoint:SPBoundField
            DataField="Id"
            HeaderText="Id"
            SortExpression="Id"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Naam"
            HeaderText="Naam"
            SortExpression="Naam"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Nummer"
            HeaderText="Nummer"
            SortExpression="Nummer"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="BaanblokId"
            HeaderText="BaanblokId"
            SortExpression="BaanblokId"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="AccommodatieId"
            HeaderText="AccommodatieId"
            SortExpression="AccommodatieId"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Status"
            HeaderText="Status"
            SortExpression="Status"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Keuring"
            HeaderText="Keuring"
            SortExpression="Keuring"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Actief"
            HeaderText="Actief"
            SortExpression="Actief"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
    </Columns>
    <EmptyDataTemplate>
        <HeaderTemplate>
            <asp:HyperLink ID="ClubCloud_Baan_Insert" Text="Toevoegen" NavigateUrl="~/ClubCloud_Baan_Insert.aspx"  runat="server" /> <br/>
        </HeaderTemplate>
        <ItemTemplate>Er zijn geen gegevens gevonden.</ItemTemplate>
    </EmptyDataTemplate>
</SharePoint:SPGridView>
<br />
<SharePoint:SPGridViewPager ID="spgvpager_bottom" GridViewId="ClubCloud_Baan_Grid" runat="server"/>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>



