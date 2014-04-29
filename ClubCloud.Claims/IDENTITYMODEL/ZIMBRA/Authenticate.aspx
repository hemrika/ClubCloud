<%@ Assembly Name="Microsoft.SharePoint.IdentityModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Assembly Name="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c"%>
<%@ Assembly Name="ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Page Language="C#" Inherits="ClubCloud.Provider.IdentityModel.AuthenticatePage" MasterPageFile="~/_layouts/15/errorv15.master"       %> 
<%@ Import Namespace="Microsoft.SharePoint.WebControls" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %> <%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<asp:Content ContentPlaceHolderId="PlaceHolderPageTitle" runat="server">
	<SharePoint:EncodedLiteral runat="server"  EncodeMethod="HtmlEncode" Id="ClaimsFormsPageTitle" />
</asp:Content>
<asp:Content ContentPlaceHolderId="PlaceHolderMain" runat="server">
 <div id="SslWarning" style="color:red;display:none">
 <SharePoint:EncodedLiteral runat="server"  EncodeMethod="HtmlEncode" Id="ClaimsFormsPageMessage" />
 </div>
  <script language="javascript" >
	if (document.location.protocol != 'https:')
	{
		var SslWarning = document.getElementById('SslWarning');
		SslWarning.style.display = '';
	}
  </script>
</asp:Content>
