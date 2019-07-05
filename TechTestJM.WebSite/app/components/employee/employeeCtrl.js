(function () {
  'use strict';

  angular.module('techtestjm.components.employee')
      .controller('employeeCtrl', employeeCtrl);

  function employeeCtrl($scope, $state, employeeService) {

    var vm = this

    vm.employeelist = [];
    vm.searchId = ''

    vm.init = function () {
      vm.getEmployees()
    };


    $scope.$watch('vm.searchId', function () {
      vm.getEmployees()
    });

    vm.getEmployees = function () {
      if (vm.searchId) {        
        employeeService.getEmployeeById(vm.searchId).then(function (result) {
          if (result.data)
          {
            vm.employeelist = []
            vm.employeelist.push(result.data);
          }          
        }).finally(function () {
        });
      } else {
        employeeService.getEmployees().then(function (result) {
          vm.employeelist = result.data;
        }).finally(function () {
        });
      }
    };
  }

})();
