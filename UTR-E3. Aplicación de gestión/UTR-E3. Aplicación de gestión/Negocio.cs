using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTR_E3.Aplicación_de_gestión
{
    public class Negocio
    {
        private static List<Peliculas> _peliculas;
        private static List<Libros> _libros;

        static Negocio()
        {
            _peliculas = new List<Peliculas>();
            _libros = new List<Libros>();
        }

        //PELICULAS

        public static List<Peliculas> ObtenerPeliculas()
        {
            return _peliculas;
        }

        public static void CrearPelicula(Peliculas nuevaPeli)
        {
            if (_peliculas.Count > 0)
            {
                nuevaPeli.PeliculaId = _peliculas.Max(x => x.PeliculaId) + 1;
            }
            else
            {
                nuevaPeli.PeliculaId = 1;
            }

            _peliculas.Add(nuevaPeli);
        }

        public static Peliculas ObtenerPelicula(int peliId)
        {
            return _peliculas.FirstOrDefault(x => x.PeliculaId == peliId);
        }

        public static void BorrarPelicula(int peliId)
        {
            var borrar = ObtenerPelicula(peliId);
            _peliculas.Remove(borrar);
        }

        public static void ActualizarPelicula(Peliculas peliMod)
        {
            Peliculas pelicula = _peliculas.FirstOrDefault(x => x.PeliculaId == peliMod.PeliculaId);

            if (pelicula != null)
            {
                pelicula.Equals(peliMod);
            }
        }

        //LIBROS

        public static List<Libros> ObtenerLibros()
        {
            return _libros;
        }

        public static void CrearLibro(Libros nuevoLibro)
        {
            if (_libros.Count > 0)
            {
                nuevoLibro.LibroId = _libros.Max(x => x.LibroId) + 1;
            }
            else
            {
                nuevoLibro.LibroId = 1;
            }
            _libros.Add(nuevoLibro);
        }

        public static Libros ObtenerLibro(int libroId)
        {
            return _libros.FirstOrDefault(x => x.LibroId == libroId);
        }

        public static void BorrarLibro(int libroId)
        {
            var borrar = ObtenerLibro(libroId);
            _libros.Remove(borrar);
        }

        public static void ActualizarLibro(Libros libroMod)
        {
            Libros libro = _libros.FirstOrDefault(x => x.LibroId == libroMod.LibroId);

            if (libro != null)
            {
                libro.Equals(libroMod);
            }
        }
    }
}
