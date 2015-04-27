<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Vereniging_Insert.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Vereniging_InsertUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Vereniging_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Verenigingen_View" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" />
<asp:FormView runat="server" ID="InsertVerenigingform" DefaultMode="Insert" RenderOuterTable="False" OnCallingDataMethods="InsertVerenigingform_CallingDataMethods" SelectMethod="SelectVereniging" InsertMethod="InsertVereniging" DataKeyNames="Id">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Vereniging gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Vereniging beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Verenigingen"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <InsertItemTemplate>
        <fieldset>
            <h1 class="title-regular clearfix">
                <%# ((FormView)Container).CurrentMode == FormViewMode.Insert ? "Nieuwe Vereniging" : "" %>
            </h1>
            <asp:Button ID="Insert" runat="server" Text="Save" CommandName="Insert" CausesValidation="true" />
            <asp:Button ID="Goback" runat="server" Text="Terug naar Verenigingen" CausesValidation="false" OnClick="GoBack"/>
        </fieldset>
    </InsertItemTemplate>
</asp:FormView>
