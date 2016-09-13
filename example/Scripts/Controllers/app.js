//angular module -  It is responsible for the home page controllers and templates.

var app = angular.module('app', ['ngRoute']);

       app.config(function ($routeProvider) {
        $routeProvider
        .when('/routeOne', {
            templateUrl: 'routesDemo/one',
            controller: 'AddImageController'
        }).
        when('/routeTwo', {
            templateUrl: 'routesDemo/two',
            controller: 'ListController'

        }).
        otherwise({
            redirectTo: '/routeOne'
        });
});
