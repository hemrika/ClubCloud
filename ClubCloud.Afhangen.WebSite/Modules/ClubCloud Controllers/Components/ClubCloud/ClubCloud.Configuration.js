﻿"use strict";

define(['angularAMD', 'angular-animate', 'angular-aria' /*, 'angular-block-ui'*/, 'angular-cookies', 'angular-formly', 'angular-messages', 'angular-resource',/* 'angular-route',*/ 'angular-sanitize', 'angular-touch', 'angular-ui-router', 'ct-ui-router-extras', 'jquery', 'modernizr', 'MicrosoftAjax', 'ShareCoffee'], function (angularAMD) {
    var app = angular.module("ClubCloud", ['ngAnimate', 'ngAria' /*, 'blockUI'*/, 'ngCookies', 'formly', 'ngMessages', 'ngResource', /*'ngRoute',*/ 'ngSanitize', 'ngTouch', 'ui.router', 'ct.ui.router.extras']);

    app.config(['$futureStateProvider', '$controllerProvider', '$urlRouterProvider', '$stateProvider', '$locationProvider',
	function ($futureStateProvider, $controllerProvider, $urlRouterProvider, $stateProvider, $locationProvider) {

	    //$locationProvider.html5Mode({ enabled: true, requireBase: false });

	    $urlRouterProvider.otherwise("/Home");

	    $stateProvider
            .state('Content', {
                url: "/",
                views: {
                    'Content': { template: '<div ui-view=""></div>', },
                    'Header': angularAMD.route({ templateUrl: 'Views/Header.html', controller: 'HeaderController' }),
                    'Footer': angularAMD.route({ templateUrl: 'Views/Footer.html', controller: 'FooterController' })
                }
            })

            .state('Content.Home', {
                url: "/Home",
                views: angularAMD.route({ templateUrl: 'Views/Default.html', controller: 'PaginasController' })
            })

            .state('Content.Contact', {
                url: "/Contact",
                views: angularAMD.route({ templateUrl: 'Views/Contact.html', controller: 'PaginasController' })
            })


	    //// Loading states from .json file during runtime
	    //var loadAndRegisterFutureStates = function ($http) {

	    //    var content = {
	    //        stateName: "Content.Home",
	    //        urlPrefix: "/",
	    //        templateUrl: "Views/Default.html",
	    //        type: "PaginasController"
	    //    }

	    //    $futureStateProvider.futureState(content);

	    //    var contact = {
	    //        stateName: "Content.Contact",
	    //        urlPrefix: "/Contact",
	    //        templateUrl: "Views/Contact.html",
	    //        type: "PaginasController"
	    //    }

	    //    $futureStateProvider.futureState(contact);

	    //    /*
        //    // $http.get().then() returns a promise
        //    return $http.get('futureStates.json').then(function (resp) {
        //        angular.forEach(resp.data, function (fstate) {
        //            // Register each state returned from $http.get() with $futureStateProvider
        //            $futureStateProvider.futureState(fstate);
        //        });
        //    });
        //    */
	    //};


	    $futureStateProvider.stateFactory('ngload', ngloadStateFactory);
	    $futureStateProvider.stateFactory('BerichtenController', BerichtenControllerCtrlStateFactory);
	    $futureStateProvider.stateFactory('CategorieenController', CategorieenCtrlStateFactory);
	    $futureStateProvider.stateFactory('EvenementenController', EvenementenCtrlStateFactory);
	    $futureStateProvider.stateFactory('KalendersController', KalendersCtrlStateFactory);
	    $futureStateProvider.stateFactory('MededelingenController', MededelingenCtrlStateFactory);
	    $futureStateProvider.stateFactory('OpmerkingenController', OpmerkingenCtrlStateFactory);
	    $futureStateProvider.stateFactory('DocumentenController', DocumentenCtrlStateFactory);
	    $futureStateProvider.stateFactory('FotosController', FotosCtrlStateFactory);
	    $futureStateProvider.stateFactory('PaginasController', PaginasCtrlStateFactory);
	    $futureStateProvider.stateFactory('AlbumsController', AlbumsCtrlStateFactory);
	    $futureStateProvider.stateFactory('EnquetesController', EnquetesCtrlStateFactory);
	    $futureStateProvider.stateFactory('FormulierenController', FormulierenCtrlStateFactory);

	    $futureStateProvider.addResolve(loadAndRegisterFutureStates);

	}]);

    app.run(function ($rootScope, $state, $window, $timeout) {
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
    });


    // Tell angularAMD to tell angular to bootstrap our app
    return angularAMD.bootstrap(app);
    // return app for requireJS registration
    //return app;

    /* Berichten */
    function BerichtenControllerCtrlStateFactory($q, futureState) {
        var d = $q.defer();
        require(['Controllers/BerichtenController'], function (BerichtenController) {
            var fullstate = {
                controller: BerichtenController,
                name: futureState.stateName,
                url: futureState.urlPrefix,
                templateUrl: futureState.templateUrl
            };
            d.resolve(fullstate);
        });
        return d.promise;
    }

    /* Categorieen */
    function CategorieenCtrlStateFactory($q, futureState) {
        var d = $q.defer();
        require(['Controllers/CategorieenController'], function (CategorieenController) {
            var fullstate = {
                controller: CategorieenController,
                name: futureState.stateName,
                url: futureState.urlPrefix,
                templateUrl: futureState.templateUrl
            };
            d.resolve(fullstate);
        });
        return d.promise;
    }

    /* Evenementen */
    function EvenementenCtrlStateFactory($q, futureState) {
        var d = $q.defer();
        require(['Controllers/EvenementenController'], function (EvenementenController) {
            var fullstate = {
                controller: EvenementenController,
                name: futureState.stateName,
                url: futureState.urlPrefix,
                templateUrl: futureState.templateUrl
            };
            d.resolve(fullstate);
        });
        return d.promise;
    }

    /* Kalender */

    function KalendersCtrlStateFactory($q, futureState) {
        var d = $q.defer();
        require(['Controllers/KalendersController'], function (KalendersController) {
            var fullstate = {
                controller: KalendersController,
                name: futureState.stateName,
                url: futureState.urlPrefix,
                templateUrl: futureState.templateUrl
            };
            d.resolve(fullstate);
        });
        return d.promise;
    }

    /* Mededelingen */

    function MededelingenCtrlStateFactory($q, futureState) {
        var d = $q.defer();
        require(['Controllers/MededelingenController'], function (MededelingenController) {
            var fullstate = {
                controller: MededelingenController,
                name: futureState.stateName,
                url: futureState.urlPrefix,
                templateUrl: futureState.templateUrl
            };
            d.resolve(fullstate);
        });
        return d.promise;
    }

    /* Opmerkingen */

    function OpmerkingenCtrlStateFactory($q, futureState) {
        var d = $q.defer();
        require(['Controllers/OpmerkingenController'], function (OpmerkingenController) {
            var fullstate = {
                controller: OpmerkingenController,
                name: futureState.stateName,
                url: futureState.urlPrefix,
                templateUrl: futureState.templateUrl
            };
            d.resolve(fullstate);
        });
        return d.promise;
    }

    /* Documenten */

    function DocumentenCtrlStateFactory($q, futureState) {
        var d = $q.defer();
        require(['Controllers/DocumentenController'], function (DocumentenController) {
            var fullstate = {
                controller: DocumentenController,
                name: futureState.stateName,
                url: futureState.urlPrefix,
                templateUrl: futureState.templateUrl
            };
            d.resolve(fullstate);
        });
        return d.promise;
    }

    /* Fotos */

    function FotosCtrlStateFactory($q, futureState) {
        var d = $q.defer();
        require(['Controllers/FotosController'], function (FotosController) {
            var fullstate = {
                controller: FotosController,
                name: futureState.stateName,
                url: futureState.urlPrefix,
                templateUrl: futureState.templateUrl
            };
            d.resolve(fullstate);
        });
        return d.promise;
    }

    /* Paginas */

    function PaginasCtrlStateFactory($q, futureState) {
        var d = $q.defer();
        require(['Controllers/PaginasController'], function (PaginasController) {
            var fullstate = {
                controller: PaginasController,
                name: futureState.stateName,
                url: futureState.urlPrefix,
                templateUrl: futureState.templateUrl
            };
            d.resolve(fullstate);
        });
        return d.promise;
    }

    /* Albums */

    function AlbumsCtrlStateFactory($q, futureState) {
        var d = $q.defer();
        require(['Controllers/AlbumsController'], function (AlbumsController) {
            var fullstate = {
                controller: AlbumsController,
                name: futureState.stateName,
                url: futureState.urlPrefix,
                templateUrl: futureState.templateUrl
            };
            d.resolve(fullstate);
        });
        return d.promise;
    }


    /* Enquetes */

    function EnquetesCtrlStateFactory($q, futureState) {
        var d = $q.defer();
        require(['Controllers/EnquetesController'], function (EnquetesController) {
            var fullstate = {
                controller: EnquetesController,
                name: futureState.stateName,
                url: futureState.urlPrefix,
                templateUrl: futureState.templateUrl
            };
            d.resolve(fullstate);
        });
        return d.promise;
    }

    /* Formulieren */

    function FormulierenCtrlStateFactory($q, futureState) {
        var d = $q.defer();
        require(['Controllers/FormulierenController'], function (FormulierenController) {
            var fullstate = {
                controller: FormulierenController,
                name: futureState.stateName,
                url: futureState.urlPrefix,
                templateUrl: futureState.templateUrl
            };
            d.resolve(fullstate);
        });
        return d.promise;
    }

    function ngloadStateFactory($q, futureState) {
        var ngloadDeferred = $q.defer();
        require(["ngload!" + futureState.src, 'ngload', 'angularAMD'],
            function ngloadCallback(result, ngload, angularAMD) {
                angularAMD.processQueue();
                ngloadDeferred.resolve(undefined);
            });
        return ngloadDeferred.promise;
    }

});

