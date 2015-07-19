"use strict";

define(['afhangen-configuration', 'mainService', 'alertsService'], function (app) {

    app.register.controller('defaultController', ['$scope', '$rootScope', 'mainService', 'alertsService', function ($scope, $rootScope, mainService, alertsService) {

        $rootScope.closeAlert = alertsService.closeAlert;

        $scope.initializeController = function () {
            $rootScope.MenuItems = [];
            $rootScope.MenuItems = [{
                'Route': '#/',
                'Description': 'Home'
            }, {
                'Route': '#/Afhangen',
                'Description': 'Afhangen'
            }, {
                'Route': '#/Reserveringen',
                'Description': 'Reserveringen'
            }, {
                'Route': '#/Bezetting',
                'Description': 'Bezetting'
            }];

            $rootScope.displayContent = true;

            mainService.initializeApplication($scope.initializeApplicationComplete, $scope.initializeApplicationError);
        }

        $scope.initializeApplicationComplete = function (response) {
            $rootScope.MenuItems = [];
            $rootScope.MenuItems.push({ Route: '#Main/Home', Description: 'Home' });
            $rootScope.displayContent = true;

            if (response.IsAuthenicated == true) {
                window.location = "/applicationMasterPage.html#/Customers/CustomerInquiry";
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


