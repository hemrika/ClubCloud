
 
<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Functionarissen.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_FunctionarissenUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Functionaris_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Functionarissen_View" />
<asp:GridView 
    ID="ClubCloud_Functionarissen_Grid" 
    runat="server" 
    AllowPaging="true" 
    AllowSorting="true" 
    AutoGenerateColumns="false" 
    DataKeyNames="Id" 
    SelectMethod="SelectFunctionarissen"
	OnCallingDataMethods="GridFunctionarissen_CallingDataMethods"
    PageSize="30"
    ShowFooter="true"
    ShowHeader="true" >
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <PagerSettings Mode="NextPreviousFirstLast" Visible="true" Position="TopAndBottom" PreviousPageText="vorige" NextPageText="volgende"  FirstPageText="Eerste" LastPageText="Laatste" PageButtonCount="5" />
    <PagerStyle HorizontalAlign="Center" VerticalAlign="Top" BackColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" />
    <Columns>
        <asp:BoundField
            DataField="TermijnBegin"
            HeaderText="TermijnBegin"
            SortExpression="TermijnBegin"
            ItemStyle-Width="40px">
        </asp:BoundField>
        <asp:BoundField
            DataField="TermijnEinde"
            HeaderText="TermijnEinde"
            SortExpression="TermijnEinde"
            ItemStyle-Width="40px">
        </asp:BoundField>
        <asp:BoundField
            DataField="Autorisatie"
            HeaderText="Autorisatie"
            SortExpression="Autorisatie"
            ItemStyle-Width="40px">
        </asp:BoundField>
        <asp:BoundField
            DataField="Actief"
            HeaderText="Actief"
            SortExpression="Actief"
            ItemStyle-Width="40px">
        </asp:BoundField>
        <asp:BoundField
            DataField="Gewijzigd"
            HeaderText="Gewijzigd"
            SortExpression="Gewijzigd"
            ItemStyle-Width="40px">
        </asp:BoundField>
    
    </Columns>
    <EmptyDataTemplate>
        <HeaderTemplate>
            <asp:HyperLink ID="ClubCloud_Functionaris_Insert" Text="Toevoegen" NavigateUrl="~/ClubCloud_Functionaris_Insert.aspx"  runat="server" /> <br/>
        </HeaderTemplate>
        <ItemTemplate>Er zijn geen gegevens gevonden.</ItemTemplate>
    </EmptyDataTemplate>
</asp:GridView>
<p>
    <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
</p>



