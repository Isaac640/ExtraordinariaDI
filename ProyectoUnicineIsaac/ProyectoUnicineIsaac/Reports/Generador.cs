using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUnicineIsaac.Reports
{
    public class Generador
    {
        private Cliente _cliente = new Cliente();
        public void CargarInformePeliculas(int peliculaID)
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvInforme.LocalReport.ReportEmbeddedResource = "ProyectoUnicineIsaac.Reports.rptPeliculas.rdlc";

            string consultaPeliculas =
            "SELECT p.Nombre, p.Categoria, p.Genero, p.Anno, p.Duracion, " +
            "pr.Inicio, pr.Fin, s.DiaSemana, s.Comienzo, s.Sala, s.Precio " +
            "FROM Peliculas AS p " +
            "INNER JOIN Proyecciones AS pr ON pr.PeliculaId = p.PeliculaId " +
            "INNER JOIN Sesiones AS s ON s.SesionId = pr.SesionId " +
            "WHERE p.PeliculaId = " + peliculaID + " ;";

            UniCineBD ctx = new UniCineBD();
            List<PeliculasWr> listaPeliculas = ctx.Database.SqlQuery<PeliculasWr>(consultaPeliculas, new object[0]).ToList();

            ReportDataSource fuenteDatosPeliculasInforme = new ReportDataSource("DataSetPeliculas", listaPeliculas);

            Pelicula p = _cliente.ObtenerPelicula(peliculaID);

            visor.rpvInforme.LocalReport.DataSources.Add(fuenteDatosPeliculasInforme);

            ReportParameter parametroNombre = new ReportParameter("NombrePelicula", "Nombre: " + p.Nombre);
            ReportParameter parametroCategoria = new ReportParameter("CategoriaPelicula", "Categoria: " + p.Categoria);
            ReportParameter parametroGenero = new ReportParameter("GeneroPelicula", "Género: " + p.Genero);
            ReportParameter parametroAnio = new ReportParameter("AnnoPelicula", "Año: " + p.Anno.ToString());
            ReportParameter parametroDuracion = new ReportParameter("DuracionPelicula", "Duración: " + p.Duracion.ToString() + " Minutos");

            List<ReportParameter> parametros = new List<ReportParameter>();
            parametros.Add(parametroNombre);
            parametros.Add(parametroCategoria);
            parametros.Add(parametroGenero);
            parametros.Add(parametroAnio);
            parametros.Add(parametroDuracion);

            visor.rpvInforme.LocalReport.SetParameters(parametros);

            visor.rpvInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvInforme.RefreshReport();
            visor.Show();
        }

        public void CargarCuadriculaSesiones()
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvInforme.LocalReport.ReportEmbeddedResource = "ProyectoUnicineIsaac.Reports.rptSesiones.rdlc";

            string consultaSesiones =
            "SELECT  s.Sala, s.DiaSemana, s.Comienzo, s.Aforo, s.Precio " +
            "FROM Sesiones AS s " +
            "GROUP BY s.DiaSemana, s.Sala, s.Comienzo, s.Aforo, s.Precio " +
            "ORDER BY s.Comienzo;";

            UniCineBD ctx = new UniCineBD();
            List<SesionesWr> listaSesiones = ctx.Database.SqlQuery<SesionesWr>(consultaSesiones, new object[0]).ToList();

            ReportDataSource fuenteDatosPeliculasInforme = new ReportDataSource("DataSetSesiones", listaSesiones);

            visor.rpvInforme.LocalReport.DataSources.Add(fuenteDatosPeliculasInforme);

            visor.rpvInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvInforme.RefreshReport();
            visor.Show();
        }

        public void CargarCarteleraProyecciones()
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvInforme.LocalReport.ReportEmbeddedResource = "ProyectoUnicineIsaac.Reports.rptProyecciones.rdlc";

            string consultaProyecciones =
               "SELECT  s.DiaSemana, p.Nombre, p.Genero, p.Duracion, p.Categoria, pr.Inicio, pr.Fin " +
               "FROM Sesiones AS s " +
               "INNER JOIN Proyecciones AS pr ON pr.SesionId = s.SesionId " +
               "INNER JOIN Peliculas AS p ON p.PeliculaId = pr.PeliculaId " +
               "ORDER BY s.DiaSemana, pr.Inicio;";

            UniCineBD ctx = new UniCineBD();
            List<ProyeccionesWr> listaProyecciones = ctx.Database.SqlQuery<ProyeccionesWr>(consultaProyecciones, new object[0]).ToList();

            ReportDataSource fuenteDatosProyeccionesInforme = new ReportDataSource("DataSetproyecciones", listaProyecciones);

            visor.rpvInforme.LocalReport.DataSources.Add(fuenteDatosProyeccionesInforme);

            //Proyeccion pr = _cliente.ObtenerProyeccion();
            //ReportParameter parametroNombre = new ReportParameter("FechaSemana", "Desde: " + pr.Inicio + " Hasta: " + pr.Fin );
            //visor.rpvInforme.LocalReport.SetParameters(parametros);

            visor.rpvInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvInforme.RefreshReport();
            visor.Show();
        }

        public void CargarCategorias(string GeneroSeleccionado)
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvInforme.LocalReport.ReportEmbeddedResource = "ProyectoUnicineIsaac.Reports.rptGenero.rdlc";

            string consultaCategoria =
                "SELECT p.Nombre, p.anno, p.duracion, p.categoria, p.sinopsis, p.Genero " +
                "FROM Peliculas AS p " +
                "WHERE p.Genero = '" + GeneroSeleccionado + "'; ";

            UniCineBD ctx = new UniCineBD();
            List<GeneroWr> listaPeliculaGeneros = ctx.Database.SqlQuery<GeneroWr>(consultaCategoria, new object[0]).ToList();

            ReportDataSource fuenteDatosGenerosInforme = new ReportDataSource("DataSetGenero", listaPeliculaGeneros);

            ReportParameter parametroGenero = new ReportParameter("GeneroSelec", GeneroSeleccionado);
            visor.rpvInforme.LocalReport.SetParameters(parametroGenero);

            visor.rpvInforme.LocalReport.DataSources.Add(fuenteDatosGenerosInforme);

            visor.rpvInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvInforme.RefreshReport();
            visor.Show();
        }
    }
}






