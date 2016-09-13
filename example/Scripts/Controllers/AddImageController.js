
//AddImageController - It is responsible to add image to data base.
app.controller('AddImageController', function ($scope, $http) {


    $scope.uploadFile = function () {

        var file = $scope.myFile;
        
        $scope.image = {
            imageUrl: "https://images.google.com/",
            imageName: file.name,
            imageSize: file.size,
            imageModifiedDate: file.lastModifiedDate,
        }
        $scope.add($scope.image);
    };

    /*send data to DB*/
    $scope.add = function (image) {
        $http.post('/api/Images1', image).success(function (data, status) {
            alert("Successfully inserted image!")
        });
    }

});