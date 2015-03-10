<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormSection" Src="~/_controltemplates/InputFormSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormControl" Src="~/_controltemplates/InputFormControl.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ContentDatabaseSection" Src="~/_admin/ContentDatabaseSection.ascx" %>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagePackage.aspx.cs" Inherits="ClubCloud.Service.Administration.ManagePackage" MasterPageFile="~/_admin/admin.master" %>

<asp:Content ID="contentPageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
</asp:Content>
<asp:Content ID="contentPageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    <asp:Literal ID="literalDatabaseSettingsPageTitle" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, UsersSettingsPageTitle %>'></asp:Literal>
</asp:Content>
<asp:Content ID="contentTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server">
    <a href="/_admin/ServiceApplications.aspx">
        <SharePoint:EncodedLiteral ID="EncodedLiteral1" runat="server" Text="<%$Resources:spadmin, svcappsadm_pagetitle%>" EncodeMethod='HtmlEncode' /></a> : 
    <a href="/_admin/ClubCloud.Service/ManageApplication.aspx?id=<%= Request.QueryString["id"] %>">
        <asp:Literal ID="literalManagePage" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ApplicationManagementPageTitle %>'></asp:Literal></a> :
    <asp:Literal ID="literalPageTitleInTitleArea" runat="server" Text='Store Packages'></asp:Literal>
</asp:Content>
<asp:Content ID="contentPageDescription" ContentPlaceHolderID="PlaceHolderPageDescription" runat="server">
    <asp:Literal ID="literalPageDescription" runat="server" Text='ClubCloud Store Packages beheren' Mode="PassThrough" />
</asp:Content>
<asp:Content ID="contentMain" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <asp:Panel ID="panelError" runat="server" Visible="false">
        <asp:Label ID="labelError" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label>
    </asp:Panel>
    <asp:Panel ID="panelMain" runat="server">
        <table width="100%" class="propertysheet" cellspacing="0" cellpadding="0" border="0">
            <tr>
                <td class="ms-descriptionText">
                    <asp:Label ID="LabelMessage" runat="server" EnableViewState="False" CssClass="ms-descriptionText" />

                </td>
            </tr>
            <tr>
                <td class="ms-error">
                    <asp:Label ID="LabelErrorMessage" runat="server" EnableViewState="False" /></td>
            </tr>
            <tr>
                <td class="ms-descriptionText">
                    <asp:ValidationSummary ID="validationSummary" HeaderText="<%$SPHtmlEncodedResources:spadmin, ValidationSummaryHeaderText%>" DisplayMode="BulletList" ShowSummary="True" runat="server"></asp:ValidationSummary>
                </td>
            </tr>
        </table>
        <table border="0" cellspacing="0" cellpadding="0" width="100%" class="ms-propertysheet">
            <wssuc:InputFormSection Title="" ID="buttonSectionTop" runat="server">
                <template_inputformcontrols>
                <wssuc:InputFormControl LabelText="" runat="server">
                    <Template_control>				        
				        <asp:Button runat="server" CssClass="ms-ButtonHeightWidth" OnClick="ButtonNew_Click" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ButtonNewText %>" ID="buttonNewTop" />
                        <asp:Button runat="server" CssClass="ms-ButtonHeightWidth" OnClick="ButtonOk_Click" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ButtonOKText %>" ID="buttonOkTop" />
                    </Template_control>
                </wssuc:InputFormControl>
            </template_inputformcontrols>
            </wssuc:InputFormSection>
            <wssuc:InputFormSection Title="Store Package Uploader" runat="server">
                <template_description>
		  <SharePoint:EncodedLiteral ID="EncodedLiteral2" runat="server" text="Upload een zip met de appx, cer en appxsym bestanden" EncodeMethod="HtmlEncode"/>
		</template_description>
            <template_inputformcontrols>
		  <wssuc:InputFormControl runat="server">
			<Template_Control>
			  <table border="0" cellspacing="1">
				<tr>
				  <td class="ms-authoringcontrols" colspan="2" nowrap="nowrap">
					<SharePoint:EncodedLiteral ID="lbl_instruction" runat="server" text="Selecteer een zip voor inladen." EncodeMethod="HtmlEncode"/>:
					<font size="3">&#160;</font><br />
				  </td>
				</tr>
				<tr>
				  <td dir="ltr">
					  <asp:FileUpload ID="fup_package" runat="server" CssClass="ms-input" />               
				  </td>
				</tr>
			  </table>
			</Template_Control>
		  </wssuc:InputFormControl>
		</template_inputformcontrols>
            </wssuc:InputFormSection>
            <wssuc:InputFormSection Title="" ID="buttonSectionBottom" runat="server">
                <template_inputformcontrols>
                <wssuc:InputFormControl LabelText="" runat="server">
                    <Template_control>
				    <asp:Button runat="server" CssClass="ms-ButtonHeightWidth" OnClick="ButtonNew_Click" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ButtonNewText %>" ID="buttonNewBottom" />&nbsp;&nbsp;
                        <asp:Button runat="server" CssClass="ms-ButtonHeightWidth" OnClick="ButtonOk_Click" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ButtonOKText %>" ID="buttonOkBottom" />
                    </Template_control>
                </wssuc:InputFormControl>
            </template_inputformcontrols>
            </wssuc:InputFormSection>

        </table>
    </asp:Panel>
</asp:Content>


