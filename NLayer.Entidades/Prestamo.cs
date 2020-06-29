using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Entidades
{
    [DataContract]
    public class Prestamo
    {
        [DataMember]
        public string Linea { get; set; }

        [DataMember]
        public double TNA { get; set; }

        [DataMember]
        public int Plazo { get; set; }

        [DataMember]
        public double Monto { get; set; }

        [DataMember]
        public string Usuario { get; set; }

        [DataMember]
        public int id { get; set; }

        public double CuotaCapital()
        {
            return Monto / Plazo;
        }

        public double CuotaInteres()
        {
            return CuotaCapital() * (TNA / 12 / 100);
        }

        public double Cuota()
        {
            return CuotaCapital() + CuotaInteres();
        }

    }
}
