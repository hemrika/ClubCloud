"use strict";

define(['angularAMD', 'Services/KalendersServices'], function (app, KalendersServices) {
    app.controller('KalendersController', function ($rootScope, $scope, $state, $stateParams, $window, KalendersServices) {

        $rootScope.Kalenders = {};

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
