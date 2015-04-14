define(['jquery', 'q'], function ($, Q) {
    'use strict';
    var httpRequester;
    httpRequester = (function () {
        function getJson(url) {
            var deferred = Q.defer();
            $.ajax({
                type: 'GET',
                url: url,
                contentType: 'application/json',
                success: function (data) {
                    deferred.resolve(data);
                },
                error: function (data) {
                    deferred.reject(data);
                }
            });

            return deferred.promise;
        }

        function postJson(url, jsonObj, sessionKey) {
            var deferred = Q.defer();

            $.ajax({
                type: 'POST',
                url: url,
                contentType: 'application/json',
                data: JSON.stringify(jsonObj),
                headers: {
                    'X-SessionKey': sessionKey
                },
                success: function (data) {
                    deferred.resolve(data);
                },
                error: function (data) {
                    deferred.reject(data);
                    httpRequester.getJson(url);
                }
            });

            return deferred.promise;
        }

        function putJson(url, sessionKey) {
            var deferred = Q.defer();

            $.ajax({
                type: 'PUT',
                url: url,
                contentType: 'application/json',
                headers: {
                    'X-SessionKey': sessionKey
                },
                success: function (data) {
                    deferred.resolve(data);
                },
                error: function (data) {
                    deferred.reject(data);
                }
            });

            return deferred.promise;
        }

        return {
            getJson: getJson,
            postJson: postJson,
            putJson: putJson
        };
    })();

    return httpRequester;
});