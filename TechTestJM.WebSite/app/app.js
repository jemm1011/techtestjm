'use strict';

angular.module('techtestjm', [
  'ui.router',
  'techtestjm.components',
])
.config(['$urlRouterProvider', function($urlRouterProvider){
  $urlRouterProvider.otherwise('/employee')
}]);