import sqlite3

def connectDB():
    try:
        con = sqlite3.connect("clinica.db")
        cur = con.cursor()
        return cur
    except:
        print("Exception is occurred")

def executeQuery(columns, table):
    cur = connectDB()
    try:
        query = "SELECT {} FROM {};".format(columns, table)
        res = cur.execute(query)
        return res.fetchall()
    except:
        print("Exception is occurred")

def executeQueryWithWhereStr(columns, table, keyvalue):
    cur = connectDB()
    try:
        query = "SELECT {} FROM {} WHERE {}='{}';".format(columns, table, keyvalue[0], keyvalue[1])
        res = cur.execute(query)
        return res.fetchall()
    except:
        print("Exception is occurred")

def executeQueryWithWhereInt(columns, table, keyvalue):
    cur = connectDB()
    try:
        query = "SELECT {} FROM {} WHERE {}={};".format(columns, table, keyvalue[0], keyvalue[1])
        res = cur.execute(query)
        return res.fetchall()
    except:
        print("Exception is occurred")


#print(executeQueryWithWhere("*", "Sesion", ["nombreUsuario", "administrator"]))
#value = executeQuery("*", "Sesion")
#value = executeQueryWithWhere("*", "Sesion", ["nombreUsuario", "administrator"])
#print(value[0][1])
#print(executeQueryWithWhereInt("*", "Citas", ["idPaciente", 3]))