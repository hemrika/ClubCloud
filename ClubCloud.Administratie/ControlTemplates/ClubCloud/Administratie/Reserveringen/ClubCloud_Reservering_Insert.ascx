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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Reservering_Insert.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Reservering_InsertUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Reservering_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Reserveringen_View" />
<asp:CustomValidator ID="Reservering_Validator" Display="Dynamic" runat="server" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" ID="Reservering_Summary" />
<asp:FormView runat="server" ID="InsertReserveringform" DefaultMode="Insert" RenderOuterTable="False" OnCallingDataMethods="InsertReserveringform_CallingDataMethods" SelectMethod="SelectReservering" InsertMethod="InsertReservering" DataKeyNames="Id" OnItemInserted="InsertReserveringform_ItemInserted">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Reservering gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Reservering beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Reserveringen"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_top" runat="server" Text="Terug naar Reserveringen" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);"/>
        <asp:LinkButton CssClass="button big" ID="btn_update_top" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_bottom" runat="server" Text="Terug naar Reserveringen" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);"/>
        <asp:LinkButton CssClass="button big" ID="btn_update_bottom" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
    </FooterTemplate>
    <InsertItemTemplate>
        <fieldset>
            Baan : <asp:DropDownList ID="BaanId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("BaanId") %>' SelectMethod="SelectBaan" OnCallingDataMethods="InsertReserveringform_CallingDataMethods" /></br>
			Datum : <asp:TextBox ID="Datum" runat="server" Text='<%# Bind("Datum") %>' TextMode="Date" /></br>
			<ajaxToolkit:CalendarExtender ID="Datum_CalendarExtender" runat="server" BehaviorID="Datum_CalendarExtender" TargetControlID="Datum" />
			Tijd : <asp:TextBox ID="Tijd" runat="server" Text='<%# Bind("Tijd") %>' TextMode="Time" /></br>
			<ajaxToolkit:MaskedEditExtender ID="Tijd_MaskedEditExtender" runat="server" BehaviorID="Tijd_MaskedEditExtender" TargetControlID="Tijd" Mask="99:99" MaskType="Time"  />
			Duur : <asp:TextBox ID="Duur" runat="server" Text='<%# Bind("Duur") %>' TextMode="Time" /></br>
			<ajaxToolkit:MaskedEditExtender ID="Duur_MaskedEditExtender" runat="server" BehaviorID="Duur_MaskedEditExtender" TargetControlID="Duur" Mask="99:99:99" MaskType="Number"  />
			_Reservering : <asp:DropDownList ID="ReserveringSoort" runat="server" DataTextField="Value" DataValueField="Value" SelectedValue='<%# Bind("ReserveringSoort") %>' SelectMethod="Select_Reservering" OnCallingDataMethods="InsertReserveringform_CallingDataMethods" /></br>
			Beschrijving : <asp:TextBox ID="Beschrijving" runat="server" Text='<%# Bind("Beschrijving") %>' TextMode="MultiLine" /></br>
			<asp:HiddenField ID="Gebruiker_Een" Value='<%# Bind("Gebruiker_Een") %>' runat="server" />
			<asp:HiddenField ID="Gebruiker_Twee" Value='<%# Bind("Gebruiker_Twee") %>' runat="server" />
			<asp:HiddenField ID="Gebruiker_Drie" Value='<%# Bind("Gebruiker_Drie") %>' runat="server" />
			<asp:HiddenField ID="Gebruiker_Vier" Value='<%# Bind("Gebruiker_Vier") %>' runat="server" />
			Final : <asp:Checkbox ID="Final" runat="server" Checked='<%# Bind("Final") %>' /></br>
        </fieldset>
    </InsertItemTemplate>
</asp:FormView>
