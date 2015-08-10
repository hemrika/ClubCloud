"use strict";

define(['afhangen-configuration', 'mainService', 'alertsService'], function (app) {

    app.register.controller('defaultController', ['$scope', '$rootScope', '$cookies', 'mainService', 'alertsService', function ($scope, $rootScope, $cookies, mainService, alertsService) {

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
                'Route': '#/Bezetting/Banen',
                'Description': 'Bezetting'
            }];

            $rootScope.displayContent = true;

            var proxy = nl.clubcloud.Afhangen;
            proxy.IsAuthorized($scope.initializeApplicationComplete, $scope.initializeApplicationError);
            //mainService.IsAuthorized($scope.initializeApplicationComplete, $scope.initializeApplicationError);

        }

        $scope.initializeApplicationComplete = function (response) {

            if (response.ErrorCode == ClubCloud.Service.LoginErrorCode.NoError) {
                $rootScope.displayContent = true;
                //window.location = "index.html";
            }
            else {
                setTimeout(function () {
                    window.location = "#Accounts/Login";
                }, 10);
            }
        }

        $scope.initializeApplicationError = function (response) {
            if (response) {
                if (response._statusCode == '401') {
                    setTimeout(function () {
                        window.location = "#Accounts/Login";
                    }, 10);
                }
            }
        }



    }]);
});


