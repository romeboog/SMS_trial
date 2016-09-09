﻿MainApp.factory("SM02Service", function ($http, $q) {
    return {
        getData: function (currentPage, pageSize) {
            var deferred = $q.defer();
            $http.get('/api/SM01', { params: { CurrPage: currentPage, PageSize: pageSize } })
                .success(deferred.resolve)
                .error(deferred.reject);
            return deferred.promise;
        },
        getDetail: function (year, org, dept, soft_id) {
            var deferred = $q.defer();

            $http.get('/api/SM01', { params: { year: year, org: org, dept: dept, soft_id: soft_id } })
                .success(deferred.resolve)
                .error(deferred.reject);
            return deferred.promise;
        },
        getSM02Detail: function (year, org, dept, soft_id) {
            var deferred = $q.defer();

            $http.get('/api/SM02', { params: { year: year, org: org, dept: dept, soft_id: soft_id } })
                .success(deferred.resolve)
                .error(deferred.reject);
            return deferred.promise;
        },
        getBD01_DDL: function () {
            var deferred = $q.defer();

            $http.get('/api/BD01')
                .success(deferred.resolve)
                .error(deferred.reject);
            return deferred.promise;
        },
        getBD02_DDL: function () {
            var deferred = $q.defer();
            $http.get('/api/BD02', { params: { year: year, org: org } })
                .success(deferred.resolve)
                .error(deferred.reject);
            return deferred.promise;
        },
        getBD03_DDL: function () {
            var deferred = $q.defer();
            $http.get('/api/BD03', { params: { year: year, org: org, dept: dept } })
                .success(deferred.resolve)
                .error(deferred.reject);
            return deferred.promise;
        },
        AddData: function (SM02) {
            var deferred = $q.defer();
            $http.post('/api/SM02', SM02)
                .success(deferred.resolve)
                .error(deferred.reject);
            return deferred.promise;
        },
        Update: function (SM02) {
            var deferred = $q.defer();
            $http.put('/api/SM02', SM02)
                .success(deferred.resolve)
                .error(deferred.reject);
            return deferred.promise;
        },
        deleteSM: function (SM01) {
            var deferred = $q.defer();
            $http.delete('/api/SM01?year='+SM01.year+'&org='+SM01.org+'&dept='+SM01.dept+'&soft_id='+SM01.soft_id)
                .success(deferred.resolve)
                .error(deferred.reject);
            return deferred.promise;
        }
    }
    }
);