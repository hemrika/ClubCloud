"use strict";

define(['afhangen-configuration', 'accountsService', 'alertsService'], function (app) {

    app.register.controller('loginController', ['$scope', '$rootScope', '$cookies', 'accountsService', 'alertsService',
        function ($scope, $rootScope, $cookies, accountsService, alertsService) {

            $rootScope.closeAlert = alertsService.closeAlert;
            $rootScope.alerts = [];

            $scope.initializeController = function () {

                $scope.UserName = "";
                $scope.Password = "";

                //alertsService.RenderSuccessMessage("Please register if you do not have an account.");

            }

            $scope.login = function () {
                $rootScope.IsloggedIn = false;
                var proxy = nl.clubcloud.Afhangen;
                proxy.Login($scope.UserName, $scope.Password, $scope.loginCompleted, $scope.loginError)
            }

            $scope.loginCompleted = function (response) {
                if (response.ErrorCode == ClubCloud.Service.LoginErrorCode.NoError) {
                    $rootScope.IsloggedIn = true;
                    window.location = "index.html";
                }
                else {
                    alertsService.RenderErrorMessage(response.ErrorCode + " : " + response.Message);
                    $rootScope.IsloggedIn = false;
                }
            }

            $scope.loginError = function (response) {

                alertsService.RenderErrorMessage(response.ErrorCode + " : " + response.Message);

                $scope.clearValidationErrors();
                alertsService.SetValidationErrors($scope, response.ErrorCode + " : " + response.Message);

            }

            $scope.clearValidationErrors = function () {

                $scope.UserNameInputError = false;
                $scope.PasswordInputError = false;

            }

            $scope.createLoginCredentials = function () {

                var user = new Object();

                user.UserName = $scope.UserName;
                user.Password = $scope.Password;

                return user;

            }

        }]);
});
