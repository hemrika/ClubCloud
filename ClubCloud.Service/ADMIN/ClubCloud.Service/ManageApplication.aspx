<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %> 
<%@ Register TagPrefix="wssuc" TagName="InputFormSection" Src="~/_controltemplates/InputFormSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormControl" Src="~/_controltemplates/InputFormControl.ascx" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageApplication.aspx.cs" Inherits="ClubCloud.Service.Administration.ManageApplicationPage" MasterPageFile="~/_admin/admin.master" %>
<asp:Content ID="contentPageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
<script type="text/javascript">
    SP.SOD.executeFunc("sp.ui.dialog.js", "SP.UI.ModalDialog", ensureModalScriptLoaded);
    
    function ensureModalScriptLoaded() {        
    }
</script>
</asp:Content>
<asp:Content ID="contentPageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    <asp:Literal ID="literalPageTitle" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ApplicationManagementPageTitle %>' Mode="PassThrough"></asp:Literal>
</asp:Content>
<asp:Content ID="contentPageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
    <a href="/_admin/ServiceApplications.aspx"><SharePoint:EncodedLiteral runat="server" Text="<%$Resources:spadmin, svcappsadm_pagetitle%>" EncodeMethod='HtmlEncode'/></a> : <asp:Literal ID="literalPageTitleInTitleArea" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ApplicationManagementPageTitleInTitleArea %>' Mode="PassThrough"></asp:Literal>
</asp:Content>
<asp:content ID="contentPageDescription" ContentPlaceHolderID="PlaceHolderPageDescription" runat="server">
	<asp:Literal id="literalPageDescription" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ApplicationManagementPageDescription %>' Mode="PassThrough" />
</asp:content>
<asp:Content ID="contentMain" ContentPlaceHolderID="PlaceHolderMain" runat="server">
<asp:Panel ID="panelError" runat="server" Visible="false">
    <asp:Label ID="labelError" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label>
</asp:Panel>
<asp:Panel ID="panelMain" runat="server">
    <table border="0" cellspacing="0" cellpadding="0" width="100%" class="ms-propertysheet">
		<wssuc:InputFormSection Title='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ApplicationManagementPropertiesSectionTitle %>' ID="propertiesSection" runat="server" Description='<%$ Resources:ClubCloud.Service.ServiceAdminResources, ApplicationManagementPropertiesSectionDescription %>'>
            <template_inputformcontrols>
                <wssuc:InputFormControl LabelText="" runat="server">
                    <Template_control>
                        <asp:LinkButton ID="linkButtonProperties" runat="server" OnClientClick='<%# GeneratePopupLink("Properties.aspx") %>' Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ApplicationManagementPropertiesButtonText %>'></asp:LinkButton>
                    </Template_control>
                </wssuc:InputFormControl>
            </template_inputformcontrols>
        </wssuc:InputFormSection>
		<wssuc:InputFormSection Title='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ApplicationManagementDBSettingsSectionTitle %>' ID="databaseConfigSection" runat="server" Description='<%$ Resources:ClubCloud.Service.ServiceAdminResources, ApplicationManagementDBSettingsSectionDescription %>'>
            <template_inputformcontrols>
                <wssuc:InputFormControl LabelText="" runat="server">
                    <Template_control>
                        <asp:HyperLink ID="hyperlinkDatabaseSettings" runat="server" NavigateUrl='<%# GenerateLink("DatabaseSettings.aspx") %>' Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ApplicationManagementDBSettingsButtonText %>'></asp:HyperLink>
                    </Template_control>
                </wssuc:InputFormControl>
            </template_inputformcontrols>
        </wssuc:InputFormSection>
        <wssuc:InputFormSection Title='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ApplicationManagementUsersSettingsSectionTitle %>' ID="gebruikersConfigSection" runat="server" Description='<%$ Resources:ClubCloud.Service.ServiceAdminResources, ApplicationManagementUsersSettingsSectionDescription %>'>
            <template_inputformcontrols>
                <wssuc:InputFormControl LabelText="" runat="server">
                    <Template_control>
                        <asp:HyperLink ID="hyperlinkusersSettings" runat="server" NavigateUrl='<%# GenerateLink("ManageUsers.aspx") %>' Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ApplicationManagementUsersSettingsButtonText %>'></asp:HyperLink>
                    </Template_control>
                </wssuc:InputFormControl>
            </template_inputformcontrols>
        </wssuc:InputFormSection>
                <wssuc:InputFormSection Title='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ApplicationManagementMetaDataSettingsSectionTitle %>' ID="metadataConfigSection" runat="server" Description='<%$ Resources:ClubCloud.Service.ServiceAdminResources, ApplicationManagementMetaDataSettingsSectionDescription %>'>
            <template_inputformcontrols>
                <wssuc:InputFormControl LabelText="" runat="server">
                    <Template_control>
                        <asp:HyperLink ID="hyperlink1" runat="server" NavigateUrl='<%# GenerateLink("ManageMetaData.aspx") %>' Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ApplicationManagementMetaDataSettingsButtonText %>'></asp:HyperLink>
                    </Template_control>
                </wssuc:InputFormControl>
            </template_inputformcontrols>
        </wssuc:InputFormSection>
    </table>
</asp:Panel>
</asp:Content>
