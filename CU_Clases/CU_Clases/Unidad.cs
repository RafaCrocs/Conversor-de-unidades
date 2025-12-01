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
        public string? NombreUnidad { get; set; }



        public List<Conversiones> conversiones { get; set; } = new();


        public static List<Unidad> unidades = new List<Unidad>
        {
            new Unidad{IdUnidad = 1, NombreUnidad = "Distancia",
                conversiones = new List<Conversiones>{
                new Conversiones{IdConversion = 1, NombreConversion = "Metros a Kilometros", FactorConversion = 0.001 },
                new Conversiones{IdConversion = 2, NombreConversion =  "Metros a centimetros", FactorConversion = 100},
                new Conversiones{IdConversion = 3, NombreConversion = "Kilometros a Metros", FactorConversion = 1000 },
                new Conversiones{IdConversion = 4, NombreConversion = "Kilometros a Centimetros", FactorConversion = 10000 },
                new Conversiones{IdConversion = 5, NombreConversion = "Centimetros a Metros", FactorConversion = 0.01 },
                new Conversiones{IdConversion = 6, NombreConversion = "Centimetros a Kilometros", FactorConversion = 0.0001}
                }
            },
            new Unidad{IdUnidad = 2, NombreUnidad = "Temperatura",
            conversiones = new List<Conversiones>{
                new Conversiones{IdConversion = 1, NombreConversion = "Celsius a Farenheit", FactorConversion = 1.8, Suma = 32},
                new Conversiones{IdConversion = 2, NombreConversion = "Celsius a Kelvin", FactorConversion = 1, Suma = 273.15 },
                new Conversiones{IdConversion = 3, NombreConversion = "Farenheit a Celsius", FactorConversion =  0.55, Suma = -17.77} } },


            new Unidad{IdUnidad = 3, NombreUnidad = "Peso" }
        };
    }
}

