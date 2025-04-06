# PROGRAMA DE GESTION DE CITAS (PROYECTO)
## Objetivos del proyecto:
Desarrollo de una aplicacion capaz de gestionar citas medicas, teniendo disponibilidad tanto en la web como en escritorio, permitiendo acceder a sus usuarios desde diferentes plataformas.

***

## Estructura del proyecto:
El protyecto consta de 3 carpetas principales cada una con un objetivo de desarrollo diferente, su utilidad se lista a continuacion:

> db: Carpeta donde se almacena la base de datos.
> appEscritorio: Carpeta donde se desarrolla la aplicacion de escritorio en windows forms con C#
> appWeb: Carpeta donde se desarrolla la aplicacion web, utilizando un servidor en  Flask con Python y tecnologias web como HTML, CSS y JS.

* NOTA: dentro de cada carpeta se encontrara una explicacion del como utilizar dicha funcionalidad explicando cada una sus funciones y su estrucutra, este archivo unicamente indica la estructura general del proyecto.

***

## Tecnologias utilizadas en este proyecto:
El proyecto hace uso de distintas tecnologias en sus distintas partes, cada tecnologias se describe su utilidad y en que lugar del proyecto se utiliza:
> * SQLite: Es la base de datos utilizada debido a su sencilles y ligereza permitiendo un desarrollo mas agil de la aplicacion.
> * Python: Es el lenguaje de programacion utilizado en la parte web en el backend para establecer un servidor al cual solicitaremos los datos.
>> * Flask: Es el framework de python utilizado para establecer este servidor web con sus distintas rutas utilizadas.
> * Tecnologias web: Este conjunto de tecnologias (HTML, CSS y JS) son utilizadas para el frontend de la pagina en la cual se presentaran los datos al usuario.
> * C#: Es el lenguaje de programacion utilizado para el desarrollo de la aplicacion de escritorio, el cual se encargara de gestionar y mostrar los datos en una interfaz de escritorio.
>> * Windows Forms: Es el framework utilizado para el desarrollo de la aplicacion de escritorio con la que contaran los usuarios.

***

## Funcionalidades:
En este conjunto de aplicaciones los usuarios tendran diferentes implementaciones, en la aplicacion de escritorio, cualquier usuarios podra acceder ya sea los administradores para crear nuevos usuarios, los medicos para agendar citas o los pacientes para observar sus citas. Mientras que en la aplicacion web unicamente podran acceder los pacientes para observar sus citas agendadas.

***

### Tareas por realizar
- [x] Desarrollo de la API
- [ ] Implementacion de una interfaz web en las rutas de usuario
- [ ] Desarrollo de la interaccion entre C# y la db
- [ ] Desarrollo de la interfaz de usuario de escritorio 