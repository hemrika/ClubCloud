<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register TagPrefix="wssuc" TagName="InputFormSection" Src="~/_controltemplates/InputFormSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormControl" Src="~/_controltemplates/InputFormControl.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="IisWebServiceApplicationPoolSection" src="~/_admin/IisWebServiceApplicationPoolSection.ascx" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateApplication.aspx.cs" Inherits="ClubCloud.Service.Administration.CreateApplicationPage" MasterPageFile="~/_layouts/dialog.master" %>
<asp:Content ID="contentDialogHeaderPageTitle" ContentPlaceHolderID="PlaceHolderDialogHeaderPageTitle" runat="server">
    <asp:Literal ID="literalDialogHeaderPageTitle" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, CreatePageTitle %>'></asp:Literal>
</asp:Content>
<asp:Content ID="contentDialogDescription" ContentPlaceHolderID="PlaceHolderDialogDescription" runat="server">
    <asp:Literal id="literalDialogDescription" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, CreatePageDescription %>' Mode="PassThrough" />
</asp:Content>
<asp:Content ID="contentHelpLink" ContentPlaceHolderID="PlaceHolderHelpLink" runat="server">
</asp:Content>
<asp:Content ID="contentDialogImage" ContentPlaceHolderID="PlaceHolderDialogImage" runat="server">
    <img src="/_admin/ClubCloud.Service/ca-icon.png" alt="" />
</asp:Content>
<asp:Content ID="contentDialogBodyMainSection" contentplaceholderid="PlaceHolderDialogBodyMainSection" runat="server">
    <asp:Panel ID="panelError" runat="server" Visible="false">
        <asp:Label ID="labelError" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label>
    </asp:Panel>
    <table width="100%" class="propertysheet" cellspacing="0" cellpadding="0" border="0"> <tr> <td class="ms-descriptionText"> <asp:Label ID="labelMessage" runat="server" EnableViewState="False" CssClass="ms-descriptionText"/> </td> </tr> <tr> <td class="ms-error"><asp:Label ID="labelErrorMessage" runat="server" EnableViewState="False" /></td> </tr> <tr> <td class="ms-descriptionText"> <asp:ValidationSummary ID="validationSummary" HeaderText="<%$SPHtmlEncodedResources:spadmin, ValidationSummaryHeaderText%>" DisplayMode="BulletList" ShowSummary="True" runat="server"> </asp:ValidationSummary> </td> </tr> </table>
    <table border="0" cellspacing="0" cellpadding="0" width="100%" class="ms-propertysheet">
            <wssuc:InputFormSection runat="server" Title="<%$Resources: ClubCloud.Service.ServiceAdminResources, CreateApplicationNameSectionTitle%>" Description="<%$Resources: ClubCloud.Service.ServiceAdminResources, CreateApplicationNameSectionDescription%>">
                <Template_InputFormControls>
                    <wssuc:InputFormControl runat="server" LabelText="<%$ Resources: ClubCloud.Service.ServiceAdminResources, CreateApplicationNameLabel %>" >
                        <Template_Control>
                            <asp:TextBox runat="server" ID="textBoxServiceName" MaxLength="50" Width="300px" />
    			            <asp:RequiredFieldValidator ID="requiredFieldValidatorServiceName" runat="server" ControlToValidate="textBoxServiceName" Font-Bold="true" Forecolor="Red" Text="*" Display="Dynamic" ErrorMessage="<%$ Resources: ClubCloud.Service.ServiceAdminResources, CreateApplicationNameRequiredError %>"></asp:RequiredFieldValidator>
                            <asp:CustomValidator ID="customValidatorServiceNameDuplicate" runat="server" ControlToValidate="textBoxServiceName" OnServerValidate="CustomValidatorServiceNameDuplicate_ServerValidate" Font-Bold="true" Forecolor="Red" Text="*" Display="Dynamic" ErrorMessage="<%$ Resources: ClubCloud.Service.ServiceAdminResources, CreateApplicationNameDuplicateError %>"></asp:CustomValidator>
                        </Template_Control>
                    </wssuc:InputFormControl>
                </Template_InputFormControls>      
            </wssuc:InputFormSection>
            <wssuc:IisWebServiceApplicationPoolSection runat="server" ID="applicationPoolSection" />
            <wssuc:InputFormSection runat="server" Title="<%$Resources: ClubCloud.Service.ServiceAdminResources, CreateApplicationDefaultProxySectionTitle%>" Description="<%$Resources: ClubCloud.Service.ServiceAdminResources, CreateApplicationDefaultProxySectionDescription%>">
                <Template_InputFormControls>
                    <wssuc:InputFormControl runat="server" LabelText="<%$ Resources: ClubCloud.Service.ServiceAdminResources, CreateApplicationDefaultProxyLabel %>" >
                        <Template_Control>
                            <asp:CheckBox ID="checkBoxIncludeInDefaultProxy" runat="server" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, CreateApplicationDefaultProxyCheckBoxLabel %>" />
                        </Template_Control>
                    </wssuc:InputFormControl>
                </Template_InputFormControls>      
            </wssuc:InputFormSection>                       
    </table>
</asp:Content>
                



