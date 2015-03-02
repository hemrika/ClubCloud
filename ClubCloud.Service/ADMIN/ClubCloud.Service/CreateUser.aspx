<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %> 
<%@ Register TagPrefix="wssuc" TagName="InputFormSection" Src="~/_controltemplates/InputFormSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormControl" Src="~/_controltemplates/InputFormControl.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ContentDatabaseSection" src="~/_admin/ContentDatabaseSection.ascx" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="ClubCloud.Service.Administration.CreateUserPage" MasterPageFile="~/_admin/admin.master" %>
<asp:Content ID="contentPageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
</asp:Content>
<asp:Content ID="contentPageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    <asp:Literal ID="literalDatabaseSettingsPageTitle" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, UsersSettingsPageTitle %>'></asp:Literal>
</asp:Content>
<asp:Content ID="contentTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
    <a href="/_admin/ServiceApplications.aspx"><SharePoint:EncodedLiteral ID="EncodedLiteral1" runat="server" Text="<%$Resources:spadmin, svcappsadm_pagetitle%>" EncodeMethod='HtmlEncode'/></a> : 
    <a href="/_admin/ClubCloud.Service/ManageApplication.aspx?id=<%= Request.QueryString["id"] %>"><asp:Literal ID="literalManagePage" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ApplicationManagementPageTitle %>'></asp:Literal></a> :
    <asp:Literal ID="literalPageTitleInTitleArea" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, UsersSettingsPageTitleInTitleArea %>'></asp:Literal>
</asp:Content>
<asp:content ID="contentPageDescription" ContentPlaceHolderID="PlaceHolderPageDescription" runat="server">
	<asp:Literal id="literalPageDescription" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, UsersSettingsPageDescription %>' Mode="PassThrough" />
</asp:content>
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
				        <asp:Button runat="server" CssClass="ms-ButtonHeightWidth" OnClick="ButtonCancel_Click" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ButtonCancelText %>" ID="buttonCancelTop" />
                        <asp:Button runat="server" CssClass="ms-ButtonHeightWidth" OnClick="ButtonOk_Click" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ButtonOKText %>" ID="buttonOkTop" />
                    </Template_control>
                </wssuc:InputFormControl>
            </template_inputformcontrols>
        </wssuc:InputFormSection>
        <wssuc:InputFormSection runat="server" Title="<%$Resources: ClubCloud.Service.ServiceAdminResources, CreateUserSectionTitle%>" Description="<%$Resources: ClubCloud.Service.ServiceAdminResources, CreateUserSectionDescription%>">
            <Template_InputFormControls>
                <wssuc:InputFormControl runat="server" LabelText="<%$ Resources: ClubCloud.Service.ServiceAdminResources, CreateUserNameLabel %>" >
                    <Template_Control>
                        Bondsnummer :<asp:TextBox runat="server" ID="tbx_bondsnummer" MaxLength="8" Width="300px" />
                        <br />
    			        <asp:RequiredFieldValidator ID="requiredFieldValidatorBondsnummer" runat="server" ControlToValidate="tbx_bondsnummer" Font-Bold="true" Forecolor="Red" Text="*" Display="Dynamic" ErrorMessage="<%$ Resources: ClubCloud.Service.ServiceAdminResources, CreateUserRequiredError %>"></asp:RequiredFieldValidator> <br />
                        Voornaam :<asp:TextBox runat="server" ID="tbx_voornaam" MaxLength="50" Width="300px" />
                        <br />
    			        <asp:RequiredFieldValidator ID="requiredFieldValidatorAchternaam" runat="server" ControlToValidate="tbx_voornaam" Font-Bold="true" Forecolor="Red" Text="*" Display="Dynamic" ErrorMessage="<%$ Resources: ClubCloud.Service.ServiceAdminResources, CreateUserRequiredError %>"></asp:RequiredFieldValidator> <br />
                        Achternaam :<asp:TextBox runat="server" ID="tbx_achternaam" MaxLength="50" Width="300px" />
                        <br />
    			        <asp:RequiredFieldValidator ID="requiredFieldValidatorVoornaam" runat="server" ControlToValidate="tbx_achternaam" Font-Bold="true" Forecolor="Red" Text="*" Display="Dynamic" ErrorMessage="<%$ Resources: ClubCloud.Service.ServiceAdminResources, CreateUserRequiredError %>"></asp:RequiredFieldValidator> <br />
                        Email :<asp:TextBox runat="server" ID="tbx_email" MaxLength="50" Width="300px" />
                        <br />
    			        <asp:RequiredFieldValidator ID="requiredFieldValidatorEmail" runat="server" ControlToValidate="tbx_email" Font-Bold="true" Forecolor="Red" Text="*" Display="Dynamic" ErrorMessage="<%$ Resources: ClubCloud.Service.ServiceAdminResources, CreateUserRequiredError %>"></asp:RequiredFieldValidator> <br />
                        Vereniging :<asp:DropDownList runat="server" ID="ddl_vereniging" Width="300px" />
                        <br />
                    </Template_Control>
                </wssuc:InputFormControl>
            </Template_InputFormControls>      
        </wssuc:InputFormSection>
        <wssuc:InputFormSection Title="" ID="buttonSectionBottom" runat="server">
            <template_inputformcontrols>
                <wssuc:InputFormControl LabelText="" runat="server">
                    <Template_control>
				        <asp:Button runat="server" CssClass="ms-ButtonHeightWidth" OnClick="ButtonCancel_Click" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ButtonCancelText %>" ID="buttonCancelBottom" />&nbsp;&nbsp;
                        <asp:Button runat="server" CssClass="ms-ButtonHeightWidth" OnClick="ButtonOk_Click" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ButtonOKText %>" ID="buttonOkBottom" />
                    </Template_control>
                </wssuc:InputFormControl>
            </template_inputformcontrols>
        </wssuc:InputFormSection>

    </table>
    </asp:Panel>
</asp:Content>


