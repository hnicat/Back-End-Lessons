var ad = document.getElementById("ad");
var soyad = document.getElementById("soyad");
var ataAd = document.getElementById("ataAd");
var olke = document.getElementById("olke");
var seher = document.getElementById("seher");
var unvan = document.getElementById("unvan");
var telefon = document.getElementById("telefon");
var eMail = document.getElementById("eMail");
var yas = document.getElementById("yas");
var sosialDurum = document.getElementById("sosialDurum");
var cinsiniz = document.querySelectorAll(".cinsiniz");
var MuracietNov = document.querySelectorAll(".MuracietNov");
var EsasMovzu = document.getElementById("EsasMovzu");
var Muraciet = document.getElementById("Muraciet");

var TesdiqEt = document.getElementById("TesdiqEt");

function IsnullOrEmpty(element) {
    if (element.value.trim() == "") {
        element.nextElementSibling.style.display = "block";

    }
    else {
        element.nextElementSibling.style.display = "none";
    }
};

TesdiqEt.addEventListener("click", function () {

    IsnullOrEmpty(ad);

    IsnullOrEmpty(soyad);

    IsnullOrEmpty(ataAd);

    IsnullOrEmpty(olke);

    IsnullOrEmpty(seher);

    IsnullOrEmpty(unvan);

    IsnullOrEmpty(telefon);

    IsnullOrEmpty(eMail);

    IsnullOrEmpty(yas);

    checked2(cinsiniz);

    checked(MuracietNov);

    IsnullOrEmpty(sosialDurum);

    IsnullOrEmpty(EsasMovzu);

    IsnullOrEmpty(Muraciet);

});

function checked(element) {
    var Checked = false;

    element.forEach(x => {
        if (x.checked) {
            Checked = true;
        }
    });
    if (Checked == false) {
        document.getElementById("checkedError").style.display = "block";
    }
    else {
        document.getElementById("checkedError").style.display = "none";
    }

}
function checked2(element) {
    var Checked = false;

    element.forEach(x => {
        if (x.checked) {
            Checked = true;
        }
    });
    if (Checked == false) {
        document.getElementById("checkedError2").style.display = "block";
    }
    else {
        document.getElementById("checkedError2").style.display = "none";
    }

}

Muraciet.addEventListener("keyup",function(){
    var MuracietLen=Muraciet.value.length;
    var sum=500-MuracietLen;
    document.getElementById("txtCount").innerHTML=sum;
})

