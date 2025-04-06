from backend import DBAction as db
#import DBAction as db
import json

def getDates(userid):
    search = db.executeQueryWithWhereInt("*", "Citas", ["idPaciente", userid])
    dataDoc = db.executeQueryWithWhereInt("*", "Usuarios", ["id", search[0][3]])
    moreDataDoc = db.executeQueryWithWhereInt("*", "Medicos", ["idMedico", search[0][3]])
    allData = []
    for element in search:
        obj = {
            "dateID": element[0],
            "current": element[1],
            "doctor": dataDoc[0][2],
            "speciality": moreDataDoc[0][1]
        }
        allData.append(obj)
    return json.dumps(allData)

def getDate(dateId):
    search = db.executeQueryWithWhereInt("*", "Citas", ["id", dateId])
    dataPac = db.executeQueryWithWhereInt("*", "Usuarios", ["id", search[0][2]])
    dataDoc = db.executeQueryWithWhereInt("*", "Usuarios", ["id", search[0][3]])
    moreDataDoc = db.executeQueryWithWhereInt("*", "Medicos", ["idMedico", search[0][3]])
    obj = {
        "dateID": search[0][0],
        "current": search[0][1],
        "name": dataPac[0][1] + " " + dataPac[0][2],
        "doctorName": dataDoc[0][1] + " " + dataDoc[0][2],
        "speciality": moreDataDoc[0][1]
    }
    return json.dumps(obj)
