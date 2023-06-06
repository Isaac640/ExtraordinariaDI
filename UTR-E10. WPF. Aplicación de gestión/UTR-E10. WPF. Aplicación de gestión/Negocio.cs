using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTR_E10.WPF.Aplicación_de_gestión
{
    public class Negocio
    {
        private int _incidenciaId;
        private List<Incidencia> incidencias;

        public void BorrarIncidencia(int incidenciaId)
        {
            var borrar = ObtenerIncidencia(incidenciaId);
            incidencias.Remove(borrar);
        }
        public void CrearIncidenciaHW(IncidenciaHW incidenciaHW)
        {
            if (incidencias.Count > 0)
            {
                incidenciaHW.IncidenciaId = SigIncidenciaId();
            }
            else
            {
                incidenciaHW.IncidenciaId = 1;
            }
            incidencias.Add(incidenciaHW);
        }
        public void CrearIncidenciaOtros(IncidenciaOtros incidenciaOtros)
        {
            if (incidencias.Count > 0)
            {
                incidenciaOtros.IncidenciaId = SigIncidenciaId();
            }
            else
            {
                incidenciaOtros.IncidenciaId = 1;
            }
            incidencias.Add(incidenciaOtros);
        }
        public void CrearIncidenciaSF(IncidenciaSF incidenciaSF)
        {
            if (incidencias.Count > 0)
            {
                incidenciaSF.IncidenciaId = SigIncidenciaId();
            }
            else
            {
                incidenciaSF.IncidenciaId = 1;
            }
            incidencias.Add(incidenciaSF);
        }

        public Negocio() { }

        public Incidencia ObtenerIncidencia(int incidenciaId)
        {
            return incidencias.FirstOrDefault(x => x.IncidenciaId == incidenciaId);
        }

        public Incidencia[] ObtenerIncidencias(TipoIncidenciaEnum tipo, bool? estado = null)
        {
            return incidencias.Where(x => x.Tipo == tipo && x.Cerrada == estado).ToArray();
        }

        private int SigIncidenciaId()
        {
            return _incidenciaId++;
        }

        public delegate void TipoIncidenciaEventHandler(object sender);
        public event TipoIncidenciaEventHandler TipoIncidenciaModificada;
        private void OnTipoIncidenciaModificada()
        {
            if (this.TipoIncidenciaModificada != null)
            {
                this.TipoIncidenciaModificada(this);
            }
        }

        public delegate void TipoHardwareEventHandler(object sender);
        public event TipoHardwareEventHandler TipoHardwareModificado;
        private void OnTipoHardwareModificado()
        {
            if (this.TipoHardwareModificado != null)
            {
                this.TipoHardwareModificado(this);
            }
        }
    }
}
