function setTimeS(id) {
    idtc = id;
    typeT = 1;
    creteTime();
}

function setDateS(id) {
    iddc = id;
    typeD = 2;
    creteDate();
}

function creteTime() {
    var today = new Date();
    var offset = today.getTimezoneOffset();

    var hour = today.getHours() ;
    var minute = today.getMinutes();
    var sec = today.getSeconds();
    var time = "Time: " + checkDD(hour) + ":" + checkDD(minute) + ":" + checkDD(sec);
    
    var locDate = today.toString("dddd , dd-MMMM-yyyy");
    var doceL = document.getElementById(idtc);
    if (parseInt(typeT) == 1)
        {doceL.innerHTML = time;}
    else { doceL.innerHTML = locDate; }

    setTimeout(creteTime, 100);
}
function creteDate() {
    var today = new Date();
    var offset = today.getTimezoneOffset()/24;
    today.setHours(today.getHours()+ offset);

    var hour = today.getHours();
    var minute = today.getMinutes();
    var sec = today.getSeconds();
    var time = "Time: " + checkDD(hour) + ":" + checkDD(minute) + ":" + checkDD(sec) ;
    var locDate = today.toDateString();
    var doceL = document.getElementById(iddc);
    if (parseInt(typeD) == 1)
        {doceL.innerHTML = time;}
    else { doceL.innerHTML = locDate; }

    setTimeout(creteDate, 10000);
}

function checkDD(number) {
    if (parseInt(number) < 10)
       { return "0" + number.toString();}
    else {return number.toString();}
}