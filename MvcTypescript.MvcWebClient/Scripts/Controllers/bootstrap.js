define('bootstrap', [
    'jquery'
], (function ($) {

    function bootstrap() { }

    bootstrap.prototype.init = function () {
        alert("init");
    };

    return bootstrap;

}));