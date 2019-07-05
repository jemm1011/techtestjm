(function () {
  'use strict';

  angular.module('techtestjm.components.employee', [])
		.config(routeConfig);

  function routeConfig($stateProvider) {
    $stateProvider
    .state('employee', {
      url: '/employee',
      templateUrl: 'app/components/employee/employee-list.html',
      controller: "employeeCtrl"
    })
  }

})();
