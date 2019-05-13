using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examen3Ventas2019.Models
{
    public class Bonificacion3
    {
        public double Categoria { get; set; }
        public int NdeHijos { get; set; }
        public String CondicionLab { get; set; }

        public double BonificacionHijos()
        {
            double bon;
            if (NdeHijos<=3)
            {
                bon = NdeHijos * 25;
            }
            else
            {
                bon = (NdeHijos - 3) * 10 + 3 * 25;
            }

            return bon;
        }

        public double BonoCodicionLab()
        {
            double bono;
            if ( CondicionLab.Equals("contratado"))
            {
                bono = 0.10 * Categoria;
            }
            else
            {
                bono = 0.15 * Categoria;
            }
            return bono;
        }





    }
}