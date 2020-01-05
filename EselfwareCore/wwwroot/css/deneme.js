function onlyNumber(input) {
    let value = input.value;
    let numbers = value.replace(/[^0-9,]/g, "");
    input.value = numbers;
}

function onlyText(input) {
    var value = input.value;
    var texts = value.replace(/[0-9]/g, "");
    input.value = texts;
}

function validateEmail(email) {
    var re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1, 3}\.[0-9]{1, 3}\.[0-9]{1, 3}\.[0-9]{1, 3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(email);
}
function validatePhone(numberPhone) {
    var re = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4, 6}$/;
    return re.test(numberPhone);
}