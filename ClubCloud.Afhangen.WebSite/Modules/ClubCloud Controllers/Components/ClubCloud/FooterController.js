﻿"use strict";

define(['angularAMD', 'Services/FooterServices'], function (app, FooterServices) {
    app.controller('FooterController', function ($rootScope, $scope, $state, $stateParams, $window, FooterServices) {

        $rootScope.Menu.Footer = {};

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
