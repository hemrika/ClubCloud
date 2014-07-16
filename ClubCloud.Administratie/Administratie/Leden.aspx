<%@ Page Language="C#" MasterPageFile="~masterurl/default.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" %>

<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="wssuc" TagName="ToolBar" Src="~/_controltemplates/ToolBar.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ToolBarButton" Src="~/_controltemplates/ToolBarButton.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormSection" Src="~/_controltemplates/InputFormSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormControl" Src="~/_controltemplates/InputFormControl.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ButtonSection" Src="~/_controltemplates/ButtonSection.ascx" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register TagPrefix="Administratie" TagName="DisplayUsers" Src="~/_controltemplates/ClubCloud.Administratie.WebControls/DisplayUsers/DisplayUsersUserControl.ascx" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<asp:Content ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server">
    <wssuc:ToolBar id="Administratie_Top" runat="server">
        <template_buttons>
            <wssuc:ToolBarButton 
                runat="server"
	            Text="Leden"
	            id="idledenDisplay"
	            ToolTip="Leden Beheer"
	            NavigateUrl="Leden.aspx"
	            ImageUrl="/_layouts/15/images/VSEMS/usersdisp.png"
	            AccessKey="L" />
            <wssuc:ToolBarButton 
                runat="server"
	            Text="Facturatie"
	            id="idFacturatieDisplay"
	            ToolTip="Facturatie Beheer"
	            NavigateUrl="Facturatie.aspx"
	            ImageUrl="/_layouts/15/images/VSEMS/rolenew.png"
	            AccessKey="F"/>	                       
            <wssuc:ToolBarButton 
                runat="server"
	            Text="Rollen"
	            id="idRolesDispay"
	            ToolTip="Rollen Beheer"
	            NavigateUrl="Rollen.aspx"
	            ImageUrl="/_layouts/15/images/VSEMS/rolesdisp.png"
	            AccessKey="R"/>
            <wssuc:ToolBarButton 
                runat="server"
	            Text="Groepen"
	            id="idGroupDisplay"
	            ToolTip="Groepen Beheer"
	            NavigateUrl="Groepen.aspx"
	            ImageUrl="/_layouts/15/images/VSEMS/rolenew.png"
	            AccessKey="G"/>
        </template_buttons>
    </wssuc:ToolBar>
</asp:Content>

<asp:Content ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    <SharePoint:ProjectProperty Property="Title" runat="server" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <h1>Leden
    </h1>
    <wssuc:ToolBar id="Administratie_Leden" runat="server">
        <template_buttons>
            <wssuc:ToolBarButton 
                runat="server"
	            Text="Leden Zoeken"
	            id="idZoeken"
	            ToolTip="Leden Zoeken"
	            NavigateUrl="LedenZoeken.aspx"
	            ImageUrl="/_layouts/15/images/VSEMS/usersdisp.png"
	            AccessKey="Z" />
            <wssuc:ToolBarButton 
                runat="server"
	            Text="Nieuw Lid"
	            id="idLidAdd"
	            ToolTip="Nieuw Lid"
	            NavigateUrl="LidNieuw.aspx"
	            ImageUrl="/_layouts/15/images/VSEMS/rolenew.png"
	            AccessKey="A"/>	                       
            <wssuc:ToolBarButton 
                runat="server"
	            Text="Nieuwe Leden"
	            id="idLidNew"
	            ToolTip="Nieuwe Leden"
	            NavigateUrl="LedenNieuw.aspx"
	            ImageUrl="/_layouts/15/images/VSEMS/rolesdisp.png"
	            AccessKey="N"/>
        </template_buttons>
    </wssuc:ToolBar>

    <Administratie:DisplayUsers id="diplay_users" runat="server" ViewName="UsersView" />
</asp:Content>

