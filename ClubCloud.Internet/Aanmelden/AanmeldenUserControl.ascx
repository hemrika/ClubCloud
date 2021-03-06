﻿<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="asp" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit, Version=15.1.1.100, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Import Namespace="AjaxControlToolkit" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AanmeldenUserControl.ascx.cs" Inherits="ClubCloud.Internet.AanmeldenUserControl" %>
<%@ Register Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls" TagPrefix="ClubCloud" %>

<style>
    .autocomplete_completionListElement
        {
            background-color: inherit;
            overflow: visible;
            text-align: left;
            list-style-type: none;
        }
        /* AutoComplete highlighted item */
        .autocomplete_highlightedListItem
        {
            background-color: rgb(218, 218, 218);
            color: black;
            padding: 1px;
        }
        /* AutoComplete item */
        .autocomplete_listItem
        {
            background-color: rgb(218, 218, 218);
            color: #838383;
            padding: 1px;
        }
</style>
<script type="text/javascript">
    function OnClientPopulating(sender, e) {
        sender._element.className = "wizardSearch";
    }
    function OnClientCompleted(sender, e) {
        sender._element.className = "";
    }

    function ValidateBank(sender, e) {
        $.getJSON('http://openiban.nl/openibanfree?bban=557308453', function (data) {
            alert(data.iban);
        });

    }

    function SetContextKey() {
        $find('<%=Verenigingsnummer_AutoCompleteExtender.ClientID%>').set_contextKey($get("<%=tbx_verenigingsnummer.ClientID %>").value);
}
</script>

<div class="first dark forms">
<asp:UpdateProgress ID="udp_progress" runat="server" AssociatedUpdatePanelID="udp_aanmelden" DynamicLayout="true" >
    <ProgressTemplate>
        <div class="progess" style="position: absolute; background-color: #F9F9F9; top: 0; left: 0; width: 100%; height: 100%;  -moz-opacity: 0.8; opacity: 0.8; filter: alpha(opacity=80); -ms-filter: 'progid:DXImageTransform.Microsoft.Alpha(Opacity=80)'; z-index: 10000;">
        <div class="bubbles aligncenter" style="top:48%; z-index: 10000;">laden...</div>
        </div>
    </ProgressTemplate>
</asp:UpdateProgress>
    <asp:UpdatePanel ID="udp_aanmelden" runat="server" UpdateMode="Conditional" RenderMode="Block"  ChildrenAsTriggers="true">
        <ContentTemplate>
            <asp:Wizard ID="wzd_aanmelden" runat="server" Width="100%" FinishPreviousButtonText="Vorige" FinishPreviousButtonType="Link" CancelButtonText="Stoppen" CancelButtonType="Link" FinishCompleteButtonText="Aanmelden" FinishCompleteButtonType="Link" StartNextButtonStyle-BorderStyle="NotSet" StartNextButtonText="Volgende" StartNextButtonType="Link" StepNextButtonText="Volgende" StepNextButtonType="Link" StepPreviousButtonText="Vorige" StepPreviousButtonType="Link" Height="100%" OnFinishButtonClick="wzd_aanmelden_FinishButtonClick" OnNextButtonClick="wzd_aanmelden_NextButtonClick" OnActiveStepChanged="wzd_aanmelden_ActiveStepChanged" OnPreRender="wzd_aanmelden_PreRender" OnLoad="wzd_aanmelden_Load" DisplaySideBar="False">
                <NavigationButtonStyle CssClass="button big" />
                <NavigationStyle CssClass="light" />
                <StartNextButtonStyle CssClass="button big" />
                <StepNextButtonStyle CssClass="button big" />
                <StepPreviousButtonStyle CssClass="button big" />
                <CancelButtonStyle CssClass="button big" />
                <FinishCompleteButtonStyle CssClass="button big" />
                <FinishPreviousButtonStyle CssClass="button big" />
                <StepStyle CssClass="light" />
                <WizardSteps>
                    <asp:WizardStep ID="wzd_vereniging" runat="server" Title="Uw vereniging" StepType="Start">
                        <asp:Panel runat="server" ID="pnl_vereniging" CssClass="forms">
                            <br />
                            <div class="three-fourth info" style="overflow:visible;">
                                <fieldset >
                                    <legend style="width:100%" class="services" ><i class="icon-address special"></i><h2>Vereniging</h2></legend>
                                    <br />
                                    <p>
                                        <label>Verenigingsnummer : </label>
                                        <asp:TextBox ID="tbx_verenigingsnummer" TextMode="SingleLine" runat="server" onkeyup ="SetContextKey()" AutoPostBack="true" OnTextChanged="tbx_verenigingsnummer_TextChanged" Width="80%" placeholder="Uw verenigingsnummer" />
                                        <asp:AutoCompleteExtender ID="Verenigingsnummer_AutoCompleteExtender" runat="server" DelimiterCharacters="" Enabled="True" ServiceMethod="GetVerenigingen" ServicePath="/_vti_bin/ClubCloud.Service/ClubCloud.svc/Script" TargetControlID="tbx_verenigingsnummer" UseContextKey="True" FirstRowSelected="True" MinimumPrefixLength="4" CompletionInterval="1000" OnClientHiding="OnClientCompleted" OnClientPopulated="OnClientCompleted" OnClientPopulating="OnClientPopulating"
                                            CompletionListCssClass="autocomplete_completionListElement" CompletionListItemCssClass="autocomplete_listItem" CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem" >
                                            <Animations>
                                       <OnShow><Sequence><OpacityAction Opacity="0" /><HideAction Visible="true" /><Parallel Duration=".4"><FadeIn /></Parallel></Sequence></OnShow>
                                       <OnHide><Parallel Duration=".4"><FadeOut /></Parallel></OnHide>
                                            </Animations>
                                        </asp:AutoCompleteExtender>
                                        <asp:FormView ID="fvw_vereniging" runat="server" RenderOuterTable="false" DataKeyNames="Id">
                                            <ItemTemplate>
                                                <label>Naam : </label>
                                                <asp:TextBox ID="Naam" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "Naam") %>' Width="80%" />
                                                <label>Kvk : </label>
                                                <asp:TextBox ID="KvKNummer" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "KvKnummer") %>' Width="20%" />
                                                te 
                                                <asp:TextBox ID="KvKPlaats" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "KvKplaats") %>' Width="57%" /><br />
                                                <label>Bankrekening: </label>
                                                <asp:TextBox ID="BankNummer" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "BankNummer") %>' Width="20%" onchange="ValidateBank()" />
                                                IBAN : 
                                                <asp:TextBox ID="BankIban" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "BankIban") %>' Width="26%" />
                                                te 
                                                <asp:TextBox ID="BankPlaats" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "BankPlaats") %>' Width="26%" /><br />
                                                <label>Telefoon Overdag : </label>
                                                <asp:TextBox ID="TelefoonOverdag" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "TelefoonOverdag") %>' Width="80%" /><br />
                                                <label>Telefoon Avond </label>
                                                <asp:TextBox ID="TelefoonAvond" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "TelefoonAvond") %>' Width="80%" /><br />
                                                <label>Email </label>
                                                <asp:TextBox ID="Email" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "EmailKNLTB") %>' Width="80%" /><br />
                                            </ItemTemplate>
                                        </asp:FormView>
                                    </p>
                                </fieldset>
                            </div>
                        </asp:Panel>
                    </asp:WizardStep>
                    <asp:WizardStep ID="wzd_gegevens" runat="server" Title="Uw Gegevens" StepType="Step">
                        <asp:Panel runat="server" ID="pnl_gegevens" CssClass="forms">
                            <br />
                            <div class="three-fourth info ">
                                <fieldset>
                                    <legend style="width:100%" ><i class="icon-user special"></i>
                                        <h2>Contact gegevens</h2>
                                    </legend>
                                    <br />
                                    <p>
                                        <asp:FormView ID="fvw_persoon" runat="server" RenderOuterTable="false" DefaultMode="Insert">
                                            <InsertItemTemplate>
                                                <label>Bondsnummer : </label>
                                                <asp:TextBox ID="KNLTBNummer" TextMode="SingleLine" runat="server" Width="80%" placeholder="KNLTB nummer" />
                                                <label>Naam : </label>
                                                <asp:TextBox ID="Naam" TextMode="SingleLine" runat="server" Width="80%" placeholder="Uw Naam"/>
                                                <label>Telefoon Overdag : </label>
                                                <asp:TextBox ID="TelefoonOverdag" TextMode="SingleLine" runat="server" Width="80%" placeholder="Telefoon overdag"/><br />
                                                <label>Telefoon Avond :</label>
                                                <asp:TextBox ID="TelefoonAvond" TextMode="SingleLine" runat="server" Width="80%" placeholder="Telefoon avond"/><br />
                                                <label>Email :</label>
                                                <asp:TextBox ID="Email" TextMode="SingleLine" runat="server" Width="80%" placeholder="Uw email"/><br />
                                            </InsertItemTemplate>
                                        </asp:FormView>
                                    </p>
                                </fieldset>
                            </div>
                        </asp:Panel>
                    </asp:WizardStep>
                    <asp:WizardStep ID="wzd_afronden" runat="server" Title="Aanmelden" StepType="Finish">
                        <asp:Panel runat="server" ID="pnl_aanmelden" CssClass="forms">
                            <br />
                            <i class="icon-pencil special"></i>
                            <div class="three-fourth info ">
                                <h3 class="lined">Aanmelden</h3>
                                <p class="description">
                                    Op alle aanbiedingen en overeenkomsten zijn de Nederland ICT Voorwaarden van toepassing, gedeponeerd bij de Kamer van Koophandel te Midden-Nederland onder nummer 30174840.
                                    <a href="https://onedrive.live.com/embed?cid=E2EF8A57AA853CB3&resid=E2EF8A57AA853CB3%21128&authkey=AFHwySTc3F1Vxi0&em=2" target="_blank">Voorwaarden lezen</a>
                                </p>
                                <label>Opmerkingen :</label>
                                <asp:TextBox ID="opmerkingen" runat="server" TextMode="MultiLine" Rows="10" /><br />
                                <asp:CheckBox ID="akkoord" runat="server" Checked="false" Text="&nbsp;&nbsp;Akkoord met de voorwaarden" TextAlign="Right"  CssClass="regular-checkbox" />
                            </div>
                        </asp:Panel>
                    </asp:WizardStep>
                    <asp:WizardStep ID="wzd_klaar" runat="server" Title="Vervolg" StepType="Complete">
            		  <h1 class="lined aligncenter">Het vervolg</h1>
            		  <i class="icon-info special"></i>
            		  <p class="description">
                            Bedankt voor het aanmelden van uw club. Wij zullen uw aanmelding zo snel mogelijk verwerken.<br/>
                            Binnenkort zullen wij contact opnemen om de verdere afhandeling te regelen.
                          </p>
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
        </ContentTemplate>
    </asp:UpdatePanel>
<asp:Label ID="lbl_result" runat="server"></asp:Label>
</div>
