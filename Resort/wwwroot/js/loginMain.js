
(function ($) {
    "use strict";

    
    /*==================================================================
    [ Validate ]*/
    var input = $('.validate-input .input100');

    $('.validate-form').on('submit',function(){
        var check = true;

        for(var i=0; i<input.length; i++) {
            if(validate(input[i]) == false){
                showValidate(input[i]);
                check=false;
            }
        }

        return check;
    });


    $('.validate-form .input100').each(function(){
        $(this).focus(function(){
           hideValidate(this);
        });
    });

    function validate (input) {
        if($(input).attr('type') == 'email' || $(input).attr('name') == 'email') {
            if($(input).val().trim().match(/^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{1,5}|[0-9]{1,3})(\]?)$/) == null) {
                return false;
            }
        }
        else {
            if($(input).val().trim() == ''){
                return false;
            }
        }
    }

    function showValidate(input) {
        var thisAlert = $(input).parent();

        $(thisAlert).addClass('alert-validate');
    }

    function hideValidate(input) {
        var thisAlert = $(input).parent();

        $(thisAlert).removeClass('alert-validate');
    }
    
    const ipnElement = document.querySelector('#ipnPassword')
    const btnElement = document.querySelector('#btnPassword')
    var icon1 = document.querySelector('.show-password i');
    btnElement.addEventListener('click', function () {
        const currentType = ipnElement.getAttribute('type')
        if (currentType === 'password') {
            ipnElement.setAttribute('type', 'text');
            icon1.className = "fa fa-eye-slash";
        } else {
            ipnElement.setAttribute('type', 'password');
            icon1.className = "fa fa-eye";
        }
    })

    const ipnElement2 = document.querySelector('#ipnPassword2')
    const btnElement2 = document.querySelector('#btnPassword2')
    var icon2 = document.querySelector('.show-password2 i');
    btnElement2.addEventListener('click', function () {
        const currentType2 = ipnElement2.getAttribute('type')
        if (currentType2 === 'password') {
            ipnElement2.setAttribute('type', 'text');
            icon2.className = "fa fa-eye-slash";
        } else {
            ipnElement2.setAttribute('type', 'password');
            icon2.className = "fa fa-eye";
        }
    })


})(jQuery);