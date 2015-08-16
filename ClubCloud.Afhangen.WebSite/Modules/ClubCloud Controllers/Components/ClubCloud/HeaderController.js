"use strict";

define(['angularAMD', 'Services/HeaderServices'], function (app, HeaderServices) {
    app.controller('HeaderController', function ($rootScope, $scope, $state, $stateParams, $window, HeaderServices) {

        $rootScope.site = { Name: 'ClubCloud', Language: 'nl-nl', Direction: 'ltr' };

        $rootScope.Menu.Header = {};

        try {
            HeaderServices.get().then(function (result) {
                $scope.rows = result;
            });
        }
        catch (err) { }

        $rootScope.$on('$viewContentLoading', function (event) {
            event.preventDefault();
            try {
                HeaderServices.get().then(function (result) {
                    $scope.rows = result;
                });
            }
            catch (err) { }
        })

        $rootScope.$on('$viewContentLoaded', function (event) {
            event.preventDefault();
            try {
                $(".memenu").memenu();

                $("#flexiselDemo1").flexisel({
                    visibleItems: 4,
                    animationSpeed: 1000,
                    autoPlay: true,
                    autoPlaySpeed: 3000,
                    pauseOnHover: true,
                    enableResponsiveBreakpoints: true,
                    responsiveBreakpoints: {
                        portrait: {
                            changePoint: 480,
                            visibleItems: 1
                        },
                        landscape: {
                            changePoint: 640,
                            visibleItems: 2
                        },
                        tablet: {
                            changePoint: 768,
                            visibleItems: 3
                        }
                    }
                });
            }
            catch (err) { }
        })

    });
});
