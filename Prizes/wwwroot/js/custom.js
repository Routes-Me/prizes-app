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

function setRTLAlignment() {
    $('.login-area').addClass('ar-direction');
    $('.login-area .title p').addClass('hd-direction');
}

function setLTRAlignment() {
    $('.login-area').removeClass('ar-direction');
    $('.login-area .title p').removeClass('hd-direction');
}