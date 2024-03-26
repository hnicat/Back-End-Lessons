/*
    document.getElementById("btnCard").addEventListener("click",function(){
      fetch('https://jsonplaceholder.typicode.com/photos/')
    .then(response => response.json())
    .then(jsonArr => {

console.log(jsonArr);
var htmlElements="";
jsonArr.forEach(element => {
    htmlElements+=`<div class="col-md-3">
    <div class="card" style="width: 18rem;">
        <img src="${element.url}" class="card-img-top" alt="...">
        <div class="card-body">
          <h5 class="card-title">${element.title}</h5>
          <a href="#" class="btn btn-primary">Go somewhere</a>
        </div>
      </div>
</div>`
});

console.log(htmlElements);
document.getElementById("cardList").innerHTML=htmlElements;
    })
    })*/


  fetch('https://fakestoreapi.com/products')
    .then(response => response.json())
    .then(jsonArr => {

      var htmldata = "";
      jsonArr.forEach(element => {
        htmldata += `
          <div class="col-md-3">
      <div class="card"  margin-left:1rem;">
          <img src="${element.image}" class="card-img-top" alt="...">
          <div class="card-body">
            <h5 class="card-title">${element.title}</h5>
            <p style="background:red;color:white;text-align: center;">${element.category}</p>
            <p class="card-text">${element.description.substring(0, 50)}...</p>
            <p class="card-text">${element.price}</p>
            <a href="#" class="btn btn-primary">Go somewhere</a>
          </div>
        </div>
  </div>
          `
      });
      console.log(jsonArr);
      document.getElementById("cardList").innerHTML = htmldata;
    })

    fetch('https://fakestoreapi.com/products/categories')
    .then(response=>response.json())
    .then(dataArr=>{
    dataArr.forEach(element => {
      var opt=document.createElement("option");
      opt.setAttribute("value",element);
      opt.innerHTML=element;
      document.getElementById("categoryFilter").appendChild(opt);
    });
 
    })
    var filter=document.getElementById("categoryFilter");
    filter.addEventListener("change",function(){
      document.getElementById("cardList").innerHTML="";
      fetch('https://fakestoreapi.com/products')
      .then(response => response.json())
      .then(jsonArr => {
     var htmldata="";
        jsonArr.forEach(element => {
          if(element.category==this.value){
            htmldata += `
            <div class="col-md-3">
        <div class="card"  margin-left:1rem;">
            <img src="${element.image}" class="card-img-top" alt="...">
            <div class="card-body">
              <h5 class="card-title">${element.title}</h5>
              <p style="background:red;color:white;text-align: center;">${element.category}</p>
              <p class="card-text">${element.description.substring(0, 50)}...</p>
              <p class="card-text">${element.price}</p>
              <a href="#" class="btn btn-primary">Go somewhere</a>
            </div>
          </div>
    </div>
            `
          }
        });
        document.getElementById("cardList").innerHTML = htmldata;
     });
    })

