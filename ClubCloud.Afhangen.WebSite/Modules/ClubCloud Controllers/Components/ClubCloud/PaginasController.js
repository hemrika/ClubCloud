"use strict";

define(['angularAMD', 'Services/PaginasServices'], function (app, PaginasServices) {
    app.controller('PaginasController', function ($rootScope, $scope, $state, $stateParams, $window, PaginasServices) {

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