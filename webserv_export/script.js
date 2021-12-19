var xhttp = new XMLHttpRequest();
var htmlContent = document.getElementById('content')

function Search(val) {
	if(val==undefined) {
		val = new URLSearchParams(window.location.search).get('title')
		if(val===null) val = ''
	}
	xhttp.onreadystatechange = function() {
		if (this.readyState == 4 && this.status == 200) {
			//Bearbetar 'response' från sql anropet
			var res = xhttp.responseText;
			if(res.length>0) {
				res = res.replace(/\r?\n/g, "")
				res = JSON.parse(res)
				Refresh(res)
			} else {
				htmlContent.innerHTML = 'No result'
			}
		}
	};
	xhttp.open("GET", "/sql.php?title=" + val, true);
	xhttp.send();
}

//Denna funktion visar upp JSON objekt i bilder och länkar
function Refresh(o) {
	if(!htmlContent) htmlContent = document.getElementById('content')
	console.log(o)
	htmlContent.innerHTML = ''
	for(const i in o) {
		htmlContent.innerHTML += `<span><a href="${o[i].url}" title="${o[i].title}"><img src="${o[i].image}"><p>${o[i].title}</p></a></span>`
	}
}

	
