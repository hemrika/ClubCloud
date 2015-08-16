"use strict";

define(['angularAMD', 'Services/EvenementenServices'], function (app, EvenementenServices) {
    app.controller('EvenementenController', function ($rootScope, $scope, $state, $stateParams, $window, EvenementenServices) {

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