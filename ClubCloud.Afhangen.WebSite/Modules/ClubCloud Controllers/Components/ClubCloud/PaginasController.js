"use strict";

define(['angularAMD', 'Services/PaginasServices', 'ShareCoffee', 'ShareCoffee-Search'], function (app, PaginasFactory, ShareCoffee, ShareCoffeeSearch) {
    app.controller('PaginasController', function ($rootScope, $scope, $state, $stateParams, $window, PaginasFactory) {
        $scope.Pagina = {};
        $scope.Paginas = [];
        $scope.Suggesties = [];

        try {
            var onDigest = function (FormDigestValue) {
                $stateParams.FormDigestValue = FormDigestValue;
                PaginasFactory.Item(onPagina, onPaginaError, $stateParams);
            };

            var onDigestError = function (data) { };

            var onPagina = function (data) {
                if (data[0].length > 0) {
                    angular.forEach(data[0], function (pagina) {
                        var content = pagina.WikiField;
                        $scope.Paginas.push(pagina);
                    });

                    $scope.Pagina = $scope.Paginas[0];
                }
                else {
                    $state.go('Content.404', $stateParams);
                }

                angular.forEach(data[1], function (suggestie) {
                    $scope.Suggesties.push(suggestie);
                });

                if (!$scope.$$phase) { $scope.$apply(); }
                $rootScope.$emit('MetadataEvent', $scope.Pagina);
            };

            var onPaginas = function (data) {
                if (data[0].length > 0) {
                    angular.forEach(data[0], function (pagina) {
                        $scope.Paginas.push(pagina);
                    });
                }

                if (!$scope.$$phase) { $scope.$apply(); }
            };

            var onSuggesties = function (data) {
                if (data[0].length > 0) {
                    angular.forEach(data[0], function (suggestie) {
                        $scope.Suggesties.push(suggestie);
                    });
                }

                if (!$scope.$$phase) { $scope.$apply(); }
            };

            var onPaginaError = function (data) {
                $state.go('Content.500', $stateParams);
            };

            var onPaginasError = function (data) {
                $state.go('Content.500', $stateParams);
            };

            var onSuggestiesError = function (data) {
                //$state.go('Content.500',$stateParams);
            };

            if ($state.is('Content.500') || $state.is('Content.404')) {
                PaginasFactory.Suggesties(onSuggesties, onSuggestiesError, $stateParams);
            }
            else {
                if ($stateParams.Name) {
                    PaginasFactory.Digest(onDigest, onDigestError, $stateParams);
                }
                else {
                    if (!$stateParams.Module) { $stateParams.Module = 'Paginas'; }
                    if (!$state.current.name === 'Content') {
                        PaginasFactory.Items(onPaginas, onPaginasError, $stateParams);
                    }
                }
            }
        }
        catch (err) { $scope.Pagina.Body = err.message; }

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