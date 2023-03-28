using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTR_E3.Eventos_y_sus_parámetros__lógica_de_negocio
{
    public enum OperacionEnum
    {
        SinOperacion,
        Suma,
        Resta,
        Multiplicacion,
        Division
    }
    public class Calculadora
    {
        private float _cache;
        private float _visor;
        private OperacionEnum _operacion;
        public float Memoria { get; set; }
        public OperacionEnum Operacion
        {
            get
            {
                return _operacion;
            }
            set
            {
                if (_operacion != OperacionEnum.SinOperacion)
                {
                    Calcular();
                }
                _cache = _visor;
                _operacion = value;
            }

        }

        public float Visor
        {
            get { return _visor; }
            set { _visor = value; }

        }

        public void Calcular()
        {
            switch (_operacion)
            {
                case OperacionEnum.Suma:
                    _visor += _cache;
                    break;

                case OperacionEnum.Resta:
                    _visor = _cache - _visor;
                    break;

                case OperacionEnum.Multiplicacion:
                    _visor *= _cache;
                    break;

                case OperacionEnum.Division:
                    _visor = _cache / _visor;
                    break;

                case OperacionEnum.SinOperacion:
                    return;
            }
            _operacion = OperacionEnum.SinOperacion;
        }
        public void Borrar()
        {
            _cache = 0;
            _operacion = OperacionEnum.SinOperacion;
        }
    }
}
