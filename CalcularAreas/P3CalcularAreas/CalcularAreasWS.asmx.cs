using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Services;

namespace P3CalcularAreas
{
    /// <summary>
    /// Descripción breve de CalcularAreasWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularAreasWS : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public decimal AreaCuadrado (decimal L)
        {
            CalcularAreas C = new CalcularAreas();
            return  C.AreaCuadrado(L);

        }

        [WebMethod]
        public decimal AreaCirculo (decimal R)
        {
            CalcularAreas C = new CalcularAreas ();
            return C.AreaCIrculo (R);
        }
        [WebMethod]
        public decimal AreaTriangulo (decimal B, decimal A)
        {
            CalcularAreas C = new CalcularAreas();
            return C.AreaTriangulo (B, A);
        }


    }
}
