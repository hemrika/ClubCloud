"use strict";

define(['angularAMD', 'Services/OpmerkingenServices'], function (app, OpmerkingenServices) {
    app.controller('OpmerkingenController', function ($rootScope, $scope, $state, $stateParams, $window, OpmerkingenServices) {

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