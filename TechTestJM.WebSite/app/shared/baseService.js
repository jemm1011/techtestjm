(function () {
  'use strict';

  angular.module('techtestjm')
    .service('baseService', baseService);

  /** @ngInject */
  function baseService($http, $q) {

    // First, checks if it isn't implemented yet.
    if (!String.prototype.format) {
      String.prototype.format = function () {
        var args = arguments;
        return this.replace(/{(\d+)}/g, function (match, number) {
          return typeof args[number] != 'undefined' ? args[number] : match;
        });
      };
    };

    this.get = function (url) {
      var deferred = $q.defer();

      var headersValues = {
        headers: {
          'Content-Type': 'application/json',
          'Access-Control-Allow-Origin': '*'
        }
      };

      $http.get(url, headersValues).then(function (data, status, headers, config) {

        deferred.resolve(data);

      }, function (data, status, headers, config) {

        var results = [];
        results.data = data;
        results.headers = headers();
        results.status = status;
        results.config = config;

        deferred.reject(results);
      });

      return deferred.promise;
    };
  }

})();
