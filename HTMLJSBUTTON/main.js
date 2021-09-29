var btn = document.createElement("button")
btn.style.height = "50px"
btn.style.width = "200px"
btn.addEventListener('click', Redify)
btn.textContent = "Go Red!"
document.body.appendChild(btn)

var btn2 = document.createElement("button")
btn2.style.height = "50px"
btn2.style.width = "200px"
btn2.addEventListener('click', Bluify)
btn2.textContent = "Go Blue!"
document.body.appendChild(btn2)

function Redify() {
	document.body.style.backgroundColor = "red"
}

function Bluify() {
	document.body.style.backgroundColor = "blue"
}