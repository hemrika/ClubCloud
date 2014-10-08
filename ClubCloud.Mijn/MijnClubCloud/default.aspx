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

<asp:Content ID="cnt_Header" ContentPlaceHolderId="PlaceHolderMain" runat="server">
	<div class="inner light">
      <div class="aligncenter">
        <h1 id="pageTitle" class="lined">Mijn ClubCloud</h1>
        <p class="description">Mijn ClubCloud is een omgeving voor tennissers om al hun gegevens in te zien en te beheren.</p>
          <!-- <Sharepoint:SPSecurityTrimmedControl runat="server" AuthenticationRestrictions="AnonymousUsersOnly" Permissions="EmptyMask"> -->
          <a href="https://mijn.clubcloud.nl/_zimbra/default.aspx" class="button big">Inloggen</a>
          <!-- </SharePoint:SPSecurityTrimmedControl> -->
        </div>
    </div>


        <div class="inner dark">

      <div class="services">

        <div class="one-half first">
        <i class="icon-vcard special"></i>
          <div class="info">
            <h3 class="lined">Bekijk uw gegevens</h3>
            <p>Bekijk en beheer uw gegevens voor uw Club en van de KNLTB.</p>
            <a href="#" style="float:right;margin-right:30px;margin-bottom:20px;">Naar mijn gegevens</a>
          </div>
        </div>

        <div class="one-half last">
        <i class="icon-edit special"></i>
          <div class="info">
            <h3 class="lined">Beheer uw gegevens</h3>
            <p>Donec elit non mi porta gravida at eget metus. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Vestibulum ligula porta felis cras ridiculus dapibus, aenean eu leo quam.</p>
            <a href="#" style="float:right;margin-right:30px;margin-bottom:20px;">Naar mijn instellingen</a>
          </div>
        </div>
        <br>

        <div class="one-half first">
        <i class="icon-docs special"></i>
          <div class="info">
            <h3 class="lined">Uw competitie uitslagen</h3>
            <p>Bekijk uw inschrijvingen en resultaten voor de competitie en toernooien.</p>
            <a href="#" style="float:right;margin-right:30px;margin-bottom:20px;">Naar mijn uitslagen</a>
          </div>
        </div>

        <div class="one-half last">
        <i class="icon-docs special"></i>
          <div class="info">
            <h3 class="lined">Uw toernooi uitslagen</h3>
            <p>Volg uw toernooi en tegenstanders.</p>
            <a href="#" style="float:right;margin-right:30px;margin-bottom:20px;">Naar mijn uitslagen</a>
          </div>
        </div>

        <div class="one-half first">
        <i class="icon-cloud special"></i>
          <div class="info">
            <h3 class="lined">Uw vereniging(en)</h3>
            <p>Eenvoudig toegang tot de gegevens van uw eigen vereniging(en).</p>
            <a href="#" style="float:right;margin-right:30px;">Naar mijn vereniging(en)</a>
          </div>
        </div>
        <div class="one-half last">
        <i class="icon-user special"></i>
          <div class="info">
            <h3 class="lined">Digitaal afhangen</h3>
            <p>U kunt direct naar het digitale afhangen van ClubCloud.</p>
            <a href="#" style="float:right;margin-right:30px;">Naar digitaal afhangen</a>
          </div>
        </div>
        <br>

        <div class="one-half first">
        <i class="icon-ccw special"></i>
          <div class="info">
            <h3 class="lined">Synchronisatie</h3>
            <p>Mijn ClubCloud synchroniseert uw gegevens met die van de KNLTB. Dit zijn uw persoonlijke gegevens maar ook uw wedstrijden.
            </p>
          </div>
        </div>
        <div class="one-half last">
        <i class="icon-check-1 special"></i>
          <div class="info">
            <h3 class="lined">Alle platformen</h3>
            <p>Mijn ClubCloud is een modern platform. U kunt uw gegevens bekijken via uw computer, tablet of SmartPhone.</p>
          </div>
        </div>
        <br>

        <div class="clear"></div>
      </div>
    </div>


        <!-- Custom Homepage -->
    <div class="inner light">

        <div class="symple-column symple-two-third symple-column-first ">
<h3>Over Mijn ClubCloud</h3>
<div class="symple-accordion ">
<h3 class="symple-accordion-trigger "><a href="#">Waarom is er Mijn ClubCloud ?</a></h3><div>ClubCloud werkt voor tennissers die recreatief of competitief tennissen in Nederland. Er worden een heleboel verplichtingen gesteld maar er zijn maar weinig baten. 
    ClubCloud wil graag voor tennissers de baten!! Inzicht in uw eigen gegevens, uw competitie, uw toernooien, digital afhangen, controle over uw betalingen, sociale functionaliteiten.</div>
<br/>
<h3 class="symple-accordion-trigger "><a href="#">Voordelen van Mijn ClubCloud ?</a></h3><div>Wij proberen uw tennis plezier te verhogen door eerst aan de tennissers te denken. We hebben geen behoefte om u latsig te vallen met Sponsors, Toptennis of DavisCup. Wij geven u de controle over uw gegevens. <b>ClubCloud werkt voor alle moderne platformen en browsers en heeft diverse Apps voor SmartPhones en SmartDevices.</b></div>
<br/>
<h3 class="symple-accordion-trigger "><a href="#">Hoe werkt Mijn ClubCloud ?</a></h3><div>Naast uw eigen gegevens halen wij, met uw toestemming, gegevens op bij de KNLTB. Met al deze gegevens proberen wij uw tennis plezier te vergroten. Snel informatie vinden en delen. Over uw informatie heeft u de controle en alle informatie wordt veilig bewaard.<br />
</div>
<br/>
<h3 class="symple-accordion-trigger "><a href="#">Wat kost Mijn ClubCloud ?</a></h3><div>Mijn ClubCloud is helemaal gratis. Geen verplichtingen, gratis, open en transparant.<br />
</div>
</div>
</div>
    <div class="clear"></div>
    </div>
</asp:Content>







