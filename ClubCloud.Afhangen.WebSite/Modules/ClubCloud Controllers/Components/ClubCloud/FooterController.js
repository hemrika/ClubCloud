"use strict";

define(['angularAMD', 'Services/FooterServices'], function (app, FooterServices) {
    app.controller('FooterController', function ($rootScope, $scope, $state, $stateParams, $window, FooterServices) {

        $rootScope.Menu.Footer = {};

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