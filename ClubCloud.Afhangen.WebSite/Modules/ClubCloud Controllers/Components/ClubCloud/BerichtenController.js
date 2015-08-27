"use strict";

define(['angularAMD', 'Services/BerichtenServices'], function (app, BerichtenFactory) {
    app.controller('BerichtenController', function ($rootScope, $scope, $state, $stateParams, $window, BerichtenFactory) {

        $scope.Bericht = {};
        $scope.Berichten = [];
        $scope.Opmerkingen = [];
        $scope.Suggesties = [];
        $scope.Categorieen = [];

        try {
            var onBericht = function (data) {

                if (data[0].length > 0) {
                    angular.forEach(data[0], function (bericht) {
                        $scope.Berichten.push(bericht);

                        angular.forEach(bericht.PostCategory.results, function (categorie) {
                            $scope.Categorieen.push(categorie);
                        });
                    });

                    angular.forEach(data[1], function (opmerking) {
                        $scope.Opmerkingen.push(opmerking);
                    });

                    $scope.Bericht = $scope.Berichten[0];
                    $rootScope.Pagina.Title = $scope.Bericht.Title;
                }
                else {
                    $state.go('Content.404');
                }

                angular.forEach(data[2], function (suggestie) {
                    $scope.Suggesties.push(suggestie);
                });

                if (!$scope.$$phase) { $scope.$apply(); }
                $rootScope.$emit('MetadataEvent', $scope.Bericht);
                //$scope.$broadcast('MetadataEvent', $scope.Bericht);
            };

            var onBerichten = function (data) {

                if (data[0].length > 0) {
                    angular.forEach(data[0], function (bericht) {
                        $scope.Berichten.push(bericht);

                        angular.forEach(bericht.PostCategory.results, function (categorie) {
                            $scope.Categorieen.push(categorie);
                        });

                    });
                }

                if (!$scope.$$phase) { $scope.$apply(); }
            };

            var onBerichtError = function (data) {
                $scope.Bericht.Body = data.message.value;
            };

            var onBerichtenError = function (data) {
                $scope.Bericht.Body = data.message.value;
            };

            if ($stateParams.Name) {
                BerichtenFactory.Item(onBericht, onBerichtError, $stateParams);
            }
            else {
                BerichtenFactory.Items(onBerichten, onBerichtenError, $stateParams);
            }
        }
        catch (err) { $scope.Bericht.Body = err.message; }


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
