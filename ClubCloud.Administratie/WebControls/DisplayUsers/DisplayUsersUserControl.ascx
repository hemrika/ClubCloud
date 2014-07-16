<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register Tagprefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="$SharePoint.Project.AssemblyFullName$" %>
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DisplayUsersUserControl.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.DisplayUsersUserControl" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="wssuc" TagName="ToolBar" src="~/_controltemplates/ToolBar.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ToolBarButton" src="~/_controltemplates/ToolBarButton.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormSection" src="~/_controltemplates/InputFormSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormControl" src="~/_controltemplates/InputFormControl.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ButtonSection" src="~/_controltemplates/ButtonSection.ascx" %>

<SharePoint:MenuTemplate ID="UserMenu" runat="server">
        <SharePoint:MenuItemTemplate ID="Details" runat="server" Text="Details" ImageUrl="/_layouts/15/images/detail.gif" ClientOnClickScript="javascript:SP.UI.ModalDialog.showModalDialog({url:'UserDisplay.aspx?UserName=%USERNAME%'});"  Title="Details"></SharePoint:MenuItemTemplate>
        <SharePoint:MenuItemTemplate ID="Bewerken" runat="server" Text="Edit" ImageUrl="/_layouts/15/images/edititem.gif" ClientOnClickNavigateUrl="UserEdit.aspx?UserName=%USERNAME%" Title="Edit"></SharePoint:MenuItemTemplate>
        <SharePoint:MenuItemTemplate ID="Activatie" runat="server" Text="Activatie" ImageUrl="/_layouts/15/images/VSEMS/userunlock.png" ClientOnClickNavigateUrl="UserActivation.aspx?UserName=%USERNAME%" Title="Activatie"></SharePoint:MenuItemTemplate>
        <SharePoint:MenuItemTemplate ID="Uitgesloten" runat="server" Text="Uitgesloten" ImageUrl="/_layouts/15/images/VSEMS/userunlock.png" ClientOnClickNavigateUrl="UserLock.aspx?UserName=%USERNAME%" Title="Unlock"></SharePoint:MenuItemTemplate>
    </SharePoint:MenuTemplate>
    
    <Administratie:ClubCloudDataSource runat="server" ID="UserDataSource" ViewName="UsersView" />	
    <SharePoint:SPGridView 
        ID="MemberGrid"
        runat="server"
        DataSourceID="UserDataSource"
        AutoGenerateColumns="false"        
        AllowPaging="true"  
        PageSize="30"
        AllowSorting="true" >
        <HeaderStyle BackColor="#0072C6" BorderColor="White" ForeColor="White" Font-Bold="true" Font-Size="Large"  />
        <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
        <PagerSettings Mode="NextPreviousFirstLast" Visible="true" Position="TopAndBottom" PreviousPageText="vorige" NextPageText="volgende"  />
        <PagerStyle HorizontalAlign="Center" VerticalAlign="Top" />
        <Columns>
             <SharePoint:SPMenuField  
                HeaderText="Naam" 
                TextFields="Naam"
                MenuTemplateId="UserMenu"
                NavigateUrlFields="KNLTB" 
                NavigateUrlFormat="UserDisplay.aspx?UserName={0}"
                TokenNameAndValueFields="USERNAME=KNLTB"
                SortExpression="Naam" />
            <SharePoint:SPBoundField 
                DataField="Email" 
                HeaderText="Email" 
                SortExpression="Email">                
            </SharePoint:SPBoundField>
            <SharePoint:SPBoundField 
                DataField="Commentaar" 
                HeaderText="Commentaar" 
                SortExpression="Commentaar">
            </SharePoint:SPBoundField>
            <SharePoint:SPBoundField 
                DataField="Actief" 
                HeaderText="Actief" 
                SortExpression="Actief">                
            </SharePoint:SPBoundField>
            <SharePoint:SPBoundField 
                DataField="Uitgesloten" 
                HeaderText="Uitgesloten" 
                SortExpression="Uitgesloten">                
            </SharePoint:SPBoundField>
            <SharePoint:SPBoundField 
                DataField="Aangemaakt" 
                HeaderText="Aangemaakt" 
                SortExpression="Aangemaakt">                
            </SharePoint:SPBoundField>
            <SharePoint:SPBoundField 
                DataField="Aanmelding" 
                HeaderText="Laatste Aanmelding" 
                SortExpression="Aanmelding">                
            </SharePoint:SPBoundField>
        </Columns>
    </SharePoint:SPGridView>
    
    <SharePoint:SPGridViewPager ID="SPGridViewPager1" GridViewId="MemberGrid" runat="server" />
    
    <p>
        <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
    </p>