var flaguser = true;
function showuser() {
    if (flaguser) $("header .User .user").css({ "display": "inline-block" });
    else $("header .User .user").css({ "display": "none" });
    flaguser = !flaguser;
}