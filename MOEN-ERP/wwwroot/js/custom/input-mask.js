Inputmask({
    'alias': 'decimal',
    'groupSeparator': ',',
    'autoGroup': true,
    'digits': 2,
    'digitsOptional': false,
    'placeholder': '0.00',
}).mask(".mask-money");

$(".mask-money").css("text-align", "left");

// Email address
Inputmask({
    mask: "*{1,20}[.*{1,20}][.*{1,20}][.*{1,20}]@*{1,20}[.*{2,6}][.*{1,2}]",
    greedy: false,
    onBeforePaste: function (pastedValue, opts) {
        pastedValue = pastedValue.toLowerCase();
        return pastedValue.replace("mailto:", "");
    },
    definitions: {
        "*": {
            validator: '[0-9A-Za-z!#$%&"*+/=?^_`{|}~\-]',
            cardinality: 1,
            casing: "lower"
        }
    }
}).mask(".mask-email");


//function setSelectionRange(input, selectionStart, selectionEnd) {
//    if (input.setSelectionRange) {
//        input.focus();
//        input.setSelectionRange(selectionStart, selectionEnd);
//    } else if (input.createTextRange) {
//        var range = input.createTextRange();
//        range.collapse(true);
//        console.log(collapse);
//        range.moveEnd('character', selectionEnd);
//        range.moveStart('character', selectionStart);
//        range.select();
//    }
//}

//function setCaretToPos(input, pos) {
//    setSelectionRange(input, pos, pos);
//}


//$(".money").click(function () {
//    var inputLength = $(".money").val().length;
//    setCaretToPos($(".money")[0], inputLength)
//});

//var options = {
//    onKeyPress: function (cep, e, field, options) {
//        if (cep.length <= 6) {

//            var inputVal = parseFloat(cep);
//            jQuery('.money').val(inputVal.toFixed(2));
//        }

//        // setCaretToPos(jQuery('#money')[0], 4);

//        var masks = ['#,##0.00', '0.00'];
//        mask = (cep == 0) ? masks[1] : masks[0];
//        $('.money').mask(mask, options);
//    },
//    reverse: true
//};

//$('.money').mask('#,##0.00', options);