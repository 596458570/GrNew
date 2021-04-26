function mp3() {
	$("#nextBir").hide();
	/*音乐*/
	var url = "source/1.mp3";
    var m = new Audio(url);
	m.play(); //播放 mp3
	
	var heart = $("<div></div>");
    heart.addClass("big");
    heart.css("display", "block");
    /*左*/
    var left = $("<div></div>");
    left.addClass("left");
    /*右*/
    var right = $("<div></div>");
    right.addClass("right");
    /*字*/
    var text = $("<div></div>");
   text.addClass("text");
  //$(".text")[0].innerHTML = userName + "<br/>I ❤ YOU";
   //text.text("I ❤ YOU");
   //text.css("font-size", "1.5rem");
    /*添加内层dom */
    heart.append(left);
    heart.append(right);
    heart.append(text);
    /*添加body层dom */
    $("body").append(heart);
	/*文字*/
	var fonts=$("<font>I ♥ YOU</font>");
	/*添加到dom*/
	heart.append(fonts);
	fonts.addClass("fonts");
}