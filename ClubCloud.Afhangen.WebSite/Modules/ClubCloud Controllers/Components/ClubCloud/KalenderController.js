"use strict";

define(['angularAMD', 'Services/KalenderServices'], function (app, KalenderServices) {
    app.controller('KalenderController', function ($rootScope, $scope, $state, $stateParams, $window, KalenderServices) {

        $rootScope.Pagina = {};

        $rootScope.$on('$viewContentLoading', function (event) {
            event.preventDefault();

            try {
            }
            catch (err) { }
        })

        $rootScope.$on('$viewContentLoaded', function (event) {
            event.preventDefault();
            try {
            }
            catch (err) { }
        })
    });
});