<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Baanschema.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_BaanschemaUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Baanschema_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Baanschemas_View" />
<asp:FormView runat="server" ID="SelectBaanschemaform" DefaultMode="ReadOnly" RenderOuterTable="False" OnCallingDataMethods="SelectBaanschemaform_CallingDataMethods" SelectMethod="SelectBaanschema" DataKeyNames="Id" >
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Baanschema gevonden
		</h1>
        <div class="notice">
            Sorry, er is geen  Baanschema beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Baanschemas" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center"/>
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <HeaderTemplate>
		<asp:LinkButton ID="btn_goback_top" runat="server" Text="Terug" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
        <asp:LinkButton ID="btn_edit_top" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/>
    </HeaderTemplate>
    <FooterTemplate>
		<asp:LinkButton ID="btn_goback_bottom" runat="server" Text="Terug " CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
		<asp:LinkButton ID="btn_edit_bottom" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/>
    </FooterTemplate>
    <ItemTemplate>
		

        <fieldset>
			Beschikbaar : <asp:Label ID="Beschikbaar" runat="server" Text='<%# Eval("Beschikbaar") %>' /></br>
			Dag : <asp:Label ID="Dag" runat="server" Text='<%# Eval("Dag") %>' /></br>
			DagBegin : <asp:Label ID="DagBegin" runat="server" Text='<%# Eval("DagBegin") %>' /></br>
			DagEinde : <asp:Label ID="DagEinde" runat="server" Text='<%# Eval("DagEinde") %>' /></br>
			MaandBegin : <asp:Label ID="MaandBegin" runat="server" Text='<%# Eval("MaandBegin") %>' /></br>
			MaandEinde : <asp:Label ID="MaandEinde" runat="server" Text='<%# Eval("MaandEinde") %>' /></br>
			Baan : <a href="Baan.aspx?Id=<%# Eval("BaanId") %>" target="_self" title="Baan" ><%# Eval("ClubCloud_Baan.Naam") %></a></br>
			Vereniging : <a href="Vereniging.aspx?Id=<%# Eval("VerenigingId") %>" target="_self" title="Vereniging" ><%# Eval("ClubCloud_Vereniging.Naam") %></a></br>
        </fieldset>
    </ItemTemplate>
</asp:FormView>

