# key-one-test

Instrucciones:
1- Clonar el repositorio
2- Abrir la solucion en Visual Studio
3- Modificar el archivo appsettings.json, poner el puerto configurado localmente (el puerto lo puedes ver ejecutando la aplicacion, esta al final de la palabra "localhost", en la barra de direcciones del navegador)
4- Ejecutar la solucion
5- Agregar "/swagger" al final de la url en el navegador
6- Abrir el metodo "/login" y clickear el boton "Try it out"
7- Cambiar las credenciales por alguna de las que hay en el archivo "UserRepository.cs", fijarse en el campo "Role" 
8- Clickear el boton "Execute"
9- Copiar el contenido del "Response body" sin las comillas
10- Clickear el boton de arriba a la derecha "Authorize" 
11- Pegar el token copiado y clickear el boton "Authorize" del popup, despues clickear el boton "Close"
12- Abrir el metodo "/process" y clickear el boton "Try it out"
13- Clickear el boton "Execute" y se despliega la lista procesada de los objetos de entrada, que pueden ver y modificar en el archivo "ObjectRepository.cs"

Adicionalmente pueden probar el metodo "/welcome" que no requiere login ni token