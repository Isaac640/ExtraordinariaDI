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

        //USAR EN BD
        //ULTILIZAR PARA QUE AFFECTE A LA BASE DE DATOS DIRECTAMENTE EN LA TABLA DE PELICULAS
        public static Peliculas[] ObtenerPeliculasBD()
        {
            GestionBD bd = new GestionBD();
            return bd.Peliculas.ToArray();
        }

        public static Peliculas ObtenerPeliculaBD(int PeliculaBD)
        {
            GestionBD bd = new GestionBD();
            return bd.Peliculas.FirstOrDefault(x => x.PeliculaId == PeliculaBD);
        }

        public static void CrearPeliculaBD(Peliculas PeliculaNueva)
        {
            GestionBD bd = new GestionBD();
            bd.Peliculas.Add(PeliculaNueva);
        }

        public static void ActualizarPeliculaBD(Peliculas PeliculaMod)
        {
            GestionBD bd = new GestionBD();
            Peliculas peliculaBD = bd.Peliculas.FirstOrDefault(x => x.PeliculaId == PeliculaMod.PeliculaId);

            if (peliculaBD != null)
            {
                bd.Entry(peliculaBD).CurrentValues.SetValues(PeliculaMod);
                bd.SaveChanges();
            }
        }

        public static void EliminarPeliculaBD(int peliculaId)
        {
            GestionBD bd = new GestionBD();
            Peliculas faltaBD = bd.Peliculas.FirstOrDefault(x => x.PeliculaId == peliculaId);
            if (faltaBD != null)
            {
                bd.Peliculas.Remove(faltaBD);
                bd.SaveChanges();
            }
        }

        //SIN BD
        //SOLO PARA PRACTICA PARA NO AFFECTAR A LA BASE DE DATOS
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

        //USAR EN BD
        //ULTILIZAR PARA QUE AFFECTE A LA BASE DE DATOS DIRECTAMENTE EN LA TABLA DE LIBROS
        public static Libros[] ObtenerLibrosBD()
        {
            GestionBD bd = new GestionBD();
            return bd.Libros.ToArray();
        }

        public static Libros ObtenerLibroBD(int libroBD)
        {
            GestionBD bd = new GestionBD();
            return bd.Libros.FirstOrDefault(x => x.LibroId == libroBD);
        }

        public static void CrearLibroBD(Libros libroNuevo)
        {
            GestionBD bd = new GestionBD();
            bd.Libros.Add(libroNuevo);
        }

        public static void ActualizarLibroBD(Libros libroMod)
        {
            GestionBD bd = new GestionBD();
            Libros refugioBD = bd.Libros.FirstOrDefault(x => x.LibroId == libroMod.LibroId);

            if (refugioBD != null)
            {
                bd.Entry(refugioBD).CurrentValues.SetValues(libroMod);
                bd.SaveChanges();
            }
        }

        public static void EliminarLibroBD(int libroId)
        {
            GestionBD bd = new GestionBD();
            Libros faltaBD = bd.Libros.FirstOrDefault(x => x.LibroId == libroId);
            if (faltaBD != null)
            {
                bd.Libros.Remove(faltaBD);
                bd.SaveChanges();
            }
        }

        //SIN BD
        //SOLO UTILIZAR EN CASO DE PRACTICAR, SIN QUE AFECTE A LA BASE DE DATOS
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
