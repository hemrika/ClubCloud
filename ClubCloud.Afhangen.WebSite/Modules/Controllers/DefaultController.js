"use strict";

define(['afhangen-configuration', 'mainService', 'alertsService'], function (app) {

    app.register.controller('defaultController', ['$scope', '$rootScope', '$cookieStore', 'mainService', 'alertsService', function ($scope, $rootScope, $cookieStore, mainService, alertsService) {

        $rootScope.closeAlert = alertsService.closeAlert;

        $scope.initializeController = function () {
            $rootScope.MenuItems = [];
            $rootScope.MenuItems = [{
                'Route': '#/',
                'Description': 'Home'
            }, {
                'Route': '#/Afhangen/Start',
                'Description': 'Afhangen'
            }, {
                'Route': '#/Reserveringen/Start',
                'Description': 'Reserveringen'
            }, {
                'Route': '#/Bezetting/Baa',
                'Description': 'Bezetting'
            }];

            $rootScope.displayContent = true;

            var FedAuth = $cookieStore.get('FedAuth');
            var proxy = nl.clubcloud.Afhangen;
            proxy.IsAuthorized(FedAuth, $scope.initializeApplicationComplete, $scope.initializeApplicationError);

            //mainService.initializeApplication($scope.initializeApplicationComplete, $scope.initializeApplicationError);
        }

        $scope.initializeApplicationComplete = function (response) {
            $rootScope.MenuItems = [];

            $rootScope.displayContent = true;

            if (response.ErrorCode == 'NoError') {
                window.location = "/index.html";
            }
            else {

                // set timeout needed to prevent AngularJS from raising a digest error
                setTimeout(function () {
                    window.location = "#Accounts/Login";
                }, 10);

            }
        }

        $scope.initializeApplicationError = function (response) {
            alertsService.RenderErrorMessage(response.ReturnMessage);
        }



    }]);
});


