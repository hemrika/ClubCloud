"use strict";

define(['afhangen-configuration', 'mainService', 'alertsService'], function (app) {

    app.register.controller('logoutController', ['$scope', '$rootScope', '$cookieStore', 'mainService', 'alertsService', function ($scope, $rootScope, mainService, alertsService) {

        $scope.initializeController = function () {
            var proxy = nl.clubcloud.Afhangen;
            proxy.Logout($scope.logoutComplete, $scope.logoutError);
            //mainService.logout($scope.logoutComplete, $scope.logoutError);
        }

        $scope.logoutComplete = function (response) {
            $cookieStore.put('FedAuth', null);
            window.location = "/index.html";
        }

        $scope.logoutError = function (response) {
            alertsService.RenderErrorMessage(response.ReturnMessage);
        }

    }]);
});