<%@ Page language="C#" MasterPageFile="4fedfed0" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" meta:progid="SharePoint.WebPartPage.Document"  %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="ClubCloud" Namespace="ClubCloud.Mijn.ControlTemplates" Assembly="ClubCloud.Mijn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="ClubCloud" TagName="KNLTBUserControl" src="~/_controltemplates/ClubCloud.Mijn/KNLTBUserControl.ascx" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<asp:Content ContentPlaceHolderId="PlaceHolderPageTitle" runat="server">
    <SharePoint:ProjectProperty Property="Title" runat="server"/>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderId="PlaceHolderMain" runat="server">
    <WebPartPages:AllowFraming runat="server" />
	<div class="inner light">
      <div class="aligncenter">
        <h1 id="pageTitle" class="lined">Mijn ClubCloud PayPal</h1>
        <p class="description">Instellingen voor het gebruik van PayPal.</p>
        </div>
    </div>
    <div class="inner dark">
      <div class="services">

        <div class="first">
        <i class="icon-vcard special"></i>
          <div class="info">
            <h3 class="lined">PayPal instellingen</h3>
            <p>instellingen
            </p>
            <p></p>
          </div>
        </div>
        <div class="clear"></div>        
	</div>
        <a href="#" onclick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK)" class="button big" style="float:right;" >Sluiten</a>
   	<div class="clear"></div>
    </div>
</asp:Content>







