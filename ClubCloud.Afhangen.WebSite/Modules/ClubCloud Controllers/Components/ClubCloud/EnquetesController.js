"use strict";

define(['angularAMD', 'Services/EnquetesServices'], function (app, EnquetesServices) {
    app.controller('EnquetesController', function ($rootScope, $scope, $state, $stateParams, $window, EnquetesServices) {

        $rootScope.Enquetes = {};

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