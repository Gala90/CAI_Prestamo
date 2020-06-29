using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NLayer.Entidades;
using System.Collections.Specialized;
using System.Configuration;

namespace NLayer.Datos
{
    public class PrestamoMapper
    {
        
        public Prestamo Traer(int registro)
        {
            string json2 = WebHelper.Get("/api?/v1?/prestamo/" + registro);
            Prestamo resultado = Map(json2);
            return resultado;
        }

        private Prestamo Map (string json2)
        {
            Prestamo lst = JsonConvert.DeserializeObject<Prestamo>(json2);
            return lst;
        }

        public ResultadoTransaccion Insert(Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo);
            string result = WebHelper.Post("/api/v1/prestamo", obj);
            ResultadoTransaccion res = MapResultado(result);
            return res;
        }

        private NameValueCollection ReverseMap (Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Linea", prestamo.Linea);
            n.Add("TNA", prestamo.TNA.ToString());
            n.Add("Plazo", prestamo.Plazo.ToString());
            n.Add("Monto", prestamo.Monto.ToString());
            n.Add("Cuota", prestamo.Cuota().ToString());
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            return n;
        }
        
        private ResultadoTransaccion MapResultado(string json)
        {
            ResultadoTransaccion lst = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);
            return lst;
        }


    }
}
