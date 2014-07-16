﻿<%@ Page language="C#" MasterPageFile="~masterurl/default.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c"  %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="wssuc" TagName="ToolBar" src="~/_controltemplates/ToolBar.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ToolBarButton" src="~/_controltemplates/ToolBarButton.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormSection" src="~/_controltemplates/InputFormSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormControl" src="~/_controltemplates/InputFormControl.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ButtonSection" src="~/_controltemplates/ButtonSection.ascx" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register TagPrefix="Administratie" TagName="DisplayUsers" src="~/_controltemplates/ClubCloud.Administratie.WebControls/DisplayUsers/DisplayUsersUserControl.ascx" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<asp:Content ContentPlaceHolderId="PlaceHolderPageTitleInTitleArea" runat="server" >
		<wssuc:ToolBar id="Administratie_Top" runat="server">
	    <Template_Buttons>
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
        </Template_Buttons>
    </wssuc:ToolBar>
</asp:Content>

<asp:Content ContentPlaceHolderId="PlaceHolderPageTitle" runat="server">
    <SharePoint:ProjectProperty Property="Title" runat="server"/>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderId="PlaceHolderMain" runat="server">
    <h1>
        Leden
    </h1>
</asp:Content>

