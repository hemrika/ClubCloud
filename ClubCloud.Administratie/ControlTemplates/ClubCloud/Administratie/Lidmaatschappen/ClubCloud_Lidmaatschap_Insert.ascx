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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Lidmaatschap_Insert.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Lidmaatschap_InsertUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Lidmaatschap_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Lidmaatschappen_View" />
<asp:CustomValidator ID="Lidmaatschap_Validator" Display="Dynamic" runat="server" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" ID="Lidmaatschap_Summary" />
<asp:FormView runat="server" ID="InsertLidmaatschapform" DefaultMode="Insert" RenderOuterTable="False" OnCallingDataMethods="InsertLidmaatschapform_CallingDataMethods" SelectMethod="SelectLidmaatschap" InsertMethod="InsertLidmaatschap" DataKeyNames="Id" OnItemInserted="InsertLidmaatschapform_ItemInserted">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Lidmaatschap gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Lidmaatschap beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Lidmaatschappen"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_top" runat="server" Text="Terug naar Lidmaatschappen" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);"/>
        <asp:LinkButton CssClass="button big" ID="btn_update_top" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_bottom" runat="server" Text="Terug naar Lidmaatschappen" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);"/>
        <asp:LinkButton CssClass="button big" ID="btn_update_bottom" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
    </FooterTemplate>
    <InsertItemTemplate>
        <fieldset>
			Bondsnummer : <asp:TextBox ID="Bondsnummer" runat="server" Text='<%# Bind("Bondsnummer") %>' TextMode="Number" Enabled="false" /></br>
            Lidmaatschapsoort : <asp:DropDownList ID="LidmaatschapsoortId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("LidmaatschapsoortId") %>' SelectMethod="SelectLidmaatschapsoort" OnCallingDataMethods="InsertLidmaatschapform_CallingDataMethods" /></br>
			Begin : <asp:TextBox ID="Begin" runat="server" Text='<%# Bind("Begin") %>' TextMode="Date" /></br>
			<ajaxToolkit:CalendarExtender ID="Begin_CalendarExtender" runat="server" BehaviorID="Begin_CalendarExtender" TargetControlID="Begin" />
			Einde : <asp:TextBox ID="Einde" runat="server" Text='<%# Bind("Einde") %>' TextMode="Date" /></br>
			<ajaxToolkit:CalendarExtender ID="Einde_CalendarExtender" runat="server" BehaviorID="Einde_CalendarExtender" TargetControlID="Einde" />
			Opzegging : <asp:TextBox ID="Opzegging" runat="server" Text='<%# Bind("Opzegging") %>' TextMode="Date" /></br>
			<ajaxToolkit:CalendarExtender ID="Opzegging_CalendarExtender" runat="server" BehaviorID="Opzegging_CalendarExtender" TargetControlID="Opzegging" />
			InternNummer : <asp:TextBox ID="InternNummer" runat="server" Text='<%# Bind("InternNummer") %>' TextMode="Number" Enabled="false" /></br>
			<asp:HiddenField ID="GebruikerId" Value='<%# Bind("GebruikerId") %>' runat="server" />
			<asp:HiddenField ID="VerenigingId" Value='<%# Bind("VerenigingId") %>' runat="server" />
			<asp:HiddenField ID="PasTypeId" Value='<%# Bind("PasTypeId") %>' runat="server" />
			PasTypeNaam : <asp:TextBox ID="PasTypeNaam" runat="server" Text='<%# Bind("PasTypeNaam") %>' TextMode="SingleLine"/></br>
			PasDatum : <asp:TextBox ID="PasDatum" runat="server" Text='<%# Bind("PasDatum") %>' TextMode="Date" /></br>
			<ajaxToolkit:CalendarExtender ID="PasDatum_CalendarExtender" runat="server" BehaviorID="PasDatum_CalendarExtender" TargetControlID="PasDatum" />
			PasNoodDatum : <asp:TextBox ID="PasNoodDatum" runat="server" Text='<%# Bind("PasNoodDatum") %>' TextMode="Date" /></br>
			<ajaxToolkit:CalendarExtender ID="PasNoodDatum_CalendarExtender" runat="server" BehaviorID="PasNoodDatum_CalendarExtender" TargetControlID="PasNoodDatum" />
			PasWedstrijd : <asp:Checkbox ID="PasWedstrijd" runat="server" Checked='<%# Bind("PasWedstrijd") %>' /></br>
			PasNieuw : <asp:Checkbox ID="PasNieuw" runat="server" Checked='<%# Bind("PasNieuw") %>' /></br>
			PasNood : <asp:Checkbox ID="PasNood" runat="server" Checked='<%# Bind("PasNood") %>' /></br>
			PasVolgnummer : <asp:TextBox ID="PasVolgnummer" runat="server" Text='<%# Bind("PasVolgnummer") %>' TextMode="Number" Enabled="false" /></br>
			SpeelsterkteDubbel : <asp:TextBox ID="SpeelsterkteDubbel" runat="server" Text='<%# Bind("SpeelsterkteDubbel") %>' TextMode="Number" /></br>
			SpeelsterkteEnkel : <asp:TextBox ID="SpeelsterkteEnkel" runat="server" Text='<%# Bind("SpeelsterkteEnkel") %>' TextMode="Number" /></br>
			Autorisatie : <asp:Checkbox ID="Autorisatie" runat="server" Checked='<%# Bind("Autorisatie") %>' /></br>
			Actief : <asp:DropDownList ID="Actief" runat="server" DataTextField="Value" DataValueField="Value" SelectedValue='<%# Bind("Actief") %>' SelectMethod="SelectActief" OnCallingDataMethods="InsertLidmaatschapform_CallingDataMethods" /></br>
			Gewijzigd : <asp:TextBox ID="Gewijzigd" runat="server" Text='<%# Bind("Gewijzigd") %>' TextMode="Date" /></br>
			<ajaxToolkit:CalendarExtender ID="Gewijzigd_CalendarExtender" runat="server" BehaviorID="Gewijzigd_CalendarExtender" TargetControlID="Gewijzigd" />
        </fieldset>
    </InsertItemTemplate>
</asp:FormView>
