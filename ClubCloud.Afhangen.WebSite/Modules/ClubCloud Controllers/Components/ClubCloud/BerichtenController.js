"use strict";

define(['angularAMD', 'Services/BerichtenServices'], function (app, BerichtenServices) {
    app.controller('BerichtenController', function ($rootScope, $scope, $state, $stateParams, $window, BerichtenServices) {

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