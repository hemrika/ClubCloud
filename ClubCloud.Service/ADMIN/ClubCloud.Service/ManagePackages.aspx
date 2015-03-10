<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %> 
<%@ Register TagPrefix="wssuc" TagName="InputFormSection" Src="~/_controltemplates/InputFormSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormControl" Src="~/_controltemplates/InputFormControl.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="ContentDatabaseSection" src="~/_admin/ContentDatabaseSection.ascx" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagePackages.aspx.cs" Inherits="ClubCloud.Service.Administration.ManagePackages" MasterPageFile="~/_admin/admin.master" %>
<asp:Content ID="contentPageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
</asp:Content>
<asp:Content ID="contentPageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    <asp:Literal ID="literalDatabaseSettingsPageTitle" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, UsersSettingsPageTitle %>'></asp:Literal>
</asp:Content>
<asp:Content ID="contentTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
    <a href="/_admin/ServiceApplications.aspx"><SharePoint:EncodedLiteral ID="EncodedLiteral1" runat="server" Text="<%$Resources:spadmin, svcappsadm_pagetitle%>" EncodeMethod='HtmlEncode'/></a> : 
    <a href="/_admin/ClubCloud.Service/ManageApplication.aspx?id=<%= Request.QueryString["id"] %>"><asp:Literal ID="literalManagePage" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ApplicationManagementPageTitle %>'></asp:Literal></a> :
    <asp:Literal ID="literalPageTitleInTitleArea" runat="server" Text='Store Packages'></asp:Literal>
</asp:Content>
<asp:content ID="contentPageDescription" ContentPlaceHolderID="PlaceHolderPageDescription" runat="server">
	<asp:Literal id="literalPageDescription" runat="server" Text='ClubCloud Store Packages beheren' Mode="PassThrough" />
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
				        <asp:Button runat="server" CssClass="ms-ButtonHeightWidth" OnClick="ButtonNew_Click" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ButtonNewText %>" ID="buttonNewTop" />
                        <asp:Button runat="server" CssClass="ms-ButtonHeightWidth" OnClick="ButtonOk_Click" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ButtonOKText %>" ID="buttonOkTop" />
                    </Template_control>
                </wssuc:InputFormControl>
            </template_inputformcontrols>
        </wssuc:InputFormSection>
                        <asp:GridView CssClass="ms-listviewtable" GridLines="None" Cellspacing="0" Cellpadding="0" HeaderStyle-CssClass="ms-viewheadertr" AlternatingRowStyle-CssClass="ms-alternatingstrong" ID="gvw_packages" runat="Server" AutoGenerateColumns="false" Width="100%">
                            <Columns>
                                <asp:TemplateField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" ItemStyle-Width="16px">
                                    <ItemTemplate>
                                        <asp:Image runat="server" ImageUrl="/_admin/ClubCloud.Service/ServiceApplication16.png"></asp:Image>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" HeaderText="ApplicationName" DataField="ApplicationName" />
                                <asp:BoundField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" HeaderText="Status" DataField="MajorVersion" />
                                <asp:BoundField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" HeaderText="Status" DataField="Status" />
                                <asp:BoundField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" HeaderText="CreationDate" DataField="CreationDate" />
                                <asp:BoundField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" HeaderText="OperationDate" DataField="OperationDate" />
                                <asp:BoundField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" HeaderText="IsHidden" DataField="IsHidden" />
                                <asp:BoundField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" HeaderText="IsRecommended" DataField="IsRecommended" />
                                <asp:BoundField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" HeaderText="IsValid" DataField="IsValid" />
                                <asp:BoundField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" HeaderText="IsPublicApp" DataField="IsPublicApp" />
                                <asp:TemplateField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" HeaderText="Beheren">
                                    <ItemTemplate>
                                        <asp:HyperLink runat="Server" NavigateUrl='<%# Eval("Id", "/_admin/ClubCloud.Service/ManagePackage.aspx?id={0}") %>' Text="Beheren"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <EmptyDataTemplate>
                                <asp:Label runat="server" Text="Geen Packages gevonden" EnableViewState="false"></asp:Label>
                                <br />
                                <br />
                                <a href="/_admin/ClubCloud.Service/ManagePackage.aspx"><SharePoint:EncodedLiteral runat="server" Text="Upload package" EncodeMethod='HtmlEncode' EnableViewState="false" /></a>
                            </EmptyDataTemplate>
                        </asp:GridView>
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


