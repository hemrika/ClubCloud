"use strict";

define(['angularAMD', 'Services/DocumentenServices'], function (app, DocumentenServices) {
    app.controller('DocumentenController', function ($rootScope, $scope, $state, $stateParams, $window, DocumentenServices) {

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