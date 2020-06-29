using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Entidades
{
    public class Operador
    {
        private List<Prestamo> _prestamos;
        private double _comision;

        public List<Prestamo> Prestamos { get => _prestamos; set => _prestamos = value; }

        public double Comision { get => _comision; set => _comision = value; }
        
        /*
        public double PorcentajeComision()
        {

        }
        */

    }
}
