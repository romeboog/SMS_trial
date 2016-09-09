﻿MainApp.controller("BD03EditCtrl", function ($scope, $location, $routeParams, $route, BD03Service) {
    var year = $routeParams.year;
    var org = $routeParams.org;
    var dept = $routeParams.dept;
    var soft_id = $routeParams.soft_id;
    $scope.IsLoad = true;

    // 依據$routeParams取得的ID，去取得單筆客戶資料
    BD03Service.getDetail(year,org,dept,soft_id).then(function (response) {
        // 給Customer ViewModel
        $scope.SM01 = response;
        $scope.IsLoad = false; //讀取完畢,隱藏loading圖示
    }, function () {
        $scope.error = "取得資料錯誤!";
        $scope.IsLoad = false; //讀取完畢,隱藏loading圖示
    })
  
    // 更新
    $scope.Update = function () {
        SM01Service.Update($scope.SM01).then(function (response) {
            alert('更新成功!');
            $scope.IsLoad = false; //讀取完畢,隱藏loading圖示
        }, function (response) {
            alert('更新失敗!');
            $scope.IsLoad = false; //讀取完畢,隱藏loading圖示
        })
    }

});