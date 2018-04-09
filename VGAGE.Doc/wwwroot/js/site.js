
$(function () {
    var cpath = window.location.pathname;
    var $a;

    $(".navbar-nav .nav-item a").each(function (idx, ele) {
        if (ele.pathname === cpath) {
            $a = $(ele);
        }
    });

    if ($a && $a.hasClass("nav-link"))
        $a.parent().addClass("active");
    else if ($a && $a.hasClass("dropdown-item"))
        $a.parent().parent().addClass("active");
});