using NLayer.Datos;
using NLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NLayer.Negocio
{
    public class PrestamoNegocio
    {
        private PrestamoMapper mapper;

        public PrestamoNegocio()
        {
            mapper = new PrestamoMapper();
        }

        public Prestamo Traer(int registro)
        {
            Prestamo result = mapper.Traer(registro);
            return result;
        }

        public int SacarPrestamo(string linea, double TNA, int plazo, double monto)
        {
            Prestamo pre = new Prestamo();
            pre.Linea = linea;
            pre.TNA = TNA;
            pre.Plazo = plazo;
            pre.Monto = monto;

            ResultadoTransaccion res = mapper.Insert(pre);

            if (res.IsOk)
                return res.Id;
            else
                throw new Exception("Hubo un error. Detalle: " + res.Error);

        }
    }
}
