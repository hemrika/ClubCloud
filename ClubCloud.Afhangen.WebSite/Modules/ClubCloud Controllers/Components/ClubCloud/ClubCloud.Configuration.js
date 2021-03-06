﻿define(['ClubCloud-Common'], function (angularAMD) {
    "use strict";

    var app = angular.module("ClubCloud", ['ngAnimate', 'ngAria', 'ngCookies', 'ngMessages', 'ngResource', 'ngSanitize', 'ngTouch', 'ui.router']);

    app.config(['$urlMatcherFactoryProvider', '$urlRouterProvider', '$stateProvider', '$locationProvider',
	function ($urlMatcherFactory, $urlRouterProvider, $stateProvider, $locationProvider) {
	    $urlMatcherFactory.caseInsensitive(true);
	    //$urlMatcherFactory.strictMode(false);
	    //$locationProvider.html5Mode({ enabled: true, requireBase: false });

	    $stateProvider
	        .state('Content', {
	            url: "/",
	            views: {
	                'Content': angularAMD.route({ templateUrl: 'Views/Default.html', controller: 'PaginasController', controllerUrl: 'ngload!Controllers/PaginasController' }),
	                'Header': angularAMD.route({ templateUrl: 'Views/Header.html', controller: 'HeaderController', controllerUrl: 'ngload!Controllers/HeaderController' }),
	                'Footer': angularAMD.route({ templateUrl: 'Views/Footer.html', controller: 'FooterController', controllerUrl: 'ngload!Controllers/FooterController' })
	            }
	        })

            .state('Content.404', {
                url: "404",
                views: {    
                    'Content@': angularAMD.route({ templateUrl: 'Views/404.html', controller: 'PaginasController', controllerUrl: 'Controllers/PaginasController' }),
                }
            })

            .state('Content.500', {
                url: "500",
                views: {
                    'Content@': angularAMD.route({ templateUrl: 'Views/500.html', controller: 'PaginasController', controllerUrl: 'Controllers/PaginasController' }),
                }
            })

            .state('Content.Listing', {
                url: "{Module:string}",
                views: {
                    'Content@': angularAMD.route({
                        templateUrl: function ($stateParams) { return 'Views/' + $stateParams.Module.charAt(0).toUpperCase() + $stateParams.Module.substring(1) + '-List.html'; },
                        resolve: {
                            loadController: ['$rootScope', '$q', '$stateParams',
                                function ($rootScope, $q, $stateParams) {
                                    var deferred = $q.defer();
                                    var controllerName = $stateParams.Module.charAt(0).toUpperCase() + $stateParams.Module.substring(1) + 'Controller';
                                    if (!KnowModule(controllerName)) {
                                        controllerName = 'PaginasController'
                                        $stateParams.Name = $stateParams.Module;
                                        $stateParams.Module = "Paginas";
                                    }

                                    require(['Controllers/' + controllerName], function () { $rootScope.Controller = controllerName; deferred.resolve(); });
                                    return deferred.promise;
                                }]
                        },
                        controllerProvider: function ($rootScope) { return $rootScope.Controller; }
                    })
                }
            })

            .state('Content.Filter', {
                url: "{Module:string}/filter/{Filter:string}",
                views: {
                    'Content@': angularAMD.route({
                        templateUrl: function ($stateParams) { return 'Views/' + $stateParams.Module.charAt(0).toUpperCase() + $stateParams.Module.substring(1) + '.html'; },
                        resolve: {
                            loadController: ['$rootScope', '$q', '$stateParams',
                                function ($rootScope, $q, $stateParams) {
                                    var deferred = $q.defer();
                                    var controllerName = $stateParams.Module.charAt(0).toUpperCase() + $stateParams.Module.substring(1) + 'Controller';
                                    if (!KnowModule(controllerName)) {
                                        controllerName = 'PaginasController'
                                        $stateParams.Name = $stateParams.Module;
                                        $stateParams.Module = "Paginas";
                                    }

                                    require(['Controllers/' + controllerName], function () { $rootScope.Controller = controllerName; deferred.resolve(); });
                                    return deferred.promise;
                                }]
                        },
                        controllerProvider: function ($rootScope) { return $rootScope.Controller; }
                    })
                }
            })

            .state('Content.Paged', {
                url: "{Module:string}/{Skip:int}/{Top:int}",
                views: {
                    'Content@': angularAMD.route({
                        templateUrl: function ($stateParams) { return 'Views/' + $stateParams.Module.charAt(0).toUpperCase() + $stateParams.Module.substring(1) + '.html'; },
                        resolve: {
                            loadController: ['$rootScope', '$q', '$stateParams',
                                function ($rootScope, $q, $stateParams) {
                                    var deferred = $q.defer();
                                    var controllerName = $stateParams.Module.charAt(0).toUpperCase() + $stateParams.Module.substring(1) + 'Controller';
                                    if (!KnowModule(controllerName)) {
                                        controllerName = 'PaginasController'
                                        $stateParams.Name = $stateParams.Module;
                                        $stateParams.Module = "Paginas";
                                    }

                                    require(['Controllers/' + controllerName], function () { $rootScope.Controller = controllerName; deferred.resolve(); });
                                    return deferred.promise;
                                }]
                        },
                        controllerProvider: function ($rootScope) { return $rootScope.Controller; }
                    })
                }
            })

            .state('Content.Ordered', {
                url: "{Module:string}/{Skip:int}/{Top:int}/{Orderby:string}/{Sort:string}",
                views: {
                    'Content@': angularAMD.route({
                        templateUrl: function ($stateParams) { return 'Views/' + $stateParams.Module.charAt(0).toUpperCase() + $stateParams.Module.substring(1) + '.html'; },
                        resolve: {
                            loadController: ['$rootScope', '$q', '$stateParams',
                                function ($rootScope, $q, $stateParams) {
                                    var deferred = $q.defer();
                                    var controllerName = $stateParams.Module.charAt(0).toUpperCase() + $stateParams.Module.substring(1) + 'Controller';
                                    if (!KnowModule(controllerName)) {
                                        controllerName = 'PaginasController'
                                        $stateParams.Name = $stateParams.Module;
                                        $stateParams.Module = "Paginas";
                                    }

                                    require(['Controllers/' + controllerName], function () { $rootScope.Controller = controllerName; deferred.resolve(); });
                                    return deferred.promise;
                                }]
                        },
                        controllerProvider: function ($rootScope) { return $rootScope.Controller; }
                    })
                }
            })

            .state('Content.Name', {
                url: "{Module:string}/{Name:string}",
                views: {
                    'Content@': angularAMD.route({
                        templateUrl: function ($stateParams) { return 'Views/' + $stateParams.Module.charAt(0).toUpperCase() + $stateParams.Module.substring(1) + '.html'; },
                        resolve: {
                            loadController: ['$rootScope', '$q', '$stateParams',
                                function ($rootScope, $q, $stateParams) {
                                    var deferred = $q.defer();
                                    var controllerName = $stateParams.Module.charAt(0).toUpperCase() + $stateParams.Module.substring(1) + 'Controller';
                                    if (!KnowModule(controllerName)) {
                                        controllerName = 'PaginasController'
                                        $stateParams.Name = $stateParams.Module;
                                        $stateParams.Module = "Paginas";
                                    }

                                    require(['Controllers/' + controllerName], function () { $rootScope.Controller = controllerName; deferred.resolve(); });
                                    return deferred.promise;
                                }]
                        },
                        controllerProvider: function ($rootScope) { return $rootScope.Controller; }
                    })
                }
            })

	    $urlRouterProvider.when('', '/');
	    $urlRouterProvider.otherwise("/");
	    /*
	    $urlRouterProvider.otherwise(function ($injector, $location) {
	        var state = $injector.get('$state');
	        state.go('Content.404');
	        return $location.path();
	    });
        */
	}]);

    app.run(['$rootScope', '$state', '$stateParams', '$window', '$timeout', function ($rootScope, $state, $stateParams, $window, $timeout) {
        $rootScope.site = {};
        $rootScope.Menu = { Header: {}, Footer: {} };

        $rootScope.$state = $state;
        $rootScope.$on("$stateChangeSuccess", function () {
            /*
            $timeout(function () {
                $window.ga('send', 'pageview', $window.location.pathname + $window.location.hash);
            });
            */
        });

        $rootScope.$on('$stateChangeError', function (event) {
            $state.go('Content.404');
        });

        $rootScope.$on('$stateNotFound', function (event) {
            $state.go('Content.404');
        });
    }]);

    // Tell angularAMD to tell angular to bootstrap our app
    angularAMD.bootstrap(app);
    // return app for requireJS registration
    return app;

    var modules = ['HeaderController', 'FooterController', 'PaginasController', 'BerichtenController'];

    function KnowModule(module) {
        return (modules.indexOf(module) > -1);
    }
});

// Initializes a new instance of the StringBuilder class
// and appends the given value if supplied
function StringBuilder(value) {
    this.strings = new Array("");
    this.append(value);
}

// Appends the given value to the end of this instance.
StringBuilder.prototype.append = function (value) {
    if (value) {
        this.strings.push(value);
    }
}

// Clears the string buffer
StringBuilder.prototype.clear = function () {
    this.strings.length = 1;
}

// Converts this instance to a String.
StringBuilder.prototype.toString = function () {
    return this.strings.join("");
}