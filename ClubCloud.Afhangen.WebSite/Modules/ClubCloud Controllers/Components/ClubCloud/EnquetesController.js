"use strict";

define(['angularAMD', 'Services/EnquetesServices'], function (app, EnquetesServices) {
    app.controller('EnquetesController', function ($rootScope, $scope, $state, $stateParams, $window, EnquetesServices) {

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