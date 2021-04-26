// JavaScript Document
    /**爱心 */
    var heart = $("<div></div>");
    heart.addClass("heart");
    // heart.css("display", "none");
    /**左心房 */
    var heart_left = $("<div></div>");
    heart_left.addClass("heart_left");
    /**右心室 */
    var heart_right = $("<div></div>");
    heart_right.addClass("heart_right");
    /**文字 */
    var heart_text = $("<div></div>");
    heart_text.addClass("heart_text");
    heart_text.text("I ❤ YOU");
    heart_text.css("font-size", "1.5rem");
    /**添加内层dom */
    heart.append(heart_left);
    heart.append(heart_right);
    heart.append(heart_text);
    /**添加body层dom */
    $("body").append(heart);
