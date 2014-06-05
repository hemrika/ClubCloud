<%@ Page language="C#" MasterPageFile="~masterurl/default.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" meta:progid="SharePoint.WebPartPage.Document"  %>
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
	<div class="inner light">
      <div class="aligncenter">
        <h1 id="pageTitle" class="lined">Mijn ClubCloud Profiel</h1>
        <p class="description">Uw ClubCloud profiel gegevens worden samengesteld uit uw eigen gegevens en informatie vanuit de KNLTB.</p>
        </div>
    </div>
    <div class="inner dark">
      <div class="services">

        <div class="first">
        <i class="icon-vcard special"></i>
          <div class="info">
            <h3 class="lined">Mijn eigen gegevens</h3>
            <p>Dit zijn uw eigen gegevens. Indien uw vereniging ClubCloud gebruikt, worden deze gegevens automatisch overgenomen in de administratie.
            </p>
            <p></p>
          </div>
        </div>
        <div class="clear"></div>        
        <div class="first">
        <i class="icon-menu special"></i>
          <div class="info">
            <h3 class="lined">Mijn KNLTB gegevens</h3>
            <p>Dit zijn uw gegevens vanuit de KNLTB. Deze gegevens kunt u helaas niet wijzigen.</p>
            <p></p>
          </div>
        </div>  
        <div class="clear"></div>
        <p>Via <a href="2bfef590" title="Instellingen">Instellingen</a> kunt aangeven welke gegevens andere ClubCloud gebruikers kunnen zien.</p>
	</div>    
   	<div class="clear"></div>
    </div>
</asp:Content>







