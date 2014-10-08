<%@ Page Language="C#" MasterPageFile="~masterurl/default.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" meta:progid="SharePoint.WebPartPage.Document" %>

<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Namespace="ClubCloud.Mijn.ControlTemplates" Assembly="ClubCloud.Mijn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="ClubCloud" TagName="WachtwoordUserControl" Src="~/_controltemplates/ClubCloud.Mijn/VeranderwachtwoordUserControl.ascx" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<asp:Content ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    <sharepoint:projectproperty property="Title" runat="server" />
    Wachtwoord Instellingen
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <div class="inner light">
        <div class="aligncenter">
            <h1 id="pageTitle" class="lined">Mijn ClubCloud Wachtwoord</h1>
            <p class="description">Mijn ClubCloud Wachtwoord</p>
        </div>
    </div>
    <div class="inner dark">
        <div class="services">
            <div class="one-half first">
                <i class="icon-key  special"></i>
                <div class="info lined">
                    <h3 class="lined">ClubCloud wachtwoord </h3>
                    <p>Wijzig uw ClubCloud wachtwoord.</p>
                    <ClubCloud:WachtwoordUserControl id="Wachtwoordusercontrol1" runat="server"></ClubCloud:WachtwoordUserControl>
                    <br />
                </div>
            </div>
            <div class="one-half last">
            </div>
            <br />
            <div class="clear"></div>
        </div>
    </div>
</asp:Content>
