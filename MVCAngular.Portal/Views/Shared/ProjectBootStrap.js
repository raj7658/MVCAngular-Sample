//
//  angular bootup and routing table
//


console.log("Project Bootstrap");

(function () {

    var app = angular.module('MVCAngular', ['ngRoute', 'ui.bootstrap', 'ngSanitize', 'blockUI']);

    app.config(['$controllerProvider', '$provide', function ($controllerProvider, $provide) {
        app.register =
          {
              controller: $controllerProvider.register,
              service: $provide.service
          };
    }]);

})();





