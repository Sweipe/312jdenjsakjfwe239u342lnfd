const http = require('http')
const express = require('express')
const app = express()
http.createServer(app)
const port = 8000

var phpexe = __dirname + '\\php\\php.exe'
const php = require('php-node')
const phpnode = require('php-node')({bin:phpexe})

//konfigurering för anrop av .php filer
app.set('views', __dirname)
app.engine('php', phpnode)
app.set('view engine', 'php')

app.listen(port, () => {
	console.log("Server activated.")
})


//HTML
app.use('*', (req,res,next) => {
	next()
})

app.get('/', function(req, res) {
	res.sendFile(__dirname + '/index.html')
})

app.get('/style.css', function(req, res) {
	res.sendFile(__dirname + '/style.css')
})

app.get('/favicon.ico', function(req, res) {
	res.sendFile(__dirname + '/favicon.ico')
})

app.get('/script.js', function(req, res) {
	res.sendFile(__dirname + '/script.js')
})


//PHP
app.get('/echo.php', (req, res) => {
	res.render('echo');
})

app.get('/sql.php', (req, res) => {
	if(req.query.title!=undefined) {
		app.engine('php', php({bin:phpexe,args:[req.query.title]}));
	}
	res.render('sql');
})