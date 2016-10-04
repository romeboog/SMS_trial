var MainApp = angular.module('MainApp', ['ngRoute', 'ui.bootstrap']);
MainApp.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    var viewBase = '/App/';
    $routeProvider
        .when('/SM01', {
            controller: 'SM01Ctrl',
            templateUrl: viewBase + 'SM01App/List.html'
        })
        .when('/SM01/Add', {
            controller: 'SM01AddCtrl',
            templateUrl: viewBase + 'SM01App/AddSM01.html'
        })
        .when('/SM01/Edit/:year/:org/:dept/:soft_id', {
            controller: 'SM01EditCtrl',
            templateUrl: viewBase + 'SM01App/EditSM01.html'
        })
        .when('/SM02/Edit/:year/:org/:dept/:soft_id', {
            controller: 'SM02EditCtrl',
            templateUrl: viewBase + 'SM01App/EditSM02.html'
        })
        .when('/SM02/Add/:year/:org/:dept/:soft_id', {
            controller: 'SM02AddCtrl',
            templateUrl: viewBase + 'SM01App/EditSM02.html'
        })
         .when('/BD03/Add', {
             controller: 'BD03AddCtrl',
             templateUrl: viewBase + 'BD03App/BD03UserAdd.html'
         })
        .when('/BD03/Edit/:user_org/:user_dept/:user_id', {
            controller: 'BD03EditCtrl',
            templateUrl: viewBase + 'BD03App/EditUser.html'
        })
       .when('/BD03', {
           controller: 'BD03Ctrl',
           templateUrl: viewBase + 'BD03App/BD03List.html'
       })
   

    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
}]);
var app = angular.module('test', ['angular-popups']);
app.controller('dialogCtrl', function ($scope) {
    $scope.message = 'hello world';
    $scope.title = '提示';
    $scope.okValue = '确定';
    $scope.cancelValue = '取消';
});

angular.module("MainApp1", ["MainApp", "test"]);

//angular.element(document).ready(function() {
//    var myDiv1 = document.getElementById("myDiv1");
//    angular.bootstrap(myDiv1, ["test"]);
//});