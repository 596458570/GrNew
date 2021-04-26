var flashing = false;

function toggleSomething() {
  if(!flashing){
    $(".overlay").css("background-color", "rgba(255,255,255,.7)");
    clearInterval(timer);
    timer = setInterval(toggleSomething, 100);
    flashing = true;
  }
  else{
    $(".overlay").css("background-color", "rgba(0,0,0,.7)");
    clearInterval(timer);
    timer = setInterval(toggleSomething, 5000);
    flashing = false;
  }
}

var timer = setInterval(toggleSomething, 5000);