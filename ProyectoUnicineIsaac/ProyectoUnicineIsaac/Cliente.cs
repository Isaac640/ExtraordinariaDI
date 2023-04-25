using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUnicineIsaac
{
    public class Cliente
    {

        //PELICULAS

        public Pelicula[] ObtenerPeliculas()
        {
            UniCineBD bd = new UniCineBD();
            return bd.Peliculas.ToArray();
        }

        public Pelicula ObtenerPelicula(int PeliculaBD)
        {
            UniCineBD bd = new UniCineBD();
            return bd.Peliculas.FirstOrDefault(x => x.PeliculaId == PeliculaBD);
        }

        public void CrearPelicula(Pelicula PeliculaNueva)
        {
            UniCineBD bd = new UniCineBD();

            bd.Peliculas.Add(PeliculaNueva);

            bd.SaveChanges();
        }

        public void ActualizarPelicula(Pelicula PeliculaMod)
        {
            UniCineBD bd = new UniCineBD();
            Pelicula peliculaBD = bd.Peliculas.FirstOrDefault(x => x.PeliculaId == PeliculaMod.PeliculaId);

            if (peliculaBD != null)
            {
                bd.Entry(peliculaBD).CurrentValues.SetValues(PeliculaMod);
                bd.SaveChanges();
            }
        }

        public void EliminarPelicula(int peliculaId)
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

        public Sesion[] ObtenerSesiones()
        {
            UniCineBD bd = new UniCineBD();
            return bd.Sesiones.ToArray();
        }

        public Sesion ObtenerSesion(int Sesionid)
        {
            UniCineBD bd = new UniCineBD();
            return bd.Sesiones.FirstOrDefault(x => x.SesionId == Sesionid);
        }

        public void CrearSesion(Sesion SesionNueva)
        {
            UniCineBD bd = new UniCineBD();
            bd.Sesiones.Add(SesionNueva);
            bd.SaveChanges();
        }

        public void ActualizarSesion(Sesion sesionMod)
        {
            UniCineBD bd = new UniCineBD();
            Sesion sesion = bd.Sesiones.FirstOrDefault(x => x.SesionId == sesionMod.SesionId);

            if (sesion != null)
            {
                bd.Entry(sesion).CurrentValues.SetValues(sesionMod);
                bd.SaveChanges();
            }
        }

        public void EliminarSesion(int sesionId)
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

        public Proyeccion[] ObtenerProyecciones()
        {
            UniCineBD bd = new UniCineBD();
            return bd.Proyecciones.ToArray();
        }

        public Proyeccion ObtenerProyeccion(int sesionId, int peliculaId, DateTime fechaIni)
        {
            UniCineBD bd = new UniCineBD();
            return bd.Proyecciones.FirstOrDefault(x => x.SesionId == sesionId &&
            x.PeliculaId == peliculaId && x.Inicio == fechaIni);
        }

        public void CrearProyeccion(Proyeccion SesionNueva)
        {
            UniCineBD bd = new UniCineBD();
            bd.Proyecciones.Add(SesionNueva);
            bd.SaveChanges();
        }

        public void ActualizarProyeccion(Proyeccion sesionMod)
        {
            UniCineBD bd = new UniCineBD();
            Proyeccion sesion = bd.Proyecciones.FirstOrDefault(x => x.SesionId == sesionMod.SesionId);

            if (sesion != null)
            {
                bd.Entry(sesion).CurrentValues.SetValues(sesionMod);
                bd.SaveChanges();
            }
        }

        public void EliminarProyeccion(Proyeccion proEliminar)
        {
            UniCineBD bd = new UniCineBD();
            Proyeccion pro = bd.Proyecciones.FirstOrDefault(x => x.SesionId == proEliminar.SesionId && 
            x.PeliculaId == proEliminar.PeliculaId && x.Inicio == proEliminar.Inicio);
            if (pro != null)
            {
                bd.Proyecciones.Remove(pro);
                bd.SaveChanges();
            }

        }

    }
}
