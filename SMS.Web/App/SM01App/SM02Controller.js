MainApp.controller("SM02Ctrl", function ($scope, $location, $route, SM01Service) {
        $scope.isload = true;
        $scope.totalRecords = 0;
        $scope.pageSize = 3;
        $scope.currentPage = 1;
        $scope.pageChanged = function () {
            $scope.isload = true;
            GetData();
        }

    // 點選刪除時，給Service ID 並呼叫Web API
        $scope.Delete = function (SM01) {
            SM01Service.deleteSM(SM01).then(function () {
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