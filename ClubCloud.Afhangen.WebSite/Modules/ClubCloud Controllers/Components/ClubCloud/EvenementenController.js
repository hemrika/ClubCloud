"use strict";

define(['angularAMD', 'Services/EvenementenServices'], function (app, EvenementenServices) {
    app.controller('EvenementenController', function ($rootScope, $scope, $state, $stateParams, $window, EvenementenServices) {

        $rootScope.Evenementen = {};

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
