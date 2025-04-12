from flask import Flask
from flask import request
from flask import redirect
from flask import make_response
from flask import render_template
from flask import url_for
from backend import Auth
from backend import Dates

app = Flask(__name__)

@app.route("/")
def login():
    url_for("static", filename="diseno2.css")
    return render_template("index.html")

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
        return "<script>location=\"/\"; console.log('{}'); </script>".format(string)

@app.get("/api/deauth")
def deauth():
    response = make_response(redirect('/'))
    response.set_cookie('userid', "0", 0)
    return response

@app.route("/home")
def home():
    url_for("static", filename="re2.css")
    url_for("static", filename="app.js")
    if request.cookies.get("userid") == None:
        return redirect("/")
    return render_template("html/re.html")

@app.get("/api/dates")
def apiDates():
    if request.cookies.get("userid") == None:
        return redirect("/")
    return Dates.getDates(request.cookies.get("userid"))

@app.route("/cita/<id>")
def cita(id):
    url_for("static", filename="cita2.css")
    url_for("static", filename="main.js")
    return render_template("html/cita.html")

@app.get("/api/date")
def apiCita():
    if request.cookies.get("userid") == None:
        return redirect("/")
    dateId = request.args.get("dateId")
    return Dates.getDate(dateId)