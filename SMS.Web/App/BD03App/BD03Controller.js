MainApp.controller("BD03Ctrl", function ($scope, $location, $route, BD03Service) {

    //分頁參數
    $scope.isload = true;
    $scope.totalRecords = 0;
    $scope.pageSize = 10; //每頁筆數
    $scope.currentPage = 1; //初始頁

    //換頁時觸發
    $scope.pageChanged = function () {
        $scope.isload = true;
        GetData();
    }
    var GetData = function () {
        BD03Service.getData($scope.currentPage, $scope.pageSize)
            .then(function (response) {
                $scope.BD03s = response.Data;
                $scope.totalRecords = response.Total;
                $scope.isload = false;
            },
            function () {
                $scope.error = "Error on getting data";
                $scope.isload = false;
            });
    };
    GetData();

    // 點選編輯時，移至編輯頁面
    $scope.Update = function (user_org,user_dept,uset_id) {
        $location.path('/BD03/Edit/' + user_org + '/' + user_dept + '/' + uset_id);
    }

    // 點選刪除時，給Service ID 並呼叫Web API
    $scope.Delete = function (BD03) {
        BD03Service.deletetUser(BD03).then(function () {
            alert('刪除成功!');
            $scope.currentPage = 1
            GetData();
            $scope.IsLoad = false; //讀取完畢,隱藏loading圖示
        }, function () {
            alert('刪除失敗!');
            $scope.IsLoad = false; //讀取完畢,隱藏loading圖示
        })
    }
});