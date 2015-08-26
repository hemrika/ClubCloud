"use strict";

define(['angularAMD', 'Services/HeaderServices', 'ShareCoffee', 'ShareCoffee-Search'], function (app, HeaderFactory, ShareCoffee, ShareCoffeeSearch) {
    app.controller('HeaderController', function ($rootScope, $scope, $state, $stateParams, HeaderFactory) {

        $rootScope.site = { Name: 'ClubCloud', Language: 'nl-nl', Direction: 'ltr' };
        $rootScope.Pagina = {};
        $rootScope.Menu.Header = {};

        HeaderFactory.TopNavigation(onItems, onItemsError, $stateParams);

        var onItems = function (data) {

            if (data[0].length > 0) {
                angular.forEach(data[0], function (node) {
                    $scope.Menu.Header.push(node);
                });
            }

            if (!$scope.$$phase) { $scope.$apply(); }
        };

        var onItemsError = function (data) { console.log('MetadataEvent :' + data.message); };

        $rootScope.$on('MetadataEvent', function (event, content) {

            try {
                var title = content.Title;
                if (!$scope.$$phase) { $scope.$apply(); }
            }
            catch (err) { console.log('MetadataEvent :' + err.message); }

        })

        $scope.$on('$viewContentLoading', function (event) {
            event.preventDefault();
            try {
            }
            catch (err) { }
        })

        $scope.$on('$viewContentLoaded', function (event) {
            event.preventDefault();
            try {
                $(".memenu").memenu();
            }
            catch (err) { }
        })

    });
});
