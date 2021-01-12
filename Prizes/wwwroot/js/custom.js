$(document).on('keyup', '.cname,.cemail,.cnumber,.cbdate', function (event) {
    var name = $('.cname').val();
    var email = $('.cemail').val();
    var number = $('.cnumber').val();
    var bdate = $('.cbdate').val();


    if (name != '' && email != '' && number != '') {
        $('.candidate-submit').removeClass('disabled');
    }
    else {
        $('.candidate-submit').addClass('disabled');
    }
});