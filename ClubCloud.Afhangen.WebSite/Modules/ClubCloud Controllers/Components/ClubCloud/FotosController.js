"use strict";

define(['angularAMD', 'Services/FotosServices'], function (app, FotosServices) {
    app.controller('FotosController', function ($rootScope, $scope, $state, $stateParams, $window, FotosServices) {

        $rootScope.Fotos = {};

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