<%@ Page language="C#" MasterPageFile="~masterurl/default.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c"  %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="wssuc" TagName="ToolBar" src="~/_controltemplates/ToolBar.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ToolBarButton" src="~/_controltemplates/ToolBarButton.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormSection" src="~/_controltemplates/InputFormSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormControl" src="~/_controltemplates/InputFormControl.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ButtonSection" src="~/_controltemplates/ButtonSection.ascx" %>
<%@ Register TagPrefix="ClubCloud" TagName="Lidmaatschappen" Src="~/_controltemplates/ClubCloud/Administratie/Lidmaatschappen/ClubCloud_Lidmaatschappen.ascx" %>
<%@ Register TagPrefix="Provider" Namespace="ClubCloud.Provider.Controls" Assembly="ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<asp:Content ID="Main" ContentPlaceHolderId="PlaceHolderMain" runat="server">
	<div class="inner light ms-dialogHidden">
        <div class="aligncenter">
			<h1 >
		        Lidmaatschappen
		    </h1>
        </div>
    </div>
    <div class="inner dark" id="Lidmaatschappen" name="Lidmaatschappen">
        <div class="services">
            <div class="first" >
                <div class="info">
					<Provider:ZimbraRolesSecurityTrimmedControl RolesString="All Authenticated Users" runat="server" ID="security" >
						<ClubCloud:Lidmaatschappen id="Lidmaatschappen" runat="server" visible="true" ViewName="ClubCloud_Lidmaatschappen_View" />
					</Provider:ZimbraRolesSecurityTrimmedControl>
	            </div>
            </div>
            <div class="clear"></div>
        </div>
        <div class="clear"></div>
    </div>
</asp:Content>
