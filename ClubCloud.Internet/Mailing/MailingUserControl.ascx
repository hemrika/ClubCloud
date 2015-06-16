<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="asp" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit, Version=15.1.1.100, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MailingUserControl.ascx.cs" Inherits="ClubCloud.Internet.MailingUserControl" %>
<Common:ClubCloudDataSource ID="Mailing_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="Mailing_View" />
<div class="first dark forms">
    <asp:UpdateProgress ID="udp_mailing_progress" runat="server" AssociatedUpdatePanelID="udp_mailing">
        <ProgressTemplate>
            <div class="progess" style="position: absolute; background-color: #F9F9F9; top: 0; left: 0; width: 100%; height: 100%; -moz-opacity: 0.8; opacity: 0.8; filter: alpha(opacity=80); -ms-filter: 'progid:DXImageTransform.Microsoft.Alpha(Opacity=80)'; z-index: 10000;">
                <div class="bubbles aligncenter" style="top: 48%; z-index: 10000;">laden...</div>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:UpdatePanelAnimationExtender ID="udp_animation" runat="server" TargetControlID="udp_mailing" >
        <Animations>
            <OnUpdating>
                <Sequence>                    
                    <FadeOut AnimationTarget="Mailingform" duration="1.0" Fps="30" minimumOpacity="0" />
                </Sequence>
            </OnUpdating>
            <OnUpdated>
                <Sequence>
                    <FadeIn AnimationTarget="Mailingform" duration="1.0" Fps="30" minimumOpacity="0" />
                </Sequence>
            </OnUpdated>
        </Animations>
    </asp:UpdatePanelAnimationExtender>
    <asp:UpdatePanel ID="udp_mailing" runat="server" UpdateMode="Conditional" RenderMode="Block" ChildrenAsTriggers="true" >
        <ContentTemplate>
            <asp:FormView runat="server" ID="Mailingform" DefaultMode="Insert" RenderOuterTable="False" OnCallingDataMethods="Mailingform_CallingDataMethods" DataKeyNames="Id" InsertMethod="SendMail" OnItemInserted="Mailform_MailSend">
                <InsertItemTemplate>
                    <fieldset>
                        Templates :
                        <br />
                        <asp:CheckBoxList ID="cbl_templates" runat="server" DataTextField="Value" DataValueField="Value" SelectMethod="SelectTemplates" OnCallingDataMethods="Mailingform_CallingDataMethods" AppendDataBoundItems="true">
                        </asp:CheckBoxList>
                        <br></br>
                    </fieldset>
                </InsertItemTemplate>
                <FooterTemplate>
                    <asp:LinkButton CssClass="button big" ID="btn_update_bottom" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
                </FooterTemplate>
            </asp:FormView>
        </ContentTemplate>
    </asp:UpdatePanel>
</div>
