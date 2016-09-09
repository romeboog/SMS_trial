MainApp.controller("SM01Ctrl", function ($scope, $location, $route, SM01Service) {
        $scope.isload = true;
        $scope.totalRecords = 0;
        $scope.pageSize = 3;
        $scope.currentPage = 1;
        $scope.pageChanged = function () {
            $scope.isload = true;
            GetData();
        }
        var GetData = function () {
            SM01Service.getData($scope.currentPage, $scope.pageSize)
                .then(function (response) {
                $scope.SM01s = response.Data;
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
        $scope.Update = function (year,org,dept,soft_id) {
            //$location.path('/SM01/Edit?year='+year+'&org='+org+'&dept='+dept+'&soft_id='+soft_id);
            $location.path('/SM01/Edit/'+ year + '/' + org + '/' + dept + '/' + soft_id);
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