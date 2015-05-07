<%@ Page language="C#" MasterPageFile="~masterurl/default.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c"  %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Provider" Namespace="ClubCloud.Provider.Controls" Assembly="ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="ClubCloud" TagName="Baantoplaag_Edit" Src="~/_controltemplates/ClubCloud/Administratie/Baantoplagen/ClubCloud_Baantoplaag_Edit.ascx" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Import Namespace="ClubCloud.Provider.Controls" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<asp:Content ContentPlaceHolderId="PlaceHolderPageTitle" runat="server">
    ClubCloud - <SharePoint:ProjectProperty Property="Title" runat="server"/> - Baantoplaag - Bewerken
</asp:Content>
<asp:Content ID="Main" ContentPlaceHolderId="PlaceHolderMain" runat="server">
	<div class="inner light ms-dialogHidden">
        <div class="aligncenter">
			<h1 >
		        Wijzigen Baantoplaag
		    </h1>
        </div>
    </div>
    <div class="inner dark" id="Baantoplaag" name="Baantoplaag" style="padding:20px 20px 10px">
        <div class="services">
            <div class="first" >
                <div class="info">
					<Provider:ZimbraRolesSecurityTrimmedControl RolesString="All Authenticated Users" runat="server" ID="security" >
						<ClubCloud:Baantoplaag_Edit id="Baantoplagen" runat="server" visible="true" ViewName="ClubCloud_Baantoplagen_View" />
					</Provider:ZimbraRolesSecurityTrimmedControl>
	            </div>
            </div>
            <div class="clear"></div>
        </div>
        <div class="clear"></div>
    </div>		
</asp:Content>
