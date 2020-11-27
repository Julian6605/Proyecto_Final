# Proyecto_Final
Proyecto final para la clase Dotnet. Creación de una pagina web de subastas


Este proyecto se basa en la creación de una página web con Dotnet en Visual Studio Code. La página está basada en la venta y subastas de artículos, las personas pueden ingresar a la página y vender un artículo u ofertar por un artículo que estén interesados, para realizar alguno de estos procesos primero deben registrarse en la página con un correo electrónico. Cuando el usuario ya se encuentra registrado en la página podrá vender un artículo llenando un formulario con los datos del articulo con su respectivo precio de venta o de subasta.

La página se llama “SUBASTAS USC”, y está desarrollada en lenguaje DotNet, con el Framework RazorPages, ya que con este framework se facilita el diseño de la página, ya que maneja las solicitudes directamente en la directiva @page sin para por un controlador.

En los archivos que están adentro de la @page las clases siempre están en dos formatos un .CS y .HTML, 

La clase Model, permite separa la logia de nuestra página, de esta forma se definen los controladores de la página para las solicitudes enviadas a la página y los datos utilizados para representar la página, de esta forma se permite la gestión de dependencias de las paginas mediante la inyección de dependencias.

En la carpeta modelos se crea el modelo de datos que se guardaran en la base de datos, en esta sección colocamos todos los datos o las tablas necesarias que necesitamos en la base de datos, aquí se incluye las características y las anotaciones y validaciones que llevaran esos datos cuando se vayan a crear.

A parte de crear las clases con los modelos de datos, estas clases deben inicializarse en la clase DbContex, que permitirá la migración en la base de datos de toda la información de los datos en la clase modelos, y también se debe inicializar el DbContexts en el archivo Startup.cs .

También se creó una validación de autenticación para los usuarios, esto se logra a partir de la creación de los servicios que se agregan en ConfigureServices. El patrón típico es llamar a todos los Add{Service}métodos y luego llamar a todos los services.Configure{Service}métodos.


<img src='https://raw.githubusercontent.com/Julian6605/imagenes/main/ARQUITECTURA.PNG' alt='' height='100'>
