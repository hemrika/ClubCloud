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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Baan_Insert.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Baan_InsertUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Baan_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Banen_View" />
<asp:CustomValidator ID="Baan_Validator" Display="Dynamic" runat="server" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" ID="Baan_Summary" />
<asp:FormView runat="server" ID="InsertBaanform" DefaultMode="Insert" RenderOuterTable="False" OnCallingDataMethods="InsertBaanform_CallingDataMethods" SelectMethod="SelectBaan" InsertMethod="InsertBaan" DataKeyNames="Id" OnItemInserted="InsertBaanform_ItemInserted">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Baan gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Baan beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Banen"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_top" runat="server" Text="Terug naar Banen" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);"/>
        <asp:LinkButton CssClass="button big" ID="btn_update_top" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_bottom" runat="server" Text="Terug naar Banen" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);"/>
        <asp:LinkButton CssClass="button big" ID="btn_update_bottom" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
    </FooterTemplate>
    <InsertItemTemplate>
        <fieldset>
			Naam : <asp:TextBox ID="Naam" runat="server" Text='<%# Bind("Naam") %>' TextMode="SingleLine"/></br>
			Nummer : <asp:TextBox ID="Nummer" runat="server" Text='<%# Bind("Nummer") %>' TextMode="Number" /></br>
            Baanblok : <asp:DropDownList ID="BaanblokId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("BaanblokId") %>' SelectMethod="SelectBaanblok" OnCallingDataMethods="InsertBaanform_CallingDataMethods" /></br>
			<asp:HiddenField ID="AccommodatieId" Value='<%# Bind("AccommodatieId") %>' runat="server" />
			Status : <asp:TextBox ID="Status" runat="server" Text='<%# Bind("Status") %>' TextMode="SingleLine"/></br>
			Keuring : <asp:TextBox ID="Keuring" runat="server" Text='<%# Bind("Keuring") %>' TextMode="Date" /></br>
			<ajaxToolkit:CalendarExtender ID="Keuring_CalendarExtender" runat="server" BehaviorID="Keuring_CalendarExtender" TargetControlID="Keuring" />
			Actief : <asp:DropDownList ID="Actief" runat="server" DataTextField="Value" DataValueField="Value" SelectedValue='<%# Bind("Actief") %>' SelectMethod="SelectActief" OnCallingDataMethods="InsertBaanform_CallingDataMethods" /></br>
        </fieldset>
    </InsertItemTemplate>
</asp:FormView>
