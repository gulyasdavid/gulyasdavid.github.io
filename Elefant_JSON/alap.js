fetch("https://elephant-api.herokuapp.com/elephants")
.then(x => x.json())
.then(y => megjelenit(y))

function megjelenit(tomb){
    console.log(tomb)
    let sz=""
    for (let elem of tomb) {
        sz+='<tr>'
        sz+='<div class="col-sm-2">'
        sz+='<td id="stilus">'
        sz+=elem.name
        sz+='</td>'
        sz+='</div>'
        sz+='<div class="col-sm-2">'
        sz+='<td id="stilus">'
        sz+=elem.affiliation
        sz+='</td>'
        sz+='</div>'
        sz+='<div class="col-sm-2">'
        sz+='<td id="stilus">'
        sz+=elem.species
        sz+='</td>'
        sz+='</div>'
        sz+='<div class="col-sm-2">'
        sz+='<td id="stilus">'
        sz+=elem.dob
        sz+='</td>'
        sz+='</div>'
        sz+='<div class="col-sm-2">'
        sz+='<td id="stilus">'
        sz+=elem.wikilink
        sz+='</td>'
        sz+='</div>'
        sz+='<div class="col-sm-2">'
        sz+='<td id="stilus">'
        sz+='<img src="'+ elem.pic+ '" style="height:300px">'
        sz+='<br>'
        sz+='<button type="button" id="'+elem.pic+'"  onclick="kepmegnyitas(this.id)" class="btn btn-success" data-bs-toggle="modal" data-bs-target="#myModal">Kattints a nagyításhoz</button>'
        sz+='</td>'
        sz+='</div>'
        sz+='</tr>'
    }
    document.getElementById("torzs").innerHTML=sz
}