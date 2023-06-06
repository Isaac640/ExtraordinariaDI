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
    public class UnitTest1
    {
        private Mock<UniCineBD> _mockUnicineBD;
        private Cliente _cliente;

        [TestInitialize]
        public void Initialize()
        {
            _mockUnicineBD = new Mock<ProyectoUnicineIsaac.UniCineBD>();

            //Datos de peliculas
            var datosPeliculas = new List<Pelicula>
            {
                new Pelicula{ PeliculaId = 12, Nombre = "John Wick", Anno = 2023,
                    Categoria = ">16", Genero = "Acción", Duracion = 110, Sinopsis= "Ejemplo"},
                new Pelicula{ PeliculaId = 13, Nombre = "Super Mario", Anno = 2023,
                 Categoria = "Todos", Genero = "Aventura", Duracion = 90, Sinopsis = "Ejemplo 2"}

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

            //falseamos la base de datos.
            _cliente = new Cliente(_mockUnicineBD.Object);
            Debug.WriteLine("TestInitialize");

        }
        [TestMethod]
        public void TestMethod1()
        {
            
        }
    }
}
