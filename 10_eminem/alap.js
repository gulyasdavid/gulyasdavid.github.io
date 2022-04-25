var tomb;
fetch("https://raw.githubusercontent.com/abstractlyZach/write_you_a_love_song/master/data/songs/artists/Eminem.json")
.then(x => x.json())
.then(y => megjelenit(y));

//Lenyilóban jeleníti meg a dalok szövegeit
function megjelenit(adatok){
    console.log(adatok)
    tomb=adatok;
    var sz='';
    for (var elem of adatok){
        sz+='<li><a class="dropdown-item" href="#">'+elem.title+'</a></li>'
    }
    document.getElementById("eminemlenyilo").innerHTML=sz
}

//dobozon kattintásra modálisban hozza ki Eminem dalainak címét és szövegét

function kattintas(sorszam){
    var sz='';
    //sz+=sorszam;
    sz+=tomb.title+" "+tomb.verses
    document.getElementById("modalisfej").innerHTML=sz

    var sz2='';
    for (var elem of tomb.title){
        sz2+='<p>'
        sz2+=elem.verses
        sz2+='</p>'

        if (typeof elem.title==='undefined' || elem.verses==='undefined')
        {
        }
        else{
        sz2+='<p>'
        sz2+=elem.title
        sz2+='</p>'
        }
        sz2+='<p>'
        sz2+=elem.verses
        sz2+='</p>'
        
    }
    document.getElementById("modalistorzs").innerHTML=sz2;
}