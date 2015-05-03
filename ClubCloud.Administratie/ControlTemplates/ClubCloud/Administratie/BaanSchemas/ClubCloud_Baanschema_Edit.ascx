<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Baanschema_Edit.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Baanschema_EditUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Baanschema_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Baanschemas_View" />
<asp:UpdatePanel ID="udp_Baanschema" runat="server" UpdateMode="Always">
    <contenttemplate>
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" />
<asp:FormView runat="server" ID="EditBaanschemaform" DefaultMode="Edit" RenderOuterTable="False" OnCallingDataMethods="EditBaanschemaform_CallingDataMethods" SelectMethod="SelectBaanschema" UpdateMethod="UpdateBaanschema" DataKeyNames="Id">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Baanschema gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Baanschema beschikbaar voor dit Id.</div>
        <asp:LinkButton CssClass="button big" ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Baanschemas"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_top" runat="server" Text="Terug naar Baanschema" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:LinkButton CssClass="button big" ID="btn_update_top" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_bottom" runat="server" Text="Terug naar Baanschema" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:LinkButton CssClass="button big" ID="btn_update_bottom" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </FooterTemplate>
    <EditItemTemplate>
        <fieldset>
			<asp:HiddenField ID="BaanId" Value='<%# Bind("BaanId") %>' runat="server" />
			<asp:HiddenField ID="VerenigingId" Value='<%# Bind("VerenigingId") %>' runat="server" />
			Beschikbaar : <asp:Checkbox ID="Beschikbaar" runat="server" Checked='<%# Bind("Beschikbaar") %>' /></br>
        </fieldset>
    </EditItemTemplate>
</asp:FormView>
    </contenttemplate>
</asp:UpdatePanel>
