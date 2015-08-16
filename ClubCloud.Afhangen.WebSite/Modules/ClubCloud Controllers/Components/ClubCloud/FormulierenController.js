"use strict";

define(['angularAMD', 'Services/FormulierenServices'], function (app, FormulierenServices) {
    app.controller('FormulierenController', function ($rootScope, $scope, $state, $stateParams, $window, FormulierenServices) {

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