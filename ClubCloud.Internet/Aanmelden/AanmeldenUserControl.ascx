<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register Tagprefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Import Namespace="AjaxControlToolkit" %> 
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AanmeldenUserControl.ascx.cs" Inherits="ClubCloud.Internet.AanmeldenUserControl" %>
<%@ Register Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls" TagPrefix="ClubCloud" %>


<script type="text/javascript">
    function OnClientPopulating(sender, e) {
    sender._element.className = "wizardSearch";
}
function OnClientCompleted(sender, e) {
    sender._element.className = "";
}
</script>

<div class="first dark">
<asp:UpdateProgress ID="udp_progress" runat="server" AssociatedUpdatePanelID="udp_aanmelden">
    <ProgressTemplate>
        <div class="progess" style="position: absolute; background-color: #F9F9F9; top: 0px; left: 0px; width: 100%; height: 100%; opacity: 0.8; -moz-opacity: 0.8; filter: alpha(opacity=80); -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=80)"; z-index: 10000;">
        <div class="bubbles aligncenter" style="top:48%; z-index: 10000;">laden...</div>
        </div>
    </ProgressTemplate>
</asp:UpdateProgress>
    <asp:UpdatePanel ID="udp_aanmelden" runat="server" UpdateMode="Always">
        <ContentTemplate>
            <asp:Timer runat="server" ID="tmr_loader_aanmelden" OnTick="tmr_loader_aanmelden_Tick" Interval="50" />
            <asp:Wizard ID="wzd_aanmelden" runat="server" Width="100%" FinishPreviousButtonText="Vorige" FinishPreviousButtonType="Link" CancelButtonText="Stoppen" CancelButtonType="Link" FinishCompleteButtonText="Aanmelden" FinishCompleteButtonType="Link" StartNextButtonStyle-BorderStyle="NotSet" StartNextButtonText="Volgende" StartNextButtonType="Link" StepNextButtonText="Volgende" StepNextButtonType="Link" StepPreviousButtonText="Vorige" StepPreviousButtonType="Link" Height="100%" OnFinishButtonClick="wzd_aanmelden_FinishButtonClick" OnNextButtonClick="wzd_aanmelden_NextButtonClick" OnActiveStepChanged="wzd_aanmelden_ActiveStepChanged" OnPreRender="wzd_aanmelden_PreRender" OnLoad="wzd_aanmelden_Load" DisplaySideBar="False">
                <NavigationButtonStyle CssClass="button big" />
                <NavigationStyle CssClass="button big" />
                <StartNextButtonStyle CssClass="button big" />
                <StepNextButtonStyle CssClass="button big" />
                <StepPreviousButtonStyle CssClass="button big" />
                <CancelButtonStyle CssClass="button big" />
                <FinishCompleteButtonStyle CssClass="button big" />
                <FinishPreviousButtonStyle CssClass="button big" />
                <StepStyle CssClass="button big" />
                <WizardSteps>
                    <asp:WizardStep ID="wzd_vereniging" runat="server" Title="Uw vereniging" StepType="Start">
                        <asp:Panel runat="server" ID="pnl_vereniging">
                            <br />
                            <i class="icon-address special"></i>
                            <div class="three-fourth info">

                                <h3 class="lined">Verenigingsnummer</h3>
                                <p>
                                    <asp:TextBox ID="tbx_verenigingsnummer" TextMode="SingleLine" runat="server" AutoPostBack="true" OnTextChanged="tbx_verenigingsnummer_TextChanged" type="number" Width="100%"/>
                                    <ajaxToolkit:AutoCompleteExtender ID="Verenigingsnummer_AutoCompleteExtender" runat="server" DelimiterCharacters="" Enabled="True" ServiceMethod="GetVereniningen" ServicePath="//mijn.clubcloud.nl/_vti_bin/ClubCloud.Afhangen/Afhangen.svc/Script" TargetControlID="tbx_verenigingsnummer" UseContextKey="True" FirstRowSelected="True" MinimumPrefixLength="5" CompletionInterval="1000" OnClientHiding="OnClientCompleted" OnClientPopulated="OnClientCompleted" OnClientPopulating="OnClientPopulating">
                                        <Animations>
                                       <OnShow><Sequence><OpacityAction Opacity="0" /><HideAction Visible="true" /><Parallel Duration=".4"><FadeIn /></Parallel></Sequence></OnShow>
                                       <OnHide><Parallel Duration=".4"><FadeOut /></Parallel></OnHide>
                                        </Animations>
                                    </ajaxToolkit:AutoCompleteExtender>
                                </p>
                                <p class="capitalize">
                                    <asp:FormView ID="fvw_aanmelden" runat="server" RenderOuterTable="false" DataKeyNames="Id">
                                        <ItemTemplate>
                                            Naam :
                                            <asp:TextBox ID="Naam" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "Naam") %>' /><br />
                                            Kvk :
                                            <asp:TextBox ID="KvKNummer" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "KvKnummer") %> te <%# Bind(Container.DataItem, "KvKplaats") %>'  Width="40%"/> te
                                            <asp:TextBox ID="KvKPlaats" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "KvKnummer") %> te <%# Bind(Container.DataItem, "KvKplaats") %>'  Width="40%"/><br />
                                            IBAN :
                                            <asp:TextBox ID="TextBox1" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "BankIban") %>' /><br />
                                        </ItemTemplate>
                                    </asp:FormView>
                                </p>
                            </div>
                        </asp:Panel>
                    </asp:WizardStep>
                    <asp:WizardStep ID="wzd_gegevens" runat="server" Title="Uw gegevens" StepType="Step">
                        <div class="content">This is Step Gegevens</div>
                        </div>
                    </asp:WizardStep>
                    <asp:WizardStep ID="wzd_opties" runat="server" Title="De Opties" StepType="Step">
                        <div class="content">This is Step Opties</div>
                    </asp:WizardStep>
                    <asp:WizardStep ID="wzd_voorwaarden" runat="server" Title="De voorwaarden" StepType="Step">
                        <div class="content">This is Step Voorwaarden</div>
                    </asp:WizardStep>
                    <asp:WizardStep ID="wzd_afronden" runat="server" Title="Aanmelden" StepType="Finish">
                        <div class="content">This is Step Finish</div>
                    </asp:WizardStep>
                    <asp:WizardStep ID="wzd_klaar" runat="server" Title="Vervolg" StepType="Complete">
                        <i class="icon-info special"></i>
                        <div class="info">
                            <h3 class="lined">Het process</h3>
                            <p>
                                Laat uw gegevens achter via het onderstaande formulier. 
						ClubCloud neemt vervolgens contact met u op.<br />
                                Nadat alles duidelijk is, starten we met het activeren 
						en regelen van uw clubcloud omgeving.<br />
                            </p>
                        </div>
                    </asp:WizardStep>
                </WizardSteps>
                <HeaderTemplate>
                    <div class="first">
                        <ul id="wizHeader">
                            <asp:Repeater ID="SideBarList" runat="server" OnItemCommand="SideBarList_ItemCommand">
                                <ItemTemplate>
                                    <li>
                                        <asp:LinkButton ID="SideBarButton" runat="server" CssClass="<%# GetClassForWizardStep(Container.DataItem) %>"> <%# wzd_aanmelden.WizardSteps.IndexOf(Container.DataItem as WizardStep) + 1 %> &nbsp; <%# Eval("Name")%></asp:LinkButton>
                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                </HeaderTemplate>
            </asp:Wizard>
            <ClubCloud:ClubCloudDataSource ID="VerenigingDataSource" runat="server" />
            <asp:GridView ID="GridView1" runat="server" DataSourceID="VerenigingDataSource"></asp:GridView>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="tmr_loader_aanmelden" EventName="Tick" />
        </Triggers>
    </asp:UpdatePanel>
<asp:Label ID="lbl_result" runat="server"></asp:Label>
<!-- <asp:AsyncPostBackTrigger ControlID="tbx_verenigingsnummer" EventName="TextChanged" /> -->
</div>
