using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Datos
{
    public static class ConsolaHelper
    {
        public static string PedirString(string msg)
        {
            Console.WriteLine("Ingrese " + msg);
            string n = Console.ReadLine();
            return n;

        }

        public static int PedirInt(string msg)
        {
            Console.WriteLine("Ingrese " + msg);

            int c = int.Parse(Console.ReadLine());


            return c;
        }

        public static DateTime PedirFecha(string msg)
        {
            Console.WriteLine("Ingrese fecha " + msg + " solo en este formato YYYY-MM-DD");

            DateTime f = Convert.ToDateTime(Console.ReadLine());

            return f;
        }

        public static bool EsOpcionValida(string input, string opcionesValidas)
        {

            try
            {

                if (string.IsNullOrEmpty(input)  
                    || input.Length > 1               
                    || !opcionesValidas.ToUpper().Contains(input.ToUpper())) 
                {
                    return false;
                }

                return true;
            }

            catch
            {


                return false;
            }
        }

        public static double PedirDouble(string msg)
        {
            Console.WriteLine("Ingrese " + msg);
            double c = double.Parse(Console.ReadLine());

            return c;
        }

        public static bool EsCodigoValido(string input)
        {

            List<String> codigosValidos = new List<String> { "CO1", "CO2", "SP1", "SP2", "FA1", "FA2" };

            if (string.IsNullOrEmpty(input)  // es nulo o vacío   
                || !codigosValidos.Contains(input.ToUpper()))  // no está dentro de las opciones válidas
            {
                return false;
            }
            else
            {

                return true;

            }



        }

    }
}
