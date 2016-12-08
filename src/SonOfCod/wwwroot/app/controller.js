(function () {
    'use strict';

    angular
        .module('app')
        .controller('controller', controller);

    controller.$inject = [];

    function controller() {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'controller';

        activate();

        function activate() { }
    }
})();