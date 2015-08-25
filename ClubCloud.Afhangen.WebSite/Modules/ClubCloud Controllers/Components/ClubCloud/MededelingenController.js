"use strict";

define(['angularAMD', 'Services/MededelingenServices'], function (app, MededelingenServices) {
    app.controller('MededelingenController', function ($rootScope, $scope, $state, $stateParams, $window, MededelingenServices) {

        $rootScope.Mededelingen = {};

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