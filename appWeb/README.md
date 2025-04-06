# Aplicacion web de gestion de citas

***

## Estructura del proyecto

A continuacion se muestra la estrucutura de los archivos de la aplicacion web, esta esta desarrollada con python utilizando el framework de Flask:

> * server.py - Archivo que ejecuta el servidor, desarrollado en python con flask
> frontend/ - directorio para almacenar los archivos del frontend (html, css y js)
> backend/ - directorio para almacenar los archivos que trabajan para el backend (python, gestion de la db)
    >> * DBAction.py - se encarga de la conexion e interaccion con la base de datos
    >> * Auth.py - se encarga de la autenticacion de los usuarios
    >> * Dates.py - se encarga de la gestion de enviar los datos al frontend con la informacion de las citas

***

## Rutas de la plataforma web

### Endpoint del usuario

Son los endpoints que el usuario tiene acceso y puede observar en su navegador.

> / - Este endpoint es la pagina de inicio de sesion, es la que se abre por default al entrar a la aplicacion web
> /home - Este endpoint es donde se muestran todas las citas del usuario
> /cita - Este endpoint es donde se muestra una cita seleccionada del usuario que inicio sesion

### Endpoint de la api

Son los endpoints para realizar solicitudes de informacion o realizar acciones en el servidor. Todas tienen el prefijo API.

> /api/auth - endpoint para solicitar un inicio de sesion al servidor, en caso de ser exitoso se agrega la informacion del inicio de sesion al navegador
> /api/deauth - endpoint para solicitar una desautenticacion y que la cuenta sea cerrada en el navegador
> /api/dates - endpoint para solicitar la informacion de todas las citas del usuario al servidor
> /api/date - endpint para solicitar la informacion de una cita especifica y mostrarla al usuario

***

## Ejecucion del servidor

Si se desea iniciar la aplicacion web en un entorno de desarrollo se usa el siguiente comando:

~~~
    flask --app server run
~~~

Este comando debe de ser ejecutado desde la carpeta de appWeb para que la ejecucion sea correcta.
