"use strict";

define(['angularAMD', 'Services/BerichtenServices'], function (app, BerichtenServices) {
    app.controller('BerichtenController', function ($rootScope, $scope, $state, $stateParams, $window, BerichtenServices) {

        $rootScope.Berichten = {};

        $scope.$on('$viewContentLoading', function (event) {
            event.preventDefault();

            try {
            }
            catch (err) { }
        })

        $scope.$on('$viewContentLoaded', function (event) {
            event.preventDefault();
            try {
            }
            catch (err) { }
        })
    });
});