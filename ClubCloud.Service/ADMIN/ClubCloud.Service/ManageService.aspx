﻿<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %> 
<%@ Register TagPrefix="wssuc" TagName="InputFormSection" Src="~/_controltemplates/InputFormSection.ascx" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormControl" Src="~/_controltemplates/InputFormControl.ascx" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageService.aspx.cs" Inherits="ClubCloud.Service.Administration.ManageServicePage" MasterPageFile="~/_admin/admin.master" %>
<asp:Content ID="contentPageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
</asp:Content>
<asp:Content ID="contentPageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    <asp:Literal ID="literalPageTitle" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServicePageTitle %>' EnableViewState="false"></asp:Literal>
</asp:Content>
<asp:Content ID="contentPageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
    <a href="/Applications.aspx"><SharePoint:EncodedLiteral runat="server" Text="<%$Resources:spadmin, applications_pagetitle%>" EncodeMethod='HtmlEncode' EnableViewState="false" /></a> : 
    <asp:Literal ID="literalPageTitleInTitleArea" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServicePageTitleInTitleArea %>' EnableViewState="false"></asp:Literal>
</asp:Content>
<asp:Content ID="contentPageDescription" ContentPlaceHolderID="PlaceHolderPageDescription" runat="server">
	<asp:Literal id="literalPageDescription" runat="server" Text='<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServicePageDescription %>' Mode="PassThrough" EnableViewState="false" />
</asp:Content>
<asp:Content ID="contentMain" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <asp:Panel ID="panelError" runat="server" Visible="false">
        <asp:Label ID="labelError" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label>
    </asp:Panel>
    <asp:Panel ID="panelMain" runat="server">
    <table width="100%" class="propertysheet" cellspacing="0" cellpadding="0" border="0"> <tr> <td class="ms-descriptionText"> <asp:Label ID="labelMessage" runat="server" EnableViewState="False" CssClass="ms-descriptionText"/> </td> </tr> <tr> <td class="ms-error"><asp:Label ID="labelErrorMessage" runat="server" EnableViewState="False" /></td> </tr> <tr> <td class="ms-descriptionText"> <asp:ValidationSummary ID="validationSummary" HeaderText="<%$SPHtmlEncodedResources:spadmin, ValidationSummaryHeaderText%>" DisplayMode="BulletList" ShowSummary="True" runat="server"> </asp:ValidationSummary> </td> </tr> </table>
    <table border="0" cellspacing="0" cellpadding="0" width="100%" class="ms-propertysheet">
        <wssuc:InputFormSection Title="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceStatusSectionTitle %>" ID="serviceStatusSection" runat="server" Description="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceStatusSectionDescription %>">
            <template_inputformcontrols>
                <wssuc:InputFormControl LabelText="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceStatusLabel %>" runat="server">
                    <Template_control>
                        <table class="ms-listviewtable" cellpadding="0" cellspacing="0" border="0" style="width:100%;">
                            <tbody>
                                <tr class="ms-viewheadertr">
                                    <th class="ms-vh2-nofilter ms-vh2-gridview" scope="col" style="width:16px;"></th>
                                    <th class="ms-vh2-nofilter ms-vh2-gridview" scope="col"><asp:Literal runat="server" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceStatusComponentHeader %>" EnableViewState="false"></asp:Literal></th>
                                    <th class="ms-vh2-nofilter ms-vh2-gridview" scope="col"><asp:Literal runat="server" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceStatusHeader %>"></asp:Literal></th>
                                </tr>
                                <tr>
                                    <td class="ms-vb2"><asp:Image runat="server" ID="imageServiceStatus" /></td>
                                    <td class="ms-vb2"><asp:Literal runat="server" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceServiceComponent %>" EnableViewState="false"></asp:Literal></td>
                                    <td class="ms-vb2"><asp:Literal ID="literalServiceStatus" runat="server"></asp:Literal></td>
                                </tr>
                                <tr class="ms-alternatingstrong">
                                    <td class="ms-vb2"><asp:Image runat="server" ID="imageServiceProxyStatus" /></td>
                                    <td class="ms-vb2"><asp:Literal runat="server" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceServiceProxyComponent %>" EnableViewState="false"></asp:Literal></td>
                                    <td class="ms-vb2"><asp:Literal ID="literalServiceProxyStatus" runat="server"></asp:Literal></td>
                                </tr>
                            </tbody>
                        </table>
                        <br />
                        <asp:Button ID="buttonInstallService" runat="server" CssClass="ms-ButtonHeightWidth" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceInstallButtonText %>" OnClick="ButtonInstallService_Click" />
                        <asp:Button ID="buttonRemoveService" runat="server" CssClass="ms-ButtonHeightWidth" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceRemoveButtonText %>" OnClick="ButtonRemoveService_Click" OnClientClick="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceRemoveConfirmText %>" />
                    </Template_control>
                </wssuc:InputFormControl>
            </template_inputformcontrols>
        </wssuc:InputFormSection>
        <wssuc:InputFormSection Title="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceInstanceStatusSectionTitle %>" ID="serviceInstanceStatusSection" runat="server" Description="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceInstanceStatusSectionDescription %>">
            <template_inputformcontrols>
                <wssuc:InputFormControl LabelText="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceInstanceStatusLabel %>" runat="server">
                    <Template_control>
                        <asp:GridView CssClass="ms-listviewtable" HeaderStyle-CssClass="ms-viewheadertr" GridLines="None" Cellpadding="0" Cellspacing="0" AlternatingRowStyle-CssClass="ms-alternatingstrong" ID="gridViewInstanceStatus" runat="Server" AutoGenerateColumns="false" Width="100%">
                            <Columns>
                                <asp:ImageField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" ItemStyle-Width="16px" DataAlternateTextField="ServerStatus" DataAlternateTextFormatString="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceInstanceStatusAlternateText %>" 
                                DataImageUrlField="ServerStatusImage" />
                                <asp:BoundField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" HeaderText="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceServerNameHeaderText %>" DataField="ServerName" />
                                <asp:BoundField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" HeaderText="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceServerStatusHeaderText %>" DataField="ServerStatus" />
                                <asp:TemplateField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" HeaderText="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceServerManageHeaderText %>">
                                    <ItemTemplate>
                                        <asp:HyperLink runat="Server" NavigateUrl='<%# Eval("ServerId", "/_admin/Server.aspx?ServerId={0}") %>' Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceServerManageHeaderText %>" Visible='<%# Eval("IsInstalled") %>'></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        <br />
                        <asp:Button ID="buttonInstallServiceInstances" runat="server" CssClass="ms-ButtonHeightWidth" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceInstallServiceInstancesButtonText %>" OnClick="ButtonInstallServiceInstances_Click" />
                    </Template_control>
                </wssuc:InputFormControl>
            </template_inputformcontrols>
        </wssuc:InputFormSection>
        <wssuc:InputFormSection Title="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceApplicationStatusSectionTitle %>" ID="serviceApplicationStatusSection" runat="server" Description="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceApplicationStatusSectionDescription %>">
            <template_inputformcontrols>
                <wssuc:InputFormControl LabelText="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceApplicationStatusLabel %>" runat="server">
                    <Template_control>
                        <asp:GridView CssClass="ms-listviewtable" GridLines="None" Cellspacing="0" Cellpadding="0" HeaderStyle-CssClass="ms-viewheadertr" AlternatingRowStyle-CssClass="ms-alternatingstrong" ID="gridViewApplicationStatus" runat="Server" AutoGenerateColumns="false" Width="100%">
                            <Columns>
                                <asp:TemplateField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" ItemStyle-Width="16px">
                                    <ItemTemplate>
                                        <asp:Image runat="server" ImageUrl="/_admin/ClubCloud.Service/ServiceApplication16.png"></asp:Image>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" HeaderText="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceApplicationNameHeaderText %>" DataField="Name" />
                                <asp:TemplateField HeaderStyle-CssClass="ms-vh2-nofilter ms-vh2-gridview" ItemStyle-CssClass="ms-vb2" HeaderText="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceApplicationManageHeaderText %>">
                                    <ItemTemplate>
                                        <asp:HyperLink runat="Server" NavigateUrl='<%# Eval("Id", "/_admin/ClubCloud.Service/ManageApplication.aspx?id={0}") %>' Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceApplicationManageHeaderText %>"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <EmptyDataTemplate>
                                <asp:Label runat="server" Text="<%$ Resources: ClubCloud.Service.ServiceAdminResources, ManageServiceApplicationEmptyData %>" EnableViewState="false"></asp:Label>
                                <br />
                                <br />
                                <a href="/_admin/ServiceApplications.aspx"><SharePoint:EncodedLiteral runat="server" Text="<%$Resources:spadmin, svcappsadm_pagetitle%>" EncodeMethod='HtmlEncode' EnableViewState="false" /></a>
                            </EmptyDataTemplate>
                        </asp:GridView>
                    </Template_control>
                </wssuc:InputFormControl>
            </template_inputformcontrols>
        </wssuc:InputFormSection>
    </table>
    </asp:Panel>
</asp:Content>
