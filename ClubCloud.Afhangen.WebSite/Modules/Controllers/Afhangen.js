/// <reference path="Scripts/angular-ui/ui-bootstrap-tpls.js" />
require.config({

    baseUrl: "",

    // alias libraries paths
    paths: {
        'afhangen-configuration': 'Controllers/Afhangen.configuration',
        'angular': 'Scripts/Angular/angular',
        'angular-route': 'Scripts/Angular/angular-route',
        'angular-cookies': 'Scripts/Angular/angular-cookies',
        'angularAMD': 'Scripts/AMD/angularAMD',
        'ui-bootstrap': 'Scripts/Bootstrap/ui-bootstrap-tpls',
        'blockUI': 'Scripts/Angular/angular-block-ui',
        'ngload': 'Scripts/AMD/ngload',
        'angular-sanitize': 'Scripts/Angular/angular-sanitize',
        'mainService': 'Services/mainServices',
        'ajaxService': 'Services/AjaxServices',
        'alertsService': 'Services/AlertsServices',
        'accountsService': 'Services/AccountsServices'
    },

    // Add angular modules that does not support AMD out of the box, put it in a shim
    shim: {
        'angularAMD': ['angular'],
        'angular-route': ['angular'],
        'blockUI': ['angular'],
        'angular-sanitize': ['angular'],
        'angular-cookies': ['angular'],
        'ui-bootstrap': ['angular']

    },

    // kick start application
    deps: ['afhangen-configuration']
});
