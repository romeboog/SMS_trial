MainApp.controller("SM01AddCtrl", function ($http,$scope, $location, $route, SM01Service) {
    $scope.isload = true;
    // 依據$routeParams取得的ID，去取得單筆客戶資料
    SM01Service.getBD01_DDL().then(function (response) {
        // 給Customer ViewModel
        $scope.org_List = response;
    }, function () {
        $scope.error = "取得資料錯誤!";
    })
    //SM01Service.getBD02_DDL($scope.year,$scope.org).then(function (response) {
    //    // 給Customer ViewModel
    //    $scope.dept_List = response;
    //}, function () {
    //    $scope.error = "取得資料錯誤!";
    //})
    //SM01Service.getBD03_DDL($scope.year, $scope.org,$scope.dept).then(function (response) {
    //    // 給Customer ViewModel
    //    $scope.user_List = response;
    //}, function () {
    //    $scope.error = "取得資料錯誤!";
    //})
    $scope.orgChange = function (selectedYear,selectedOrgID) {
        $http.get('/api/BD02', { params: { year: selectedYear, org: selectedOrgID } }).success(function (data) {
            $scope.dept_List = data;
        }).error(function () {
            $scope.error = "發生錯誤";
        })};
    $scope.deptChange = function (selectedYear, selectedOrgID, selectedDeptID) {
        $http.get('/api/BD03', { params: { year: selectedYear, org: selectedOrgID, dept_id: selectedDeptID } }).success(function (data) {
            $scope.user_List = data;
        }).error(function () {
            $scope.error = "發生錯誤";
        })
    };
    //$scope.org_List = SM01Service.getBD01_DDL();
    //$scope.dept_List = SM01Service.getBD02_DDL();
    //$scope.user_List = SM01Service.getBD03_DDL();
    $scope.year = '';
    $scope.org = '';
    $scope.dept = '';
    $scope.soft_id = '';
    $scope.soft_name = '';
    $scope.user_id = '';
    $scope.soft_type = '';
    $scope.soft_sn = '';
    $scope.soft_for = '';
    $scope.soft_work_on = '';
    $scope.soft_max_user = '';
    $scope.soft_number = '';
    $scope.soft_platform = '';
    $scope.soft_from = '';
    $scope.soft_from_unit = '';
    $scope.soft_keeper = '';
    $scope.soft_doc = '';
    $scope.install_date = '';
    $scope.install_place = '';
    $scope.memo = '';

    $scope.Add = function () {
        var SM = {
            year: $scope.year,
            org: $scope.org,
            dept: $scope.dept,
            soft_id: $scope.soft_id,
            soft_name: $scope.soft_name,
            user_id: $scope.user_id,
            soft_type: $scope.soft_type,
            soft_sn: $scope.soft_sn,
            soft_for: $scope.soft_for,
            soft_work_on: $scope.soft_work_on,
            soft_max_user: $scope.soft_max_user,
            soft_number: $scope.soft_number,
            soft_platform: $scope.soft_platform,
            soft_from: $scope.soft_from,
            soft_from_unit: $scope.soft_from_unit,
            soft_keeper: $scope.soft_keeper,
            soft_doc: $scope.soft_doc,
            install_date: $scope.install_date,
            install_place: $scope.install_place,
            memo: $scope.memo,
            detail_id: 1,
            keep_org: $scope.keep_org,
            keep_man: $scope.keep_man,
            use_org: $scope.use_org,
            use_man: $scope.use_man,
            soft_ver: $scope.use_man,
            soft_cost: $scope.soft_cost,
            auth_number: $scope.auth_number,
            update_date: $scope.update_date,
            decrease_reason: -1,
            decrease_handle: -1,
            detail_memo: $scope.detail_memo
        }
        SM01Service.AddData(SM).then(function (response) {
            alert('新增成功');
            $scope.isload = false;
        }, function () {
            $scope.error = "新增失敗";
            $scope.isload = false;
        })
    }
});