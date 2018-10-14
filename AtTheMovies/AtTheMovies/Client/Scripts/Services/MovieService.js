(function (app) {
    var movieService = function ($http, movieApiUrl) {
        var getAll = function () {
            return $http.get(movieApiUrl);
        };
        var getById = function (id) {
            return $http.get(movieApiUrl + id);
        };
        var update = function (movie) {
            return $http.put(movieApiUrl + movie.Id, movie);
        };
        var create = function (movie) {
            return $http.post(movieApiUrl, movie);
        };
        var destroy = function (movie) {
            return $http.delete(movieApiUrl + movie.Id);
        };
        return {
            getAll: getAll,
            getById: getById,
            update: update,
            create: create,
            delete: destroy
        };
    };
    app.factory("movieService", movieService);
}(angular.module("atTheMovies")));