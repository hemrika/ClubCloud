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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Functionaris_Insert.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Functionaris_InsertUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Functionaris_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Functionarissen_View" />
<asp:CustomValidator ID="Functionaris_Validator" Display="Dynamic" runat="server" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" ID="Functionaris_Summary" />
<asp:FormView runat="server" ID="InsertFunctionarisform" DefaultMode="Insert" RenderOuterTable="False" OnCallingDataMethods="InsertFunctionarisform_CallingDataMethods" SelectMethod="SelectFunctionaris" InsertMethod="InsertFunctionaris" DataKeyNames="Id" OnItemInserted="InsertFunctionarisform_ItemInserted">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Functionaris gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Functionaris beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Functionarissen"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_top" runat="server" Text="Terug naar Functionarissen" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);"/>
        <asp:LinkButton CssClass="button big" ID="btn_update_top" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_bottom" runat="server" Text="Terug naar Functionarissen" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);"/>
        <asp:LinkButton CssClass="button big" ID="btn_update_bottom" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
    </FooterTemplate>
    <InsertItemTemplate>
        <fieldset>
            Functie : <asp:DropDownList ID="FunctieId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("FunctieId") %>' SelectMethod="SelectFunctie" OnCallingDataMethods="InsertFunctionarisform_CallingDataMethods" /></br>
			<asp:HiddenField ID="VerenigingId" Value='<%# Bind("VerenigingId") %>' runat="server" />
			<asp:HiddenField ID="GebruikerId" Value='<%# Bind("GebruikerId") %>' runat="server" />
            Bestuursorgaan : <asp:DropDownList ID="BestuursorgaanId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("BestuursorgaanId") %>' SelectMethod="SelectBestuursorgaan" OnCallingDataMethods="InsertFunctionarisform_CallingDataMethods" /></br>
			<asp:HiddenField ID="DistrictId" Value='<%# Bind("DistrictId") %>' runat="server" />
			TermijnBegin : <asp:TextBox ID="TermijnBegin" runat="server" Text='<%# Bind("TermijnBegin") %>' TextMode="Date" /></br>
			<ajaxToolkit:CalendarExtender ID="TermijnBegin_CalendarExtender" runat="server" BehaviorID="TermijnBegin_CalendarExtender" TargetControlID="TermijnBegin" />
			TermijnEinde : <asp:TextBox ID="TermijnEinde" runat="server" Text='<%# Bind("TermijnEinde") %>' TextMode="Date" /></br>
			<ajaxToolkit:CalendarExtender ID="TermijnEinde_CalendarExtender" runat="server" BehaviorID="TermijnEinde_CalendarExtender" TargetControlID="TermijnEinde" />
			Autorisatie : <asp:Checkbox ID="Autorisatie" runat="server" Checked='<%# Bind("Autorisatie") %>' /></br>
			Actief : <asp:TextBox ID="Actief" runat="server" Text='<%# Bind("Actief") %>' TextMode="SingleLine"/></br>
			Gewijzigd : <asp:TextBox ID="Gewijzigd" runat="server" Text='<%# Bind("Gewijzigd") %>' TextMode="Date" /></br>
			<ajaxToolkit:CalendarExtender ID="Gewijzigd_CalendarExtender" runat="server" BehaviorID="Gewijzigd_CalendarExtender" TargetControlID="Gewijzigd" />
        </fieldset>
    </InsertItemTemplate>
</asp:FormView>
