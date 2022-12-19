# Java Hibernate & C# NHibernate

## Importante:

> Este proyecto fue el examen final del curso de Programación 4.


## Requerimientos Solicitados:

* CRUD de clientes y libros en Java con framework Hibernate 4.3.1 <br />

* Creación de prestamos y devoluciones de libros en C# con framework NHibernate 5.4.0

## Desarrollo:

* Se útilizo programación por capas en ambos proyectos. <br /> 

* En Java se crean ambos CRUD y se pueden ser ejecutados desde un web service. <br />

* En C# se hace la referencia al web service de Java para su consumo.<br />

* Se crea un web service nuevo en C# con los métodos para la creación de prestamos, devoluciones y este mismo consume los métodos de Java.

## Características:

* Motor de base de datos: SQL Server

* IDE utilizado para el desarrollo del proyecto en Java: NetBeans 8.2

* Servidor utilizado en Java: GlassFish 5.1

* .NET 6.0

## Librerías C#:

* Antlr3.Runtime 3.5.1
* Castle.Core 1.2.0
* Castle.DynamicProxy 2.2.0
* lesi.Collections 4.0.4
* log4net 2.0.15
* NHibernate 5.4.0
* NLog 1.0.0.505
* Remotion.Linq 2.2.0
* Remotion.Linq.EagerFetching 2.2.0
* LinqSQL

## Librerías Java:

* mssql-jdbc-11.2.0.jre8.jar

## Anotaciones:

* Las conexiones a bases de datos se deben configurar nuevamente con los credenciales a utilizar.

* Es recomendado crear las configarciones de Hibernate y de NHiberante nuevamente para evitar erorres.

* El Web.config debe establecer la conexión entre NHibernate y SQL Server.

* Las propiedades de los XML en C# deben ser incrustados.

* Proyectos utilizados: <br />
    1- Java Web - Web Application <br />
    2- ASP.NET Web Application (.NET) <br />
    3- Librería de Clases (.NET) <br />