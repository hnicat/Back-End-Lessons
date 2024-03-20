var buttons = document.querySelectorAll(".btn-danger");

var count = 0;

buttons.forEach(button => {
    button.addEventListener("click", function () {
        count++; 
        if (count<3) {
            var text = button.previousElementSibling
            text.style.display = "block"
            var img = button.parentElement.firstElementChild
            img.style.filter = "blur(0px)";
        }
        else {
            alert("Sizin Sansiniz Bitdi")
        }
    })
});
document.querySelector(".btn-success").addEventListener("click",function(){
    count=0;
    buttons.forEach(elememt =>{
        var text = elememt.previousElementSibling
        text.style.display = "none"
        var img = elememt.parentElement.firstElementChild
        img.style.filter = "blur(50px)";
    })
})