function time(){
    var date = new Date;
    var hour = date.getHours();
    var min = date.getMinutes();
    var sec = date.getSeconds();
    if(sec < 10){
        if(min < 10){
            document.getElementById("clock").value = hour + ":" + "0" + min + ":" + "0" + sec;
        }
        else{
        document.getElementById("clock").value = hour + ":" + min + ":" + "0" + sec;
        }
        return;
    }
    if(min<10){
        if(sec<10){
            document.getElementById("clock").value = hour + ":" + "0" + min + ":" + "0" + sec;
        }
        else{
            document.getElementById("clock").value = hour + ":" + "0" + min + ":" + sec;
        }
        return;
    }
    else{
        document.getElementById("clock").value = hour + ":" + min + ":" + sec;
    }

}
setInterval(time, 1000)