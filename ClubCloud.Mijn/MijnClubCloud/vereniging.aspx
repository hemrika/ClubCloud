<%@ Page language="C#" MasterPageFile="~masterurl/default.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" meta:progid="SharePoint.WebPartPage.Document"  %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="ClubCloud" Namespace="ClubCloud.Mijn.ControlTemplates" Assembly="ClubCloud.Mijn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="ClubCloud" TagName="MijnVerenigingUserControl" Src="~/_controltemplates/ClubCloud.Mijn/MijnVerenigingUserControl.ascx" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<asp:Content ContentPlaceHolderId="PlaceHolderPageTitle" runat="server">
    <SharePoint:ProjectProperty Property="Title" runat="server"/> Verening(en)
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderId="PlaceHolderMain" runat="server">
	<div class="inner light">
      <div class="aligncenter">
        <h1 id="pageTitle" class="lined">Mijn Vereniging(en)</h1>
        <p class="description">Bekijk en de belangrijkste gegevens van u vereniging(en). Alle informatie op een pagina; adressen, telefoonnummers, email, bestuur, VLC's, wedstrijdleiders etc.  </p>
      </div>
    </div>
    <div class="inner dark">
        <div class="services">
            <!-- <Sharepoint:SPSecurityTrimmedControl runat="server" AuthenticationRestrictions="AnonymousUsersOnly" Permissions="EmptyMask"> -->
            <p>Alle infomatie die u nodig heeft van uw vereniging. De informatie wordt automatisch bijgehouden en is de actuele informatie zoals bekend bij de KNLTB.
            </p>
            <!-- </SharePoint:SPSecurityTrimmedControl> -->
            <clubcloud:MijnVerenigingUserControl id="instellingen_privacy" runat="server"></clubcloud:MijnVerenigingUserControl>
        <!-- <Sharepoint:SPSecurityTrimmedControl runat="server" AuthenticationRestrictions="AuthenticatedUsersOnly" Permissions="EmptyMask"> -->
        <br />
        <div class="first">
            <i class="icon-info special"></i>
            <div class="info">
            <h3 class="lined">Incorrecte gegevens ?</h3>
                <p>
                    Als de informatie die u ziet volgens u niet correct is, neemt u dan contact op met uw vereniging. Via de ClubCloud Administratie kan u vereniging
                    de informatie direct wijzigenen. Dit kan ook door door in te loggen op de KNLTB ServIt omgeving en de wijzigingen door te voeren.
                </p>
            </div>
        </div>  
        <!-- </SharePoint:SPSecurityTrimmedControl> -->
	</div>    
   	<div class="clear"></div>
    </div>
</asp:Content>







