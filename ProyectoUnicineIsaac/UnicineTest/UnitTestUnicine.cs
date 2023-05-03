using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProyectoUnicineIsaac;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;

namespace UnicineTest
{
    [TestClass]
    public class UnitTestUnicine
    {
        private Mock<UniCineBD> _mockUnicineBD;
        private Cliente _cliente;

        [TestInitialize]
        public void Initialize()
        {
            _mockUnicineBD = new Mock<UniCineBD>();

            //Datos de peliculas
            var datosPeliculas = new List<Pelicula>
            {
                new Pelicula{ PeliculaId = 13, Nombre = "Super Mario", Anno = 2023,
                 Categoria = "Todos", Genero = "Aventura", Duracion = 90, Sinopsis = "Ejemplo 2"}

            }.AsQueryable();

            //Datos de Sesiones
            DateTime fin = new DateTime(2023, 5, 15, 8, 30, 54);
            var datosSesiones = new List<Sesion>
            {
                new Sesion{ SesionId = 24, Sala = "SALA 6", DiaSemana = "Lunes", Comienzo = DateTime.Now,
                    FinMax = fin, Aforo = 120, Precio = 7.2f}
            }.AsQueryable();

            //Datos de proyecciones
            DateTime inicio = new DateTime(2023, 5, 15, 8, 30, 54);
            var datosProyecciones = new List<Proyeccion>
            {
                new Proyeccion{PeliculaId = 13, SesionId = 24, Inicio = inicio}
            }.AsQueryable();



            // Falseo de tabla Peliculas
            var mockTablaPeliculas = new Mock<DbSet<Pelicula>>();
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x =>
            x.Provider).Returns(datosPeliculas.Provider);
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x =>
            x.Expression).Returns(datosPeliculas.Expression);
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x =>
            x.ElementType).Returns(datosPeliculas.ElementType);

            //Al solicitar, devuelve objeto falseado
            _mockUnicineBD.Setup(x => x.Peliculas).Returns(mockTablaPeliculas.Object);

            // Falseo de tabla Sesiones
            var mockTablaSesiones = new Mock<DbSet<Sesion>>();
            mockTablaSesiones.As<IQueryable<Sesion>>().Setup(x =>
            x.Provider).Returns(datosSesiones.Provider);
            mockTablaSesiones.As<IQueryable<Sesion>>().Setup(x =>
            x.Expression).Returns(datosSesiones.Expression);
            mockTablaSesiones.As<IQueryable<Sesion>>().Setup(x =>
            x.ElementType).Returns(datosSesiones.ElementType);

            _mockUnicineBD.Setup(x => x.Sesiones).Returns(mockTablaSesiones.Object);

            // Falseo de tabla Proyecciones
            var mockTablaProyecciones = new Mock<DbSet<Proyeccion>>();
            mockTablaProyecciones.As<IQueryable<Proyeccion>>().Setup(x =>
            x.Provider).Returns(datosProyecciones.Provider);
            mockTablaProyecciones.As<IQueryable<Proyeccion>>().Setup(x =>
            x.Expression).Returns(datosProyecciones.Expression);
            mockTablaProyecciones.As<IQueryable<Proyeccion>>().Setup(x =>
            x.ElementType).Returns(datosProyecciones.ElementType);

            _mockUnicineBD.Setup(x => x.Proyecciones).Returns(mockTablaProyecciones.Object);


            //falseamos la base de datos.
            _cliente = new Cliente(_mockUnicineBD.Object);

        }

        [TestMethod]
        public void ComprobarDuracionPeliculaCorrecta()
        {
            Pelicula unPelicula = _cliente.ObtenerPelicula(13);

            //unPelicula no es null
            Assert.IsNotNull(unPelicula);

            Assert.AreEqual(90, unPelicula.Duracion);
        }

        [TestMethod]
        public void ComprobarDuracionPeliculaIncorrecta()
        {
            Pelicula unPelicula = _cliente.ObtenerPelicula(13);

            //unPelicula no es null
            Assert.IsNotNull(unPelicula);

            Assert.AreNotEqual(110, unPelicula.Duracion);
            Assert.Fail("La duracion de la pelicula debe ser entre 0 y 300 minutos");
        }

        [TestMethod]
        public void ComprobarDuracionPeliculaNull()
        {
            Pelicula unPelicula = _cliente.ObtenerPelicula(13);

            //unPelicula no es null
            Assert.IsNotNull(unPelicula);

            //Pero su duracion lo es
            Assert.IsNull(null, unPelicula.Duracion.ToString());
            Assert.Fail("El dato de duración es nulo");
        }

        [TestMethod]
        public void EliminarPeliculaCorrecta()
        {
            DateTime inicio = new DateTime(2023, 5, 15, 8, 30, 54);
            Pelicula unPelicula = _cliente.ObtenerPelicula(13);
            Proyeccion unProyeccion = _cliente.ObtenerProyeccion(24, 13, inicio);

            //unPelicula y unProyeccion no es null
            Assert.IsNotNull(unPelicula);
            Assert.IsNotNull(unProyeccion);

            //La proyeccion no tiene proyeccion asociada
            Assert.AreNotEqual(12, unProyeccion.PeliculaId);
        }

        [TestMethod]
        public void EliminarPeliculaIncorrecta()
        {
            DateTime inicio = new DateTime(2023, 5, 15, 8, 30, 54);
            Pelicula unPelicula = _cliente.ObtenerPelicula(13);
            Proyeccion unProyeccion = _cliente.ObtenerProyeccion(24, 13, inicio);

            //unPelicula y unProyeccion no es null
            Assert.IsNotNull(unPelicula);
            Assert.IsNotNull(unProyeccion);

            //La proyeccion tiene asociada una pelicula
            Assert.AreEqual(13, unProyeccion.PeliculaId);
            Assert.Fail("No se puede eliminar la pelicula, esta asociada a una proyeccion");
        }

        [TestMethod]
        public void EliminarPeliculaNull()
        {
            Pelicula unPelicula = null;

            //unPelicula y unProyeccion no es null
            Assert.IsNull(unPelicula);
            Assert.Fail("No se puede eliminar la pelicula, no tiene ninguna pelicula asignada");
        }

        [TestMethod]
        public void CrearSesionCorrecta()
        {
            Sesion unSesion = _cliente.ObtenerSesion(24);

            //unSesion no es null
            Assert.IsNotNull(unSesion);

            //El precio o aforo es mayor de 0
            Assert.AreEqual(120, unSesion.Aforo);
            Assert.AreEqual(7.2f, unSesion.Precio);

        }

        [TestMethod]
        public void CrearSesionIncorrecta()
        {
            Sesion unSesion = _cliente.ObtenerSesion(24);

            //unSesion no es null
            Assert.IsNotNull(unSesion);

            //El precio o aforo es 0
            Assert.AreNotEqual(0, unSesion.Aforo);
            Assert.AreNotEqual(0f, unSesion.Precio);
            Assert.Fail("El precio o el Aforo de la sesion no pueden ser de 0");
        }

        [TestMethod]
        public void CrearSesionnull()
        {
            Sesion unSesion = null;

            //unSesion es null
            Assert.IsNull(unSesion);
            Assert.Fail("No se puede crear la sesión, no tiene valor");
        }

        [TestMethod]
        public void DuracionSesionProyeccionCorrecto()
        {
            DateTime inicio = new DateTime(2023, 5, 15, 8, 30, 54);
            Pelicula unPelicula = _cliente.ObtenerPelicula(13);
            Sesion unSesion = _cliente.ObtenerSesion(24);
            Proyeccion unProyeccion = _cliente.ObtenerProyeccion(24, 13, inicio);

            Assert.IsNotNull(unPelicula);
            Assert.IsNotNull(unSesion);
            Assert.IsNotNull(unProyeccion);

            //Periodo de tiempo de la sesion
            TimeSpan periodo = unSesion.Comienzo - unSesion.FinMax;
            Assert.AreNotEqual(unPelicula.Duracion, periodo.TotalMinutes);
        }
        [TestMethod]
        public void DuracionSesionProyeccionIncorrecto()
        {
            DateTime inicio = new DateTime(2023, 5, 15, 8, 30, 54);
            Pelicula unPelicula = _cliente.ObtenerPelicula(13);
            Sesion unSesion = _cliente.ObtenerSesion(24);
            Proyeccion unProyeccion = _cliente.ObtenerProyeccion(24, 13, inicio);

            Assert.IsNotNull(unPelicula);
            Assert.IsNotNull(unSesion);
            Assert.IsNotNull(unProyeccion);

            //Periodo de tiempo de la sesion
            TimeSpan periodo = unSesion.Comienzo - unSesion.FinMax;
            Assert.AreEqual(unPelicula.Duracion, periodo.TotalMinutes);
            Assert.Fail("");
        }
    }
}
