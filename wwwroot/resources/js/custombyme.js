$(document).ready(()=>{
$.ajax({
    type: "POST",
    url: "/",
    success: function (response) {
       console.log(response) ;
    }
});
});