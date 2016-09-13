/**
 * This is the ListController which is responsible for getting all the images from the data base.
 */
    app.controller('ListController', function ($scope, $http) {


        $scope.images;

        //get images from db 
    var init = function () {
        $http.get('/api/Images1').success(function (data) {
            console.log(data)
            $scope.images = data;
        });
    };

      

    init();
   

});