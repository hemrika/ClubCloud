<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="AjaxControlToolkit" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit, Version=15.1.1.100, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Baanblok_Insert.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Baanblok_InsertUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Baanblok_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Baanblokken_View" />
<asp:CustomValidator ID="Baanblok_Validator" Display="Dynamic" runat="server" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" ID="Baanblok_Summary" />
<asp:FormView runat="server" ID="InsertBaanblokform" DefaultMode="Insert" RenderOuterTable="False" OnCallingDataMethods="InsertBaanblokform_CallingDataMethods" SelectMethod="SelectBaanblok" InsertMethod="InsertBaanblok" DataKeyNames="Id" OnItemInserted="InsertBaanblokform_ItemInserted">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Baanblok gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Baanblok beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Baanblokken"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_top" runat="server" Text="Terug naar Baanblokken" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);"/>
        <asp:LinkButton CssClass="button big" ID="btn_update_top" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_bottom" runat="server" Text="Terug naar Baanblokken" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);"/>
        <asp:LinkButton CssClass="button big" ID="btn_update_bottom" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
    </FooterTemplate>
    <InsertItemTemplate>
        <fieldset>
			Naam : <asp:TextBox ID="Naam" runat="server" Text='<%# Bind("Naam") %>' TextMode="SingleLine"/></br>
			<asp:HiddenField ID="AccommodatieId" Value='<%# Bind("AccommodatieId") %>' runat="server" />
            Baantype : <asp:DropDownList ID="BaantypeId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("BaantypeId") %>' SelectMethod="SelectBaantype" OnCallingDataMethods="InsertBaanblokform_CallingDataMethods" /></br>
            Baansoort : <asp:DropDownList ID="BaansoortId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("BaansoortId") %>' SelectMethod="SelectBaansoort" OnCallingDataMethods="InsertBaanblokform_CallingDataMethods" /></br>
			Verlichting : <asp:Checkbox ID="Verlichting" runat="server" Checked='<%# Bind("Verlichting") %>' /></br>
			Locatie : <asp:TextBox ID="Locatie" runat="server" Text='<%# Bind("Locatie") %>' TextMode="SingleLine"/></br>
			Actief : <asp:DropDownList ID="Actief" runat="server" DataTextField="Value" DataValueField="Value" SelectedValue='<%# Bind("Actief") %>' SelectMethod="SelectActief" OnCallingDataMethods="InsertBaanblokform_CallingDataMethods" /></br>
        </fieldset>
    </InsertItemTemplate>
</asp:FormView>
