/*
console.log("Hello");
*/
//alert("Ez egy felugró ablak!")

var tomb=[0,1,2];

kattintas()


function kattintas(){
    var veletlen=Math.floor(Math.random() * tomb.length);
    document.getElementById("gyumolcshelye").innerHTML=tomb[veletlen];
    console.log(tomb[veletlen]);

    document.getElementById("kep").src=veletlen+".jfif";
}