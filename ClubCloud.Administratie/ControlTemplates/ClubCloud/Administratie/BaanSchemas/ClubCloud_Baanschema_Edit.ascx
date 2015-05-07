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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Baanschema_Edit.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Baanschema_EditUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Baanschema_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Baanschemas_View" />
<asp:CustomValidator ID="Baanschema_Validator" Display="Dynamic" runat="server" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" ID="Baanschema_Summary" />
<asp:FormView runat="server" ID="EditBaanschemaform" DefaultMode="Edit" RenderOuterTable="False" OnCallingDataMethods="EditBaanschemaform_CallingDataMethods" SelectMethod="SelectBaanschema" UpdateMethod="UpdateBaanschema" DataKeyNames="Id" OnItemUpdated="UpdateBaanschemaform_ItemUpdated">
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
			<asp:HiddenField ID="Id" Value='<%# Bind("Id") %>' runat="server" />
            Baan : <asp:DropDownList ID="BaanId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("BaanId") %>' SelectMethod="SelectBaan" OnCallingDataMethods="EditBaanschemaform_CallingDataMethods" /></br>
			<asp:HiddenField ID="VerenigingId" Value='<%# Bind("VerenigingId") %>' runat="server" />
			Beschikbaar : <asp:Checkbox ID="Beschikbaar" runat="server" Checked='<%# Bind("Beschikbaar") %>' /></br>
			MaandBegin : <asp:DropDownList ID="MaandBegin" runat="server" DataTextField="Value" DataValueField="Value" SelectedValue='<%# Bind("MaandBegin") %>' SelectMethod="SelectMaandBegin" OnCallingDataMethods="EditBaanschemaform_CallingDataMethods" /></br>
			MaandEinde : <asp:DropDownList ID="MaandEinde" runat="server" DataTextField="Value" DataValueField="Value" SelectedValue='<%# Bind("MaandEinde") %>' SelectMethod="SelectMaandEinde" OnCallingDataMethods="EditBaanschemaform_CallingDataMethods" /></br>
			Dag : <asp:DropDownList ID="Dag" runat="server" DataTextField="Value" DataValueField="Value" SelectedValue='<%# Bind("Dag") %>' SelectMethod="SelectDag" OnCallingDataMethods="EditBaanschemaform_CallingDataMethods" /></br>

			DagBegin : <asp:TextBox ID="DagBegin" runat="server" Text='<%# Bind("DagBegin") %>' TextMode="Time" /></br>

			DagEinde : <asp:TextBox ID="DagEinde" runat="server" Text='<%# Bind("DagEinde") %>' TextMode="Time" /></br>
        </fieldset>
    </EditItemTemplate>
</asp:FormView>
