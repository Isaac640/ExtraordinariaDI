using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUnicineIsaac
{
    public class Herramientas
    {

        //PELICULAS

        public static Pelicula[] ObtenerPeliculas()
        {
            UniCineBD bd = new UniCineBD();
            return bd.Peliculas.ToArray();
        }

        public static Pelicula ObtenerPelicula(int PeliculaBD)
        {
            UniCineBD bd = new UniCineBD();
            return bd.Peliculas.FirstOrDefault(x => x.PeliculaId == PeliculaBD);
        }

        public static void CrearPelicula(Pelicula PeliculaNueva)
        {
            UniCineBD bd = new UniCineBD();
            bd.Peliculas.Add(PeliculaNueva);
        }

        public static void ActualizarPelicula(Pelicula PeliculaMod)
        {
            UniCineBD bd = new UniCineBD();
            Pelicula peliculaBD = bd.Peliculas.FirstOrDefault(x => x.PeliculaId == PeliculaMod.PeliculaId);

            if (peliculaBD != null)
            {
                bd.Entry(peliculaBD).CurrentValues.SetValues(PeliculaMod);
                bd.SaveChanges();
            }
        }

        public static void EliminarPelicula(int peliculaId)
        {
            UniCineBD bd = new UniCineBD();
            Pelicula faltaBD = bd.Peliculas.FirstOrDefault(x => x.PeliculaId == peliculaId);
            if (faltaBD != null)
            {
                bd.Peliculas.Remove(faltaBD);
                bd.SaveChanges();
            }
        }

        //SESIÓN

        public static Sesion[] ObtenerSesiones()
        {
            UniCineBD bd = new UniCineBD();
            return bd.Sesiones.ToArray();
        }

        public static Sesion ObtenerSesion(int Sesionid)
        {
            UniCineBD bd = new UniCineBD();
            return bd.Sesiones.FirstOrDefault(x => x.SesionId == Sesionid);
        }

        public static void CrearSesion(Sesion SesionNueva)
        {
            UniCineBD bd = new UniCineBD();
            bd.Sesiones.Add(SesionNueva);
        }

        public static void ActualizarSesion(Sesion sesionMod)
        {
            UniCineBD bd = new UniCineBD();
            Sesion sesion = bd.Sesiones.FirstOrDefault(x => x.SesionId == sesionMod.SesionId);

            if (sesion != null)
            {
                bd.Entry(sesion).CurrentValues.SetValues(sesionMod);
                bd.SaveChanges();
            }
        }

        public static void EliminarSesion(int sesionId)
        {
            UniCineBD bd = new UniCineBD();
            Sesion faltaBD = bd.Sesiones.FirstOrDefault(x => x.SesionId == sesionId);
            if (faltaBD != null)
            {
                bd.Sesiones.Remove(faltaBD);
                bd.SaveChanges();
            }
        }

        //PROYECCIONES 
        //falta de arreglar o decidir que id obtener

        public static Proyeccion[] ObtenerProyecciones()
        {
            UniCineBD bd = new UniCineBD();
            return bd.Proyecciones.ToArray();
        }

        public static Proyeccion ObtenerProyeccion(int Sesionid)
        {
            UniCineBD bd = new UniCineBD();
            return bd.Proyecciones.FirstOrDefault(x => x.SesionId == Sesionid);
        }

        public static void CrearProyeccion(Proyeccion SesionNueva)
        {
            UniCineBD bd = new UniCineBD();
            bd.Proyecciones.Add(SesionNueva);
        }

        public static void ActualizarProyeccion(Proyeccion sesionMod)
        {
            UniCineBD bd = new UniCineBD();
            Proyeccion sesion = bd.Proyecciones.FirstOrDefault(x => x.SesionId == sesionMod.SesionId);

            if (sesion != null)
            {
                bd.Entry(sesion).CurrentValues.SetValues(sesionMod);
                bd.SaveChanges();
            }
        }

        public static void EliminarProyeccion(int sesionId)
        {
            UniCineBD bd = new UniCineBD();
            Proyeccion faltaBD = bd.Proyecciones.FirstOrDefault(x => x.SesionId == sesionId);
            if (faltaBD != null)
            {
                bd.Proyecciones.Remove(faltaBD);
                bd.SaveChanges();
            }
        }

    }
}
