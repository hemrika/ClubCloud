"use strict";

define(['angularAMD'], function (app) {
    app.factory('PaginasFactory', function ($timeout, $http, $q) {
        var Ophalen = {};
        Ophalen.Digest = function (onSucces, onError, $stateParams) { $q.all([FormDigest()]).then(onSucces, onError); };
        Ophalen.Item = function (onSucces, onError, $stateParams) { $q.all([Item($stateParams), Suggesties($stateParams)]).then(onSucces, onError); };
        Ophalen.Items = function (onSucces, onError, $stateParams) { $q.all([Items($stateParams)]).then(onSucces, onError); };
        Ophalen.Suggesties = function (onSucces, onError, $stateParams) { $q.all([Suggesties($stateParams)]).then(onSucces, onError); };
        return Ophalen;

        var FormDigestValue = null;

        function FormDigest() {
            var deferred = $q.defer();
            var digest = { method: 'POST', url: '_api/contextinfo', headers: { 'accept': 'application/json;odata=verbose' } };
            $http(digest).success(function (data) { deferred.resolve(data.d.GetContextWebInformation.FormDigestValue); }).error(function (data) { deferred.reject(data.error); });
            return deferred.promise;
        };

        function Item($stateParams) {
            var deferred = $q.defer();
            var digest = {
                method: 'POST', url: "_api/web/lists/GetByTitle('" + $stateParams.Module + "')/GetItems", headers: { "X-RequestDigest": $stateParams.FormDigestValue, "Accept": "application/json; odata=verbose", "Content-Type": "application/json; odata=verbose" },
                data: JSON.stringify({ query: { __metadata: { type: "SP.CamlQuery" }, ViewXml: "<View><Query><Where><Contains><FieldRef Name='FileLeafRef' /><Value Type='File'>" + $stateParams.Name + "</Value></Contains></Where></Query><ViewFields><FieldRef Name='FileLeafRef' /><FieldRef Name='WikiField' /></ViewFields><QueryOptions /></View>" } })
            };
            $http(digest).success(function (data) { deferred.resolve(data.d.results); }).error(function (data) { deferred.reject(data.error); });
            return deferred.promise;
        };

        function Items($stateParams) {
            var deferred = $q.defer();

            var curl = new StringBuilder();
            curl.append("web/lists/GetByTitle('" + $stateParams.Module + "')/items?$select=*");
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

    app.service('PaginasServices', function ($timeout, $http, $q) {
    });
});
