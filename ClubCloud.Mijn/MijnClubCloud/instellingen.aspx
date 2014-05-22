<%@ Page language="C#" MasterPageFile="~masterurl/default.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" meta:progid="SharePoint.WebPartPage.Document" meta:webpartpageexpansion="full"  %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="ClubCloud" Namespace="ClubCloud.Mijn.ControlTemplates" Assembly="ClubCloud.Mijn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="ClubCloud" TagName="FaceBookUserControl" src="~/_controltemplates/ClubCloud.Mijn/FaceBookUserControl.ascx" %>
<%@ Register TagPrefix="ClubCloud" TagName="KNLTBUserControl" src="~/_controltemplates/ClubCloud.Mijn/KNLTBUserControl.ascx" %>
<%@ Register TagPrefix="ClubCloud" TagName="TwitterUserControl" src="~/_controltemplates/ClubCloud.Mijn/TwitterUserControl.ascx" %>
<%@ Register TagPrefix="ClubCloud" TagName="BetalingenUserControl" src="~/_controltemplates/ClubCloud.Mijn/BetalingenUserControl.ascx" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<asp:Content ContentPlaceHolderId="PlaceHolderPageTitle" runat="server">
    <SharePoint:ProjectProperty Property="Title" runat="server"/>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderId="PlaceHolderMain" runat="server">
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
	            	<p>U bepaalt welke gegevens u met andere wilt delen of 
					verbergen.<br/>
	            	</p>
	            </div>
	    	</div>  
	        <div class="one-half last">
		        <i class="icon-shareable special"></i>
					<div class="info lined">
						<h3 class="lined">Betalings instellingen</h3>
						<p>Bepaal op welke wijze uw vereniging(en) bij u 
						betalingen kunnen verwerken.
							<ClubCloud:BetalingenUserControl ID="instellingen_betalingen" runat="server"></ClubCloud:BetalingenUserControl><br/>						
						</p>
					</div>
	        </div>
	        <br/>
	        <div class="one-half first">
		        <i class="icon-facebook special"></i>
	            <div class="info lined">
	            	<h3 class="lined">FaceBook</h3>
	            	<p>U kunt uw presetaties en updates automatisch op FaceBook 
					delen.<br/>
		            		<ClubCloud:FaceBookUserControl ID="instellingen_facebook" runat="server"></ClubCloud:FaceBookUserControl><br/>	            	
	            	</p>
	            </div>
	    	</div>  
	        <div class="one-half last">
		        <i class="icon-twitter special"></i>
					<div class="info lined">
						<h3 class="lined">Twitter </h3>
						<p>U kunt uw presetaties en updates automatisch op 
						Twitter delen.<br/>
		            		<ClubCloud:TwitterUserControl ID="instellingen_twitter" runat="server"></ClubCloud:TwitterUserControl><br/>
						</p>
					</div>
	        </div>
	        <br/>
	        <div class="one-half first">
		        <i class="icon-linkedin special"></i>
	            <div class="info lined">
	            	<h3 class="lined">LinkedIn</h3>
	            	<p>U kunt uw presetaties en updates automatisch op LinkedIn 
					delen.</p>
	            </div>
	    	</div>  
	        <div class="one-half last">
		        <i class="icon-mobile special"></i>
	            <div class="info lined">
	            	<h3 class="lined">Live</h3>
	            	<p>U kunt uw presetaties en updates automatisch op Live 
					delen.</p>
	            </div>
	        </div>	    	        
	        <br/>
	        <div class="one-half first">
		        <i class="icon-magic special"></i>
	            <div class="info lined">
	            	<h3 class="lined">MijnKNLTB</h3>
	            	<p>Synchronisser uw KNTLB gegevens. Met het instellen van de 
					synchronisatie kunt u via MijnClubCloud uw actuele tennis 
					gegevens bekijken zoals bekend bij de KNLTB.<br/>
	            		<ClubCloud:KNLTBUserControl ID="knltb_validate" runat="server"></ClubCloud:KNLTBUserControl><br/>
	            	</p>
	            </div>
	    	</div>  
	        <div class="one-half last">
		        <i class="icon-key  special"></i>
					<div class="info lined">
						<h3 class="lined">ClubCloud wachtwoord </h3>
						<p>Wijzig uw ClubCloud wachtwoord.</p>
					</div>
	        </div>	    	        
    		<div class="clear"></div>
		</div>    	
    </div>
</asp:Content>
