id = getURLRoute()

fetch("/api/date?dateId=" + id)
.then(resp => resp.json())
.then(data => {
    console.log(data)
    show(data)
})

function getURLRoute(){
    url = location.href;
    index = url.split("/")
    i = index.length - 1;
    return index[i];
}

function show(data){
    username = document.getElementById("name");
    date = document.getElementById("date");
    doctor = document.getElementById("doc");

    username.value = data.name;
    date.value = data.current;
    doctor.value = data.doctorName + ", " + data.speciality;
}