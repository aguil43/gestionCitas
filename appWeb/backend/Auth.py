from backend import DBAction as db
# import DBAction as db

# CODIGOS DE ESTADO DE RESPUESTA A LA CONSULTA (SEGUNDO INDICE DEL OBJETO RESPONSE)
# 0 - USUARIO NO ENCONTRADO
# 1 - INICIO DE SESION EXITOSO
# 2 - USUARIO NO AUTORIZADO PARA ESTA PLATAFORMA
# 3 - CONTRASENA INCORRECTA

def auth(username, password):
    result = db.executeQueryWithWhereStr("*", "Sesion", ["nombreUsuario", username])
    response = [False, 0, 0]
    if not result == []:
        if result[0][2] == password:
            privileges = db.executeQueryWithWhereStr("*", "Usuarios", ["id", result[0][0]])
            if privileges[0][3] == 3:
                response[0] = True
                response[1] = 1
                response[2] = result[0][0]
                return response
            else:
                response[1] = 2
        else:
            response[1] = 3
    return response
