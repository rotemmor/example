
app.service('fileUpload', ['$http', function ($http) {
    this.uploadFileToUrl = function (file) {
        var fd = new FormData();
        fd.append('file', file);
        $http.post('api/Images1', fd, {
            transformRequest: angular.identity,
            headers: { 'Content-Type': undefined }
        })

                .success(function () {
                })

                .error(function () {
                });
    }
}]);