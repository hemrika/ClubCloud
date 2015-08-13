require.config({

    baseUrl: "",

    paths: {
        /*"Controllers": "Controllers",
        "Directives": "Directives",
        */
        'angularAMD': 'Components/Script/angularAMD',
        'ngload': 'Components/Script/ngload',
        'clubcloud-Configuration': 'clubcloud.Configuration',
        'angular': 'Components/Script/angular',
        /* ng-animate $animateCss $animate */
        'angular-animate': 'Components/Script/angular-animate',
        /* ngAria $ariaProvider */
        'angular-aria': 'Components/Script/angular-aria',
        /* blockUI blockUI */
        'angular-block-ui': 'Components/Script/angular-block-ui',
        /* ngCookies $cookiesProvider */
        'angular-cookies': 'Components/Script/angular-cookies',
        /*'angular-loader': 'Components/Script/angular-loader', */
        /* ngMessages*/
        'angular-messages': 'Components/Script/angular-messages',
        /* ngResource $resource */
        'angular-resource': 'Components/Script/angular-resource',
        /* ngRoute $routeProvider $route $routeParams */
        /*'angular-route': 'Components/Script/angular-route',*/
        /* ngSanitize $sanitize */
        'angular-sanitize': 'Components/Script/angular-sanitize',
        /* ngTouch $swipe */
        'angular-touch': 'Components/Script/angular-touch',
        /* ui-router $stateProvider $urlRouterProvider */
        'angular-ui-router': 'Components/Script/angular-ui-router',
        /* ct-ui-router-extras */
        'ct-ui-router-extras': 'Components/Script/ct-ui-router-extras',
        'bootstrap': 'Components/Script/bootstrap',
        'jquery': 'Components/Script/jquery',
        'modernizr': 'Components/Script/modernizr',
        'webcomponents': 'Components/Script/webcomponents',
        'ShareCoffee': 'Components/Script/ShareCoffee',
        'MicrosoftAjax': 'Components/Script/MicrosoftAjax',
    },

    // Add angular modules that does not support AMD out of the box, put it in a shim
    shim: {
        'angular': { exports: 'angular' },
        'angular-animate': ['angular'],
        'angular-aria': ['angular'],
        'angular-block-ui': ['angular'],
        'angular-cookies': ['angular'],
        'angular-messages': ['angular'],
        'angular-resource': ['angular'],
        /*'angular-route': ['angular'],*/
        'angular-sanitize': ['angular'],
        'angular-touch': ['angular'],
        'angular-ui-router': ['angular'],
        'ct.ui.router.extras': ['angular'],
        'angularAMD': ['angular']
    },

    // kick start application
    deps: ['clubcloud-Configuration']
});