/// <reference path="../Services/afhangen.js" />
"use strict";

define(['angularAMD', 'angular-route', 'angular-cookies', 'ui-bootstrap', 'angular-sanitize', 'blockUI'], function (angularAMD) {
    var app = angular.module("mainModule", ['ngRoute', 'ngCookies', 'blockUI', 'ngSanitize', 'ui.bootstrap']);

    app.filter("leadingZeroes", function () {
        return function (data) {
            var pad = "000" + data;
            pad = pad.substr(pad.length - 3);
            return pad;
        }
    });


    app.config(function ($httpProvider) {
        $httpProvider.defaults.headers.common['X-Requested-With'] = 'XMLHttpRequest';
        $httpProvider.defaults.withCredentials = true;
    });

    app.config(function (blockUIConfigProvider) {

        // Change the default overlay message
        blockUIConfigProvider.message("executing...");
        // Change the default delay to 100ms before the blocking is visible
        blockUIConfigProvider.delay(1);
        // Disable automatically blocking of the user interface
        blockUIConfigProvider.autoBlock(false);

    });

    app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        $routeProvider

           .when("/", angularAMD.route({

               templateUrl: function (rp) { return 'Views/Default.html'; },
               controllerUrl: "Controllers/DefaultController"

           }))

            .when("/:section/:tree", angularAMD.route({

                templateUrl: function (rp) { return 'Views/' + rp.section + '/' + rp.tree + '.html'; },

                resolve: {

                    load: ['$q', '$rootScope', '$location', function ($q, $rootScope, $location) {

                        var path = $location.path();
                        var parsePath = path.split("/");
                        var parentPath = parsePath[1];
                        var controllerName = parsePath[2];

                        var loadController = "Controllers/" + parentPath + '/' + controllerName + "Controller";

                        var deferred = $q.defer();
                        require([loadController], function () {
                            $rootScope.$apply(function () {
                                deferred.resolve();
                            });
                        });

                        var loadServices = "Services/" + parentPath + '/' + controllerName + "Services";

                        var deferred = $q.defer();
                        require([loadServices], function () {
                            $rootScope.$apply(function () {
                                deferred.resolve();
                            });
                        });

                        return deferred.promise;
                    }]
                }

            }))

            .when("/:section/:tree/:id", angularAMD.route({

                templateUrl: function (rp) { return 'Views/' + rp.section + '/' + rp.tree + '.html'; },

                resolve: {

                    load: ['$q', '$rootScope', '$location', function ($q, $rootScope, $location) {

                        var path = $location.path();
                        var parsePath = path.split("/");
                        var parentPath = parsePath[1];
                        var controllerName = parsePath[2];

                        var loadController = "Controllers/" + parentPath + '/' + controllerName + "Controller";

                        var deferred = $q.defer();
                        require([loadController], function () {
                            $rootScope.$apply(function () {
                                deferred.resolve();
                            });
                        });

                        var loadServices = "Services/" + parentPath + '/' + controllerName + "Services";

                        require([loadServices], function () {
                            $rootScope.$apply(function () {
                                deferred.resolve();
                            });
                        });

                        return deferred.promise;
                    }]
                }

            }))


            .otherwise({ redirectTo: '/' })

        //$locationProvider.html5Mode(true);
        //$locationProvider.html5Mode({ enabled: true,  requireBase: false});
    }]);
    /*
	app.factory('authHttpResponseInterceptor',['$q','$location',function($q,$location){
    return {
        response: function(response){
            if (response.status === 401) {
                console.log("Response 401");
            }
            return response || $q.when(response);
        },
        responseError: function(rejection) {
            if (rejection.status === 401) {
                console.log("Response Error 401",rejection);
                $location.path('/login').search('returnTo', $location.path());
            }
            return $q.reject(rejection);
        }
    }
	}])
	
	app.config(['$httpProvider',function($httpProvider) {
    //Http Intercpetor to check auth failures for xhr requests
    $httpProvider.interceptors.push('authHttpResponseInterceptor');
	}]);
	*/
    var indexController = function ($scope, $rootScope, $cookieStore, $http, $location, blockUI) {

        $scope.$on('$routeChangeStart', function (scope, next, current) {

            if ($rootScope.IsloggedIn == true) {
                $scope.authenicateUser($location.path(), $scope.authenicateUserComplete, $scope.authenicateUserError);
            }

        });

        $scope.$on('$routeChangeSuccess', function (scope, next, current) {

            setTimeout(function () {
                if ($scope.isCollapsed == true) {
                    set95PercentWidth();
                }
            }, 1000);


        });


        $scope.initializeController = function () {
            $rootScope.displayContent = false;
            if ($location.path() != "") {
                $scope.initializeApplication($scope.initializeApplicationComplete, $scope.initializeApplicationError);
            }
        }

        $scope.initializeApplicationComplete = function (response) {
            if (response.ErrorCode == ClubCloud.Service.LoginErrorCode.NoError) {
                $rootScope.MenuItems = [];
                $rootScope.MenuItems = [{
                    'Route': '#/',
                    'Description': 'Home'
                }, {
                    'Route': '#/Afhangen/Start',
                    'Description': 'Afhangen'
                }, {
                    'Route': '#/Reserveringen/Start',
                    'Description': 'Reserveringen'
                }, {
                    'Route': '#/Bezetting/Baa',
                    'Description': 'Bezetting'
                }];
                $rootScope.displayContent = true;
                $rootScope.IsloggedIn = true;
            }
        }

        $scope.initializeApplicationError = function (response) {
            if (response) {
                if (response._statusCode == '401') {
                    setTimeout(function () {
                        window.location = "#Accounts/Login";
                    }, 10);
                }
            }
        }

        $scope.initializeApplication = function (successFunction, errorFunction) {
            blockUI.start();
            var proxy = nl.clubcloud.Afhangen;
            proxy.IsAuthorized($scope.initializeApplicationComplete, $scope.initializeApplicationError);
            blockUI.stop();
        };

        $scope.authenicateUser = function (route, successFunction, errorFunction) {
            var proxy = nl.clubcloud.Afhangen;
            proxy.IsAuthorized($scope.authenicateUserComplete, $scope.authenicateUserError);
            //$scope.AjaxGetWithData(authenication, "/api/main/AuthenicateUser", successFunction, errorFunction);
        };

        $scope.authenicateUserComplete = function (response) {

            if (response.ErrorCode == ClubCloud.Service.LoginErrorCode.NoError) {
                window.location = "index.html";
            }
            else {
                setTimeout(function () {
                    window.location = "#Accounts/Login";
                }, 10);
            }
        }

        $scope.authenicateUserError = function (response) {
            alert("Error " + response.ErrorCode + " : " + response.Message);
        }

        /*
        $scope.AjaxGet = function (route, successFunction, errorFunction) {         
            setTimeout(function () {
                $http({ method: 'GET', url: route }).success(function (response, status, headers, config) {                 
                    successFunction(response, status);
                }).error(function (response) {                  
                    errorFunction(response);
                });
            }, 1);

        }   

        $scope.AjaxGetWithData = function (data, route, successFunction, errorFunction) {
            setTimeout(function () {
                $http({ method: 'GET', url: route, params: data }).success(function (response, status, headers, config) {
                    successFunction(response, status);
                }).error(function (response) {
                    errorFunction(response);
                });
            }, 1);

        }
        */
    };

    indexController.$inject = ['$scope', '$rootScope', '$cookies', '$http', '$location', 'blockUI'];
    app.controller("indexController", indexController);

    // Bootstrap Angular when DOM is ready
    angularAMD.bootstrap(app);


    return app;
});


