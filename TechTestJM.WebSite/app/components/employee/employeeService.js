'use strict';

angular.module('techtestjm.components.employee')
.service('employeeService', ['config', 'baseService', function (config, baseService) {

  var getEmployeesUrl = config.apiUrl + "employee";

  return {
    getEmployees: function () {
      return baseService.get(getEmployeesUrl);
    },
    getEmployeeById: function (id) {
      return baseService.get(getEmployeesUrl + '/' + id);
    },
  }
}]);