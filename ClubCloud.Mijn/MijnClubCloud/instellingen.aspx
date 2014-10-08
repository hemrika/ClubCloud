<%@ Page Language="C#" MasterPageFile="~masterurl/default.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" meta:progid="SharePoint.WebPartPage.Document" %>

<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Namespace="ClubCloud.Mijn.ControlTemplates" Assembly="ClubCloud.Mijn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="ClubCloud" TagName="FaceBookUserControl" Src="~/_controltemplates/ClubCloud.Mijn/FaceBookUserControl.ascx" %>
<%@ Register TagPrefix="ClubCloud" TagName="TwitterUserControl" Src="~/_controltemplates/ClubCloud.Mijn/TwitterUserControl.ascx" %>
<%@ Register TagPrefix="ClubCloud" TagName="BetalingenUserControl" Src="~/_controltemplates/ClubCloud.Mijn/BetalingenUserControl.ascx" %>
<%@ Register TagPrefix="ClubCloud" TagName="PrivacyControl" Src="~/_controltemplates/ClubCloud.Mijn/PrivacyUserControl.ascx" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<asp:Content ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    <sharepoint:projectproperty property="Title" runat="server" /> instellingen
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <div class="inner light">
        <div class="aligncenter">
            <h1 id="pageTitle" class="lined">Mijn ClubCloud Instellingen</h1>
            <p class="description">Mijn ClubCloud Instellingen</p>
        </div>
    </div>
    <div class="inner dark">
        <div class="services">
            <div class="one-half first">
                <i class="icon-vcard special"></i>
                <div class="info lined">
                    <h3 class="lined">Privacy instellingen</h3>
                    <p>
                        U bepaalt welke gegevens u met andere wilt delen of verbergen.
                        <clubcloud:privacycontrol id="instellingen_privacy" runat="server"></clubcloud:privacycontrol>
                        <br />
                    </p>
                </div>
            </div>
            <div class="one-half last">
                <i class="icon-shareable special"></i>
                <div class="info lined">
                    <h3 class="lined">Betalings instellingen</h3>
                    <p>
                        Bepaal op welke wijze u uw betalingen wilt doen aan verenigingen.
							<clubcloud:betalingenusercontrol id="Betalingenusercontrol1" runat="server"></clubcloud:betalingenusercontrol>
                        <br />
                    </p>
                </div>
            </div>
            <br />
            <div class="one-half first">
                <i class="icon-facebook special"></i>
                <div class="info lined">
                    <h3 class="lined">FaceBook</h3>
                    <p>
                        U kunt uw presetaties en updates automatisch op FaceBook delen.<br />
                        <clubcloud:facebookusercontrol id="instellingen_facebook" runat="server"></clubcloud:facebookusercontrol>
                        <br />
                    </p>
                </div>
            </div>
            <div class="one-half last">
                <i class="icon-twitter special"></i>
                <div class="info lined">
                    <h3 class="lined">Twitter </h3>
                    <p>
                        U kunt uw presetaties en updates automatisch op 
						Twitter delen.<br />
                        <clubcloud:twitterusercontrol id="instellingen_twitter" runat="server"></clubcloud:twitterusercontrol>
                        <br />
                    </p>
                </div>
            </div>
            <br />
            <div class="clear"></div>
        </div>
    </div>
</asp:Content>
