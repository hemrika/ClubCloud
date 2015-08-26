"use strict";

define(['angularAMD'], function (app) {
    app.factory('HeaderFactory', function ($timeout, $http, $q) {

        var Ophalen = {};
        Ophalen.TopNavigation = function (onSucces, onError, $stateParams) { $q.all([TopNavigation($stateParams)]).then(onSucces, onError); };
        Ophalen.QuickLaunch = function (onSucces, onError, $stateParams) { $q.all([QuickLaunch($stateParams)]).then(onSucces, onError); };

        return Ophalen;

        function TopNavigation($stateParams) {
            var deferred = $q.defer();
            var digest = { method: 'GET', url: "_api/web/navigation/TopNavigationbar", headers: { "Accept": "application/json; odata=verbose" } };
            $http(digest).success(function (data) { deferred.resolve(data.d.TopNavigationBar); }).error(function (data) { deferred.reject(data); });
            return deferred.promise;
        };

        function QuickLaunch($stateParams) {
            var deferred = $q.defer();
            var digest = { method: 'GET', url: "_api/web/navigation/quickLaunch", headers: { "Accept": "application/json; odata=verbose" } };
            $http(digest).success(function (data) { deferred.resolve(data.d.quickLaunch); }).error(function (data) { deferred.reject(data); });
            return deferred.promise;
        };

    });

    app.service('HeaderServices', function ($timeout, $http, $q) {

    });
});