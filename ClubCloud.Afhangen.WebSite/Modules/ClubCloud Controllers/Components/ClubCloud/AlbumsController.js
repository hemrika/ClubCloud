"use strict";

define(['angularAMD', 'Services/AlbumsServices'], function (app, AlbumsServices) {
    app.controller('AlbumsController', function ($rootScope, $scope, $state, $stateParams, $window, AlbumsServices) {

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