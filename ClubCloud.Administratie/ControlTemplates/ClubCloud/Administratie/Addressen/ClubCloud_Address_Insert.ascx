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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Address_Insert.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Address_InsertUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Address_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Addressen_View" />
<asp:CustomValidator ID="Address_Validator" Display="Dynamic" runat="server" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" ID="Address_Summary" />
<asp:FormView runat="server" ID="InsertAddressform" DefaultMode="Insert" RenderOuterTable="False" OnCallingDataMethods="InsertAddressform_CallingDataMethods" SelectMethod="SelectAddress" InsertMethod="InsertAddress" DataKeyNames="Id" OnItemInserted="InsertAddressform_ItemInserted">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Address gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Address beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Addressen"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_top" runat="server" Text="Terug naar Addressen" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);"/>
        <asp:LinkButton CssClass="button big" ID="btn_update_top" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_bottom" runat="server" Text="Terug naar Addressen" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);"/>
        <asp:LinkButton CssClass="button big" ID="btn_update_bottom" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
    </FooterTemplate>
    <InsertItemTemplate>
        <fieldset>
			<asp:HiddenField ID="ParentId" Value='<%# Bind("ParentId") %>' runat="server" />
			Stad : <asp:TextBox ID="Stad" runat="server" Text='<%# Bind("Stad") %>' TextMode="SingleLine"/></br>
			Provincie : <asp:TextBox ID="Provincie" runat="server" Text='<%# Bind("Provincie") %>' TextMode="SingleLine"/></br>
			<asp:HiddenField ID="Latitude" Value='<%# Bind("Latitude") %>' runat="server" />
			<asp:HiddenField ID="Longitude" Value='<%# Bind("Longitude") %>' runat="server" />
			Naam : <asp:DropDownList ID="Naam" runat="server" DataTextField="Value" DataValueField="Value" SelectedValue='<%# Bind("Naam") %>' SelectMethod="SelectNaam" OnCallingDataMethods="InsertAddressform_CallingDataMethods" ><asp:ListItem  Text="Onbekend" Value="00000000-0000-0000-0000-000000000000" Selected="True"></asp:ListItem></asp:DropDownList></br>
			Postcode : <asp:TextBox ID="Postcode" runat="server" Text='<%# Bind("Postcode") %>' TextMode="SingleLine"/></br>
			Straat : <asp:TextBox ID="Straat" runat="server" Text='<%# Bind("Straat") %>' TextMode="SingleLine"/></br>
			Nummer : <asp:TextBox ID="Nummer" runat="server" Text='<%# Bind("Nummer") %>' TextMode="Number" Enabled="false" /></br>
            Land : <asp:DropDownList ID="LandId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("LandId") %>' SelectMethod="SelectLand" OnCallingDataMethods="InsertAddressform_CallingDataMethods" ><asp:ListItem  Text="Onbekend" Value="00000000-0000-0000-0000-000000000000" Selected="True"></asp:ListItem></asp:DropDownList></br>
			Actief : <asp:DropDownList ID="Actief" runat="server" DataTextField="Value" DataValueField="Value" SelectedValue='<%# Bind("Actief") %>' SelectMethod="SelectActief" OnCallingDataMethods="InsertAddressform_CallingDataMethods" ><asp:ListItem  Text="Onbekend" Value="00000000-0000-0000-0000-000000000000" Selected="True"></asp:ListItem></asp:DropDownList></br>
			Fax : <asp:TextBox ID="Fax" runat="server" Text='<%# Bind("Fax") %>' TextMode="Phone" /></br>
			Toevoeging : <asp:TextBox ID="Toevoeging" runat="server" Text='<%# Bind("Toevoeging") %>' TextMode="SingleLine"/></br>
			Postbus : <asp:TextBox ID="Postbus" runat="server" Text='<%# Bind("Postbus") %>' TextMode="SingleLine"/></br>
			TelefoonPrimair : <asp:TextBox ID="TelefoonPrimair" runat="server" Text='<%# Bind("TelefoonPrimair") %>' TextMode="Phone" /></br>
			TelefoonSecundair : <asp:TextBox ID="TelefoonSecundair" runat="server" Text='<%# Bind("TelefoonSecundair") %>' TextMode="Phone" /></br>
			TelefoonTertiair : <asp:TextBox ID="TelefoonTertiair" runat="server" Text='<%# Bind("TelefoonTertiair") %>' TextMode="Phone" /></br>
			<asp:HiddenField ID="GeoLocation" Value='<%# Bind("GeoLocation") %>' runat="server" />
			Gewijzigd : <asp:TextBox ID="Gewijzigd" runat="server" Text='<%# Bind("Gewijzigd") %>' TextMode="Date" /></br>
			<ajaxToolkit:CalendarExtender ID="Gewijzigd_CalendarExtender" runat="server" BehaviorID="Gewijzigd_CalendarExtender" TargetControlID="Gewijzigd" />
			Gemeente : <asp:TextBox ID="Gemeente" runat="server" Text='<%# Bind("Gemeente") %>' TextMode="SingleLine"/></br>
			AddressGeheim : <asp:Checkbox ID="AddressGeheim" runat="server" Checked='<%# Bind("AddressGeheim") %>' /></br>
        </fieldset>
    </InsertItemTemplate>
</asp:FormView>
