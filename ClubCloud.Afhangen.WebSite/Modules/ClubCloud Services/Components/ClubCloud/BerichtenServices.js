"use strict";
//$timeout, $http, $q, $resource
define(['angularAMD'], function (app) {
    app.factory('BerichtenFactory', function ($timeout, $http, $q) {

        var Ophalen = {};

        Ophalen.Items = function (onSucces, onError, $stateParams) {
            $q.all([Items($stateParams)]).then(onSucces, onError);
        };

        Ophalen.Item = function (onSucces, onError, $stateParams) {
            $q.all([Item($stateParams), Opmerkingen($stateParams), Suggesties($stateParams)]).then(onSucces, onError);
        };

        Ophalen.Suggesties = function (onSucces, onError, $stateParams) {
            $q.all([Suggesties($stateParams)]).then(onSucces, onError);
        };

        return Ophalen;

        function Items($stateParams) {
            var deferred = $q.defer();

            var curl = new StringBuilder();
            curl.append("web/lists/GetByTitle('" + $stateParams.Module + "')/items?$select=*,PostCategory/Title&$expand=PostCategory");
            //curl.append("web/lists/GetByTitle('"+$stateParams.Module+"')/items?$select=*,Author/Title,Author/Name,PostCategory/Title&$expand=Author,PostCategory");
            if ($stateParams.Filter !== undefined) { curl.append("&$filter=Title eq '" + $stateParams.Filter + "'"); }
            if ($stateParams.Skip !== undefined) { curl.append("&$skip=" + $stateParams.Skip + ""); }
            if ($stateParams.Top !== undefined) { curl.append("&$top=" + $stateParams.Top + ""); }
            if ($stateParams.Orderby !== undefined) { curl.append("&$orderby='" + $stateParams.Orderby + "'"); }
            if ($stateParams.Orderby !== undefined && $stateParams.Sort !== undefined) { curl.append(" " + $stateParams.Sort + ""); }
            var result = curl.toString();

            var properties = ShareCoffee.REST.build.read.for.angularJS({
                //url: "web/lists/GetByTitle('"+$stateParams.Module+"')/items?$select=*,Author/Title,Author/Name,PostCategory/Title&$expand=Author,PostCategory"
                url: curl.toString()
            });
            $http(properties).success(function (data) { deferred.resolve(data.d.results); }).error(function (data) { deferred.reject(data.error); });
            return deferred.promise;
        };

        function Item($stateParams) {
            var deferred = $q.defer();
            var properties = ShareCoffee.REST.build.read.for.angularJS({
                url: "web/lists/GetByTitle('" + $stateParams.Module + "')/items?$select=*,PostCategory/Title&$expand=PostCategory&$filter=Title eq '" + $stateParams.Name + "'"
                //url: "web/lists/GetByTitle('"+$stateParams.Module+"')/items?$select=*,Author/Title,Author/Name,PostCategory/Title&$expand=Author,PostCategory&$filter=Title eq '" + $stateParams.Name + "'"
            });
            $http(properties).success(function (data) { deferred.resolve(data.d.results); }).error(function (data) { deferred.reject(data.error); });
            return deferred.promise;
        };

        function Opmerkingen($stateParams) {
            var deferred = $q.defer();
            var properties = ShareCoffee.REST.build.read.for.angularJS({
                url: "web/lists/GetByTitle('Opmerkingen')/items?$select=*,PostTitle/Title&$expand=PostTitle&$filter=PostTitle/Title eq '" + $stateParams.Name + "'"
                //url: "web/lists/GetByTitle('Opmerkingen')/items?$select=*,Author/Title,Author/Name,PostTitle/Title&$expand=Author,PostTitle&$filter=PostTitle/Title eq '" + $stateParams.Name + "'"
            });
            $http(properties).success(function (data) { deferred.resolve(data.d.results); }).error(function (data) { deferred.reject(data.error); });
            return deferred.promise;
        };

        function Suggesties($stateParams) {
            var deferred = $q.defer();
            var curl = new StringBuilder();
            if ($stateParams.Filter !== undefined) { curl.append($stateParams.Filter + ","); }
            if ($stateParams.Name !== undefined) { curl.append($stateParams.Name + ","); }
            var suggest = new ShareCoffee.SuggestProperties(curl.toString());
            var properties = ShareCoffee.REST.build.read.f.angularJS(suggest);
            $http(properties).success(function (data) { deferred.resolve(data.d.suggest.Queries.results); }).error(function (data) { deferred.reject(data.error); });
            return deferred.promise;
        };

    });
    app.service('BerichtenServices', function ($timeout, $http, $q) {

    });
});