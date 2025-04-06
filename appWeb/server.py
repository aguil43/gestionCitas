from flask import Flask
from flask import request
from flask import redirect
from flask import make_response
from backend import Auth
from backend import Dates

app = Flask(__name__)

@app.route("/")
def login():
    return "<h1>Login page</h1>"

@app.post("/api/auth")
def auth():
    username = request.form['username']
    password = request.form['password']
    check = Auth.auth(username, password)
    if check[0]:
        response = make_response(redirect('/home'))
        cookie = "{}".format(check[2])
        response.set_cookie('userid', cookie)
        return response
    else:
        string = "nothing"
        if check[1] == 0:
            string = "Username not found"
        elif check[1] == 2:
            string = "Not autorized for this app"
        elif check[1] == 3:
            string = "Bad password"
        return "<script>alert({})</script>".format(string)

@app.get("/api/deauth")
def deauth():
    response = make_response(redirect('/'))
    response.set_cookie('userid', "0", 0)
    return response

@app.route("/home")
def home():
    if request.cookies.get("userid") == None:
        return redirect("/")
    return "<h1>Home page</h1>"

@app.get("/api/dates")
def apiDates():
    if request.cookies.get("userid") == None:
        return redirect("/")
    return Dates.getDates(request.cookies.get("userid"))

@app.route("/cita")
def cita():
    return "<h1> Pagina de informacion de una cita </h1>"

@app.get("/api/date")
def apiCita():
    if request.cookies.get("userid") == None:
        return redirect("/")
    dateId = request.args.get("dateId")
    return Dates.getDate(dateId)