"use strict";

define(['angularAMD', 'Services/CategorieenServices'], function (app, CategorieenServices) {
    app.controller('CategorieenController', function ($rootScope, $scope, $state, $stateParams, $window, CategorieenServices) {

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