using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_Clases
{
    public class Unidad
    {
        public int IdUnidad { get; set; }
        public string NombreUnidad { get; set; } = string.Empty;



        List<Conversiones> conversiones { get; } = new List<Conversiones>();
        public static List<Unidad> unidades = new List<Unidad>
        {
            new Unidad{IdUnidad = 1, NombreUnidad = "Distancia", },
            new Unidad{IdUnidad = 2, NombreUnidad = "Temperatura"},
            new Unidad{IdUnidad = 3, NombreUnidad = "Peso" }
        };
    }
}
