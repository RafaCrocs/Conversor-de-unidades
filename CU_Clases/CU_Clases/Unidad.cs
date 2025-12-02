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



        public List<Conversiones> conversiones { get; set; }


        public static List<Unidad> unidades = new List<Unidad>
        {
            new Unidad{IdUnidad = 1, NombreUnidad = "Distancia",
                conversiones = new List<Conversiones>{
                new Conversiones{IdConversion = 1, NombreOrigen = "Metros", NombreDestino = "Kilometros", FactorConversion = 0.001 },
                new Conversiones{IdConversion = 2, NombreOrigen =  "Metros", NombreDestino= "centimetros", FactorConversion = 100},
                new Conversiones{IdConversion = 3, NombreOrigen = "Kilometros", NombreDestino = "Metros", FactorConversion = 1000 },
                new Conversiones{IdConversion = 4, NombreOrigen = "Kilometros", NombreDestino = "Centimetros", FactorConversion = 10000 },
                new Conversiones{IdConversion = 5, NombreOrigen = "Centimetros", NombreDestino = "Metros", FactorConversion = 0.01 },
                new Conversiones{IdConversion = 6, NombreOrigen = "Centimetros", NombreDestino = "Kilometros", FactorConversion = 0.0001}
                }
            },
            new Unidad{IdUnidad = 2, NombreUnidad = "Temperatura",
            conversiones = new List<Conversiones>{
                new Conversiones{IdConversion = 1, NombreOrigen = "Celsius", NombreDestino = "Farenheit", FactorConversion = 1.8, Suma = 32},
                new Conversiones{IdConversion = 2, NombreOrigen = "Celsius", NombreDestino = "Kelvin", FactorConversion = 1, Suma = 273.15 },
                new Conversiones{IdConversion = 3, NombreOrigen = "Farenheit", NombreDestino = "Celsius", FactorConversion =  0.55, Suma = -17.77} } },


            new Unidad{IdUnidad = 3, NombreUnidad = "Peso",
            conversiones = new List<Conversiones>{
                new Conversiones{IdConversion = 1, NombreOrigen = "Gramos", NombreDestino = "Kilogramos", FactorConversion = 0.001},
                new Conversiones{IdConversion = 2, NombreOrigen = "Gramos", NombreDestino = "Centigramos", FactorConversion = 100},
                new Conversiones{IdConversion = 3, NombreOrigen = "Kilogramos", NombreDestino = "Gramos", FactorConversion =  1000},
                new Conversiones{IdConversion = 4, NombreOrigen = "Kilogramos", NombreDestino = "Centigramos", FactorConversion = 10000},
                new Conversiones{IdConversion = 5, NombreOrigen = "Centigramos", NombreDestino = "Gramos", FactorConversion = 0.01 },
                new Conversiones{IdConversion = 6, NombreOrigen = "Centigramos", NombreDestino = "Kilogramos", FactorConversion = 0.0001} }
            },

        };
    }
}

