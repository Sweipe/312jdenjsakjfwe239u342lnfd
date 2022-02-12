const express = require('express')
const app = express()
const http = require('http')
const server = http.createServer(app)

const cookieParser = require('cookie-parser')
const session = require('express-session')

const phpnode = require('php-node')
const php = phpnode({bin:'php'})
bin = ''

//Encrypter
const crypto = require('crypto')
const init = Buffer.from('myspecialcodeint','utf-8')
const seckey = Buffer.from('alwocmekdolfiglsmeifoxelfoejvunr', 'utf-8')
const algorithm = 'aes-256-cbc'


//PHP render config
app.set('views', __dirname)
//app.engine('php', phpnode)
app.set('view engine', 'php')

var port = 8000
server.listen(port, ()=>{
	console.log('HTTPServer listening on localhost: ' + port)
})
app.use(cookieParser())
app.use(session({
	secret: 'mycustomsessionid',
	resave: false,
	saveUninitialized: true
}))

app.get('/', function(req, res) {
	res.sendFile(__dirname + '/index.html')
})

app.get('/style.css', function(req,res) {
	res.sendFile(__dirname + '/style.css')
})

app.get('/script.js', function(req, res) {
	res.sendFile(__dirname + '/script.js')
})

app.get('/functions.js', function(req,res) {
	res.sendFile(__dirname + '/functions.js')
})

app.get('/favicon.ico', function(req,res) {
	res.sendFile(__dirname + '/favicon.ico')
})


//PHP
app.get('/echo.php', (req, res) => {
	app.engine('php', php)
	res.render('echo')
})

app.get('/search.php', (req,res) => {
	app.engine('php', phpnode({bin: 'php', args: [req.query.key]}))
	res.render('search')
})

//---Admin.html---//
app.get('/admin', function(req,res) {
	res.cookie('access', 'granted', {maxAge:1000*60*60})
	//console.log(req.session.id)
	//req.session.goldeagle = 'goldeagle'
	res.sendFile(__dirname + '/admin.html')
	//if(req.cookies.access='granted')
})

app.get('/admin.js', (req, res) => {
	//res.cookie('access', 'granted', {encode: String})
	res.sendFile(__dirname + '/admin.js')
})

app.get('/login.php', (req,res) => {
	console.log(req.cookies.access)
	let q = req.query
	//console.log(req.session.goldeagle)
	let pass = Encrypt(q.pass)
	app.engine('php', phpnode({bin: 'php', args: [q.name, pass]}))
	res.render('login')
})

//req.cookies

app.get('/register.php', (req,res) => {
	let q = req.query
	let pass = Encrypt(pass)
	app.engine('php', phpnode({bin: 'php', args: [q.name, pass]}))
	res.render('register')
})

//local functions
function Encrypt(rawkey){
	const cipher = crypto.createCipheriv(algorithm, seckey, init)
	rawkey = cipher.update(rawkey, 'utf-8', 'hex')
	rawkey+=cipher.final('hex')
	return rawkey
}