MainApp.controller("BD03Ctrl", function ($scope, $location, $route, BD03Service) {

    $scope.user_dept = '';
    $scope.user_id = '';
    $scope.user_name = '';
    var delptP_year = "105";
    var delptP_org = $scope.user_org;

    //取得機關資料
    BD03Service.getorg_base($scope).then(function (response) {

        $scope.user_orgs = response;
    }, function () {
        $scope.error = "取得機關資料錯誤";
    });

    //機關變動時，部門一併變動
    $scope.change = function (org) {
      
        if (org !== undefined && org !== null) {
            //org有值
            BD03Service.getdept_base(delptP_year, org).then(function (response) {
                $scope.user_depts = response;
            }, function () {
                $scope.error = "取得部門資料錯誤";
            })        
        } else {
            //org無值
            org = "all";
            BD03Service.getdept_base(delptP_year, org).then(function (response) {
                $scope.user_depts = response;
            }, function () {
                $scope.error = "取得部門資料錯誤";
            })
        }
        
        
    };


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

        if (confirm('你確定要刪除？') === false)
        { return false }
        else
        {
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
        }

  
});