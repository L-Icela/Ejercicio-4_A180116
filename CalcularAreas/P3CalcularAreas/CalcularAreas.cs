using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P3CalcularAreas
{
    public class CalcularAreas
    {
        public decimal LadoCuadrado { get; set;}
        public decimal RadioCirculo { get; set;}
        public decimal BaseTriangulo { get; set;}
        public decimal AlturaTriangulo { get; set;}

        public decimal AreaCuadrado(decimal L)
        {
            LadoCuadrado = L;
            var Resultado = L * L;
            return Resultado;
        }

        public decimal AreaCIrculo(decimal R)
        {
            RadioCirculo = R;
            var Resultado = Math.PI * (double)(R * R);
            return (decimal) Resultado;
        }

        public decimal AreaTriangulo (decimal B, decimal A)
        {
            BaseTriangulo = B;
            AlturaTriangulo = A;
            var Resultado = (B * A) / 2;
            return Resultado;

        }
    }
}