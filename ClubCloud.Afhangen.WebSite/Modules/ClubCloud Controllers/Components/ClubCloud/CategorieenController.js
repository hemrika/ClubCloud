"use strict";

define(['angularAMD', 'Services/CategorieenServices'], function (app, CategorieenServices) {
    app.controller('CategorieenController', function ($rootScope, $scope, $state, $stateParams, $window, CategorieenServices) {

        $rootScope.Categorieen = {};

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