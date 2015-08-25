"use strict";

define(['angularAMD', 'Services/FormulierenServices'], function (app, FormulierenServices) {
    app.controller('FormulierenController', function ($rootScope, $scope, $state, $stateParams, $window, FormulierenServices) {

        $rootScope.Formulieren = {};

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