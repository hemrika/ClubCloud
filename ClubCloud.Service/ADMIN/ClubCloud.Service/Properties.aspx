﻿<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register TagPrefix="wssuc" TagName="InputFormSection" src="~/_controltemplates/InputFormSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormControl" src="~/_controltemplates/InputFormControl.ascx" %> 
<%@ Register TagPrefix="wssuc" TagName="ContentDatabaseSection" src="~/_admin/ContentDatabaseSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="IisWebServiceApplicationPoolSection" src="~/_admin/IisWebServiceApplicationPoolSection.ascx" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Properties.aspx.cs" Inherits="ClubCloud.Service.Administration.PropertiesPage" MasterPageFile="~/_layouts/dialog.master" %>
<asp:Content ID="contentDialogHeaderPageTitle" ContentPlaceHolderID="PlaceHolderDialogHeaderPageTitle" runat="server">
    <asp:Literal ID="literalDialogHeaderPageTitle" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, PropertiesPageTitle %>'></asp:Literal>
</asp:Content>
<asp:Content ID="contentDialogDescription" ContentPlaceHolderID="PlaceHolderDialogDescription" runat="server">
    <asp:Literal id="literalDialogDescription" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, PropertiesPageDescription %>' Mode="PassThrough" />
</asp:Content>
<asp:Content ID="contentHelpLink" ContentPlaceHolderID="PlaceHolderHelpLink" runat="server">
</asp:Content>
<asp:Content ID="contentDialogImage" ContentPlaceHolderID="PlaceHolderDialogImage" runat="server">
    <img src="/_admin/ClubCloud.Service/ca-icon.png" alt="" />
</asp:Content>
<asp:Content ID="contentDialogBodyMainSection" ContentPlaceHolderID="PlaceHolderDialogBodyMainSection" runat="server">
    <table width="100%" class="propertysheet" cellspacing="0" cellpadding="0" border="0"> <tr> <td class="ms-descriptionText"> <asp:Label ID="LabelMessage" runat="server" EnableViewState="False" CssClass="ms-descriptionText"/> </td> </tr> <tr> <td class="ms-error"><asp:Label ID="LabelErrorMessage" runat="server" EnableViewState="False" /></td> </tr> <tr> <td class="ms-descriptionText"> <asp:ValidationSummary ID="ValidationSummary" HeaderText="<%$SPHtmlEncodedResources:spadmin, ValidationSummaryHeaderText%>" DisplayMode="BulletList" ShowSummary="True" runat="server"> </asp:ValidationSummary> </td> </tr> </table>
    <table border="0" cellspacing="0" cellpadding="0" width="100%" class="ms-propertysheet">
            <wssuc:InputFormSection runat="server" Title="<%$Resources: ClubCloud.Service.ServiceAdminResources, EditServiceNameSectionTitle%>" Description="<%$Resources: ClubCloud.Service.ServiceAdminResources, EditServiceNameSectionDescription%>">
                <Template_InputFormControls>
                    <wssuc:InputFormControl runat="server" LabelText="<%$ Resources: ClubCloud.Service.ServiceAdminResources, EditServiceNameLabel %>" >
                        <Template_Control>
                            <asp:TextBox runat="server" ID="textBoxServiceName" MaxLength="50" Width="300px" />
    			            <asp:RequiredFieldValidator ID="requiredFieldValidatorServiceName" runat="server" ControlToValidate="textBoxServiceName" Font-Bold="true" Forecolor="Red" Text="*" Display="Dynamic" ErrorMessage="<%$ Resources: ClubCloud.Service.ServiceAdminResources, EditServiceNameRequiredError %>"></asp:RequiredFieldValidator>
                            <asp:CustomValidator ID="customValidatorServiceNameDuplicate" runat="server" ControlToValidate="textBoxServiceName" OnServerValidate="CustomValidatorServiceNameDuplicate_ServerValidate" Font-Bold="true" Forecolor="Red" Text="*" Display="Dynamic" ErrorMessage="<%$ Resources: ClubCloud.Service.ServiceAdminResources, EditServiceNameDuplicateError %>"></asp:CustomValidator>
                        </Template_Control>
                    </wssuc:InputFormControl>
                </Template_InputFormControls>      
            </wssuc:InputFormSection>
	    <wssuc:IisWebServiceApplicationPoolSection
		    ID="applicationPoolSection"
		    runat="server" />
    </table>
</asp:Content>