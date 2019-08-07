$(document).ready(()=> {

(()=>{
  $.ajax({
    type: "Get",
    url: "/Ajax/GetMainMenu",
    success: function (response) {
      //console.log(response);
      $(".center").html(response);
    }
  });
})();


  (()=>{
    var child= $(".categoryMenu");
    $(child[0]).css({"display":"block"});
    for(var i=1;i<child.length;i++){
      var cId=$(child[i]).attr("data-catId");
          $(child[i]).css({"display":"none"});
    }
  })();

});