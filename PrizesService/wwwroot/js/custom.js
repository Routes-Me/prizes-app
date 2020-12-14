$(document).ready(function () {
    $("#datepicker").keypress(function () {
        return false;
    });

    $('#datepicker').on("keydown", function (event) {
        if (event.keyCode === 8 || event.which === 8 || event.keyCode == 46 || event.which == 46) {
            event.preventDefault();
        }
    });

    $('#datepicker').bind("cut copy paste", function (e) {
        e.preventDefault();
    });
});