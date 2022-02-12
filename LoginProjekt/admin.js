function Send(name, pass) {
	const xhttp = new XMLHttpRequest()
	xhttp.onload = function(){
		if(xhttp.readyState==4&&xhttp.status==200) {
			//let data = JSON.parse(this.responseText)
			document.body.innerHTML = this.responseText
		}
	}
	xhttp.open("GET","/login.php?name="+name+"&pass="+pass,true)
	xhttp.send()
}