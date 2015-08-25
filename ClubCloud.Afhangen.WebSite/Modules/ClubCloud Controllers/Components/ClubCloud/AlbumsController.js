"use strict";

define(['angularAMD', 'Services/AlbumsServices'], function (app, AlbumsServices) {
    app.controller('AlbumsController', function ($rootScope, $scope, $state, $stateParams, $window, AlbumsServices) {

        $root.Albums = {};

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