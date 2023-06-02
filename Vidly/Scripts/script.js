$(document).ready(function () {

    $('.form-floating input').keypress(function (e) {
        $(this).parent().removeClass('input-validation-error');
        $(this).removeClass('input-validation-error');
        $(this).parent().find('span.field-validation-error').remove()
    });

    $('.form-floating input').change(function (e) {
        $(this).parent().removeClass('input-validation-error');
        $(this).removeClass('input-validation-error');
        $(this).parent().find('span.field-validation-error').remove()
    });

    $('.form-floating select').change(function (e) {
        $(this).parent().removeClass('input-validation-error');
        $(this).removeClass('input-validation-error');
        $(this).parent().find('span.field-validation-error').remove()
    });

    $('#logoutButton').click(function () {
        $.ajax({
            url: '/account/logoff',
            type: 'POST',
            data: {
                '__RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val()
            },
            success: function () {
                window.location.href = '/account/login';
            }
        });
    });
});
