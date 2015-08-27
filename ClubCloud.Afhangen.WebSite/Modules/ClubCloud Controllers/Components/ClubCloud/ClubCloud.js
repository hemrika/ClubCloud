require.config({
    baseUrl: "",

    paths: {
        'angularAMD': 'Components/Script/angularAMD',
        'ngload': 'Components/Script/ngload',
        'angular': 'Components/Script/angular',
        /* ng-animate $animateCss $animate */
        'angular-animate': 'Components/Script/angular-animate',
        /* ngAria $ariaProvider */
        'angular-aria': 'Components/Script/angular-aria',
        /* blockUI blockUI */
        /*'angular-block-ui': 'Components/Script/angular-block-ui',*/
        /* ngCookies $cookiesProvider */
        'angular-cookies': 'Components/Script/angular-cookies',
        /* */
        'angular-loader': 'Components/Script/angular-loader',
        /* formly */
        'angular-formly': 'Components/Script/formly',
        /* ngMessages*/
        'angular-messages': 'Components/Script/angular-messages',
        /* ngResource $resource */
        'angular-resource': 'Components/Script/angular-resource',
        /* ngSanitize $sanitize */
        'angular-sanitize': 'Components/Script/angular-sanitize',
        /* ngTouch $swipe */
        'angular-touch': 'Components/Script/angular-touch',
        /* ui-router $stateProvider $urlRouterProvider */
        'angular-ui-router': 'Components/Script/angular-ui-router',
        'api-check': 'Components/Script/api-check',
        'bootstrap': 'Components/Script/bootstrap',
        'jquery': 'Components/Script/jquery',
        'modernizr': 'Components/Script/modernizr',
        'webcomponents': 'Components/Script/webcomponents-lite',
        'ClubCloud-Common': 'Controllers/ClubCloud.Common',
        'ClubCloud-Configuration': 'Controllers/ClubCloud.Configuration'
        /*
        'ShareCoffee': 'Components/Script/ShareCoffee',
        'ShareCoffee-Search': 'Components/Script/ShareCoffee.Search',
        'MicrosoftAjax': 'Components/Script/MicrosoftAjax',
        'SharePoint': '_layouts/15/sp',
        'SharePointRuntTime': '_layouts/15/sp.runtime'
        */
    },

    // Add angular modules that does not support AMD out of the box, put it in a shim
    shim: {
        'angular': { exports: 'angular' },
        'ngload': ['angularAMD'],
        'angularAMD': ['angular'],
        'angular-animate': ['angular'],
        'angular-aria': ['angular'],        
        'angular-cookies': ['angular'],
        'angular-loader': ['angular'],
        'angular-formly': ['angular'],
        'angular-messages': ['angular'],
        'angular-resource': ['angular'],
        'angular-sanitize': ['angular'],
        'angular-touch': ['angular'],
        'angular-ui-router': ['angular']
    },

    // kick start application
    deps: ['ClubCloud-Configuration']
});
