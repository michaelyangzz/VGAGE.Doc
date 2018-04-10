$(function () {
    var cpath = window.location.pathname;
    var ta = (".navbar-nav .nav-item a[href='" + cpath + "']");
    var $a = $(ta);
    if ($a.length) {
        if ($a.hasClass("nav-link"))
            $a.parent().addClass("active");
        else if ($a.hasClass("dropdown-item"))
            $a.parent().parent().addClass("active");
    }
});