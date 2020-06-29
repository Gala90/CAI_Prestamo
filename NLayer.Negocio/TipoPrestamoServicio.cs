using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Datos;
using NLayer.Entidades;

namespace NLayer.Negocio
{
    public class TipoPrestamoServicio
    {
        private TipoPrestamoMapper mapper;

        public TipoPrestamoServicio()
        {
            mapper = new TipoPrestamoMapper();
        }

        public List<TipoPrestamo> TraerTipoPrestamos()
        {
            List<TipoPrestamo> result = mapper.TraerTipoPrestamos();
            return result;
                
        }
    }
}
