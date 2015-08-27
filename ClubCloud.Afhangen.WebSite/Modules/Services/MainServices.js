define(['afhangen-configuration', 'ajaxService'], function (app) {

    app.register.service('mainService', ['ajaxService', function (ajaxService) {

        this.initializeApplication = function (successFunction, errorFunction) {
            ajaxService.AjaxGet("/_vti_bin/ClubCloud.Mobiel/Mobiel.svc", successFunction, errorFunction);
        };

        this.authenicateUser = function (successFunction, errorFunction) {
            ajaxService.AjaxGet("/_vti_bin/ClubCloud.Mobiel/Mobiel.svc/Login", successFunction, errorFunction);
        };

        this.logout = function (successFunction, errorFunction) {
            ajaxService.AjaxGet("/_vti_bin/ClubCloud.Mobiel/Mobiel.svc/Logout", successFunction, errorFunction);
        };
    }]);
});
