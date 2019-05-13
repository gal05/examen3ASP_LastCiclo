using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examen3Ventas2019.Models
{
    public class Bonificacion2
    {
        public double ImporteTotalMes { get; set; }
        public int NdeHijos { get; set; }

        

        public double bonificacion()
        {
            double bon;
            bon = 50 * NdeHijos;
            return bon;
        }
        public double comision()
        {
            return ImporteTotalMes * 0.075;
        }


        public double SueldoBruto()
        {
            double sb;
            sb = 600 + (comision()) + bonificacion();
            return sb;
        }

        public double descuento()
        {
            return SueldoBruto() * 0.11;
        }

        public double sueldoNeto()
        {
            return SueldoBruto() - descuento();
        }
    }
}