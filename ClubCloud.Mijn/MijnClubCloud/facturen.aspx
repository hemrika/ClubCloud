<%@ Page language="C#" MasterPageFile="~masterurl/default.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" meta:progid="SharePoint.WebPartPage.Document"  %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="ClubCloud" Namespace="ClubCloud.Mijn.ControlTemplates" Assembly="ClubCloud.Mijn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="ClubCloud" TagName="MijnFacturenUserControl" src="~/_controltemplates/ClubCloud.Mijn/MijnFacturenUserControl.ascx" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<asp:Content ContentPlaceHolderId="PlaceHolderPageTitle" runat="server">
    <SharePoint:ProjectProperty Property="Title" runat="server"/> Uitslagen
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderId="PlaceHolderMain" runat="server">
	<div class="inner light">
      <div class="aligncenter">
        <h1 id="pageTitle" class="lined">Mijn ClubCloud Facturen</h1>
        <p class="description">Dit zijn de facturen van uw vereniging(en)</p>
        </div>
    </div>
    <div class="inner dark">
        <div class="services">
            <!-- <Sharepoint:SPSecurityTrimmedControl runat="server" AuthenticationRestrictions="AnonymousUsersOnly" Permissions="EmptyMask"> -->
            <p>Dit zijn uw eigen facturen. Indien uw vereniging ClubCloud gebruikt, worden deze gegevens automatisch overgenomen in de administratie.
            </p>
            <!-- </SharePoint:SPSecurityTrimmedControl> -->
            <ClubCloud:MijnFacturenUserControl id="mijnfacturen" runat="server"></ClubCloud:MijnFacturenUserControl>
            <!-- <Sharepoint:SPSecurityTrimmedControl runat="server" AuthenticationRestrictions="AuthenticatedUsersOnly" Permissions="EmptyMask"> -->
            <br />
            <div class="first">
                <i class="icon-info special"></i>
                <div class="info">
                <h3 class="lined">Incorrecte gegevens ?</h3>
                    <p>
                        Als de informatie die u ziet volgens u niet correct is, dan kunt u deze hier meteen wijzigen. Via de ClubCloud Administratie kan u vereniging
                        de wijzigen doorvoeren bij de KNLTB.
                    </p>
                </div>
            </div>  
            <!-- </SharePoint:SPSecurityTrimmedControl> -->
   	        <div class="clear"></div>
        </div>
    	<div class="clear"></div>
    </div>
</asp:Content>







