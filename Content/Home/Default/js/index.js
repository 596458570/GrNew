var userName;
$(function () {
    // 初始化界面
    var userInfo = $("<div id='userInfo'></div>");
	
    var userName = $("<div id='userName'><label for='txtName'>亲爱的：</label><input type='text' placeholder='请输入姓名' id='txtName'></div>");
	
    var userBir = $("<div id='userBir'>"+
                    "<label for=''>纪念日期：</label>"+
                    " <select id='year' onChange='chg()'></select>年"+
                    "<select id='mon' onChange='chg()'></select>月"+
                    " <select id='day'></select>日"+
                    " </div>");
	
    var btn = $("<input id='userBtn' type='button' value='提交信息'>");
    userInfo.append(userName);
    userInfo.append(userBir);
    userInfo.append(btn);
    userInfo.appendTo($("body"));
    initBir();
});
//初始化生日下拉框
function initBir(){
    var date = new Date();
    // 初始化年份
    for(var i=date.getFullYear();i>1990;i--){
        var option=$("<option value='"+i+"'>"+i+"</option>");
        $('#year').append(option);
    }
    // 初始化月
    for(var i=0;i<12;i++){
        var option=$("<option value='"+i+"'>"+(i+1)+"</option>");
        $('#mon').append(option);
    }
    $("#year").val(2000);
    $("#mon").val(0);
    initDay($("#year").val(),$("#mon").val());
    //按钮单击事件
$("#userBtn").click(function(){
    var name = $("#txtName").val();
    if (name=="") {
        $("#txtName").attr("placeholder","此处不能为空");
        $("#txtName").css("border","1px solid red");
        setTimeout(txtNameInit,1000);
        return;
    }
    if(confirm("是否提交数据？")){
        userName = name;
        var year = $("#year").val();
        var mon = $("#mon").val();
        var day = $("#day").val();
        var birthday=year+"年"+mon+"月"+day+"日";
        $("#userInfo").hide();
        nextBir(name,birthday,mon,day);
    }
});
}
function txtNameInit(){
    $("#txtName").attr("placeholder","请输入姓名");
    $("#txtName").css("border","");
}
//初始化日
function initDay(year,mon){
    $("#day").empty();
    //获取天数
    var days = new Date(year,mon,0).getDate();
    for(var i=1;i<=days;i++){
        var option=$("<option value='"+i+"'>"+i+"</option>");
        $('#day').append(option);
    }
}
//年月改变事件
function chg(){
    initDay($("#year").val(),$("#mon").val());
}