<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DisplayUsersUserControl.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.DisplayUsersUserControl" %>
<SharePoint:MenuTemplate ID="UserMenu" runat="server">
    <SharePoint:MenuItemTemplate ID="Details" runat="server" Text="Details bekijken van %ROEPNAAM%" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Contact/Contact_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'LedenDetails.aspx?Bondsnummer=%BONDSNUMMER%'});" Title="Details van %VOLLEDIGENAAM%"></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Facturen" runat="server" Text="Facturen bekijken van %ROEPNAAM%" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Factuur/Factuur_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'LedenFacturen.aspx?Bondsnummer=%BONDSNUMMER%'});" Title="Facturen van %VOLLEDIGENAAM%" ></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Rechten" runat="server" Text="Rechten en Rollen voor %ROEPNAAM%" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Rollen/Rollen_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'LedenRollen.aspx?Bondsnummer=%BONDSNUMMER%'});" Title="Rechten voor %VOLLEDIGENAAM%" ></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Groepen" runat="server" Text="Groepen van %ROEPNAAM%" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Groepen/Groepen_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'LedenGroepen.aspx?Bondsnummer=%BONDSNUMMER%'});" Title="Groepen van %BONDSNUMMERVOLLEDIGENAAM%" ></SharePoint:MenuItemTemplate>
    <SharePoint:MenuItemTemplate ID="Email" runat="server" Text="Email versturen naar %ROEPNAAM%" ImageUrl="/_layouts/15/images/ClubCloud.Administratie/Mail/Mail_32.png" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'LedenEmail.aspx?Bondsnummer=%BONDSNUMMER%'});" Title="Emailen naar %VOLLEDIGENAAM%"></SharePoint:MenuItemTemplate>
</SharePoint:MenuTemplate>
<Common:ClubCloudDataSource runat="server" ID="UserDataSource" />
<SharePoint:SPGridViewPager ID="spgvpager_top" GridViewId="MemberGrid" runat="server" />
<br />
<SharePoint:SPGridView
    ID="MemberGrid"
    runat="server"
    DataSourceID="UserDataSource"
    AutoGenerateColumns="false"     
    AllowPaging="true"
    PageSize="30"
    AllowSorting="true" 
    ShowFooter="True" OnDataBinding="Page_Load">
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <PagerSettings Mode="NextPreviousFirstLast" Visible="true" Position="TopAndBottom" PreviousPageText="vorige" NextPageText="volgende" FirstPageText="Eerste" LastPageText="Laatste" PageButtonCount="5" />
    <PagerStyle HorizontalAlign="Center" VerticalAlign="Top" BackColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <Columns>
        <SharePoint:SPBoundField
            DataField="Bondsnummer"
            HeaderText="Bondsnummer"
            SortExpression="Bondsnummer"
            ItemStyle-Width="40px">
        </SharePoint:SPBoundField>
        <SharePoint:SPMenuField
            HeaderText="Naam"
            TextFields="Volledigenaam"
            MenuTemplateId="UserMenu"
            NavigateUrlFields="Bondsnummer"
            NavigateUrlFormat="#"
            TokenNameAndValueFields="BONDSNUMMER=Bondsnummer,ROEPNAAM=Roepnaam,VOLLEDIGENAAM=Volledigenaam"
            SortExpression="Volledigenaam"
            ItemStyle-Width="120px" />
        <SharePoint:SPBoundField
            DataField="EmailKNLTB"
            HeaderText="Email"
            SortExpression="EmailKNLTB"
            ItemStyle-Width="60px">
        </SharePoint:SPBoundField>
        <SharePoint:SPBoundField
            DataField="Actief"
            HeaderText="Actief"
            SortExpression="Actief"
            ItemStyle-Width="60px">
        </SharePoint:SPBoundField>
    </Columns>
</SharePoint:SPGridView>
<br />
<SharePoint:SPGridViewPager ID="spgvpager_bottom" GridViewId="MemberGrid" runat="server"/>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>

