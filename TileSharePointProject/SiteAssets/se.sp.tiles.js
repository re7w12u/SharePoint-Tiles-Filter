

function handleError(response) {

    if (!angular.isObject(response.data) || !response.data.message) {
        return ($q.reject("An unknown error occurred."));
    }
    // Otherwise, use expected error message.
    return ($q.reject(response.data.message));
}

function ListService($http) {

    this.getAllItems = function (listname) {
        if (listname != null) {
            var orderby = "?$orderby=Order".concat(orderByDesc ? "%20desc" : "");
            var url = _spPageContextInfo.webServerRelativeUrl + "/_api/web/lists/GetByTitle('" + listname + "')/items" + orderby;

            var request = $http({
                url: url,
                method: 'Get',
                headers: { "accept": "application/json;odata=verbose" }
            });

            return request.then(function (data) {
                return data.data.d.results;
            }, handleError);
        }
        else {
            var d = $.Deferred(function () { return []; });
            return d.promise();
        }
    };
}

angular.module('FilterModule', ['ngAnimate'])
    .service('ListService', ['$http', ListService])
    .controller('FilterController', ['$scope', 'ListService', function ($scope, ListService) {
        $scope.filter = "";
        $scope.tiles = null;

        $scope.Show = function (tile) {
            if (tile.Title == null) return true;
            return tile.Title.toLowerCase().indexOf($scope.filter.toLowerCase()) > -1;
        };

        this.fetch = function () {
            ListService.getAllItems(filterListName).then(function (data) {
                $scope.tiles = data;
            });
        }

        this.fetch();
    }])
    .directive("tile", function () {
        return {
            restrict: "E",
            transclude: true,
            template: '<div style="width: 160px; height: 160px;" class="ms-tileview-tile-root"> \
                            <div style="width: 150px; height: 150px;" aria-haspopup="true" class="ms-tileview-tile-content"> \
                                <a href="{{url}}" > \
                                    <img ng-show="img" ng-src="{{img}}" onload="(event.srcElement ? event.srcElement : event.target).style.visibility = \'visible\'; SP.ScriptHelpers.resizeImageToSquareLength(this, 150)" height="150" class=" ms-positionRelative">\
                                    <div style="width: 150px; height: 150px; left: 0px;" offy="100" class="ms-tileview-tile-detailsBox"> \
                                        <ul class="ms-noList ms-tileview-tile-detailsListMedium"> \
                                            <li collapsed="ms-tileview-tile-titleMedium ms-tileview-tile-titleMediumCollapsed" expanded="ms-tileview-tile-titleMedium ms-tileview-tile-titleMediumExpanded" class="ms-tileview-tile-titleMedium ms-tileview-tile-titleMediumCollapsed"> \
                                                <div collapsed="ms-tileview-tile-titleTextMediumCollapsed" expanded="ms-tileview-tile-titleTextMediumExpanded" class="ms-tileview-tile-titleTextMediumCollapsed">{{text}}</div>\
                                            </li> \
                                            <li title="{{text}}" class="ms-tileview-tile-descriptionMedium">{{description}}</li> \
                                        </ul> \
                                    </div>\
                                </a>\
                              </div>\
                            </div>',
            controller: ['$attrs', '$scope', function ($attrs, $scope) {
                $scope.text = $scope.$eval($attrs.text);
                $scope.url = $scope.$eval($attrs.url);
                $scope.description = $scope.$eval($attrs.description);

                var img = $scope.$eval($attrs.img);
                if (img == null) $scope.img = defaultImgPath;
                else $scope.img = img;

            }]
        };
    });
