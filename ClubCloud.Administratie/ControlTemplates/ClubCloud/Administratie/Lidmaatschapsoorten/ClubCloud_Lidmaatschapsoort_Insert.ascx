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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Lidmaatschapsoort_Insert.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Lidmaatschapsoort_InsertUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Lidmaatschapsoort_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Lidmaatschapsoorten_View" />
<asp:CustomValidator ID="Lidmaatschapsoort_Validator" Display="Dynamic" runat="server" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" ID="Lidmaatschapsoort_Summary" />
<asp:FormView runat="server" ID="InsertLidmaatschapsoortform" DefaultMode="Insert" RenderOuterTable="False" OnCallingDataMethods="InsertLidmaatschapsoortform_CallingDataMethods" SelectMethod="SelectLidmaatschapsoort" InsertMethod="InsertLidmaatschapsoort" DataKeyNames="Id" OnItemInserted="InsertLidmaatschapsoortform_ItemInserted">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Lidmaatschapsoort gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Lidmaatschapsoort beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Lidmaatschapsoorten"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_top" runat="server" Text="Terug naar Lidmaatschapsoorten" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);"/>
        <asp:LinkButton CssClass="button big" ID="btn_update_top" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_bottom" runat="server" Text="Terug naar Lidmaatschapsoorten" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);"/>
        <asp:LinkButton CssClass="button big" ID="btn_update_bottom" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
    </FooterTemplate>
    <InsertItemTemplate>
        <fieldset>
			<asp:HiddenField ID="VerenigingId" Value='<%# Bind("VerenigingId") %>' runat="server" />
			Naam : <asp:TextBox ID="Naam" runat="server" Text='<%# Bind("Naam") %>' TextMode="SingleLine"/></br>
			Beschrijving : <asp:TextBox ID="Beschrijving" runat="server" Text='<%# Bind("Beschrijving") %>' TextMode="MultiLine" /></br>
			Omschrijving : <asp:TextBox ID="Omschrijving" runat="server" Text='<%# Bind("Omschrijving") %>' TextMode="MultiLine" /></br>
			Code : <asp:TextBox ID="Code" runat="server" Text='<%# Bind("Code") %>' TextMode="SingleLine"/></br>
			DagBegin : <asp:TextBox ID="DagBegin" runat="server" Text='<%# Bind("DagBegin") %>' TextMode="Time" /></br>
			<ajaxToolkit:MaskedEditExtender ID="DagBegin_MaskedEditExtender" runat="server" BehaviorID="DagBegin_MaskedEditExtender" TargetControlID="DagBegin" Mask="99:99" MaskType="Time"  />
			DagEinde : <asp:TextBox ID="DagEinde" runat="server" Text='<%# Bind("DagEinde") %>' TextMode="Time" /></br>
			<ajaxToolkit:MaskedEditExtender ID="DagEinde_MaskedEditExtender" runat="server" BehaviorID="DagEinde_MaskedEditExtender" TargetControlID="DagEinde" Mask="99:99" MaskType="Time"  />
			Contributie : <asp:Checkbox ID="Contributie" runat="server" Checked='<%# Bind("Contributie") %>' /></br>
			Tarief : <asp:TextBox ID="Tarief" runat="server" Text='<%# Bind("Tarief") %>' TextMode="SingleLine"/></br>
			Actief : <asp:DropDownList ID="Actief" runat="server" DataTextField="Value" DataValueField="Value" SelectedValue='<%# Bind("Actief") %>' SelectMethod="SelectActief" OnCallingDataMethods="InsertLidmaatschapsoortform_CallingDataMethods" ><asp:ListItem  Text="Onbekend" Value="00000000-0000-0000-0000-000000000000" Selected="True"></asp:ListItem></asp:DropDownList></br>
        </fieldset>
    </InsertItemTemplate>
</asp:FormView>
