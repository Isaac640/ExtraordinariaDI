using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUnicineIsaac
{
    public class Cliente
    {
        private UniCineBD bd = new UniCineBD();

        public Cliente()
        {
        }

        public Cliente(UniCineBD bd)
        {

        }


        //PELICULAS

        public Pelicula[] ObtenerPeliculas()
        {
            return bd.Peliculas.ToArray();
        }

        public Pelicula ObtenerPelicula(int PeliculaBD)
        {
            return bd.Peliculas.FirstOrDefault(x => x.PeliculaId == PeliculaBD);
        }

        public void CrearPelicula(Pelicula PeliculaNueva)
        {
            if (PeliculaNueva.Duracion > 300 || PeliculaNueva.Duracion <= 0)
            {
                throw new ApplicationException("La pelicula no debe ser mayor a 300 o menor a 0 minutos");
            }
            else
            {
                bd.Peliculas.Add(PeliculaNueva);
                bd.SaveChanges();
            }

        }

        public void ActualizarPelicula(Pelicula PeliculaMod)
        {
            Pelicula peliculaBD = bd.Peliculas.FirstOrDefault(x => x.PeliculaId == PeliculaMod.PeliculaId);

            if (peliculaBD != null)
            {
                bd.Entry(peliculaBD).CurrentValues.SetValues(PeliculaMod);
                bd.SaveChanges();
            }
        }

        public void EliminarPelicula(int peliculaId)
        {
            Pelicula faltaBD = bd.Peliculas.FirstOrDefault(x => x.PeliculaId == peliculaId);
            if (faltaBD != null)
            {
                if (bd.Proyecciones.Any(p => p.PeliculaId == peliculaId))
                {
                    throw new ApplicationException("La pelicula esta asociada a una proyección");
                }
                bd.Peliculas.Remove(faltaBD);
                bd.SaveChanges();
            }
        }

        //SESIÓN

        public Sesion[] ObtenerSesiones()
        {
            return bd.Sesiones.ToArray();
        }

        public Sesion ObtenerSesion(int Sesionid)
        {
            return bd.Sesiones.FirstOrDefault(x => x.SesionId == Sesionid);
        }

        public void CrearSesion(Sesion SesionNueva)
        {
            if (SesionNueva.Aforo <= 0 || SesionNueva.Precio < 0)
            {
                throw new ApplicationException("La sesión no debe tener un precio de 0,00€ o el aforo no puede ser de 0 o menos");
            }
            else
            {
                bd.Sesiones.Add(SesionNueva);
                bd.SaveChanges();
            }
        }

        public void ActualizarSesion(Sesion sesionMod)
        {
            Sesion sesion = bd.Sesiones.FirstOrDefault(x => x.SesionId == sesionMod.SesionId);

            if (sesion != null)
            {
                bd.Entry(sesion).CurrentValues.SetValues(sesionMod);
                bd.SaveChanges();
            }
        }

        public void EliminarSesion(int sesionId)
        {
            Sesion faltaBD = bd.Sesiones.FirstOrDefault(x => x.SesionId == sesionId);
            if (faltaBD != null)
            {
                bd.Sesiones.Remove(faltaBD);
                bd.SaveChanges();
            }
        }

        //PROYECCIONES 

        public Proyeccion[] ObtenerProyecciones()
        {
            return bd.Proyecciones.ToArray();
        }

        public Proyeccion ObtenerProyeccion(int sesionId, int peliculaId, DateTime fechaIni)
        {
            return bd.Proyecciones.FirstOrDefault(x => x.SesionId == sesionId &&
            x.PeliculaId == peliculaId && x.Inicio == fechaIni);
        }

        public void CrearProyeccion(Proyeccion SesionNueva)
        {
            bd.Proyecciones.Add(SesionNueva);
            bd.SaveChanges();
        }

        public void ActualizarProyeccion(Proyeccion sesionMod)
        {
            Proyeccion sesion = bd.Proyecciones.FirstOrDefault(x => x.SesionId == sesionMod.SesionId);

            if (sesion != null)
            {
                bd.Entry(sesion).CurrentValues.SetValues(sesionMod);
                bd.SaveChanges();
            }
        }

        public void EliminarProyeccion(Proyeccion proEliminar)
        {
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
