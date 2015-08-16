"use strict";

define(['angularAMD', 'Services/MededelingenServices'], function (app, MededelingenServices) {
    app.controller('MededelingenController', function ($rootScope, $scope, $state, $stateParams, $window, MededelingenServices) {

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