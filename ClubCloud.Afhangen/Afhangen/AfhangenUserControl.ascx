<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Assembly Name="Syncfusion.EJ, Version=12.4450.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register Tagprefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Import Namespace="AjaxControlToolkit" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AfhangenUserControl.ascx.cs" Inherits="ClubCloud.Afhangen.AfhangenUserControl" %>
<%@ Register Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls" TagPrefix="cc1" %>
<%@ Register Assembly="Syncfusion.EJ, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Web" TagPrefix="ej" %>
<%@ Register Assembly="Syncfusion.EJ.Web, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Web" TagPrefix="ej" %>


<style>
    .userInteractionDiv {
        height: 380px;
    }

    .userInteractionTable {
        padding: 15px;
        background-color: #f4f4f4;
        vertical-align: top;
        border: 1px solid lightgray;
    }

    .travelTypeDiv {
        background-color: white;
        border: 1px solid lightgray;
        width: 259px;
    }

    .iconButton {
        color: white;
        font-size: 18px;
        border: 1px solid #67c9ed;
        background-color: #rgb(0, 114, 198);
        width: 30px;
        height: 28px;
    }

    .countBox {
        text-align: center;
        width: 40px !important;
        height: 28px !important;
        outline: none !important;
        border: 1px solid lightgray !important;
        text-indent: 0 !important;
        margin-bottom: 2px !important;
        padding-top: 0 !important;
        padding-bottom: 0 !important;
    }

    .MonthYearBox {
        text-align: center;
        outline: none !important;
        border: 1px solid lightgray !important;
        text-indent: 0 !important;
        margin-bottom: 2px !important;
        padding-top: 0 !important;
        padding-bottom: 0 !important;
        background-color: rgb(0, 114, 198);
    }

    #btnSearchFlight {
        vertical-align: bottom;
        color: white;
        font-size: 14px;
        border-color: #67c9ed;
        background-color: #67c9ed;
    }

        #btnSearchFlight:hover {
            background-color: #11A0C1;
            border-color: #11A0C1;
        }


    #btnOneWaymainiconstatic {
        background-image: url(images/icons-white.png);
        background-position: -470px -62px;
        background-color: #67c9ed;
    }

    #btnRoundTripmainiconstatic {
        background-image: url(images/icons-white.png);
        background-position: -417px -60px;
        background-color: #67c9ed;
    }
    /*
    .frame {
            margin-left: 31%;
            margin-top: 4%;
            padding: 14px 37px 10px 18px;
            width: 218px;
        }
    */
</style>
<script type="text/javascript">
    function OnClientPopulating(sender, e) {
        sender._element.className = "wizardSearch";
    }
    function OnClientCompleted(sender, e) {
        sender._element.className = "";
    }
</script>


<asp:UpdateProgress ID="udp_progress" runat="server" AssociatedUpdatePanelID="udp_afhangen">
    <ProgressTemplate>
        <div class="progess" style="position: absolute; background-color: #F9F9F9; top: 0px; left: 0px; width: 100%; height: 100%; opacity: 0.8; -moz-opacity: 0.8; filter: alpha(opacity=80); -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=80)"; z-index: 10000;">
        <div class="bubbles aligncenter" style="top:48%; z-index: 10000;">laden...</div>
        </div>
    </ProgressTemplate>
</asp:UpdateProgress>

<asp:UpdatePanel ID="udp_afhangen" runat="server" UpdateMode="Always" >
    <ContentTemplate>
        <asp:Timer runat="server" ID="tmr_loader_afhangen" OnTick="tmr_loader_afhangen_Tick" Interval="50" />
        <fieldset >
            <div class="one-third first">
                <i class="icon-vcard special"></i>
                <div class="info lined">
                    <ej:DatePicker ID="DatePicker" runat="server" OnSelect="DatePicker_Select"></ej:DatePicker>
                    <ej:TimePicker ID="TimePicker" runat="server" OnSelect="TimePicker_Select" Locale="nl-NL" TimeFormat="hh:mm tttt"></ej:TimePicker>

                    <h3 class="lined">Gegevens</h3>
                    <label>Spelers</label><br />
                    <p>
                        <input type="button" id="SpelerDecrement" value="-" class="iconButton" onclick="return DecrementCount()" />
                        <asp:TextBox Text="2" ID="SpelersCount" ClientIDMode="Static" runat="server" Enabled="false" CssClass="countBox" AutoPostBack="true" minValue="1" maxValue="4" defaultValue="2" OnTextChanged="aantal_TextChanged"/>
                        <input type="button" id="SpelerIncrement" value="+" class="iconButton" onclick="return IncrementCount()"/>
                    </p>
                    
                    <asp:TextBox ID="tbx_speler_een" runat="server" OnTextChanged="aantal_TextChanged"></asp:TextBox>
                    <ajaxToolkit:AutoCompleteExtender ID="SpelerEen_AutoCompleteExtender" runat="server" DelimiterCharacters="" Enabled="True" ServiceMethod="GetGebruikers" ServicePath="/_vti_bin/ClubCloud.Service/ClubCloud.svc/Script" TargetControlID="tbx_speler_een" UseContextKey="True" FirstRowSelected="True" MinimumPrefixLength="3" CompletionInterval="250" OnClientHiding="OnClientCompleted" OnClientPopulated="OnClientCompleted" OnClientPopulating="OnClientPopulating">
                        <Animations>
                            <OnShow><Sequence><OpacityAction Opacity="0" /><HideAction Visible="true" /><Parallel Duration=".4"><FadeIn /></Parallel></Sequence></OnShow>
                            <OnHide><Parallel Duration=".4"><FadeOut /></Parallel></OnHide>
                        </Animations>
                    </ajaxToolkit:AutoCompleteExtender>
                    <asp:TextBox ID="tbx_speler_twee" runat="server"></asp:TextBox>
                    <ajaxToolkit:AutoCompleteExtender ID="SpelerTwee" TargetControlID="tbx_speler_twee" runat="server" DelimiterCharacters="" Enabled="True" ServiceMethod="GetGebruikers" ServicePath="/_vti_bin/ClubCloud.Service/ClubCloud.svc/Script" UseContextKey="True" FirstRowSelected="True" MinimumPrefixLength="3" CompletionInterval="250" OnClientHiding="OnClientCompleted" OnClientPopulated="OnClientCompleted" OnClientPopulating="OnClientPopulating">
                        <Animations>
                            <OnShow><Sequence><OpacityAction Opacity="0" /><HideAction Visible="true" /><Parallel Duration=".4"><FadeIn /></Parallel></Sequence></OnShow>
                            <OnHide><Parallel Duration=".4"><FadeOut /></Parallel></OnHide>
                        </Animations>
                    </ajaxToolkit:AutoCompleteExtender>
                    <asp:TextBox ID="tbx_speler_drie" runat="server"></asp:TextBox>
                    <ajaxToolkit:AutoCompleteExtender ID="SpelerDrie" TargetControlID="tbx_speler_drie" runat="server" DelimiterCharacters="" Enabled="True" ServiceMethod="GetGebruikers" ServicePath="/_vti_bin/ClubCloud.Service/ClubCloud.svc/Script" UseContextKey="True" FirstRowSelected="True" MinimumPrefixLength="3" CompletionInterval="250" OnClientHiding="OnClientCompleted" OnClientPopulated="OnClientCompleted" OnClientPopulating="OnClientPopulating">
                        <Animations>
                            <OnShow><Sequence><OpacityAction Opacity="0" /><HideAction Visible="true" /><Parallel Duration=".4"><FadeIn /></Parallel></Sequence></OnShow>
                            <OnHide><Parallel Duration=".4"><FadeOut /></Parallel></OnHide>
                        </Animations>
                    </ajaxToolkit:AutoCompleteExtender>
                    <asp:TextBox ID="tbx_speler_vier" runat="server"></asp:TextBox>
                    <ajaxToolkit:AutoCompleteExtender ID="SpelerVier" TargetControlID="tbx_speler_vier" runat="server" DelimiterCharacters="" Enabled="True" ServiceMethod="GetGebruikers" ServicePath="/_vti_bin/ClubCloud.Service/ClubCloud.svc/Script" UseContextKey="True" FirstRowSelected="True" MinimumPrefixLength="3" CompletionInterval="250" OnClientHiding="OnClientCompleted" OnClientPopulated="OnClientCompleted" OnClientPopulating="OnClientPopulating">
                        <Animations>
                            <OnShow><Sequence><OpacityAction Opacity="0" /><HideAction Visible="true" /><Parallel Duration=".4"><FadeIn /></Parallel></Sequence></OnShow>
                            <OnHide><Parallel Duration=".4"><FadeOut /></Parallel></OnHide>
                        </Animations>
                    </ajaxToolkit:AutoCompleteExtender>
                    <label>Datum</label><br />
                        <p>
                            <div id="DateMonthYear" class="MonthYearBox">
                            <asp:Label ID="DateMonth" ClientIDMode="Static" runat="server" Enabled="false" CssClass="countBox" AutoPostBack="true" />
                             <asp:Label ID="DateYear" ClientIDMode="Static" runat="server" Enabled="false" CssClass="countBox" AutoPostBack="true" />
                            </div>
                                <br />
                            <input type="button" id="DateDecrement" value="<" class="iconButton" onclick="return DecrementDay()" />
                            <asp:TextBox ID="DateDay" ClientIDMode="Static" runat="server" Enabled="false" CssClass="countBox" AutoPostBack="true" />
                            <input type="button" id="DateIncrement" value=">" class="iconButton" onclick="return Incrementday()" />
                            <p>
                            </p>
                            <p>
                            </p>
                            <p>
                            </p>
                    </p>
                </div>
            </div>
            <div class="two-third last">
                <div class="info">
                    <h3 class="lined">Banen</h3>
                    <ej:NumericTextBox ID="NumericTextBox" runat="server"></ej:NumericTextBox>
                    <ej:CheckBox ID="CheckBox" runat="server"></ej:CheckBox>
                </div>
            </div>
        </fieldset>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="tmr_loader_afhangen" EventName="Tick" />
        <asp:AsyncPostBackTrigger ControlID="DatePicker" EventName="Select" />
        <asp:AsyncPostBackTrigger ControlID="TimePicker" EventName="Select" />
        
    </Triggers>
</asp:UpdatePanel>
<asp:Label ID="lbl_result" runat="server"></asp:Label>
<script async="async" defer="defer" id="afhangen" type="text/javascript" src="https://mijn.clubcloud.nl/_vti_bin/ClubCloud.Afhangen/Afhangen.svc/Script/jsdebug" ></script>
    <script type="text/javascript">

        Date.prototype.getMonthShortName = function () {
            var m = ['JAN', 'FEB', 'MAR', 'APR', 'MAY', 'JUN', 'JUL', 'AUG', 'SEP', 'OCT', 'NOV', 'DEC'];
            return m[this.getMonth()];
        };

        Date.prototype.getDayShortName = function () {
            var d = ['SUN', 'MON', 'TUE', 'WED', 'THU', 'FRI', 'SAT'];
            return d[this.getDay()];
        };

        var nHoverNode = null;
        var oHoverNode = null;

        var oneWay = false;
        var roundTrip = false;
        var selectedNode = null;
        var spelerCount = 0;
        var numobject;

        var vereniging = null;
        var vereniging_settings = null;

        $(function () {

            /*
            var increment = $("#spelerIncrement");

            $('#spelerIncrement').bind("click", function (event) {
                var spelerTextElement = document.getElementById("spelerCount");
                var lastValue = Number(spelerTextElement.value);
                spelerTextElement.value = lastValue + 1;

            });

            $('body').on('click', '#spelerIncrement', function () {
                console.log("yeahhhh!!! but this doesn't work for me :(");
            });

            var decrement = $("#spelerDecrement");

            $("#spelerDecrement").bind("click", function (event) {
                var spelerTextElement = document.getElementById("spelerCount");
                var lastValue = Number(spelerTextElement.value);
                if (lastValue != 0)
                    spelerTextElement.value = lastValue - 1;

            });
            */
        });

        //$(function () {
        //    /* var dateObj = $('#datepickerinline').data("ejDatePicker"); */

        //    // declaration
        //    $("#datepickerinline").ejDatePicker({
        //        select: "onSelected",
        //        showFooter: false,
        //        displayInline: true/*, width: 200*/
        //    });
        //});

        //$(function () {
        //    /*var timeObj = $('#timepickerinline').data("ejTimePicker");
        //    timeObj.setCurrentTime();*/

        //    // declaration
        //    $("#timepickerinline").ejTimePicker({
        //        "value": "10:10"
        //    });
        //});

        function DateCreated(args) {
            var today = new Date();
            /*
            var dateObj = $('#datepickerinline').data("ejDatePicker");
            dateObj.model.maxDate = today.setDate(5);
            dateObj.model.minDate = today;
            dateObj.model.defaultVal = today;
            */
            /*
            var timeObj = $('#datepickerinline').ejDatePicker({
                minDate: today,
                maxDate: today.setDate(5),
                DefaultDate: today
            });
            */

            /*$("#col-md-2").html("Op " + dateObj.model.value + " om " + timeObj.model.value); */
        };

        function DateSelected(args) {
            var dateObj = $('#datepickerinline').data("ejDatePicker");

            var timeObj = $('#timepickerinline').data("ejTimePicker");

            /* $("#col-md-2").html("Op " + dateObj.model.value + " om "+ timeObj.model.value); */
        }

        function TimeCreated(args) {
            var timeObj = $('#timepickerinline').data("ejTimePicker");
            timeObj.setCurrentTime();

            /*$("#col-md-2").html("Op " + dateObj.model.value + " om " + timeObj.model.value); */
        };

        function TimeSelected(args) {
            var dateObj = $('#datepickerinline').data("ejDatePicker");

            var timeObj = $('#timepickerinline').data("ejTimePicker");

            /* $("#col-md-2").html("Op " + dateObj.model.value + " om " + timeObj.model.value); */
        };

        /*
        function isNumber(evt) {

            var element = evt.srcElement;
            var val = parseInt(element.value);
            var minVal = parseInt(element.getAttribute("minValue"));
            var maxVal = parseInt(element.getAttribute("maxValue"));
            var defaultVal = parseInt(element.getAttribute("defaultValue"));
            if (!isNaN(maxVal) && !isNaN(minVal)) {
                if (!isNaN(val)) {
                    if (minVal <= val && val <= maxVal) {
                        element.value = val;
                    }
                    else
                    {
                        element.value = defaultVal;
                    }
                }
                else
                {  
                    element.value = defaultVal;
                }
            }
            else {
                if (!isNaN(val)) {
                    element.value = val;
                }
                else
                {
                    element.value = defaultVal;
                }
            }

            $("#col-md-1").html("Aantal Spelers : " + element.value);
            return true;
            
        };
        */

        function IncrementCount(args) {
            var spelerTextElement = document.getElementById("SpelersCount");
            var lastValue = Number(spelerTextElement.value);
            if (lastValue < 4) {
                spelerTextElement.value = lastValue + 1;
            };
            /* $("#col-md-1").html("Aantal Spelers : " + spelerTextElement.value);*/
        };

        function DecrementCount(args) {
            var spelerTextElement = document.getElementById("SpelersCount");
            var lastValue = Number(spelerTextElement.value);
            if (lastValue > 1) {
                spelerTextElement.value = lastValue - 1;
            };
            /* $("#col-md-1").html("Aantal Spelers : " + spelerTextElement.value); */
        };

        function getSpelerCount() {
            var spelerTextBoxElement = document.getElementById("SpelersCount");
            if (spelerTextBoxElement) {
                spelerCount = Number(spelerTextBoxElement.value);
                return spelerCount
            }
            return 0;
        };


        function btnAantalClick(sender) {
            if (vereniging === null) {
                clubcloud.nl.ClubCloudAfhangen.GetVerenigingByNummer('12073385', '82503', false, VerenigingSucceededCallback, VerenigingFailedCallback);
            };

            /* clubcloud.nl.ClubCloudAfhangen.GetVerenigingSettings('12073385', vereniging.Id , true, SettingsSucceededCallback, SettingsFailedCallback);*/
        };

        function VerenigingSucceededCallback(result) {
            alert(result);
        }

        function VerenigingFailedCallback(result) {
            alert(result);
        }

        function SucceededCallback(result) {
            alert(result);
        }

        function FailedCallback(result) {
            alert(result);
        }

    </script>