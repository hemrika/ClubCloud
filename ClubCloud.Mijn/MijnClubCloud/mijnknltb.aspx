<%@ Page Language="C#" MasterPageFile="~masterurl/default.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" meta:progid="SharePoint.WebPartPage.Document" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Namespace="ClubCloud.Mijn.ControlTemplates" Assembly="ClubCloud.Mijn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="ClubCloud" TagName="KNLTBUserControl" Src="~/_controltemplates/ClubCloud.Mijn/KNLTBUserControl.ascx" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<asp:Content ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    <sharepoint:projectproperty property="Title" runat="server" />
    CLubCloud - MijnKNLTB instellingen
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <div class="inner light">
        <div class="aligncenter">
            <h1 id="pageTitle" class="lined">MijnKNLTB Instellingen</h1>
            <p class="description">MijnKNLTB Instellingen</p>
        </div>
    </div>
    <div class="inner dark">
        <div class="services">
            <div class="one-half first">
                <i class="icon-magic special"></i>
                <div class="info lined">
                    <h3 class="lined">MijnKNLTB</h3>
                    <p>
                        Synchronisser uw KNTLB gegevens. Met het instellen van de 
					synchronisatie kunt u via MijnClubCloud uw actuele tennis 
					gegevens bekijken zoals bekend bij de KNLTB.<br />
                        <ClubCloud:KNLTBUserControl id="knltb_validate" runat="server"></ClubCloud:KNLTBUserControl>
                        <br />
                    </p>
                </div>
            </div>
            <div class="one-half last">
            </div>
            <br />
        </div>
        <div class="clear"></div>
        </div>
    </div>
</asp:Content>
