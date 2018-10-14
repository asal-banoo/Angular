(function (app) {
    var DetailsController = function ($scope, $routeParams,movieServise) {
        var id = $routeParams.id;
        movieServise.getById($routeParams.id).success(function (movie) {
            $scope.movie = movie;
        });
        $scope.edit = function () {
            $scope.edit.movie = angular.copy($scope.movie);
        };
    };
    DetailsController.$inject = ["$scope", "$routeParams","movieServise"];
    app.controller("DetailsController", DetailsController); 
}(angular.madule("atTheMovies")));