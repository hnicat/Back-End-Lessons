
    var Month=document.getElementById("SelectMonth");
    var City=document.getElementById("SelectCity");
    var Year=document.getElementById("SelectYear");


    document.getElementById("btnSearch").addEventListener("click",function(){
        fetch(`https://api.aladhan.com/v1/calendarByCity/${Year.value}/${Month.value}?city=${City.value}&country=Azerbajan&method=2`)
        .then(response => response.json())
        .then(jsonData => {
            var htmlElement="";
         console.log(jsonData);
            jsonData.data.forEach(element => {
                htmlElement += `
                <tr>
                <td>${element.date.gregorian.date}</td>
                <td>${element.date.hijri.date}</td>  
                <td>${element.date.gregorian.weekday.en}</td>
                <td>${element.timings.Imsak}</td>
                <td>${element.timings.Fajr}</td>
                <td>${element.timings.Sunrise}</td>
                <td>${element.timings.Dhuhr}</td>
            </tr>
                `
            });
            document.getElementById("namazBody").innerHTML=htmlElement;
    
        })
    })