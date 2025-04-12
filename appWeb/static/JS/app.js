let string = `<div class="date"><h2 class="le">${null}</h2><button class="ab">ABRIR</button></div>`;

const elementFirst = document.getElementById("first");
const elementSecond = document.getElementById("second")

var resp;

fetch("/api/dates")
.then(resp => resp.json())
.then(data => {
    show(data)
})

function show(data){
    let iter = 1;
    data.forEach(element => {
        let date = element.current.split(" ");
        let string = date[0] + ", " + element.doctor + ", " + element.speciality;
        let html = `<div class="date"><h2 class="le">${string}</h2><button class="ab" onclick="redirect(${element.dateID});">ABRIR</button></div>`;
        if(iter%2 == 0){
            elementSecond.innerHTML += html;
        }else{
            elementFirst.innerHTML += html;
        }
        iter++;
    });
}

function redirect(id){
    url = `/cita/${id}`;
    location=url;   
}