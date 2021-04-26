function nextBir(userName,bir,mon,day){
    var nextBir = $("<div id='nextBir'></div>");
    var name_p=$("<p>姓名："+userName+"</p>");
    var bir_p=$("<p>出生日期："+bir+"</p>");
    var next_p=$("<p>距离生日还剩：</p>");
    var birP=$("<p id='birP'></p>");
    var btn=$("<input id='btn' type='button' value='预览' onClick='mp3()'>");
    nextBir.append(name_p);
    nextBir.append(bir_p);
    nextBir.append(next_p);
    nextBir.append(birP);
    nextBir.append(btn);
    nextBir.appendTo($("body"));
    var now = new Date();
    var next = new Date(now.getFullYear()+1,mon,day);
    var timer=setInterval(function(){
        now = new Date();
        //时间差
        var time = next.getTime()-now.getTime();
        var days = parseInt(time/1000/60/60/24);
        var hours=parseInt(time/1000/60/60%24);
        var min = parseInt(time/1000/60%60);
        var sco=parseInt(time/1000%60);
        $("#birP").text(days+"天"+hours+"时"+min+"分"+sco+"秒");
        if(time==0){
            clearInterval(timer);
            mp3();
        }
    },500);
}